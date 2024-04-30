using profilus_project;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

            chart.ChartAreas[0].AxisY.Maximum = 10; // ChartAreas[x] - настройка границ осей графика, где "x" номер коллекции.
            chart.ChartAreas[0].AxisY.Minimum = -5;
            


            chart.ChartAreas[0].AxisX.Maximum = 10; // Максимум оси X .
            chart.ChartAreas[0].AxisX.Minimum = -5; // Минимумом оси X.


            chart.ChartAreas[0].AxisX.Interval = 5; // Интервал сетки.


        }


    }
}
