using L2AutomationPortCmd;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace L2ARAutomationSerialPort
{
    public partial class FormSerialPortAutomation : Form
    {
        private static FormSerialPortAutomation INSTANCE = null;
        SerialPortCmd sPC;

        public FormSerialPortAutomation()
        {
            InitializeComponent();
            INSTANCE = this;
            initializeSpc();
        }
        private void initializeSpc()
        {
            sPC = new SerialPortCmd();
        }
        public static FormSerialPortAutomation getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormSerialPortAutomation();

            return INSTANCE;
        }
        private void buttonOpenDrawer_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("OPEN");
            buttonOpenDrawer.BackColor = Color.Green;
            buttonCloseDrawer.BackColor = Color.Red;
        }
        private void buttonCloseDrawer_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("CLOSE");
            buttonCloseDrawer.BackColor = Color.Green;
            buttonOpenDrawer.BackColor = Color.Red;
        }
        private void buttonUpClip_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("SIXON");
            buttonUpClip.BackColor = Color.Green;
            buttonDownClip.BackColor = Color.Red;
        }
        private void buttonDownClip_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("SIXOFF");
            buttonDownClip.BackColor = Color.Green;
            buttonUpClip.BackColor = Color.Red;
        }
        private void buttonUSBIn_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("FOURON");
            buttonUSBIn.BackColor = Color.Green;
            buttonUSBOut.BackColor = Color.Red;
        }
        private void buttonUSBOut_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("FOUROFF");
            buttonUSBOut.BackColor = Color.Green;
            buttonUSBIn.BackColor = Color.Red;
        }
        private void buttonP3In_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("FIVEON");
            buttonP3In.BackColor = Color.Green;
            buttonP3Out.BackColor = Color.Red;
        }

        private void buttonP3Out_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("FIVEOFF");
            buttonP3Out.BackColor = Color.Green;
            buttonP3In.BackColor = Color.Red;
        }

        private void buttonAudio_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("AUDIO");
            buttonAudio.BackColor = Color.Green;
            buttonRadio.BackColor = Color.Red;
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand("RADIO");
            buttonRadio.BackColor = Color.Green;
            buttonAudio.BackColor = Color.Red;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sPC.sendSerialComand(textBoxSend.Text);
            textBoxSend.Text = "";
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
        }    
    }
}