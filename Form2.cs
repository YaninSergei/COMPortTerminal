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
        string DataEnd;
        public string SaveDataInPeremenaya {  get; set; }

        public Form2()
        {
            InitializeComponent();
           


        }
        public void PostroenieGrafika()
        {
            Graphics graphics = pictureBox1.CreateGraphics(); // Класс Graphics | экземпляр класса(переменная) graphics | = | присваиваем значения picturebox1.CreateGraphics(), для возможности сразу выводить изображение в picturebox1.
            Pen pencil = new Pen(Color.Black, 3f); //Класс Pen | экземпляр класса(переменная) pencil | = | Инициализируем экземпляр класса Pen, указывая значения цвета и толщины линии new Pen(Color.Black, 3f).

            Point[] points = new Point[1000]; // C помощью класса Point создаём массив точек | экземпляр класса(переменная) points | = | Инициализируем экземпляр класса Point, указывая количество точек- 1000.
            
            tBoxX.Text = SaveDataInPeremenaya;

            int ZnamenatelSinusa;
            try
            {
                ZnamenatelSinusa = Convert.ToInt32(SaveDataInPeremenaya);
            }
            catch
            {
                MessageBox.Show("не корректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < points.Length; i++) // начинаем заполнять массив. 
            {
                points[i] = new Point(i, (int)(Math.Sin((double)i / ZnamenatelSinusa) * 100 + 150)); // задаём функцию каждой точке.      
            }
            graphics.Clear(Color.White); 
            graphics.DrawLines(pencil, points);
        }

        public void btnDraw_Click(object sender, EventArgs e)
        {
            PostroenieGrafika();
        }
    }
}
