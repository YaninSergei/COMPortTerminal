using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COMPortTerminal
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Отображения окна в центре экрана в момент запуск программы.

        }
        private int _countSecond = 0; // Переменная времени, которая отвечает за переодичность обновления графика.
        int limitheight = 100;
        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Enabled = true; // При запуске программы запустим таймер.

            chart.ChartAreas[0].AxisY.Maximum = 120; // ChartAreas[x] - настройка границ осей графика, где "x" номер коллекции.
            chart.ChartAreas[0].AxisY.Minimum = -30;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss"; // Задаем формат оси который будет выводиться в графике: Минуты, секунды.
            chart.Series[0].XValueType = ChartValueType.DateTime; // Задаем формат в котором будет отображаться информация: Время.

            chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Максимум оси X задаем текущее время.
            chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Минимумом оси X задаем текущее время.

            chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds; // Настройка интервала времени.
            chart.ChartAreas[0].AxisX.Interval = 5; // Интервал сетки.
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // отображение введенного числа в поле numeric.
            DateTime timNow = DateTime.Now; // текущее время.
            tBoxDataPort.Text = form1.T.ToString(); // Переменная принимающая знаечение из COMPORT 
            string DataPort = tBoxDataPort.Text;

            Random random = new Random(DateTime.Now.Millisecond); //Функция рандома.
            double randomHeigth = random.Next(-5, 100); //Переменна типа double, значение которой в дальнейшем будем подставлять в кривую коллекции [1].
            tBoxRandom.Text = randomHeigth.ToString();

            chart.Series[0].Points.AddXY(timNow, DataPort); // Функции chart (графика) воспроизводить по точкам кривую коллекции .Series [0] и [1]. 
            chart.Series[1].Points.AddXY(timNow, randomHeigth);
            // На данном этапе по прошествию минуты или достижению _countSecond = 60 (Переменная временного интервала) - на графике остонавливается отображение кривой!

            // Решение данной проблемы:
            _countSecond++; // Каждый раз к переменной времени _countSecond, мы будем прибавлять одну секунду.
            // Теперь c помощью условного оператора if, создадим условие: (при достижении _countSecond == 60) ->, переменная _countSecond обнуляется и координатная ось рисуется заново!

            if (_countSecond == 60)
            {
                _countSecond = 0;
                chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Максимум оси X задаем текущее время.
                chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Минимумом оси X задаем текущее время.

                chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds; // Настройка интервала времени.
                chart.ChartAreas[0].AxisX.Interval = 5; // Интервал сетки.
            }

        }
       
    }
}
