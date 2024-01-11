using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace COMPortTerminal
{
    public partial class Form1 : Form
    {
        string dataOUT;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;


            btnsave.FlatAppearance.BorderSize = 2;
            btnsave.FlatAppearance.BorderColor = Color.Black;
            btnsave.Text = "Сохранить";
            groupBox1.Controls.Add(btnsave);
            btnsend.FlatAppearance.BorderSize = 2;
            btnsend.FlatAppearance.BorderColor = Color.Black;
            groupBox2.Controls.Add(btnsend);


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void cBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                progressBar1.BackColor = Color.Red;
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                serialPort1.Write(dataOUT);
                tBoxOut.Text += tBoxDataOut.Text;


            }
        }
    }
}
