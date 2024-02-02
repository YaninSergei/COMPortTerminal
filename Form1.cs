using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //Библиотека по портам.
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.ConstrainedExecution;

namespace COMPortTerminal
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        
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
            string[] ports = SerialPort.GetPortNames(); // Получаем список имен последовательных портов.
            cBoxComPort.Items.AddRange(ports); // отображение всех портов в выподающем списке cBoxComPort
            // Настройки поумолчанию:
            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false; 
            chBoxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;
            chBoxAddToOldData.Checked = false;

        }

        private void btnConnect_Click(object sender, EventArgs e) // Обработчик событий при нажатии конпки "Connect".
            // C Помощью конструкции (try...catch..finally) обрабатываем исключения для перехвата ошибок. Вначале выполняются все инструкции в блоке try.
            //Если в этом блоке не возникло исключений, то после его выполнения начинает выполняться блок finally. И затем конструкция try..catch..finally завершает свою работу.
        {
            try 
            {   // Ниже задаём параметры Порта: PortName -Имя последовательного порта; BaudRate -Скорость передачи в бодах; DataBits - Количество битов, чтобыпредставлять один символ данных;
                // StopBits -Шаблон битов, который указывает на конец символа; Parity -Четность; 
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text); // Convert.'тип данных'(конвертируемый объект) - Конвертация переменных в другой тип данных.
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text); 
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text); //Enum.Parse: преобразование строки в перечисление. Смотреть описание - нихрена не понятно.
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text); 
                serialPort1.Open();
                progressBar1.Value = 100;
                LabelConnectStatus.Text = "Статус: Подключено.";
                btnConnect.Enabled = false;
                btnStop.Enabled = true;


                /*if (serialPort1.IsOpen)
                {
                    //MessageBox.Show("Подключение выполненно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    LabelConnectStatus.BackColor = Color.Lime;
                    LabelConnectStatus.Text = "Статус: Подключено.";
                }*/
            }
            // Если в блоке try возникает исключение, то порядок выполнения останавливается, и среда CLR начинает искать блок catch, который может обработать данное исключение.
            // Если нужный блок catch найден, то он выполняется, и после его завершения выполняется блок finally.
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LabelConnectStatus.Text = "Статус: Неподключено.";
                progressBar1.BackColor = Color.Red;
                btnConnect.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e) // Обработчик событий при нажатии конпки "Stop".
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                LabelConnectStatus.BackColor = Color.White;
                LabelConnectStatus.Text = "Статус: Неподключено.";
                btnConnect.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnsend_Click(object sender, EventArgs e) //Обработчик событий при нажатии конпки "Отправить"
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                serialPort1.Write(dataOUT);
            }

        }


        private void cBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text.Length > 0)
            {
                tBoxDataOut.Text = tBoxDataOut.Text.Substring(0, tBoxDataOut.Text.Length - 1);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }
        private void btnClearDataIn_Click(object sender, EventArgs e)
        {

            if (tBoxDataIn.Text != "")
            {
                tBoxDataIn.Text = "";
            }

        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e) //обработчик события по нажатию чек бокса DTR сигнала
        {
            if(chBoxDtrEnable.Checked) 
            {
                serialPort1.DtrEnable = true;
            }
            else { serialPort1.DtrEnable = false; }
        }

        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e) //обработчик события по нажатию чек бокса Rts сигнала
        {
            if (chBoxRtsEnable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else { serialPort1.RtsEnable = false; }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            if (chBoxAddToOldData.Checked)
            {
                tBoxDataIn.Text += dataIN;
            }
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
