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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

            string[] port = SerialPort.GetPortNames();

            btnsave.FlatAppearance.BorderSize = 2;
            btnsave.FlatAppearance.BorderColor = Color.Black;
            btnsave.Text = "Сохранить";
            groupBox1.Controls.Add(btnsave);
            btnsend.FlatAppearance.BorderSize = 2;
            btnsend.FlatAppearance.BorderColor = Color.Black;
            groupBox2.Controls.Add(btnsend);


        }
    }
}
