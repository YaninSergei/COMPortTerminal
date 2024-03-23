using System;
using System.Drawing;
using System.IO.Ports; //Библиотека по портам.
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace COMPortTerminal
{
    public partial class Form1 : Form
    {
        string dataOUT; // Переменная выходных данных
        string dataIN;  // Переменная входных данных
        int SistemaSchisleniya; // Переменная для системы счисления.
        public string T; // Переменная которая вычленяет последний символ из dataIN
        
        

        public Form1()
        {           // Конструктор класса Form 1:
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; // предотвращает множетсвенный доступ к элементу из нескольких потоков. Отключает проверку конкурентного доступа у разных поток. Мы попытались работать с свойствами обьекта не из потока создателя.
            

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LabelConnectStatus.Text = "Статус: Ошибка подключения.";
                progressBar1.Value = 0;
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
                string dataOUT = tBoxDataOut.Text;
                serialPort1.Write(dataOUT);
                tBoxOut.Text += $" \n + {dataOUT}";
                tBoxDataOut.Clear();
            }
            else
                tBoxOut.Text = "<COMPort не выбран>";
        }


        private void cBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*  if (tBoxDataOut.Text.Length > 0)
              {
                  tBoxDataOut.Text = tBoxDataOut.Text.Substring(0, tBoxDataOut.Text.Length - 1);
             }*/
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
            if (chBoxDtrEnable.Checked)
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
        
        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting(); //+ Environment.NewLine;
            this.Invoke(new EventHandler(ShowData));
            T = dataIN.Substring(dataIN.Length - 1);  // Метод Substring() позволяет Извлекает подстроку из этого экземпляра. Подстрока начинается с указанной позиции символа и продолжается до конца строки.
            tBoxT.Text = T;
        }

        private void ShowData(object sender, EventArgs e)
        {
            //tBoxDataIn.Text += dataIN;

            // Ниже реализованна система счисления ASCII, BIN, HEX
            if (rBtnD.Checked == true)
            {
                tBoxDataIn.Text += Convert.ToString(Convert.ToInt32(dataIN), 2);
            }
            
            else if (rBtnHEX.Checked == true)
            {
                tBoxDataIn.Text += Convert.ToString(Convert.ToInt32(dataIN), 16);
            }
            else
            {
                tBoxDataIn.Text += dataIN;
            }
        }

        private void tBoxOut_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnGraphic_Click(object sender, EventArgs e) // обработчик событий по нажатию на клавишу "График'.
        {
            if (dataIN != null && dataIN.Length > 0) //При нажатии на кнопку "График" выполняется условие наличия каких либо данных в окне приема.
            {
                new Form2(this).Show(); // Далее открывается форма для отображения данных в виде кривой, куда мы переносим свои права как владелец.
            }
            else
            {
                MessageBox.Show("Данных нет, не из чего строить график!", "", MessageBoxButtons.OK);
                return;
            }
        }
        
    }
}
