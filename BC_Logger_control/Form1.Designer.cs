using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
namespace BC_Logger_control
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Get = new System.Windows.Forms.TabPage();
            this.label_sdCard = new System.Windows.Forms.Label();
            this.button_stopLog = new System.Windows.Forms.Button();
            this.button_startLog = new System.Windows.Forms.Button();
            this.button_readConfig = new System.Windows.Forms.Button();
            this.button_saveConfig = new System.Windows.Forms.Button();
            this.button_delFile = new System.Windows.Forms.Button();
            this.button_getFile = new System.Windows.Forms.Button();
            this.comboBox_delFileList = new System.Windows.Forms.ComboBox();
            this.comboBox_getFileList = new System.Windows.Forms.ComboBox();
            this.button_getConfig = new System.Windows.Forms.Button();
            this.button_getFileList = new System.Windows.Forms.Button();
            this.tabPage_Set = new System.Windows.Forms.TabPage();
            this.checkBox_pcTime = new System.Windows.Forms.CheckBox();
            this.comboBox_echo = new System.Windows.Forms.ComboBox();
            this.button_autoStart = new System.Windows.Forms.Button();
            this.checkBox_autoStart = new System.Windows.Forms.CheckBox();
            this.button_echo = new System.Windows.Forms.Button();
            this.button_signals = new System.Windows.Forms.Button();
            this.button_timeStamp = new System.Windows.Forms.Button();
            this.button_sendAll = new System.Windows.Forms.Button();
            this.checkBox_signals = new System.Windows.Forms.CheckBox();
            this.checkBox_timeStamp = new System.Windows.Forms.CheckBox();
            this.textBox_setTime = new System.Windows.Forms.TextBox();
            this.textBox_portConfig = new System.Windows.Forms.TextBox();
            this.textBox_portSpeed = new System.Windows.Forms.TextBox();
            this.textBox_serialSpeed = new System.Windows.Forms.TextBox();
            this.button_setTime = new System.Windows.Forms.Button();
            this.button_portConfig = new System.Windows.Forms.Button();
            this.button_getTime = new System.Windows.Forms.Button();
            this.button_portSpeed = new System.Windows.Forms.Button();
            this.button_serialSpeed = new System.Windows.Forms.Button();
            this.tabPage_Commands = new System.Windows.Forms.TabPage();
            this.checkBox_customEdit = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_autoStartCMD = new System.Windows.Forms.TextBox();
            this.textBox_signalsCMD = new System.Windows.Forms.TextBox();
            this.textBox_timeStampCMD = new System.Windows.Forms.TextBox();
            this.textBox_echoCMD = new System.Windows.Forms.TextBox();
            this.textBox_portConfigCMD = new System.Windows.Forms.TextBox();
            this.textBox_portSpeedCMD = new System.Windows.Forms.TextBox();
            this.textBox_serialSpeedCMD = new System.Windows.Forms.TextBox();
            this.textBox_getFileListCMD = new System.Windows.Forms.TextBox();
            this.textBox_delFileCMD = new System.Windows.Forms.TextBox();
            this.textBox_getFileCMD = new System.Windows.Forms.TextBox();
            this.textBox_setTimeCMD = new System.Windows.Forms.TextBox();
            this.textBox_stopCMD = new System.Windows.Forms.TextBox();
            this.textBox_readConfigCMD = new System.Windows.Forms.TextBox();
            this.textBox_getTimeCMD = new System.Windows.Forms.TextBox();
            this.textBox_startCMD = new System.Windows.Forms.TextBox();
            this.textBox_saveConfigCMD = new System.Windows.Forms.TextBox();
            this.textBox_getConfigCMD = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_terminal = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox_portName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_openPort = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_closePort = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox_autoScroll = new System.Windows.Forms.CheckBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.checkBox_portMon = new System.Windows.Forms.CheckBox();
            this.comboBox_speed = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox_dtr = new System.Windows.Forms.CheckBox();
            this.checkBox_rts = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabPage_Get.SuspendLayout();
            this.tabPage_Set.SuspendLayout();
            this.tabPage_Commands.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl.Controls.Add(this.tabPage_Get);
            this.tabControl.Controls.Add(this.tabPage_Set);
            this.tabControl.Controls.Add(this.tabPage_Commands);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(2, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(440, 365);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Get
            // 
            this.tabPage_Get.Controls.Add(this.label_sdCard);
            this.tabPage_Get.Controls.Add(this.button_stopLog);
            this.tabPage_Get.Controls.Add(this.button_startLog);
            this.tabPage_Get.Controls.Add(this.button_readConfig);
            this.tabPage_Get.Controls.Add(this.button_saveConfig);
            this.tabPage_Get.Controls.Add(this.button_delFile);
            this.tabPage_Get.Controls.Add(this.button_getFile);
            this.tabPage_Get.Controls.Add(this.comboBox_delFileList);
            this.tabPage_Get.Controls.Add(this.comboBox_getFileList);
            this.tabPage_Get.Controls.Add(this.button_getConfig);
            this.tabPage_Get.Controls.Add(this.button_getFileList);
            this.tabPage_Get.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Get.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage_Get.Name = "tabPage_Get";
            this.tabPage_Get.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage_Get.Size = new System.Drawing.Size(432, 328);
            this.tabPage_Get.TabIndex = 1;
            this.tabPage_Get.Text = "Get data";
            this.tabPage_Get.UseVisualStyleBackColor = true;
            // 
            // label_sdCard
            // 
            this.label_sdCard.AutoSize = true;
            this.label_sdCard.BackColor = System.Drawing.Color.Red;
            this.label_sdCard.Location = new System.Drawing.Point(217, 75);
            this.label_sdCard.Name = "label_sdCard";
            this.label_sdCard.Size = new System.Drawing.Size(178, 24);
            this.label_sdCard.TabIndex = 10;
            this.label_sdCard.Text = "SD-card present: no";
            // 
            // button_stopLog
            // 
            this.button_stopLog.BackColor = System.Drawing.Color.Red;
            this.button_stopLog.Enabled = false;
            this.button_stopLog.Location = new System.Drawing.Point(220, 282);
            this.button_stopLog.Margin = new System.Windows.Forms.Padding(6);
            this.button_stopLog.Name = "button_stopLog";
            this.button_stopLog.Size = new System.Drawing.Size(200, 42);
            this.button_stopLog.TabIndex = 0;
            this.button_stopLog.Text = "Stop logging";
            this.button_stopLog.UseVisualStyleBackColor = false;
            this.button_stopLog.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_startLog
            // 
            this.button_startLog.BackColor = System.Drawing.Color.LimeGreen;
            this.button_startLog.Enabled = false;
            this.button_startLog.Location = new System.Drawing.Point(12, 282);
            this.button_startLog.Margin = new System.Windows.Forms.Padding(6);
            this.button_startLog.Name = "button_startLog";
            this.button_startLog.Size = new System.Drawing.Size(196, 42);
            this.button_startLog.TabIndex = 0;
            this.button_startLog.Text = "Start logging";
            this.button_startLog.UseVisualStyleBackColor = false;
            this.button_startLog.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_readConfig
            // 
            this.button_readConfig.Enabled = false;
            this.button_readConfig.Location = new System.Drawing.Point(220, 227);
            this.button_readConfig.Margin = new System.Windows.Forms.Padding(6);
            this.button_readConfig.Name = "button_readConfig";
            this.button_readConfig.Size = new System.Drawing.Size(200, 42);
            this.button_readConfig.TabIndex = 0;
            this.button_readConfig.Text = "Read config from SD";
            this.button_readConfig.UseVisualStyleBackColor = true;
            this.button_readConfig.Click += new System.EventHandler(this.button_readConfig_Click);
            // 
            // button_saveConfig
            // 
            this.button_saveConfig.Enabled = false;
            this.button_saveConfig.Location = new System.Drawing.Point(12, 228);
            this.button_saveConfig.Margin = new System.Windows.Forms.Padding(6);
            this.button_saveConfig.Name = "button_saveConfig";
            this.button_saveConfig.Size = new System.Drawing.Size(196, 42);
            this.button_saveConfig.TabIndex = 0;
            this.button_saveConfig.Text = "Save config to SD";
            this.button_saveConfig.UseVisualStyleBackColor = true;
            this.button_saveConfig.Click += new System.EventHandler(this.button_saveConfig_Click);
            // 
            // button_delFile
            // 
            this.button_delFile.Enabled = false;
            this.button_delFile.Location = new System.Drawing.Point(12, 174);
            this.button_delFile.Margin = new System.Windows.Forms.Padding(6);
            this.button_delFile.Name = "button_delFile";
            this.button_delFile.Size = new System.Drawing.Size(196, 42);
            this.button_delFile.TabIndex = 0;
            this.button_delFile.Text = "Delete file";
            this.button_delFile.UseVisualStyleBackColor = true;
            this.button_delFile.Click += new System.EventHandler(this.button_delFile_Click);
            // 
            // button_getFile
            // 
            this.button_getFile.Enabled = false;
            this.button_getFile.Location = new System.Drawing.Point(12, 120);
            this.button_getFile.Margin = new System.Windows.Forms.Padding(6);
            this.button_getFile.Name = "button_getFile";
            this.button_getFile.Size = new System.Drawing.Size(196, 42);
            this.button_getFile.TabIndex = 0;
            this.button_getFile.Text = "Get file";
            this.button_getFile.UseVisualStyleBackColor = true;
            this.button_getFile.Click += new System.EventHandler(this.button_getFile_Click);
            // 
            // comboBox_delFileList
            // 
            this.comboBox_delFileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_delFileList.FormattingEnabled = true;
            this.comboBox_delFileList.Location = new System.Drawing.Point(220, 180);
            this.comboBox_delFileList.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_delFileList.Name = "comboBox_delFileList";
            this.comboBox_delFileList.Size = new System.Drawing.Size(200, 32);
            this.comboBox_delFileList.TabIndex = 2;
            // 
            // comboBox_getFileList
            // 
            this.comboBox_getFileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_getFileList.FormattingEnabled = true;
            this.comboBox_getFileList.Location = new System.Drawing.Point(220, 126);
            this.comboBox_getFileList.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_getFileList.Name = "comboBox_getFileList";
            this.comboBox_getFileList.Size = new System.Drawing.Size(200, 32);
            this.comboBox_getFileList.TabIndex = 2;
            // 
            // button_getConfig
            // 
            this.button_getConfig.Enabled = false;
            this.button_getConfig.Location = new System.Drawing.Point(12, 12);
            this.button_getConfig.Margin = new System.Windows.Forms.Padding(6);
            this.button_getConfig.Name = "button_getConfig";
            this.button_getConfig.Size = new System.Drawing.Size(196, 42);
            this.button_getConfig.TabIndex = 0;
            this.button_getConfig.Text = "Get settings";
            this.button_getConfig.UseVisualStyleBackColor = true;
            this.button_getConfig.Click += new System.EventHandler(this.button_getSettings_Click);
            // 
            // button_getFileList
            // 
            this.button_getFileList.Enabled = false;
            this.button_getFileList.Location = new System.Drawing.Point(12, 66);
            this.button_getFileList.Margin = new System.Windows.Forms.Padding(6);
            this.button_getFileList.Name = "button_getFileList";
            this.button_getFileList.Size = new System.Drawing.Size(196, 42);
            this.button_getFileList.TabIndex = 0;
            this.button_getFileList.Text = "Get file list";
            this.button_getFileList.UseVisualStyleBackColor = true;
            this.button_getFileList.Click += new System.EventHandler(this.button_getFileList_Click);
            // 
            // tabPage_Set
            // 
            this.tabPage_Set.AutoScroll = true;
            this.tabPage_Set.Controls.Add(this.checkBox_pcTime);
            this.tabPage_Set.Controls.Add(this.comboBox_echo);
            this.tabPage_Set.Controls.Add(this.button_autoStart);
            this.tabPage_Set.Controls.Add(this.checkBox_autoStart);
            this.tabPage_Set.Controls.Add(this.button_echo);
            this.tabPage_Set.Controls.Add(this.button_signals);
            this.tabPage_Set.Controls.Add(this.button_timeStamp);
            this.tabPage_Set.Controls.Add(this.button_sendAll);
            this.tabPage_Set.Controls.Add(this.checkBox_signals);
            this.tabPage_Set.Controls.Add(this.checkBox_timeStamp);
            this.tabPage_Set.Controls.Add(this.textBox_setTime);
            this.tabPage_Set.Controls.Add(this.textBox_portConfig);
            this.tabPage_Set.Controls.Add(this.textBox_portSpeed);
            this.tabPage_Set.Controls.Add(this.textBox_serialSpeed);
            this.tabPage_Set.Controls.Add(this.button_setTime);
            this.tabPage_Set.Controls.Add(this.button_portConfig);
            this.tabPage_Set.Controls.Add(this.button_getTime);
            this.tabPage_Set.Controls.Add(this.button_portSpeed);
            this.tabPage_Set.Controls.Add(this.button_serialSpeed);
            this.tabPage_Set.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Set.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage_Set.Name = "tabPage_Set";
            this.tabPage_Set.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage_Set.Size = new System.Drawing.Size(432, 328);
            this.tabPage_Set.TabIndex = 0;
            this.tabPage_Set.Text = "Set settings";
            this.tabPage_Set.UseVisualStyleBackColor = true;
            // 
            // checkBox_pcTime
            // 
            this.checkBox_pcTime.AutoSize = true;
            this.checkBox_pcTime.Location = new System.Drawing.Point(314, 245);
            this.checkBox_pcTime.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_pcTime.Name = "checkBox_pcTime";
            this.checkBox_pcTime.Size = new System.Drawing.Size(94, 28);
            this.checkBox_pcTime.TabIndex = 10;
            this.checkBox_pcTime.Text = "PC time";
            this.checkBox_pcTime.UseVisualStyleBackColor = true;
            this.checkBox_pcTime.CheckedChanged += new System.EventHandler(this.checkBox_pcTime_CheckedChanged);
            // 
            // comboBox_echo
            // 
            this.comboBox_echo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_echo.FormattingEnabled = true;
            this.comboBox_echo.Items.AddRange(new object[] {
            "OFF",
            "HEX",
            "BIN"});
            this.comboBox_echo.Location = new System.Drawing.Point(228, 178);
            this.comboBox_echo.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_echo.Name = "comboBox_echo";
            this.comboBox_echo.Size = new System.Drawing.Size(180, 32);
            this.comboBox_echo.TabIndex = 9;
            // 
            // button_autoStart
            // 
            this.button_autoStart.Enabled = false;
            this.button_autoStart.Location = new System.Drawing.Point(12, 441);
            this.button_autoStart.Margin = new System.Windows.Forms.Padding(6);
            this.button_autoStart.Name = "button_autoStart";
            this.button_autoStart.Size = new System.Drawing.Size(204, 42);
            this.button_autoStart.TabIndex = 8;
            this.button_autoStart.Text = "Start log on boot";
            this.button_autoStart.UseVisualStyleBackColor = true;
            this.button_autoStart.Click += new System.EventHandler(this.button_autoStart_Click);
            // 
            // checkBox_autoStart
            // 
            this.checkBox_autoStart.AutoSize = true;
            this.checkBox_autoStart.Location = new System.Drawing.Point(228, 456);
            this.checkBox_autoStart.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_autoStart.Name = "checkBox_autoStart";
            this.checkBox_autoStart.Size = new System.Drawing.Size(15, 14);
            this.checkBox_autoStart.TabIndex = 7;
            this.checkBox_autoStart.UseVisualStyleBackColor = true;
            // 
            // button_echo
            // 
            this.button_echo.Enabled = false;
            this.button_echo.Location = new System.Drawing.Point(12, 172);
            this.button_echo.Margin = new System.Windows.Forms.Padding(6);
            this.button_echo.Name = "button_echo";
            this.button_echo.Size = new System.Drawing.Size(204, 42);
            this.button_echo.TabIndex = 6;
            this.button_echo.Text = "Print log data";
            this.button_echo.UseVisualStyleBackColor = true;
            this.button_echo.Click += new System.EventHandler(this.button_echo_Click);
            // 
            // button_signals
            // 
            this.button_signals.Enabled = false;
            this.button_signals.Location = new System.Drawing.Point(12, 387);
            this.button_signals.Margin = new System.Windows.Forms.Padding(6);
            this.button_signals.Name = "button_signals";
            this.button_signals.Size = new System.Drawing.Size(204, 42);
            this.button_signals.TabIndex = 5;
            this.button_signals.Text = "Log signals";
            this.button_signals.UseVisualStyleBackColor = true;
            this.button_signals.Click += new System.EventHandler(this.button_signals_Click);
            // 
            // button_timeStamp
            // 
            this.button_timeStamp.Enabled = false;
            this.button_timeStamp.Location = new System.Drawing.Point(12, 333);
            this.button_timeStamp.Margin = new System.Windows.Forms.Padding(6);
            this.button_timeStamp.Name = "button_timeStamp";
            this.button_timeStamp.Size = new System.Drawing.Size(204, 42);
            this.button_timeStamp.TabIndex = 5;
            this.button_timeStamp.Text = "Enable timestamp";
            this.button_timeStamp.UseVisualStyleBackColor = true;
            this.button_timeStamp.Click += new System.EventHandler(this.button_timeStamp_Click);
            // 
            // button_sendAll
            // 
            this.button_sendAll.Enabled = false;
            this.button_sendAll.Location = new System.Drawing.Point(289, 424);
            this.button_sendAll.Margin = new System.Windows.Forms.Padding(6);
            this.button_sendAll.Name = "button_sendAll";
            this.button_sendAll.Size = new System.Drawing.Size(119, 59);
            this.button_sendAll.TabIndex = 4;
            this.button_sendAll.Text = "Send all settings";
            this.button_sendAll.UseVisualStyleBackColor = true;
            this.button_sendAll.Click += new System.EventHandler(this.button_sendSet_Click);
            // 
            // checkBox_signals
            // 
            this.checkBox_signals.AutoSize = true;
            this.checkBox_signals.Location = new System.Drawing.Point(228, 402);
            this.checkBox_signals.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_signals.Name = "checkBox_signals";
            this.checkBox_signals.Size = new System.Drawing.Size(15, 14);
            this.checkBox_signals.TabIndex = 2;
            this.checkBox_signals.UseVisualStyleBackColor = true;
            // 
            // checkBox_timeStamp
            // 
            this.checkBox_timeStamp.AutoSize = true;
            this.checkBox_timeStamp.Location = new System.Drawing.Point(228, 348);
            this.checkBox_timeStamp.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_timeStamp.Name = "checkBox_timeStamp";
            this.checkBox_timeStamp.Size = new System.Drawing.Size(15, 14);
            this.checkBox_timeStamp.TabIndex = 2;
            this.checkBox_timeStamp.UseVisualStyleBackColor = true;
            // 
            // textBox_setTime
            // 
            this.textBox_setTime.Location = new System.Drawing.Point(228, 285);
            this.textBox_setTime.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_setTime.MaxLength = 19;
            this.textBox_setTime.Name = "textBox_setTime";
            this.textBox_setTime.Size = new System.Drawing.Size(180, 29);
            this.textBox_setTime.TabIndex = 1;
            this.textBox_setTime.Text = "2018/12/31 01:02:03";
            // 
            // textBox_portConfig
            // 
            this.textBox_portConfig.Location = new System.Drawing.Point(228, 124);
            this.textBox_portConfig.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_portConfig.MaxLength = 3;
            this.textBox_portConfig.Name = "textBox_portConfig";
            this.textBox_portConfig.Size = new System.Drawing.Size(180, 29);
            this.textBox_portConfig.TabIndex = 1;
            this.textBox_portConfig.Text = "8N1";
            // 
            // textBox_portSpeed
            // 
            this.textBox_portSpeed.Location = new System.Drawing.Point(228, 71);
            this.textBox_portSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_portSpeed.MaxLength = 7;
            this.textBox_portSpeed.Name = "textBox_portSpeed";
            this.textBox_portSpeed.Size = new System.Drawing.Size(180, 29);
            this.textBox_portSpeed.TabIndex = 1;
            this.textBox_portSpeed.Text = "115200";
            // 
            // textBox_serialSpeed
            // 
            this.textBox_serialSpeed.Location = new System.Drawing.Point(228, 17);
            this.textBox_serialSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_serialSpeed.MaxLength = 7;
            this.textBox_serialSpeed.Name = "textBox_serialSpeed";
            this.textBox_serialSpeed.Size = new System.Drawing.Size(180, 29);
            this.textBox_serialSpeed.TabIndex = 1;
            this.textBox_serialSpeed.Text = "250000";
            // 
            // button_setTime
            // 
            this.button_setTime.Enabled = false;
            this.button_setTime.Location = new System.Drawing.Point(12, 279);
            this.button_setTime.Margin = new System.Windows.Forms.Padding(6);
            this.button_setTime.Name = "button_setTime";
            this.button_setTime.Size = new System.Drawing.Size(204, 42);
            this.button_setTime.TabIndex = 0;
            this.button_setTime.Text = "Set time";
            this.button_setTime.UseVisualStyleBackColor = true;
            this.button_setTime.Click += new System.EventHandler(this.button_setTime_Click);
            // 
            // button_portConfig
            // 
            this.button_portConfig.Enabled = false;
            this.button_portConfig.Location = new System.Drawing.Point(12, 118);
            this.button_portConfig.Margin = new System.Windows.Forms.Padding(6);
            this.button_portConfig.Name = "button_portConfig";
            this.button_portConfig.Size = new System.Drawing.Size(204, 42);
            this.button_portConfig.TabIndex = 0;
            this.button_portConfig.Text = "Set port config";
            this.button_portConfig.UseVisualStyleBackColor = true;
            this.button_portConfig.Click += new System.EventHandler(this.button_portConfig_Click);
            // 
            // button_getTime
            // 
            this.button_getTime.Enabled = false;
            this.button_getTime.Location = new System.Drawing.Point(12, 226);
            this.button_getTime.Margin = new System.Windows.Forms.Padding(6);
            this.button_getTime.Name = "button_getTime";
            this.button_getTime.Size = new System.Drawing.Size(204, 42);
            this.button_getTime.TabIndex = 0;
            this.button_getTime.Text = "Get time";
            this.button_getTime.UseVisualStyleBackColor = true;
            this.button_getTime.Click += new System.EventHandler(this.button_getTime_Click);
            // 
            // button_portSpeed
            // 
            this.button_portSpeed.Enabled = false;
            this.button_portSpeed.Location = new System.Drawing.Point(12, 65);
            this.button_portSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.button_portSpeed.Name = "button_portSpeed";
            this.button_portSpeed.Size = new System.Drawing.Size(204, 42);
            this.button_portSpeed.TabIndex = 0;
            this.button_portSpeed.Text = "Set logging speed";
            this.button_portSpeed.UseVisualStyleBackColor = true;
            this.button_portSpeed.Click += new System.EventHandler(this.button_portSpeed_Click);
            // 
            // button_serialSpeed
            // 
            this.button_serialSpeed.Enabled = false;
            this.button_serialSpeed.Location = new System.Drawing.Point(12, 11);
            this.button_serialSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.button_serialSpeed.Name = "button_serialSpeed";
            this.button_serialSpeed.Size = new System.Drawing.Size(204, 42);
            this.button_serialSpeed.TabIndex = 0;
            this.button_serialSpeed.Text = "Set device port speed";
            this.button_serialSpeed.UseVisualStyleBackColor = true;
            this.button_serialSpeed.Click += new System.EventHandler(this.button_serialSpeed_Click);
            // 
            // tabPage_Commands
            // 
            this.tabPage_Commands.AutoScroll = true;
            this.tabPage_Commands.Controls.Add(this.checkBox_customEdit);
            this.tabPage_Commands.Controls.Add(this.label12);
            this.tabPage_Commands.Controls.Add(this.label11);
            this.tabPage_Commands.Controls.Add(this.label10);
            this.tabPage_Commands.Controls.Add(this.label9);
            this.tabPage_Commands.Controls.Add(this.label8);
            this.tabPage_Commands.Controls.Add(this.label7);
            this.tabPage_Commands.Controls.Add(this.label6);
            this.tabPage_Commands.Controls.Add(this.label5);
            this.tabPage_Commands.Controls.Add(this.label4);
            this.tabPage_Commands.Controls.Add(this.label3);
            this.tabPage_Commands.Controls.Add(this.label21);
            this.tabPage_Commands.Controls.Add(this.label16);
            this.tabPage_Commands.Controls.Add(this.label14);
            this.tabPage_Commands.Controls.Add(this.label19);
            this.tabPage_Commands.Controls.Add(this.label15);
            this.tabPage_Commands.Controls.Add(this.label13);
            this.tabPage_Commands.Controls.Add(this.label2);
            this.tabPage_Commands.Controls.Add(this.textBox_autoStartCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_signalsCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_timeStampCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_echoCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_portConfigCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_portSpeedCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_serialSpeedCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_getFileListCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_delFileCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_getFileCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_setTimeCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_stopCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_readConfigCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_getTimeCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_startCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_saveConfigCMD);
            this.tabPage_Commands.Controls.Add(this.textBox_getConfigCMD);
            this.tabPage_Commands.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Commands.Name = "tabPage_Commands";
            this.tabPage_Commands.Size = new System.Drawing.Size(432, 328);
            this.tabPage_Commands.TabIndex = 2;
            this.tabPage_Commands.Text = "Commands";
            this.tabPage_Commands.UseVisualStyleBackColor = true;
            // 
            // checkBox_customEdit
            // 
            this.checkBox_customEdit.AutoSize = true;
            this.checkBox_customEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_customEdit.Location = new System.Drawing.Point(331, 5);
            this.checkBox_customEdit.Name = "checkBox_customEdit";
            this.checkBox_customEdit.Size = new System.Drawing.Size(79, 17);
            this.checkBox_customEdit.TabIndex = 4;
            this.checkBox_customEdit.Text = "Edit enable";
            this.checkBox_customEdit.UseVisualStyleBackColor = true;
            this.checkBox_customEdit.CheckedChanged += new System.EventHandler(this.checkBoxcustomEdit_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(112, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Settings -> Start log on boot";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(112, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Settings -> Log signals";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(112, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Settings -> Enable timestamp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(112, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Settings -> Print log data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(112, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Settings -> Set port config";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(112, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Settings -> Set logging speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(112, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Settings -> Set device port speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(112, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Get data -> Get file list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(112, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Get data -> Delete file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Get data -> Get file";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(112, 390);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Settings -> Set time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(112, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Get data -> Stop logging";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(112, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Get data -> Read config from SD";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(112, 366);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Settings -> Get time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(112, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Get data -> Start logging";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(112, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Get data -> Save config to SD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(112, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Get data -> Get settings";
            // 
            // textBox_autoStartCMD
            // 
            this.textBox_autoStartCMD.Enabled = false;
            this.textBox_autoStartCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_autoStartCMD.Location = new System.Drawing.Point(6, 243);
            this.textBox_autoStartCMD.Name = "textBox_autoStartCMD";
            this.textBox_autoStartCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_autoStartCMD.TabIndex = 2;
            this.textBox_autoStartCMD.Text = "autostart ";
            // 
            // textBox_signalsCMD
            // 
            this.textBox_signalsCMD.Enabled = false;
            this.textBox_signalsCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_signalsCMD.Location = new System.Drawing.Point(6, 219);
            this.textBox_signalsCMD.Name = "textBox_signalsCMD";
            this.textBox_signalsCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_signalsCMD.TabIndex = 2;
            this.textBox_signalsCMD.Text = "signals ";
            // 
            // textBox_timeStampCMD
            // 
            this.textBox_timeStampCMD.Enabled = false;
            this.textBox_timeStampCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_timeStampCMD.Location = new System.Drawing.Point(6, 195);
            this.textBox_timeStampCMD.Name = "textBox_timeStampCMD";
            this.textBox_timeStampCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_timeStampCMD.TabIndex = 2;
            this.textBox_timeStampCMD.Text = "timestamp ";
            // 
            // textBox_echoCMD
            // 
            this.textBox_echoCMD.Enabled = false;
            this.textBox_echoCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_echoCMD.Location = new System.Drawing.Point(6, 171);
            this.textBox_echoCMD.Name = "textBox_echoCMD";
            this.textBox_echoCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_echoCMD.TabIndex = 2;
            this.textBox_echoCMD.Text = "echo ";
            // 
            // textBox_portConfigCMD
            // 
            this.textBox_portConfigCMD.Enabled = false;
            this.textBox_portConfigCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_portConfigCMD.Location = new System.Drawing.Point(6, 147);
            this.textBox_portConfigCMD.Name = "textBox_portConfigCMD";
            this.textBox_portConfigCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_portConfigCMD.TabIndex = 2;
            this.textBox_portConfigCMD.Text = "portconfig ";
            // 
            // textBox_portSpeedCMD
            // 
            this.textBox_portSpeedCMD.Enabled = false;
            this.textBox_portSpeedCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_portSpeedCMD.Location = new System.Drawing.Point(6, 123);
            this.textBox_portSpeedCMD.Name = "textBox_portSpeedCMD";
            this.textBox_portSpeedCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_portSpeedCMD.TabIndex = 2;
            this.textBox_portSpeedCMD.Text = "portspeed ";
            // 
            // textBox_serialSpeedCMD
            // 
            this.textBox_serialSpeedCMD.Enabled = false;
            this.textBox_serialSpeedCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_serialSpeedCMD.Location = new System.Drawing.Point(6, 99);
            this.textBox_serialSpeedCMD.Name = "textBox_serialSpeedCMD";
            this.textBox_serialSpeedCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_serialSpeedCMD.TabIndex = 2;
            this.textBox_serialSpeedCMD.Text = "serialspeed ";
            // 
            // textBox_getFileListCMD
            // 
            this.textBox_getFileListCMD.Enabled = false;
            this.textBox_getFileListCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_getFileListCMD.Location = new System.Drawing.Point(6, 75);
            this.textBox_getFileListCMD.Name = "textBox_getFileListCMD";
            this.textBox_getFileListCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_getFileListCMD.TabIndex = 2;
            this.textBox_getFileListCMD.Text = "list";
            // 
            // textBox_delFileCMD
            // 
            this.textBox_delFileCMD.Enabled = false;
            this.textBox_delFileCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_delFileCMD.Location = new System.Drawing.Point(6, 51);
            this.textBox_delFileCMD.Name = "textBox_delFileCMD";
            this.textBox_delFileCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_delFileCMD.TabIndex = 2;
            this.textBox_delFileCMD.Text = "delete ";
            // 
            // textBox_getFileCMD
            // 
            this.textBox_getFileCMD.Enabled = false;
            this.textBox_getFileCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_getFileCMD.Location = new System.Drawing.Point(6, 27);
            this.textBox_getFileCMD.Name = "textBox_getFileCMD";
            this.textBox_getFileCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_getFileCMD.TabIndex = 2;
            this.textBox_getFileCMD.Text = "download bin ";
            // 
            // textBox_setTimeCMD
            // 
            this.textBox_setTimeCMD.Enabled = false;
            this.textBox_setTimeCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_setTimeCMD.Location = new System.Drawing.Point(6, 387);
            this.textBox_setTimeCMD.Name = "textBox_setTimeCMD";
            this.textBox_setTimeCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_setTimeCMD.TabIndex = 2;
            this.textBox_setTimeCMD.Text = "time ";
            // 
            // textBox_stopCMD
            // 
            this.textBox_stopCMD.Enabled = false;
            this.textBox_stopCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_stopCMD.Location = new System.Drawing.Point(6, 339);
            this.textBox_stopCMD.Name = "textBox_stopCMD";
            this.textBox_stopCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_stopCMD.TabIndex = 2;
            this.textBox_stopCMD.Text = "stop";
            // 
            // textBox_readConfigCMD
            // 
            this.textBox_readConfigCMD.Enabled = false;
            this.textBox_readConfigCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_readConfigCMD.Location = new System.Drawing.Point(6, 291);
            this.textBox_readConfigCMD.Name = "textBox_readConfigCMD";
            this.textBox_readConfigCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_readConfigCMD.TabIndex = 2;
            this.textBox_readConfigCMD.Text = "read config";
            // 
            // textBox_getTimeCMD
            // 
            this.textBox_getTimeCMD.Enabled = false;
            this.textBox_getTimeCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_getTimeCMD.Location = new System.Drawing.Point(6, 363);
            this.textBox_getTimeCMD.Name = "textBox_getTimeCMD";
            this.textBox_getTimeCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_getTimeCMD.TabIndex = 2;
            this.textBox_getTimeCMD.Text = "showtime";
            // 
            // textBox_startCMD
            // 
            this.textBox_startCMD.Enabled = false;
            this.textBox_startCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_startCMD.Location = new System.Drawing.Point(6, 315);
            this.textBox_startCMD.Name = "textBox_startCMD";
            this.textBox_startCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_startCMD.TabIndex = 2;
            this.textBox_startCMD.Text = "start";
            // 
            // textBox_saveConfigCMD
            // 
            this.textBox_saveConfigCMD.Enabled = false;
            this.textBox_saveConfigCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_saveConfigCMD.Location = new System.Drawing.Point(6, 267);
            this.textBox_saveConfigCMD.Name = "textBox_saveConfigCMD";
            this.textBox_saveConfigCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_saveConfigCMD.TabIndex = 2;
            this.textBox_saveConfigCMD.Text = "save config";
            // 
            // textBox_getConfigCMD
            // 
            this.textBox_getConfigCMD.Enabled = false;
            this.textBox_getConfigCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_getConfigCMD.Location = new System.Drawing.Point(6, 3);
            this.textBox_getConfigCMD.Name = "textBox_getConfigCMD";
            this.textBox_getConfigCMD.Size = new System.Drawing.Size(100, 18);
            this.textBox_getConfigCMD.TabIndex = 2;
            this.textBox_getConfigCMD.Text = "config";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox6);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(432, 328);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Enabled = false;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox6.Location = new System.Drawing.Point(16, 172);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(70, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Show RX";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Enabled = false;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox5.Location = new System.Drawing.Point(16, 149);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 17);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Show TX";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(16, 126);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(108, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Show timestamps";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(16, 103);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Show signals";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(16, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "To BIN";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(3, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Decode downloaded files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(6, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Log line buffer";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(86, 33);
            this.textBox3.MaxLength = 6;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 18);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "866";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(6, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Code page";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(71, 7);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 18);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "866";
            // 
            // textBox_terminal
            // 
            this.textBox_terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_terminal.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_terminal.Location = new System.Drawing.Point(450, 34);
            this.textBox_terminal.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_terminal.Multiline = true;
            this.textBox_terminal.Name = "textBox_terminal";
            this.textBox_terminal.ReadOnly = true;
            this.textBox_terminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_terminal.Size = new System.Drawing.Size(281, 409);
            this.textBox_terminal.TabIndex = 1;
            this.textBox_terminal.TextChanged += new System.EventHandler(this.textBox_terminal_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 57600;
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save log to file...";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // comboBox_portName
            // 
            this.comboBox_portName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_portName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portName.FormattingEnabled = true;
            this.comboBox_portName.Location = new System.Drawing.Point(81, 377);
            this.comboBox_portName.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_portName.Name = "comboBox_portName";
            this.comboBox_portName.Size = new System.Drawing.Size(133, 32);
            this.comboBox_portName.TabIndex = 2;
            this.comboBox_portName.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port #";
            // 
            // button_openPort
            // 
            this.button_openPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_openPort.Location = new System.Drawing.Point(15, 455);
            this.button_openPort.Margin = new System.Windows.Forms.Padding(6);
            this.button_openPort.Name = "button_openPort";
            this.button_openPort.Size = new System.Drawing.Size(133, 42);
            this.button_openPort.TabIndex = 5;
            this.button_openPort.Text = "Open port";
            this.button_openPort.UseVisualStyleBackColor = true;
            this.button_openPort.Click += new System.EventHandler(this.button_openPort_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(631, 455);
            this.button_clear.Margin = new System.Windows.Forms.Padding(6);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 42);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Clear log";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_closePort
            // 
            this.button_closePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_closePort.Enabled = false;
            this.button_closePort.Location = new System.Drawing.Point(159, 455);
            this.button_closePort.Margin = new System.Windows.Forms.Padding(6);
            this.button_closePort.Name = "button_closePort";
            this.button_closePort.Size = new System.Drawing.Size(133, 42);
            this.button_closePort.TabIndex = 4;
            this.button_closePort.Text = "Close port";
            this.button_closePort.UseVisualStyleBackColor = true;
            this.button_closePort.Click += new System.EventHandler(this.button_closePort_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_save.Location = new System.Drawing.Point(454, 455);
            this.button_save.Margin = new System.Windows.Forms.Padding(6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(98, 42);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save log";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_saveFile_Click);
            // 
            // checkBox_autoScroll
            // 
            this.checkBox_autoScroll.AutoSize = true;
            this.checkBox_autoScroll.Checked = true;
            this.checkBox_autoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoScroll.Location = new System.Drawing.Point(454, 0);
            this.checkBox_autoScroll.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_autoScroll.Name = "checkBox_autoScroll";
            this.checkBox_autoScroll.Size = new System.Drawing.Size(112, 28);
            this.checkBox_autoScroll.TabIndex = 8;
            this.checkBox_autoScroll.Text = "Autoscroll";
            this.checkBox_autoScroll.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_refresh.Location = new System.Drawing.Point(308, 455);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(133, 42);
            this.button_refresh.TabIndex = 10;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // checkBox_portMon
            // 
            this.checkBox_portMon.AutoSize = true;
            this.checkBox_portMon.Checked = true;
            this.checkBox_portMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_portMon.Location = new System.Drawing.Point(578, 0);
            this.checkBox_portMon.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_portMon.Name = "checkBox_portMon";
            this.checkBox_portMon.Size = new System.Drawing.Size(156, 28);
            this.checkBox_portMon.TabIndex = 9;
            this.checkBox_portMon.Text = "Port monitoring";
            this.checkBox_portMon.UseVisualStyleBackColor = true;
            this.checkBox_portMon.CheckedChanged += new System.EventHandler(this.checkBox_portMon_CheckedChanged);
            // 
            // comboBox_speed
            // 
            this.comboBox_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_speed.FormattingEnabled = true;
            this.comboBox_speed.Items.AddRange(new object[] {
            "2000000",
            "1000000",
            "500000",
            "250000",
            "230400",
            "115200",
            "57600",
            "38400",
            "19200",
            "9600",
            "4800",
            "2400",
            "1200"});
            this.comboBox_speed.Location = new System.Drawing.Point(304, 377);
            this.comboBox_speed.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_speed.Name = "comboBox_speed";
            this.comboBox_speed.Size = new System.Drawing.Size(134, 32);
            this.comboBox_speed.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 380);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 24);
            this.label17.TabIndex = 3;
            this.label17.Text = "Speed";
            // 
            // checkBox_dtr
            // 
            this.checkBox_dtr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_dtr.AutoSize = true;
            this.checkBox_dtr.Enabled = false;
            this.checkBox_dtr.Location = new System.Drawing.Point(15, 418);
            this.checkBox_dtr.Name = "checkBox_dtr";
            this.checkBox_dtr.Size = new System.Drawing.Size(67, 28);
            this.checkBox_dtr.TabIndex = 11;
            this.checkBox_dtr.Text = "DTR";
            this.checkBox_dtr.UseVisualStyleBackColor = true;
            this.checkBox_dtr.CheckedChanged += new System.EventHandler(this.checkBox_dtr_CheckedChanged);
            // 
            // checkBox_rts
            // 
            this.checkBox_rts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_rts.AutoSize = true;
            this.checkBox_rts.Enabled = false;
            this.checkBox_rts.Location = new System.Drawing.Point(159, 418);
            this.checkBox_rts.Name = "checkBox_rts";
            this.checkBox_rts.Size = new System.Drawing.Size(66, 28);
            this.checkBox_rts.TabIndex = 11;
            this.checkBox_rts.Text = "RTS";
            this.checkBox_rts.UseVisualStyleBackColor = true;
            this.checkBox_rts.CheckedChanged += new System.EventHandler(this.checkBox_rts_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 512);
            this.Controls.Add(this.checkBox_rts);
            this.Controls.Add(this.checkBox_dtr);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.checkBox_portMon);
            this.Controls.Add(this.checkBox_autoScroll);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_openPort);
            this.Controls.Add(this.button_closePort);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox_speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_portName);
            this.Controls.Add(this.textBox_terminal);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(770, 550);
            this.Name = "Form1";
            this.Text = "RS232Logger control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Get.ResumeLayout(false);
            this.tabPage_Get.PerformLayout();
            this.tabPage_Set.ResumeLayout(false);
            this.tabPage_Set.PerformLayout();
            this.tabPage_Commands.ResumeLayout(false);
            this.tabPage_Commands.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Set;
        private System.Windows.Forms.CheckBox checkBox_timeStamp;
        private System.Windows.Forms.TextBox textBox_portConfig;
        private System.Windows.Forms.TextBox textBox_portSpeed;
        private System.Windows.Forms.TextBox textBox_serialSpeed;
        private System.Windows.Forms.Button button_portConfig;
        private System.Windows.Forms.Button button_portSpeed;
        private System.Windows.Forms.Button button_serialSpeed;
        private System.Windows.Forms.TabPage tabPage_Get;
        private System.Windows.Forms.TextBox textBox_terminal;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_portName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_openPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_closePort;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_sendAll;
        private System.Windows.Forms.Button button_echo;
        private System.Windows.Forms.Button button_timeStamp;
        private System.Windows.Forms.CheckBox checkBox_autoScroll;
        private System.Windows.Forms.TabPage tabPage_Commands;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_portConfigCMD;
        private System.Windows.Forms.TextBox textBox_portSpeedCMD;
        private System.Windows.Forms.TextBox textBox_serialSpeedCMD;
        private System.Windows.Forms.TextBox textBox_getFileListCMD;
        private System.Windows.Forms.TextBox textBox_delFileCMD;
        private System.Windows.Forms.TextBox textBox_getFileCMD;
        private System.Windows.Forms.TextBox textBox_getConfigCMD;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.CheckBox checkBox_customEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_autoStartCMD;
        private System.Windows.Forms.TextBox textBox_signalsCMD;
        private System.Windows.Forms.TextBox textBox_timeStampCMD;
        private System.Windows.Forms.TextBox textBox_echoCMD;
        private System.Windows.Forms.TextBox textBox_readConfigCMD;
        private System.Windows.Forms.TextBox textBox_saveConfigCMD;
        private System.Windows.Forms.Button button_stopLog;
        private System.Windows.Forms.Button button_startLog;
        private System.Windows.Forms.Button button_delFile;
        private System.Windows.Forms.Button button_getFile;
        private System.Windows.Forms.Button button_getConfig;
        private System.Windows.Forms.Button button_getFileList;
        private System.Windows.Forms.CheckBox checkBox_portMon;
        private System.Windows.Forms.Button button_signals;
        private System.Windows.Forms.CheckBox checkBox_signals;
        private System.Windows.Forms.Button button_autoStart;
        private System.Windows.Forms.CheckBox checkBox_autoStart;
        private System.Windows.Forms.Button button_readConfig;
        private System.Windows.Forms.Button button_saveConfig;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_stopCMD;
        private System.Windows.Forms.TextBox textBox_startCMD;
        private System.Windows.Forms.Label label_sdCard;
        private System.Windows.Forms.ComboBox comboBox_speed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox_echo;
        private System.Windows.Forms.CheckBox checkBox_dtr;
        private System.Windows.Forms.CheckBox checkBox_rts;
        private System.Windows.Forms.ComboBox comboBox_getFileList;
        private System.Windows.Forms.ComboBox comboBox_delFileList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox_pcTime;
        private System.Windows.Forms.TextBox textBox_setTime;
        private System.Windows.Forms.Button button_setTime;
        private System.Windows.Forms.Button button_getTime;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_setTimeCMD;
        private System.Windows.Forms.TextBox textBox_getTimeCMD;
    }
}

