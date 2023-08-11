using L2ARAutomationSerialPort;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace L2AutomationPortCmd
{
    class SerialPortCmd
    {
        SerialPort serialPort;
        FormSerialPortAutomation fSPA = FormSerialPortAutomation.getInstance();
        public void sendSerialComand(string serialCmd)
        {
            fSPA.textBoxResult.Text += "-> Write" + Environment.NewLine;
            try
            {
                fSPA.textBoxResult.Text += serialCmd + Environment.NewLine;
                Application.DoEvents();
                serialPort = new SerialPort(fSPA.comboBoxPorts.Text);
                serialPort.BaudRate = int.Parse(fSPA.comboBoxBoundRate.Text);
                serialPort.DataBits = int.Parse(fSPA.comboBoxDataBits.Text);
                serialPort.DtrEnable = false;
                serialPort.RtsEnable = false;
                serialPort.ReadTimeout = 10000;
                serialPort.WriteTimeout = 10000;
                serialPort.Parity = Parity.None;

                if (fSPA.comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;
                if (fSPA.comboBoxStopBits.Text == "Two")
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
    }
}
