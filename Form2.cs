using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPortTerminal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics(); // Класс Graphics | экземпляр класса(переменная) graphics | = | присваиваем значения picturebox1.CreateGraphics(), для возможности сразу выводить изображение в picturebox1.
            Pen pencil = new Pen(Color.Black, 3f); //Класс Pen | экземпляр класса(переменная) pencil | = | Инициализируем экземпляр класса Pen, указывая значения цвета и толщины линии new Pen(Color.Black, 3f).

            Point[] points = new Point[1000]; // C помощью класса Point создаём массив точек | экземпляр класса(переменная) points | = | Инициализируем экземпляр класса Point, указывая количество точек- 1000.

            for (int i = 0; i< points.Length; i++) // начинаем заполнять массив. 
            {
                points[i] = new Point(i,(int)(Math.Sin((double)i/10)*100+150)); // задаём функцию каждой точке.
            }
            graphics.DrawLines(pencil, points); 
        
        }
    }
}
