using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace L2ARAutomationSerialPort
{
    public partial class FormSerialPortAutomation : Form
    {
        SerialPort serialPort;
        public FormSerialPortAutomation()
        {
            InitializeComponent();
        }
        private void sendSerialComand(string serialCmd)
        {
            textBoxResult.Text += "-> Write" + Environment.NewLine;
            try
            {
                textBoxResult.Text += serialCmd + Environment.NewLine;
                Application.DoEvents();
                serialPort = new SerialPort(comboBoxPorts.Text);
                serialPort.BaudRate = int.Parse(comboBoxBoundRate.Text);
                serialPort.DataBits = int.Parse(comboBoxDataBits.Text);
                serialPort.DtrEnable = false;
                serialPort.RtsEnable = false;
                serialPort.ReadTimeout = 10000;
                serialPort.WriteTimeout = 10000;
                serialPort.Parity = Parity.None;

                if (comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;
                if (comboBoxStopBits.Text == "Two")
                    serialPort.StopBits = StopBits.Two;

                serialPort.Open();
                serialPort.Write(serialCmd);


                if (serialPort.IsOpen)
                    serialPort.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }
        private void buttonOpenDrawer_Click(object sender, EventArgs e)
        {
            sendSerialComand("OPEN");
            buttonOpenDrawer.BackColor = Color.Green;
            buttonCloseDrawer.BackColor = Color.Red;
        }

        private void buttonCloseDrawer_Click(object sender, EventArgs e)
        {
            sendSerialComand("CLOSE");
            buttonCloseDrawer.BackColor = Color.Green;
            buttonOpenDrawer.BackColor = Color.Red;
        }

        private void buttonUpClip_Click(object sender, EventArgs e)
        {
            sendSerialComand("SIXON");
            buttonUpClip.BackColor = Color.Green;
            buttonDownClip.BackColor = Color.Red;
        }

        private void buttonDownClip_Click(object sender, EventArgs e)
        {
            sendSerialComand("SIXOFF");
            buttonDownClip.BackColor = Color.Green;
            buttonUpClip.BackColor = Color.Red;
        }

        private void buttonUSBIn_Click(object sender, EventArgs e)
        {
            sendSerialComand("FOURON");
            buttonUSBIn.BackColor = Color.Green;
            buttonUSBOut.BackColor = Color.Red;
        }

        private void buttonUSBOut_Click(object sender, EventArgs e)
        {
            sendSerialComand("FOUROFF");
            buttonUSBOut.BackColor = Color.Green;
            buttonUSBIn.BackColor = Color.Red;

        }

        private void buttonP3In_Click(object sender, EventArgs e)
        {
            sendSerialComand("FIVEON");
            buttonP3In.BackColor = Color.Green;
            buttonP3Out.BackColor = Color.Red;
        }

        private void buttonP3Out_Click(object sender, EventArgs e)
        {
            sendSerialComand("FIVEOFF");
            buttonP3Out.BackColor = Color.Green;
            buttonP3In.BackColor = Color.Red;
        }

        private void buttonAudio_Click(object sender, EventArgs e)
        {
            sendSerialComand("AUDIO");
            buttonAudio.BackColor = Color.Green;
            buttonRadio.BackColor = Color.Red;
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            sendSerialComand("RADIO");
            buttonRadio.BackColor = Color.Green;
            buttonAudio.BackColor = Color.Red;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendSerialComand(textBoxSend.Text);
            textBoxSend.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
        }    
        private void textBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendSerialComand(textBoxSend.Text);
            }
        }
    }
}