namespace COMPortTerminal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPriem = new System.Windows.Forms.Button();
            this.tBoxT = new System.Windows.Forms.TextBox();
            this.btnClearDataIn = new System.Windows.Forms.Button();
            this.btnGraphic = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.tBoxOut = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTerminal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rBtnHEX = new System.Windows.Forms.RadioButton();
            this.rBtnD = new System.Windows.Forms.RadioButton();
            this.rBtnASCII = new System.Windows.Forms.RadioButton();
            this.chBoxRtsEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.LabelConnectStatus = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonPriem);
            this.groupBox1.Controls.Add(this.tBoxT);
            this.groupBox1.Controls.Add(this.btnClearDataIn);
            this.groupBox1.Controls.Add(this.btnGraphic);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.tBoxDataIn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входящие данные";
            // 
            // buttonPriem
            // 
            this.buttonPriem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPriem.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonPriem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPriem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPriem.Location = new System.Drawing.Point(189, 529);
            this.buttonPriem.Name = "buttonPriem";
            this.buttonPriem.Size = new System.Drawing.Size(91, 33);
            this.buttonPriem.TabIndex = 16;
            this.buttonPriem.Text = "Показать";
            this.buttonPriem.UseVisualStyleBackColor = false;
            this.buttonPriem.Click += new System.EventHandler(this.buttonPriem_Click);
            // 
            // tBoxT
            // 
            this.tBoxT.Location = new System.Drawing.Point(122, 485);
            this.tBoxT.Name = "tBoxT";
            this.tBoxT.Size = new System.Drawing.Size(51, 26);
            this.tBoxT.TabIndex = 15;
            // 
            // btnClearDataIn
            // 
            this.btnClearDataIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearDataIn.BackColor = System.Drawing.Color.LightGray;
            this.btnClearDataIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearDataIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearDataIn.Location = new System.Drawing.Point(308, 483);
            this.btnClearDataIn.Name = "btnClearDataIn";
            this.btnClearDataIn.Size = new System.Drawing.Size(40, 32);
            this.btnClearDataIn.TabIndex = 14;
            this.btnClearDataIn.Text = "<---";
            this.btnClearDataIn.UseVisualStyleBackColor = false;
            this.btnClearDataIn.Click += new System.EventHandler(this.btnClearDataIn_Click);
            // 
            // btnGraphic
            // 
            this.btnGraphic.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGraphic.Location = new System.Drawing.Point(6, 482);
            this.btnGraphic.Name = "btnGraphic";
            this.btnGraphic.Size = new System.Drawing.Size(91, 33);
            this.btnGraphic.TabIndex = 13;
            this.btnGraphic.Text = "График";
            this.btnGraphic.UseVisualStyleBackColor = false;
            this.btnGraphic.Click += new System.EventHandler(this.btnGraphic_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsave.BackColor = System.Drawing.Color.PowderBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsave.Location = new System.Drawing.Point(6, 556);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 33);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxDataIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDataIn.Location = new System.Drawing.Point(6, 30);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIn.Size = new System.Drawing.Size(342, 447);
            this.tBoxDataIn.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnClearDataOut);
            this.groupBox2.Controls.Add(this.tBoxDataOut);
            this.groupBox2.Controls.Add(this.btnsend);
            this.groupBox2.Controls.Add(this.tBoxOut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(640, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 596);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходящие данные";
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearDataOut.BackColor = System.Drawing.Color.LightGray;
            this.btnClearDataOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearDataOut.Location = new System.Drawing.Point(307, 484);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(40, 32);
            this.btnClearDataOut.TabIndex = 4;
            this.btnClearDataOut.Text = "<---";
            this.btnClearDataOut.UseVisualStyleBackColor = false;
            this.btnClearDataOut.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxDataOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDataOut.Location = new System.Drawing.Point(6, 364);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataOut.Size = new System.Drawing.Size(342, 108);
            this.tBoxDataOut.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsend.BackColor = System.Drawing.Color.PowderBlue;
            this.btnsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsend.Location = new System.Drawing.Point(210, 484);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(91, 33);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "Отправить";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // tBoxOut
            // 
            this.tBoxOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxOut.Location = new System.Drawing.Point(5, 30);
            this.tBoxOut.Multiline = true;
            this.tBoxOut.Name = "tBoxOut";
            this.tBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxOut.Size = new System.Drawing.Size(342, 328);
            this.tBoxOut.TabIndex = 0;
            this.tBoxOut.TextChanged += new System.EventHandler(this.tBoxOut_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnTerminal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rBtnHEX);
            this.groupBox3.Controls.Add(this.rBtnD);
            this.groupBox3.Controls.Add(this.rBtnASCII);
            this.groupBox3.Controls.Add(this.chBoxRtsEnable);
            this.groupBox3.Controls.Add(this.chBoxDtrEnable);
            this.groupBox3.Controls.Add(this.LabelConnectStatus);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.cBoxParityBits);
            this.groupBox3.Controls.Add(this.cBoxStopBits);
            this.groupBox3.Controls.Add(this.cBoxDataBits);
            this.groupBox3.Controls.Add(this.cBoxBaudRate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cBoxComPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(372, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 579);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры";
            // 
            // btnTerminal
            // 
            this.btnTerminal.Location = new System.Drawing.Point(86, 431);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Size = new System.Drawing.Size(115, 29);
            this.btnTerminal.TabIndex = 25;
            this.btnTerminal.Text = "TERMINAL";
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(55, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Система счисления";
            // 
            // rBtnHEX
            // 
            this.rBtnHEX.AutoSize = true;
            this.rBtnHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rBtnHEX.Location = new System.Drawing.Point(196, 294);
            this.rBtnHEX.Name = "rBtnHEX";
            this.rBtnHEX.Size = new System.Drawing.Size(57, 22);
            this.rBtnHEX.TabIndex = 23;
            this.rBtnHEX.Text = "HEX";
            this.rBtnHEX.UseVisualStyleBackColor = true;
            // 
            // rBtnD
            // 
            this.rBtnD.AutoSize = true;
            this.rBtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rBtnD.Location = new System.Drawing.Point(106, 294);
            this.rBtnD.Name = "rBtnD";
            this.rBtnD.Size = new System.Drawing.Size(50, 22);
            this.rBtnD.TabIndex = 21;
            this.rBtnD.Text = "BIN";
            this.rBtnD.UseVisualStyleBackColor = true;
            // 
            // rBtnASCII
            // 
            this.rBtnASCII.AutoSize = true;
            this.rBtnASCII.Checked = true;
            this.rBtnASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rBtnASCII.Location = new System.Drawing.Point(6, 294);
            this.rBtnASCII.Name = "rBtnASCII";
            this.rBtnASCII.Size = new System.Drawing.Size(62, 22);
            this.rBtnASCII.TabIndex = 20;
            this.rBtnASCII.TabStop = true;
            this.rBtnASCII.Text = "ASCII";
            this.rBtnASCII.UseVisualStyleBackColor = true;
            // 
            // chBoxRtsEnable
            // 
            this.chBoxRtsEnable.AutoSize = true;
            this.chBoxRtsEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxRtsEnable.Location = new System.Drawing.Point(143, 228);
            this.chBoxRtsEnable.Name = "chBoxRtsEnable";
            this.chBoxRtsEnable.Size = new System.Drawing.Size(110, 20);
            this.chBoxRtsEnable.TabIndex = 15;
            this.chBoxRtsEnable.Text = "RTS ENABLE";
            this.chBoxRtsEnable.UseVisualStyleBackColor = true;
            this.chBoxRtsEnable.CheckedChanged += new System.EventHandler(this.chBoxRtsEnable_CheckedChanged);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxDtrEnable.Location = new System.Drawing.Point(10, 228);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(111, 20);
            this.chBoxDtrEnable.TabIndex = 14;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // LabelConnectStatus
            // 
            this.LabelConnectStatus.BackColor = System.Drawing.Color.OldLace;
            this.LabelConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelConnectStatus.Location = new System.Drawing.Point(6, 486);
            this.LabelConnectStatus.Name = "LabelConnectStatus";
            this.LabelConnectStatus.Size = new System.Drawing.Size(250, 23);
            this.LabelConnectStatus.TabIndex = 13;
            this.LabelConnectStatus.Text = "Статус: Неподключено.";
            this.LabelConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(138, 541);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 27);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 541);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 27);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 512);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(106, 184);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(147, 28);
            this.cBoxParityBits.TabIndex = 9;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(106, 149);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(147, 28);
            this.cBoxStopBits.TabIndex = 8;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(106, 114);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(147, 28);
            this.cBoxDataBits.TabIndex = 7;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(106, 79);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(147, 28);
            this.cBoxBaudRate.TabIndex = 6;
            this.cBoxBaudRate.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(106, 44);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(147, 28);
            this.cBoxComPort.TabIndex = 0;
            this.cBoxComPort.SelectedIndexChanged += new System.EventHandler(this.cBoxComPort_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1005, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPort Terminal";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox tBoxOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LabelConnectStatus;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.CheckBox chBoxRtsEnable;
        private System.Windows.Forms.Button btnClearDataIn;
        private System.Windows.Forms.RadioButton rBtnHEX;
        private System.Windows.Forms.RadioButton rBtnD;
        private System.Windows.Forms.RadioButton rBtnASCII;
        private System.Windows.Forms.TextBox tBoxT;
        private System.Windows.Forms.Label label6;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tBoxDataIn;
        public System.Windows.Forms.Button btnGraphic;
        private System.Windows.Forms.Button btnTerminal;
        private System.Windows.Forms.Button buttonPriem;
    }
}

