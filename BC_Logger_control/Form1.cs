/*
Command list:
	start                   - start logging
	stop                    - stop logging
	save config             - save config file to SD-card
	read config             - read config file from SD-card
	
    config                  - print current logger settings
    serialspeed x           - serial output speed
	portspeed x             - logging port speed
	portconfig nnn          - port configuration [data_bits][parity][stop_bits] like "8N1"
    echo off / bin / hex    - show data on the screen off / bin / hex
	timestamp on / off      - log timestamp in msec.
	signals on / off        - log signals on / off
	autostart on / off      - start logging on boot / off
	
--- following commands work only if logging stopped-- - 
	list                    - print file list
	download <filename>     - download file to serial(HEX)
	download bin <filename> - download file to serial(BIN)
	delete <filename>       - delete file from SD-card

**** SETTINGS ****

Serial output speed: serialSpeed
Logging port speed: portSpeed, portConfig
Save timestamps: 1/0
Print log to serial: 1/0
HEX serial output: 1/0
Print signals to serial: 1/0
Start logging on boot: 1/0
SD-card present: 1/0

*****

*/
using System;
using System.IO;
using System.IO.Ports;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using Microsoft.Win32;
using System.Collections.Generic;

namespace BC_Logger_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static System.Timers.Timer aTimer;
        List<string> portDesc = new List<string>();
        int LogBufferLimit = 100;
        int CodePage = RS232Logger_control.Properties.Settings.Default.CodePage;

        delegate void SetTextCallback1(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            //if (this.textBox_terminal1.InvokeRequired)
            if (textBox_terminal.InvokeRequired)
            {
                SetTextCallback1 d = new SetTextCallback1(SetText);
                BeginInvoke(d, new object[] { text });
            }
            else
            {
                StringBuilder terminal = new StringBuilder();
                terminal.Append(textBox_terminal.Text);
                terminal.Append(text);
                int pos = textBox_terminal.SelectionStart;
                int l = terminal.Length - LogBufferLimit;
                if (l < 0) l = 0;
                textBox_terminal.Text = terminal.ToString().Substring(l);

                if (checkBox_autoScroll.Checked)
                {
                    textBox_terminal.SelectionStart = textBox_terminal.Text.Length;
                    textBox_terminal.ScrollToCaret();
                }
                else
                {
                    pos = pos - text.Length;
                    if (pos < 0) pos = 0;
                    textBox_terminal.SelectionStart = pos;
                    textBox_terminal.ScrollToCaret();
                }
            }
        }

        Hashtable BuildPortNameHash(string[] oPortsToMap)
        {
            Hashtable oReturnTable = new Hashtable();
            MineRegistryForPortName("SYSTEM\\CurrentControlSet\\Enum", oReturnTable, oPortsToMap);
            return oReturnTable;
        }

        void MineRegistryForPortName(string strStartKey, Hashtable oTargetMap, string[] oPortNamesToMatch)
        {
            if (oTargetMap.Count >= oPortNamesToMatch.Length)
                return;
            RegistryKey oCurrentKey = Registry.LocalMachine;

            try
            {
                oCurrentKey = oCurrentKey.OpenSubKey(strStartKey);

                string[] oSubKeyNames = oCurrentKey.GetSubKeyNames();
                if (((IList<string>)oSubKeyNames).Contains("Device Parameters") && strStartKey != "SYSTEM\\CurrentControlSet\\Enum")
                {
                    object oPortNameValue = Registry.GetValue("HKEY_LOCAL_MACHINE\\" + strStartKey + "\\Device Parameters", "PortName", null);

                    if (oPortNameValue == null || ((IList<string>)oPortNamesToMatch).Contains(oPortNameValue.ToString()) == false)
                        return;
                    object oFriendlyName = Registry.GetValue("HKEY_LOCAL_MACHINE\\" + strStartKey, "FriendlyName", null);

                    string strFriendlyName = "N/A";

                    if (oFriendlyName != null)
                        strFriendlyName = oFriendlyName.ToString();
                    if (strFriendlyName.Contains(oPortNameValue.ToString()) == false)
                        strFriendlyName = string.Format("{0} ({1})", strFriendlyName, oPortNameValue);
                    oTargetMap[strFriendlyName] = oPortNameValue;
                }
                else
                {
                    foreach (string strSubKey in oSubKeyNames)
                        MineRegistryForPortName(strStartKey + "\\" + strSubKey, oTargetMap, oPortNamesToMatch);
                }
            }
            catch
            {

            }
        }

        byte crcCalc(byte[] instr)
        {
            byte crc = 0x00;
            int i = 0;
            while (i < instr.Length)
            {
                for (byte tempI = 8; tempI > 0; tempI--)
                {
                    byte sum = (byte)((crc & 0xFF) ^ (instr[i] & 0xFF));
                    sum = (byte)((sum & 0xFF) & 0x01);

                    crc >>= 1;
                    if (sum != 0)
                    {
                        crc ^= 0x8C;
                    }
                    instr[i] >>= 1;
                }
                i++;
            }
            return (crc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_codePageSetting.Text = RS232Logger_control.Properties.Settings.Default.CodePage.ToString();
            int.TryParse(textBox_codePageSetting.Text, out CodePage);
            serialPort1.Encoding = Encoding.GetEncoding(CodePage);

            textBox_logBufferSetting.Text = RS232Logger_control.Properties.Settings.Default.LogBufferSize.ToString();
            int.TryParse(textBox_logBufferSetting.Text, out LogBufferLimit);

            button_refresh_Click(this, EventArgs.Empty);
            comboBox_echo.SelectedIndex = 0;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            comboBox_portName.Items.Clear();
            comboBox_portName.Items.Add("None");
            portDesc.Clear();
            foreach (string portname in SerialPort.GetPortNames())
            {
                comboBox_portName.Items.Add(portname); //добавить порт в список
            }
            if (comboBox_portName.Items.Count == 1)
            {
                comboBox_portName.SelectedIndex = 0;
                button_openPort.Enabled = false;
            }
            else
            {
                comboBox_portName.SelectedIndex = 0;
            }
            comboBox_speed.SelectedIndex = 3;
            Hashtable PortNames = new Hashtable();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0 && sender == button_refresh)
            {
                textBox_terminal.Text += "ERROR: No COM ports exist\n\r";
            }
            else
            {
                if (sender == button_refresh) textBox_terminal.Text += "\r\nPorts found:\r\n";
                PortNames = BuildPortNameHash(ports);
                foreach (String s in PortNames.Keys)
                {
                    if (sender == button_refresh) textBox_terminal.Text += PortNames[s].ToString() + ": " + s + "\r\n";
                    portDesc.Add(PortNames[s].ToString() + ": " + s);
                }
            }
        }

        private void button_openPort_Click(object sender, EventArgs e)
        {
            if (comboBox_portName.SelectedIndex != 0)
            {
                serialPort1.PortName = comboBox_portName.Text;
                serialPort1.BaudRate = int.Parse(comboBox_speed.Text);
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.ReadBufferSize = 1024000;
                serialPort1.ReadTimeout = 1000;
                serialPort1.WriteTimeout = 500;
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    SetText("Error opening port " + serialPort1.PortName + ": " + ex.Message);
                }
                if (serialPort1.IsOpen)
                {
                    button_openPort.Enabled = false;
                    button_closePort.Enabled = true;
                    button_refresh.Enabled = false;
                    comboBox_portName.Enabled = false;
                    comboBox_speed.Enabled = false;
                    checkBox_dtr.Enabled = true;
                    checkBox_rts.Enabled = true;

                    button_getConfig.Enabled = true;
                    button_getFileList.Enabled = true;
                    button_getFile.Enabled = true;
                    button_delFile.Enabled = true;
                    button_saveConfig.Enabled = true;
                    button_readConfig.Enabled = true;
                    button_startLog.Enabled = true;
                    button_stopLog.Enabled = true;

                    button_serialSpeed.Enabled = true;
                    button_portSpeed.Enabled = true;
                    button_portConfig.Enabled = true;
                    button_echo.Enabled = true;
                    button_echo.Enabled = true;
                    button_getTime.Enabled = true;
                    button_setTime.Enabled = true;
                    button_timeStamp.Enabled = true;
                    button_signals.Enabled = true;
                    button_autoStart.Enabled = true;
                    button_sendAll.Enabled = true;
                    int i = 0;
                    for (i = 0; i < portDesc.Count; i++)
                    {
                        if (portDesc[i].Contains(comboBox_portName.Text + ":")) break;
                    }
                    if (i < portDesc.Count && portDesc[i].Contains("Maple Serial")) checkBox_dtr.Checked = true;
                }
                else return;
            }
        }

        private void button_closePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    SetText("Error closing port " + serialPort1.PortName + ": " + ex.Message);
                }
            }
            button_openPort.Enabled = true;
            button_closePort.Enabled = false;
            button_refresh.Enabled = true;
            comboBox_portName.Enabled = true;
            comboBox_speed.Enabled = true;
            checkBox_dtr.Enabled = false;
            checkBox_rts.Enabled = false;

            button_getConfig.Enabled = false;
            button_getFileList.Enabled = false;
            button_getFile.Enabled = false;
            button_delFile.Enabled = false;
            button_saveConfig.Enabled = false;
            button_readConfig.Enabled = false;
            button_startLog.Enabled = false;
            button_stopLog.Enabled = false;

            button_serialSpeed.Enabled = false;
            button_portSpeed.Enabled = false;
            button_portConfig.Enabled = false;
            button_echo.Enabled = false;
            button_echo.Enabled = false;
            button_getTime.Enabled = false;
            button_setTime.Enabled = false;
            button_timeStamp.Enabled = false;
            button_signals.Enabled = false;
            button_autoStart.Enabled = false;
            button_sendAll.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (checkBox_portMon.Checked)
            {
                List<byte> rx = new List<byte>();
                while (serialPort1.BytesToRead > 0)
                {
                    rx.Add((byte)serialPort1.ReadByte());
                }
                SetText(Encoding.GetEncoding(RS232Logger_control.Properties.Settings.Default.CodePage).GetString(rx.ToArray()));
            }
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            SetText("\r\nCOM port error\r\n");
        }

        private void button_saveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName, textBox_terminal.Text);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_terminal.Text = "";
        }

        private void textBox_terminal_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_autoScroll.Checked)
            {
                textBox_terminal.SelectionStart = textBox_terminal.Text.Length;
                textBox_terminal.ScrollToCaret();
            }
        }

        private void checkBoxcustomEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_customEdit.Checked)
            {
                textBox_getConfigCMD.Enabled = true;
                textBox_getFileCMD.Enabled = true;
                textBox_delFileCMD.Enabled = true;
                textBox_getFileListCMD.Enabled = true;
                textBox_serialSpeedCMD.Enabled = true;
                textBox_portSpeedCMD.Enabled = true;
                textBox_portConfigCMD.Enabled = true;
                textBox_echoCMD.Enabled = true;
                textBox_timeStampCMD.Enabled = true;
                textBox_signalsCMD.Enabled = true;
                textBox_autoStartCMD.Enabled = true;
                textBox_saveConfigCMD.Enabled = true;
                textBox_readConfigCMD.Enabled = true;
                textBox_startCMD.Enabled = true;
                textBox_stopCMD.Enabled = true;
            }
            else
            {
                textBox_getConfigCMD.Enabled = false;
                textBox_getFileCMD.Enabled = false;
                textBox_delFileCMD.Enabled = false;
                textBox_getFileListCMD.Enabled = false;
                textBox_serialSpeedCMD.Enabled = false;
                textBox_portSpeedCMD.Enabled = false;
                textBox_portConfigCMD.Enabled = false;
                textBox_echoCMD.Enabled = false;
                textBox_timeStampCMD.Enabled = false;
                textBox_signalsCMD.Enabled = false;
                textBox_autoStartCMD.Enabled = false;
                textBox_saveConfigCMD.Enabled = false;
                textBox_readConfigCMD.Enabled = false;
                textBox_startCMD.Enabled = false;
                textBox_stopCMD.Enabled = false;
            }
        }

        private void button_getSettings_Click(object sender, EventArgs e)
        {
            bool portMon_backup = checkBox_portMon.Checked;
            checkBox_portMon.Checked = false;
            string tmp = textBox_getConfigCMD.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
            try
            {
                serialPort1.ReadTo("Serial output speed: ");
                SetText("Serial output speed: ");
                textBox_serialSpeed.Text = serialPort1.ReadLine().Replace("\r", "");
                SetText(textBox_serialSpeed.Text);

                serialPort1.ReadTo("Logging port speed: ");
                SetText("\r\nLogging port speed: ");
                textBox_portSpeed.Text = serialPort1.ReadLine().Replace("\r", "");
                textBox_portConfig.Text = textBox_portSpeed.Text.Substring(textBox_portSpeed.Text.IndexOf(' ') + 1);
                textBox_portSpeed.Text = textBox_portSpeed.Text.Substring(0, textBox_portSpeed.Text.IndexOf(','));
                SetText(textBox_portSpeed.Text);
                SetText("\r\nPort config: ");
                SetText(textBox_portConfig.Text);

                serialPort1.ReadTo("Save timestamps: ");
                SetText("\r\nSave timestamps: ");
                tmp = serialPort1.ReadLine().Replace("\r", "");
                if (tmp == "0") checkBox_timeStamp.Checked = false;
                else checkBox_timeStamp.Checked = true;
                SetText(checkBox_timeStamp.Checked.ToString());

                serialPort1.ReadTo("Print log to serial: ");
                SetText("\r\nPrint log to serial: ");
                tmp = serialPort1.ReadLine().Replace("\r", "");
                if (tmp == "0") comboBox_echo.SelectedIndex = 0;
                else if (tmp == "1") comboBox_echo.SelectedIndex = 1;
                else if (tmp == "2") comboBox_echo.SelectedIndex = 2;
                SetText(comboBox_echo.SelectedItem.ToString());

                serialPort1.ReadTo("Log signals: ");
                SetText("\r\nLog signals: ");
                tmp = serialPort1.ReadLine().Replace("\r", "");
                if (tmp == "0") checkBox_signals.Checked = false;
                else checkBox_signals.Checked = true;
                SetText(checkBox_signals.Checked.ToString());

                serialPort1.ReadTo("Start logging on boot: ");
                SetText("\r\nStart logging on boot: ");
                tmp = serialPort1.ReadLine().Replace("\r", "");
                if (tmp == "0") checkBox_autoStart.Checked = false;
                else checkBox_autoStart.Checked = true;
                SetText(checkBox_autoStart.Checked.ToString());

                serialPort1.ReadTo("SD-card present: ");
                SetText("\r\nSD-card present: ");
                tmp = serialPort1.ReadLine().Replace("\r", "");
                if (tmp == "0")
                {
                    label_sdCard.BackColor = System.Drawing.Color.Red;
                    label_sdCard.Text = "SD-card present: no";
                    SetText("no");
                }
                else
                {
                    label_sdCard.BackColor = System.Drawing.Color.LimeGreen;
                    label_sdCard.Text = "SD-card present: yes";

                }
                SetText(tmp + "\r\n");
            }
            catch (TimeoutException ex)
            {
                SetText("Error reading file from device: timeout. " + ex.Message);
            }
            checkBox_portMon.Checked = portMon_backup;
        }

        private void button_getFileList_Click(object sender, EventArgs e)
        {
            bool portMon_backup = checkBox_portMon.Checked;
            checkBox_portMon.Checked = false;

            string tmp = textBox_getFileListCMD.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
            /*
            SD - card file list:
            config.ini      137
            log0.bin        651
            log1.bin        0
            */
            try
            {
                comboBox_getFileList.Items.Clear();
                comboBox_delFileList.Items.Clear();
                comboBox_getFileList.Items.Add("All files");
                serialPort1.ReadTo("SD-card file list:");
                serialPort1.ReadLine();
                tmp = serialPort1.ReadLine();
                long timeout = DateTime.Now.Ticks;
                while (tmp != "\r\n" && tmp != "")
                {
                    if (!tmp.Contains("/"))
                    {
                        SetText(tmp + "\n");
                        comboBox_getFileList.Items.Add(tmp.Substring(0, tmp.IndexOf('\t')));
                        comboBox_delFileList.Items.Add(tmp.Substring(0, tmp.IndexOf('\t')));
                    }
                    tmp = serialPort1.ReadLine();
                }
            }
            catch (TimeoutException ex)
            {
                if (comboBox_getFileList.Items.Count == 0) SetText("Error reading file from device: timeout. " + ex.Message);
            }
            checkBox_portMon.Checked = portMon_backup;
        }

        private void button_getFile_Click(object sender, EventArgs e)
        {
            /*            
            Downloading file [BIN]: filename[size]
            ====
            ...
            ====
            CRC = 0xcrc
            */
            bool portMon_backup = checkBox_portMon.Checked;
            checkBox_portMon.Checked = false;
            if (comboBox_getFileList.SelectedIndex < 0) return;
            else if (comboBox_getFileList.SelectedIndex == 0)
            {
                for (int i = 1; i < comboBox_getFileList.Items.Count; i++)
                {
                    downloadFile(comboBox_getFileList.Items[i].ToString());
                }
            }
            else downloadFile(comboBox_getFileList.SelectedItem.ToString());
            checkBox_portMon.Checked = portMon_backup;
        }

        bool downloadFile(string name)
        {
            string tmp = textBox_getFileCMD.Text + name + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
            int fsize = 0;
            int getcrc = 0;
            byte crc = 0;
            List<byte> file = new List<byte>();
            try
            {
                serialPort1.ReadTo("Downloading file [BIN]: ");
                tmp = serialPort1.ReadLine();
                SetText(tmp.Replace("\r", "") + " - ");
                if (!int.TryParse(tmp.Substring(tmp.IndexOf('[') + 1).Replace(']', ' ').Trim(), out fsize))
                {
                    SetText("Error parsing file size\r\n");
                    return (false);
                }
                serialPort1.ReadLine();
                while (file.Count < fsize)
                {
                    if (serialPort1.BytesToRead > 0) file.Add((byte)serialPort1.ReadByte());
                }
                crc = crcCalc(file.ToArray());
                serialPort1.ReadTo("====");
                serialPort1.ReadLine();
                tmp = serialPort1.ReadLine();
                if (tmp.StartsWith("CRC = 0x"))
                {
                    SetText(tmp + "\n");
                    tmp = tmp.Substring(tmp.IndexOf('x') + 1).Trim();
                    getcrc = Convert.ToInt16(tmp, 16);
                }
            }
            catch (TimeoutException ex)
            {
                SetText("Error reading file from device: timeout. " + ex.Message);
                return (false);
            }
            if (crc == getcrc)
            {
                try
                {
                    File.WriteAllBytes(name, file.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\r\nError write to file " + name + ": " + ex.Message);
                }
                try
                {
                    byte[] hexLog = decodeLog(file.ToArray());
                    File.WriteAllBytes(name + ".hex", hexLog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\r\nError write to file " + name + ": " + ex.Message);
                }
                try
                {
                    byte[] hexLog = decodeLog(file.ToArray(), CodePage, textBox_csvDelimiter.Text, checkBox_toBinSetting.Checked, checkBox_showSignalsSetting.Checked, checkBox_showTimestampsSetting.Checked, checkBox_showTxSetting.Checked, checkBox_showRxSetting.Checked);
                    File.WriteAllBytes(name + ".txt", hexLog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\r\nError write to file " + name + ": " + ex.Message);
                }
            }
            else
            {
                SetText("CRC doesn't match!");
                return false;
            }
            return true;
        }

        public static byte[] decodeLog(byte[] inData, int CodePage = 866, string CSVdelimiter = " ", bool toBIN = false, bool signals = true, bool timeStamp = true, bool showTX = true, bool showRX = true)
        {
            //convert data
            //byte stuffing decode
            byte BYTE_255 = 100;
            byte BYTE_TIMESTAMP = 101;
            byte SERIAL_RX = 102;
            byte SERIAL_TX = 103;
            //byte SERIAL_SIGNAL = 104;
            byte BUFFER_OVERFLOW = 105;
            byte BYTE_DATESTAMP = 106;

            byte CD_bit = 0;
            byte DTR_bit = 1;
            byte DSR_bit = 2;
            byte RTS_bit = 3;
            byte CTS_bit = 4;
            byte RING_bit = 5;
            int printed_signals = -1;
            bool now_tx = true;
            string timeStampString = "";
            UInt32 startTime = 0;
            DateTime startDate = new DateTime();

            List<byte> outData = new List<byte>();
            int pos = 0;
            while (pos < inData.Length)
            {
                if (pos >= inData.Length) break;
                byte b = inData[pos];
                pos++;

                //byte stuffing
                if (b == 255)
                {
                    if (pos >= inData.Length) break;
                    b = inData[pos];
                    pos++;
                    if (b == BYTE_255) //byte 0xFF
                    {
                        if ((now_tx && showTX) || (!now_tx && showRX))
                        {
                            if (toBIN == false) outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes(ConvertByteToHex(0xff)));
                            else outData.Add(0xff);
                        }
                    }
                    else if (b == BYTE_DATESTAMP)
                    {

                        UInt32 longNumber = 0;
                        if (pos >= inData.Length) break;
                        longNumber = (UInt32)inData[pos];
                        pos++;
                        if (pos >= inData.Length) break;
                        longNumber += (UInt32)(inData[pos] * 256);
                        pos++;
                        if (pos >= inData.Length) break;
                        longNumber += (UInt32)(inData[pos] * 256 * 256);
                        pos++;
                        if (pos >= inData.Length) break;
                        longNumber += (UInt32)(inData[pos] * 256 * 256 * 256);
                        pos++;
                        DateTime localDateTime = UnixTimeStampToDateTime(longNumber);
                        if (startDate.ToBinary() == 0) startDate = localDateTime;
                        if (timeStamp)
                        {
                            timeStampString = "[" + (localDateTime.Year).ToString() + "/" + localDateTime.Month.ToString() + "/" + localDateTime.Day.ToString() + " " + localDateTime.Hour.ToString() + ":" + localDateTime.Minute.ToString() + ":" + localDateTime.Second.ToString() + "]";
                            outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes("\r\n" + timeStampString + CSVdelimiter + "<<" + CSVdelimiter));
                            timeStampString = "";
                        }
                    }
                    else if (b == BYTE_TIMESTAMP)
                    {

                        UInt32 longNumber = 0;
                        if (pos >= inData.Length) break;
                        longNumber = (UInt32)inData[pos];
                        pos++;
                        if (pos >= inData.Length) break;
                        longNumber += (UInt32)(inData[pos] * 256);
                        pos++;
                        if (pos >= inData.Length) break;
                        longNumber += (UInt32)(inData[pos] * 256 * 256);
                        pos++;
                        if (pos >= inData.Length) break;
                        longNumber += (UInt32)(inData[pos] * 256 * 256 * 256);
                        pos++;
                        if (startTime == 0) startTime = longNumber;
                        if (timeStamp)
                        {
                            DateTime localDateTime = new DateTime(1, 1, 1).AddMilliseconds(longNumber - startTime);
                            localDateTime = localDateTime.Add(TimeSpan.FromTicks(startDate.Ticks));
                            timeStampString = "[" + (localDateTime.Year).ToString() + "/" + localDateTime.Month.ToString() + "/" + localDateTime.Day.ToString() + " " + localDateTime.Hour.ToString() + ":" + localDateTime.Minute.ToString() + ":" + localDateTime.Second.ToString() + "." + localDateTime.Millisecond.ToString() + "]";
                        }
                    }
                    else if (b == SERIAL_RX)
                    {
                        now_tx = false;
                        if (showRX == true)
                        {
                            outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes("\r\n" + timeStampString + CSVdelimiter + "<<" + CSVdelimiter));
                            timeStampString = "";
                        }
                    }
                    else if (b == SERIAL_TX)
                    {
                        now_tx = true;
                        if (showTX == true)
                        {
                            outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes("\r\n" + timeStampString + CSVdelimiter + ">>" + CSVdelimiter));
                            timeStampString = "";
                        }
                    }
                    else if (b == BUFFER_OVERFLOW)
                    {
                        string tmp = "\r\n" + timeStampString + CSVdelimiter;
                        tmp += "<OVF>";
                        outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes(tmp + CSVdelimiter));
                        timeStampString = "";
                    }
                    else if (b < 64 && signals == true)
                    {
                        string tmp = "\r\n" + timeStampString + CSVdelimiter;
                        if (printed_signals == -1)
                        {
                            tmp += "<CD>";
                            tmp += (GetBit(b, CD_bit)).ToString();
                            tmp += "<DTR>";
                            tmp += (GetBit(b, DTR_bit)).ToString();
                            tmp += "<DSR>";
                            tmp += (GetBit(b, DSR_bit)).ToString();
                            tmp += "<RTS>";
                            tmp += (GetBit(b, RTS_bit)).ToString();
                            tmp += "<CTS>";
                            tmp += (GetBit(b, CTS_bit)).ToString();
                            tmp += "<RING>";
                            tmp += (GetBit(b, RING_bit)).ToString();
                        }
                        else
                        {
                            if (GetBit(b, CD_bit) != GetBit((byte)printed_signals, CD_bit))
                            {
                                tmp += "<CD>";
                                tmp += (GetBit(b, CD_bit)).ToString();
                            }
                            if (GetBit(b, DTR_bit) != GetBit((byte)printed_signals, DTR_bit))
                            {
                                tmp += "<DTR>";
                                tmp += (GetBit(b, DTR_bit)).ToString();
                            }
                            if (GetBit(b, DSR_bit) != GetBit((byte)printed_signals, DSR_bit))
                            {
                                tmp += "<DSR>";
                                tmp += (GetBit(b, DSR_bit)).ToString();
                            }
                            if (GetBit(b, RTS_bit) != GetBit((byte)printed_signals, RTS_bit))
                            {
                                tmp += "<RTS>";
                                tmp += (GetBit(b, RTS_bit)).ToString();
                            }
                            if (GetBit(b, CTS_bit) != GetBit((byte)printed_signals, CTS_bit))
                            {
                                tmp += "<CTS>";
                                tmp += (GetBit(b, CTS_bit)).ToString();
                            }
                            if (GetBit(b, RING_bit) != GetBit((byte)printed_signals, RING_bit))
                            {
                                tmp += "<RING>";
                                tmp += (GetBit(b, RING_bit)).ToString();
                            }
                        }
                        outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes(tmp + CSVdelimiter));
                        printed_signals = b;
                        timeStampString = "";
                    }
                    else outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes("\r\n [UNKNOWN]" + ConvertByteToHex(b)));
                }
                //simple byte
                else if ((now_tx && showTX) || (!now_tx && showRX))
                {
                    if (toBIN == false) outData.AddRange(Encoding.GetEncoding(CodePage).GetBytes(ConvertByteToHex(b)));
                    else outData.Add(b);
                }
            }
            return outData.ToArray();
        }

        public static byte GetBit(byte b, byte bitNumber)
        {
            byte r = 0;
            if ((b & (1 << bitNumber)) != 0) r = 1;
            return r;
        }

        public static string ConvertByteToHex(byte byteVal)
        {
            return byteVal.ToString("X2") + " ";
        }

        private void button_delFile_Click(object sender, EventArgs e)
        {
            if (comboBox_delFileList.SelectedIndex < 0) return;
            string tmp = textBox_delFileCMD.Text + comboBox_delFileList.SelectedItem.ToString() + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_saveConfig_Click(object sender, EventArgs e)
        {
            string tmp = textBox_saveConfigCMD.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_readConfig_Click(object sender, EventArgs e)
        {
            string tmp = textBox_readConfigCMD.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            string tmp = textBox_startCMD.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            string tmp = textBox_stopCMD.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_serialSpeed_Click(object sender, EventArgs e)
        {
            string tmp = textBox_serialSpeedCMD.Text + textBox_serialSpeed.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_portSpeed_Click(object sender, EventArgs e)
        {
            string tmp = textBox_portSpeedCMD.Text + textBox_portSpeed.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_portConfig_Click(object sender, EventArgs e)
        {
            string tmp = textBox_portConfigCMD.Text + textBox_portConfig.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_echo_Click(object sender, EventArgs e)
        {
            string tmp = textBox_echoCMD.Text + comboBox_echo.SelectedItem.ToString().ToLower() + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_timeStamp_Click(object sender, EventArgs e)
        {
            string tmp = textBox_timeStampCMD.Text;
            if (checkBox_timeStamp.Checked) tmp += "on\r\n";
            else tmp += "off\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_signals_Click(object sender, EventArgs e)
        {
            string tmp = textBox_signalsCMD.Text;
            if (checkBox_signals.Checked) tmp += "on\r\n";
            else tmp += "off\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_autoStart_Click(object sender, EventArgs e)
        {
            string tmp = textBox_autoStartCMD.Text;
            if (checkBox_autoStart.Checked) tmp += "on\r\n";
            else tmp += "off\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_sendSet_Click(object sender, EventArgs e)
        {
            button_serialSpeed_Click(this, EventArgs.Empty);
            Thread.Sleep(100);
            button_portSpeed_Click(this, EventArgs.Empty);
            Thread.Sleep(100);
            button_portConfig_Click(this, EventArgs.Empty);
            Thread.Sleep(100);
            button_echo_Click(this, EventArgs.Empty);
            Thread.Sleep(100);
            button_timeStamp_Click(this, EventArgs.Empty);
            Thread.Sleep(100);
            button_signals_Click(this, EventArgs.Empty);
            Thread.Sleep(100);
            button_autoStart_Click(this, EventArgs.Empty);
        }

        private void checkBox_dtr_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.DtrEnable = checkBox_dtr.Checked;
        }

        private void checkBox_rts_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.RtsEnable = checkBox_rts.Checked;
        }

        private void checkBox_portMon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_portMon.Checked) serialPort1_DataReceived(this, null);
        }

        private void checkBox_pcTime_CheckedChanged(object sender, EventArgs e)
        {
            // String(rtc.year() + 1970) + "/" + String(rtc.month()) + "/" + String(rtc.day()) + " " + String(rtc.hour()) + ":" + String(rtc.minute()) + ":" + String(rtc.second())
            textBox_setTime.Text = DateTime.Now.Year.ToString("D4") + "/" + DateTime.Now.Month.ToString("D2") + "/" + DateTime.Now.Day.ToString("D2") + " " + DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            textBox_setTime.Enabled = !checkBox_pcTime.Checked;
        }

        private void button_getTime_Click(object sender, EventArgs e)
        {
            string tmp = textBox_getTimeCMD.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        private void button_setTime_Click(object sender, EventArgs e)
        {
            if (checkBox_pcTime.Checked) textBox_setTime.Text = DateTime.Now.Year.ToString("D4") + "/" + DateTime.Now.Month.ToString("D2") + "/" + DateTime.Now.Day.ToString("D2") + " " + DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            string tmp = textBox_setTimeCMD.Text + textBox_setTime.Text + "\r\n";
            serialPort1.WriteLine(tmp);
            SetText("\r\n>> " + tmp);
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void checkBox_decodeFilesSetting_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_toBinSetting.Enabled = checkBox_decodeFilesSetting.Checked;
            checkBox_showSignalsSetting.Enabled = checkBox_decodeFilesSetting.Checked;
            checkBox_showTimestampsSetting.Enabled = checkBox_decodeFilesSetting.Checked;
            checkBox_showTxSetting.Enabled = checkBox_decodeFilesSetting.Checked;
            checkBox_showRxSetting.Enabled = checkBox_decodeFilesSetting.Checked;
            textBox_csvDelimiter.Enabled = checkBox_decodeFilesSetting.Checked;
        }

        private void textBox_codePageSetting_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox_codePageSetting.Text, out CodePage);
            serialPort1.Encoding = Encoding.GetEncoding(CodePage);
        }

        private void textBox_logLineSetting_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox_logBufferSetting.Text, out LogBufferLimit);
        }
    }
}
