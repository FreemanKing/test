﻿using System.Windows.Forms;

namespace Modbus.Common
{
    partial class BaseForm
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonPauseLog = new System.Windows.Forms.Button();
            this.listBoxCommLog = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSlaveDelay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSlaveID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonInteger = new System.Windows.Forms.RadioButton();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.grpStart = new System.Windows.Forms.GroupBox();
            this.groupBoxRTU = new System.Windows.Forms.GroupBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonRTU = new System.Windows.Forms.RadioButton();
            this.radioButtonUDP = new System.Windows.Forms.RadioButton();
            this.radioButtonTCP = new System.Windows.Forms.RadioButton();
            this.groupBoxTCP = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpExchange = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSignalStart = new System.Windows.Forms.Button();
            this.signalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.btnSignalStop = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpStart.SuspendLayout();
            this.groupBoxRTU.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxTCP.SuspendLayout();
            this.grpExchange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPauseLog);
            this.groupBox4.Controls.Add(this.listBoxCommLog);
            this.groupBox4.Controls.Add(this.buttonClear);
            this.groupBox4.Location = new System.Drawing.Point(7, 645);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(859, 179);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Communication Log";
            // 
            // buttonPauseLog
            // 
            this.buttonPauseLog.Location = new System.Drawing.Point(660, 18);
            this.buttonPauseLog.Name = "buttonPauseLog";
            this.buttonPauseLog.Size = new System.Drawing.Size(86, 26);
            this.buttonPauseLog.TabIndex = 25;
            this.buttonPauseLog.Text = "Pause";
            this.buttonPauseLog.Click += new System.EventHandler(this.buttonPauseLog_Click);
            // 
            // listBoxCommLog
            // 
            this.listBoxCommLog.BackColor = System.Drawing.Color.Black;
            this.listBoxCommLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.listBoxCommLog.FormattingEnabled = true;
            this.listBoxCommLog.HorizontalScrollbar = true;
            this.listBoxCommLog.ItemHeight = 12;
            this.listBoxCommLog.Location = new System.Drawing.Point(3, 50);
            this.listBoxCommLog.Name = "listBoxCommLog";
            this.listBoxCommLog.Size = new System.Drawing.Size(847, 124);
            this.listBoxCommLog.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(752, 18);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 26);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearLogClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Slave delay (ms)";
            // 
            // textBoxSlaveDelay
            // 
            this.textBoxSlaveDelay.Location = new System.Drawing.Point(120, 37);
            this.textBoxSlaveDelay.Name = "textBoxSlaveDelay";
            this.textBoxSlaveDelay.Size = new System.Drawing.Size(40, 21);
            this.textBoxSlaveDelay.TabIndex = 29;
            this.textBoxSlaveDelay.Text = "1";
            this.textBoxSlaveDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(28, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Slave ID";
            // 
            // textBoxSlaveID
            // 
            this.textBoxSlaveID.Location = new System.Drawing.Point(120, 18);
            this.textBoxSlaveID.Name = "textBoxSlaveID";
            this.textBoxSlaveID.Size = new System.Drawing.Size(40, 21);
            this.textBoxSlaveID.TabIndex = 27;
            this.textBoxSlaveID.Text = "1";
            this.textBoxSlaveID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonInteger);
            this.groupBox3.Location = new System.Drawing.Point(7, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 102);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display Format";
            // 
            // radioButtonInteger
            // 
            this.radioButtonInteger.Checked = true;
            this.radioButtonInteger.Location = new System.Drawing.Point(13, 32);
            this.radioButtonInteger.Name = "radioButtonInteger";
            this.radioButtonInteger.Size = new System.Drawing.Size(67, 48);
            this.radioButtonInteger.TabIndex = 2;
            this.radioButtonInteger.TabStop = true;
            this.radioButtonInteger.Tag = "Integer";
            this.radioButtonInteger.Text = "Integer";
            this.radioButtonInteger.Click += new System.EventHandler(this.RadioButtonDisplayFormatCheckedChanged);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(188, 14);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(86, 26);
            this.buttonImport.TabIndex = 26;
            this.buttonImport.Text = "Import";
            this.buttonImport.Click += new System.EventHandler(this.ButtonImportClick);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(188, 46);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(86, 26);
            this.buttonExport.TabIndex = 25;
            this.buttonExport.Text = "Export";
            this.buttonExport.Click += new System.EventHandler(this.ButtonExportClick);
            // 
            // grpStart
            // 
            this.grpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStart.Controls.Add(this.groupBoxRTU);
            this.grpStart.Controls.Add(this.groupBoxMode);
            this.grpStart.Controls.Add(this.groupBoxTCP);
            this.grpStart.Location = new System.Drawing.Point(7, 11);
            this.grpStart.Name = "grpStart";
            this.grpStart.Size = new System.Drawing.Size(665, 116);
            this.grpStart.TabIndex = 18;
            this.grpStart.TabStop = false;
            this.grpStart.Text = "Communication";
            // 
            // groupBoxRTU
            // 
            this.groupBoxRTU.Controls.Add(this.comboBoxStopBits);
            this.groupBoxRTU.Controls.Add(this.label10);
            this.groupBoxRTU.Controls.Add(this.comboBoxDataBits);
            this.groupBoxRTU.Controls.Add(this.label9);
            this.groupBoxRTU.Controls.Add(this.comboBoxParity);
            this.groupBoxRTU.Controls.Add(this.labelParity);
            this.groupBoxRTU.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxRTU.Controls.Add(this.comboBoxSerialPorts);
            this.groupBoxRTU.Controls.Add(this.label4);
            this.groupBoxRTU.Controls.Add(this.label5);
            this.groupBoxRTU.Enabled = false;
            this.groupBoxRTU.Location = new System.Drawing.Point(291, 12);
            this.groupBoxRTU.Name = "groupBoxRTU";
            this.groupBoxRTU.Size = new System.Drawing.Size(377, 98);
            this.groupBoxRTU.TabIndex = 25;
            this.groupBoxRTU.TabStop = false;
            this.groupBoxRTU.Text = "RTU";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "None",
            "1 Bit",
            "1.5 Bits",
            "2 Bits"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(280, 44);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(94, 20);
            this.comboBoxStopBits.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stop Bits =";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "7 Bits",
            "8 Bits"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(280, 18);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(94, 20);
            this.comboBoxDataBits.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "Data Bits =";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(80, 68);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(94, 20);
            this.comboBoxParity.TabIndex = 23;
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(36, 72);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(53, 12);
            this.labelParity.TabIndex = 22;
            this.labelParity.Text = "Parity =";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "128000",
            "115200",
            "57600",
            "38400",
            "19200",
            "14400",
            "9600",
            "7200",
            "4800",
            "2400",
            "1800",
            "1200",
            "600",
            "300",
            "150"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(80, 43);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(94, 20);
            this.comboBoxBaudRate.TabIndex = 21;
            // 
            // comboBoxSerialPorts
            // 
            this.comboBoxSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPorts.FormattingEnabled = true;
            this.comboBoxSerialPorts.Location = new System.Drawing.Point(80, 18);
            this.comboBoxSerialPorts.Name = "comboBoxSerialPorts";
            this.comboBoxSerialPorts.Size = new System.Drawing.Size(94, 20);
            this.comboBoxSerialPorts.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port Name =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Baud =";
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonRTU);
            this.groupBoxMode.Controls.Add(this.radioButtonUDP);
            this.groupBoxMode.Controls.Add(this.radioButtonTCP);
            this.groupBoxMode.Location = new System.Drawing.Point(6, 18);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(81, 92);
            this.groupBoxMode.TabIndex = 0;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // radioButtonRTU
            // 
            this.radioButtonRTU.AutoSize = true;
            this.radioButtonRTU.Location = new System.Drawing.Point(6, 54);
            this.radioButtonRTU.Name = "radioButtonRTU";
            this.radioButtonRTU.Size = new System.Drawing.Size(41, 16);
            this.radioButtonRTU.TabIndex = 3;
            this.radioButtonRTU.Text = "RTU";
            this.radioButtonRTU.UseVisualStyleBackColor = true;
            this.radioButtonRTU.CheckedChanged += new System.EventHandler(this.RadioButtonModeChanged);
            // 
            // radioButtonUDP
            // 
            this.radioButtonUDP.AutoSize = true;
            this.radioButtonUDP.Location = new System.Drawing.Point(6, 36);
            this.radioButtonUDP.Name = "radioButtonUDP";
            this.radioButtonUDP.Size = new System.Drawing.Size(41, 16);
            this.radioButtonUDP.TabIndex = 2;
            this.radioButtonUDP.Text = "UDP";
            this.radioButtonUDP.UseVisualStyleBackColor = true;
            this.radioButtonUDP.CheckedChanged += new System.EventHandler(this.RadioButtonModeChanged);
            // 
            // radioButtonTCP
            // 
            this.radioButtonTCP.AutoSize = true;
            this.radioButtonTCP.Checked = true;
            this.radioButtonTCP.Location = new System.Drawing.Point(6, 18);
            this.radioButtonTCP.Name = "radioButtonTCP";
            this.radioButtonTCP.Size = new System.Drawing.Size(41, 16);
            this.radioButtonTCP.TabIndex = 1;
            this.radioButtonTCP.TabStop = true;
            this.radioButtonTCP.Text = "TCP";
            this.radioButtonTCP.UseVisualStyleBackColor = true;
            this.radioButtonTCP.CheckedChanged += new System.EventHandler(this.RadioButtonModeChanged);
            // 
            // groupBoxTCP
            // 
            this.groupBoxTCP.Controls.Add(this.label8);
            this.groupBoxTCP.Controls.Add(this.txtIP);
            this.groupBoxTCP.Controls.Add(this.label6);
            this.groupBoxTCP.Controls.Add(this.textBoxPort);
            this.groupBoxTCP.Location = new System.Drawing.Point(93, 12);
            this.groupBoxTCP.Name = "groupBoxTCP";
            this.groupBoxTCP.Size = new System.Drawing.Size(192, 98);
            this.groupBoxTCP.TabIndex = 0;
            this.groupBoxTCP.TabStop = false;
            this.groupBoxTCP.Text = "TCP";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "IP Address";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(79, 43);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(97, 21);
            this.txtIP.TabIndex = 10;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(79, 18);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(44, 21);
            this.textBoxPort.TabIndex = 8;
            this.textBoxPort.Text = "502";
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // grpExchange
            // 
            this.grpExchange.Controls.Add(this.buttonImport);
            this.grpExchange.Controls.Add(this.textBoxSlaveID);
            this.grpExchange.Controls.Add(this.buttonExport);
            this.grpExchange.Controls.Add(this.label1);
            this.grpExchange.Controls.Add(this.label7);
            this.grpExchange.Controls.Add(this.textBoxSlaveDelay);
            this.grpExchange.Location = new System.Drawing.Point(571, 154);
            this.grpExchange.Name = "grpExchange";
            this.grpExchange.Size = new System.Drawing.Size(289, 81);
            this.grpExchange.TabIndex = 36;
            this.grpExchange.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSignalStart
            // 
            this.btnSignalStart.Location = new System.Drawing.Point(759, 103);
            this.btnSignalStart.Name = "btnSignalStart";
            this.btnSignalStart.Size = new System.Drawing.Size(86, 23);
            this.btnSignalStart.TabIndex = 0;
            this.btnSignalStart.Text = "开始";
            this.btnSignalStart.UseVisualStyleBackColor = true;
            this.btnSignalStart.Click += new System.EventHandler(this.btnSignalStartClick);
            // 
            // signalChart
            // 
            this.signalChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signalChart.Location = new System.Drawing.Point(7, 240);
            this.signalChart.Name = "signalChart";
            this.signalChart.Size = new System.Drawing.Size(884, 422);
            this.signalChart.TabIndex = 1;
            this.signalChart.Text = "chart1";
            // 
            // timerCount
            // 
            this.timerCount.Interval = 300;
            this.timerCount.Tick += new System.EventHandler(this.timerCountTick);
            // 
            // btnSignalStop
            // 
            this.btnSignalStop.Location = new System.Drawing.Point(759, 132);
            this.btnSignalStop.Name = "btnSignalStop";
            this.btnSignalStop.Size = new System.Drawing.Size(86, 23);
            this.btnSignalStop.TabIndex = 2;
            this.btnSignalStop.Text = "停止";
            this.btnSignalStop.UseVisualStyleBackColor = true;
            this.btnSignalStop.Click += new System.EventHandler(this.btnSignalStopClick);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(759, 74);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(86, 23);
            this.btnInit.TabIndex = 3;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInitClick);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 832);
            this.Controls.Add(this.grpExchange);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnSignalStop);
            this.Controls.Add(this.signalChart);
            this.Controls.Add(this.btnSignalStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "Modbus Slave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseFormClosing);
            this.Load += new System.EventHandler(this.BaseFormLoading);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpStart.ResumeLayout(false);
            this.groupBoxRTU.ResumeLayout(false);
            this.groupBoxRTU.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.groupBoxTCP.ResumeLayout(false);
            this.groupBoxTCP.PerformLayout();
            this.grpExchange.ResumeLayout(false);
            this.grpExchange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.ListBox listBoxCommLog;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox textBoxSlaveID;
        protected System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.RadioButton radioButtonLED;
        protected System.Windows.Forms.RadioButton radioButtonInteger;
        protected System.Windows.Forms.RadioButton radioButtonHex;
        protected System.Windows.Forms.RadioButton radioButtonBinary;
        protected System.Windows.Forms.Button buttonClear;
        protected System.Windows.Forms.Button buttonImport;
        protected System.Windows.Forms.Button buttonExport;
        protected System.Windows.Forms.GroupBox grpStart;
        protected System.Windows.Forms.GroupBox groupBoxRTU;
        protected System.Windows.Forms.ComboBox comboBoxSerialPorts;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.GroupBox groupBoxMode;
        protected System.Windows.Forms.RadioButton radioButtonUDP;
        protected System.Windows.Forms.RadioButton radioButtonTCP;
        protected System.Windows.Forms.GroupBox groupBoxTCP;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox textBoxPort;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox textBoxSlaveDelay;
        protected System.Windows.Forms.ComboBox comboBoxBaudRate;
        protected System.Windows.Forms.RadioButton radioButtonRTU;
        protected System.Windows.Forms.OpenFileDialog openFileDialog;
        protected System.Windows.Forms.SaveFileDialog saveFileDialog;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtIP;
        protected System.Windows.Forms.ComboBox comboBoxStopBits;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.ComboBox comboBoxDataBits;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.ComboBox comboBoxParity;
        protected System.Windows.Forms.Label labelParity;
        protected System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.GroupBox grpExchange;
        protected System.Windows.Forms.Button buttonPauseLog;

        private Button btnSignalStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart signalChart;
        private Timer timerCount;
        private Button btnSignalStop;
        private Button btnInit;
        private System.ComponentModel.IContainer components;
    }
}