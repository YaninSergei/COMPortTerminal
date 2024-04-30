using profilus_project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static profilus_project.WProtocolParser;


namespace COMPortTerminal
{
    public partial class Form2 : Form, IShowEntries
    {
        void IShowEntries.ShowEntries(List<Entry> prientries)
        {
            int counter = 0;
            

            for (int i = 0; i < prientries.Count; i++) 
            {
                if (prientries[i].key == "AB")
                {
                    chart.Series[0].Points.AddXY( counter++ , prientries[i].value);
                }
            }
                


        }


        Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Отображения окна в центре экрана в момент запуск программы.

        }


        private void Form2_Load(object sender, EventArgs e)
        {
           
        

        }


    }
}
