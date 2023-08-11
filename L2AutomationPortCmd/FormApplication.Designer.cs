
namespace L2ARAutomationSerialPort
{
    partial class FormSerialPortAutomation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialPortAutomation));
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBoundRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.buttonOpenDrawer = new System.Windows.Forms.Button();
            this.buttonCloseDrawer = new System.Windows.Forms.Button();
            this.buttonUpClip = new System.Windows.Forms.Button();
            this.buttonDownClip = new System.Windows.Forms.Button();
            this.buttonUSBIn = new System.Windows.Forms.Button();
            this.buttonUSBOut = new System.Windows.Forms.Button();
            this.buttonP3In = new System.Windows.Forms.Button();
            this.buttonP3Out = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAudio = new System.Windows.Forms.Button();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(49, 26);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Portas:";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(25, 60);
            this.labelBaudRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(64, 13);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "Baud Rate: ";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(33, 97);
            this.labelDataBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(53, 13);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(33, 133);
            this.labelStopBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(55, 13);
            this.labelStopBits.TabIndex = 3;
            this.labelStopBits.Text = "Stop Bits: ";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(112, 26);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(82, 21);
            this.comboBoxPorts.TabIndex = 6;
            // 
            // comboBoxBoundRate
            // 
            this.comboBoxBoundRate.FormattingEnabled = true;
            this.comboBoxBoundRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBoundRate.Location = new System.Drawing.Point(112, 58);
            this.comboBoxBoundRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBoundRate.Name = "comboBoxBoundRate";
            this.comboBoxBoundRate.Size = new System.Drawing.Size(82, 21);
            this.comboBoxBoundRate.TabIndex = 7;
            this.comboBoxBoundRate.Text = "9600";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(112, 97);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(82, 21);
            this.comboBoxDataBits.TabIndex = 8;
            this.comboBoxDataBits.Text = "8";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(112, 133);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(82, 21);
            this.comboBoxStopBits.TabIndex = 9;
            this.comboBoxStopBits.Text = "One";
            // 
            // buttonOpenDrawer
            // 
            this.buttonOpenDrawer.Location = new System.Drawing.Point(283, 21);
            this.buttonOpenDrawer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenDrawer.Name = "buttonOpenDrawer";
            this.buttonOpenDrawer.Size = new System.Drawing.Size(71, 33);
            this.buttonOpenDrawer.TabIndex = 12;
            this.buttonOpenDrawer.Text = "Open";
            this.buttonOpenDrawer.UseVisualStyleBackColor = true;
            this.buttonOpenDrawer.Click += new System.EventHandler(this.buttonOpenDrawer_Click);
            // 
            // buttonCloseDrawer
            // 
            this.buttonCloseDrawer.Location = new System.Drawing.Point(377, 21);
            this.buttonCloseDrawer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCloseDrawer.Name = "buttonCloseDrawer";
            this.buttonCloseDrawer.Size = new System.Drawing.Size(70, 33);
            this.buttonCloseDrawer.TabIndex = 13;
            this.buttonCloseDrawer.Text = "Close";
            this.buttonCloseDrawer.UseVisualStyleBackColor = true;
            this.buttonCloseDrawer.Click += new System.EventHandler(this.buttonCloseDrawer_Click);
            // 
            // buttonUpClip
            // 
            this.buttonUpClip.Location = new System.Drawing.Point(283, 58);
            this.buttonUpClip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpClip.Name = "buttonUpClip";
            this.buttonUpClip.Size = new System.Drawing.Size(71, 32);
            this.buttonUpClip.TabIndex = 14;
            this.buttonUpClip.Text = "Up Clip";
            this.buttonUpClip.UseVisualStyleBackColor = true;
            this.buttonUpClip.Click += new System.EventHandler(this.buttonUpClip_Click);
            // 
            // buttonDownClip
            // 
            this.buttonDownClip.Location = new System.Drawing.Point(377, 58);
            this.buttonDownClip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDownClip.Name = "buttonDownClip";
            this.buttonDownClip.Size = new System.Drawing.Size(70, 32);
            this.buttonDownClip.TabIndex = 15;
            this.buttonDownClip.Text = "Down Clip";
            this.buttonDownClip.UseVisualStyleBackColor = true;
            this.buttonDownClip.Click += new System.EventHandler(this.buttonDownClip_Click);
            // 
            // buttonUSBIn
            // 
            this.buttonUSBIn.Location = new System.Drawing.Point(283, 96);
            this.buttonUSBIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUSBIn.Name = "buttonUSBIn";
            this.buttonUSBIn.Size = new System.Drawing.Size(71, 31);
            this.buttonUSBIn.TabIndex = 16;
            this.buttonUSBIn.Text = "USB IN";
            this.buttonUSBIn.UseVisualStyleBackColor = true;
            this.buttonUSBIn.Click += new System.EventHandler(this.buttonUSBIn_Click);
            // 
            // buttonUSBOut
            // 
            this.buttonUSBOut.Location = new System.Drawing.Point(377, 97);
            this.buttonUSBOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUSBOut.Name = "buttonUSBOut";
            this.buttonUSBOut.Size = new System.Drawing.Size(70, 34);
            this.buttonUSBOut.TabIndex = 17;
            this.buttonUSBOut.Text = "USB OUT";
            this.buttonUSBOut.UseVisualStyleBackColor = true;
            this.buttonUSBOut.Click += new System.EventHandler(this.buttonUSBOut_Click);
            // 
            // buttonP3In
            // 
            this.buttonP3In.Location = new System.Drawing.Point(283, 135);
            this.buttonP3In.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonP3In.Name = "buttonP3In";
            this.buttonP3In.Size = new System.Drawing.Size(71, 34);
            this.buttonP3In.TabIndex = 18;
            this.buttonP3In.Text = "P3 IN";
            this.buttonP3In.UseVisualStyleBackColor = true;
            this.buttonP3In.Click += new System.EventHandler(this.buttonP3In_Click);
            // 
            // buttonP3Out
            // 
            this.buttonP3Out.Location = new System.Drawing.Point(377, 135);
            this.buttonP3Out.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonP3Out.Name = "buttonP3Out";
            this.buttonP3Out.Size = new System.Drawing.Size(70, 34);
            this.buttonP3Out.TabIndex = 19;
            this.buttonP3Out.Text = "P3 OUT";
            this.buttonP3Out.UseVisualStyleBackColor = true;
            this.buttonP3Out.Click += new System.EventHandler(this.buttonP3Out_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(8, 207);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(615, 176);
            this.textBoxResult.TabIndex = 22;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(557, 183);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(65, 20);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAudio
            // 
            this.buttonAudio.Location = new System.Drawing.Point(464, 21);
            this.buttonAudio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(70, 33);
            this.buttonAudio.TabIndex = 25;
            this.buttonAudio.Text = "AUDIO";
            this.buttonAudio.UseVisualStyleBackColor = true;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(552, 22);
            this.buttonRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(69, 31);
            this.buttonRadio.TabIndex = 26;
            this.buttonRadio.Text = "RADIO";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(8, 169);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(71, 34);
            this.buttonSend.TabIndex = 27;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(83, 186);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(452, 20);
            this.textBoxSend.TabIndex = 28;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(203, 22);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 26);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormSerialPortAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 402);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonRadio);
            this.Controls.Add(this.buttonAudio);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonP3Out);
            this.Controls.Add(this.buttonP3In);
            this.Controls.Add(this.buttonUSBOut);
            this.Controls.Add(this.buttonUSBIn);
            this.Controls.Add(this.buttonDownClip);
            this.Controls.Add(this.buttonUpClip);
            this.Controls.Add(this.buttonCloseDrawer);
            this.Controls.Add(this.buttonOpenDrawer);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.comboBoxBoundRate);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSerialPortAutomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L2AR Port Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        public System.Windows.Forms.ComboBox comboBoxPorts;
        public System.Windows.Forms.ComboBox comboBoxBoundRate;
        public System.Windows.Forms.ComboBox comboBoxDataBits;
        public System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Button buttonOpenDrawer;
        private System.Windows.Forms.Button buttonCloseDrawer;
        private System.Windows.Forms.Button buttonUpClip;
        private System.Windows.Forms.Button buttonDownClip;
        private System.Windows.Forms.Button buttonUSBIn;
        private System.Windows.Forms.Button buttonUSBOut;
        private System.Windows.Forms.Button buttonP3In;
        private System.Windows.Forms.Button buttonP3Out;
        public System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAudio;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSearch;
    }
}