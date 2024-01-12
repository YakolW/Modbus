
using System.IO.Ports;

namespace WindowsFormsApp1
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
            this.BTEnd = new System.Windows.Forms.Button();
            this.CBSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSoob = new System.Windows.Forms.TextBox();
            this.BTOpenport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTPEREDdata = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBSpeed = new System.Windows.Forms.ComboBox();
            this.CBBTDAT = new System.Windows.Forms.ComboBox();
            this.CBSTOPbt = new System.Windows.Forms.ComboBox();
            this.CBOUT = new System.Windows.Forms.ComboBox();
            this.port1 = new System.IO.Ports.SerialPort(this.components);
            this.TBDiol = new System.Windows.Forms.TextBox();
            this.TIMEROPENport = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.BTCleanDIOL = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BTASCII = new System.Windows.Forms.Button();
            this.RBhex = new System.Windows.Forms.RadioButton();
            this.RBbin = new System.Windows.Forms.RadioButton();
            this.RBdec = new System.Windows.Forms.RadioButton();
            this.RBchar = new System.Windows.Forms.RadioButton();
            this.BTStop = new System.Windows.Forms.Button();
            this.GBPORT = new System.Windows.Forms.GroupBox();
            this.GBDIOLOG = new System.Windows.Forms.GroupBox();
            this.GBSOOB = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TBCRC16 = new System.Windows.Forms.TextBox();
            this.TBFIRSTreg = new System.Windows.Forms.TextBox();
            this.BTZapros = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.GBzapros = new System.Windows.Forms.GroupBox();
            this.labsis4 = new System.Windows.Forms.Label();
            this.BTDOBcrc = new System.Windows.Forms.Button();
            this.labsis3 = new System.Windows.Forms.Label();
            this.TBADRES = new System.Windows.Forms.TextBox();
            this.labsis2 = new System.Windows.Forms.Label();
            this.TBKOLreg = new System.Windows.Forms.TextBox();
            this.labsis1 = new System.Windows.Forms.Label();
            this.TBFUNK = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TBdecZap = new System.Windows.Forms.TextBox();
            this.GBzapic = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TBhexZap = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.RBHLzap = new System.Windows.Forms.RadioButton();
            this.TBhextotxZap = new System.Windows.Forms.TextBox();
            this.RBLLzap = new System.Windows.Forms.RadioButton();
            this.RBHHzap = new System.Windows.Forms.RadioButton();
            this.RBLHzap = new System.Windows.Forms.RadioButton();
            this.GBchten = new System.Windows.Forms.GroupBox();
            this.RBLLchen = new System.Windows.Forms.RadioButton();
            this.RBLHchen = new System.Windows.Forms.RadioButton();
            this.RBHLchen = new System.Windows.Forms.RadioButton();
            this.RBHHchen = new System.Windows.Forms.RadioButton();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TBdecChten = new System.Windows.Forms.TextBox();
            this.TBhexChten = new System.Windows.Forms.TextBox();
            this.TBbitpac = new System.Windows.Forms.TextBox();
            this.GBBitPacet = new System.Windows.Forms.GroupBox();
            this.GBOhib = new System.Windows.Forms.GroupBox();
            this.TBochfunk = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TBochkolreg = new System.Windows.Forms.TextBox();
            this.TBochreg = new System.Windows.Forms.TextBox();
            this.TBochlong = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.TBochcrc = new System.Windows.Forms.TextBox();
            this.TCPervStr = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.BTAVotpr = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.BTCleanAV = new System.Windows.Forms.Button();
            this.GBDiolAV = new System.Windows.Forms.GroupBox();
            this.TBDIOLAV = new System.Windows.Forms.TextBox();
            this.AVtime32 = new System.Windows.Forms.Label();
            this.AVtime31 = new System.Windows.Forms.Label();
            this.AVtime30 = new System.Windows.Forms.Label();
            this.AVtime29 = new System.Windows.Forms.Label();
            this.AVtime28 = new System.Windows.Forms.Label();
            this.AVtime27 = new System.Windows.Forms.Label();
            this.AVtime26 = new System.Windows.Forms.Label();
            this.AVtime25 = new System.Windows.Forms.Label();
            this.AVtime24 = new System.Windows.Forms.Label();
            this.AVtime23 = new System.Windows.Forms.Label();
            this.AVtime22 = new System.Windows.Forms.Label();
            this.AVtime21 = new System.Windows.Forms.Label();
            this.AVtime20 = new System.Windows.Forms.Label();
            this.AVtime19 = new System.Windows.Forms.Label();
            this.AVtime18 = new System.Windows.Forms.Label();
            this.AVtime17 = new System.Windows.Forms.Label();
            this.AVtime16 = new System.Windows.Forms.Label();
            this.AVtime15 = new System.Windows.Forms.Label();
            this.AVtime14 = new System.Windows.Forms.Label();
            this.AVtime13 = new System.Windows.Forms.Label();
            this.AVtime12 = new System.Windows.Forms.Label();
            this.AVtime11 = new System.Windows.Forms.Label();
            this.AVtime10 = new System.Windows.Forms.Label();
            this.AVtime9 = new System.Windows.Forms.Label();
            this.AVtime8 = new System.Windows.Forms.Label();
            this.AVtime7 = new System.Windows.Forms.Label();
            this.AVtime6 = new System.Windows.Forms.Label();
            this.AVtime5 = new System.Windows.Forms.Label();
            this.AVtime4 = new System.Windows.Forms.Label();
            this.AVtime3 = new System.Windows.Forms.Label();
            this.AVtime2 = new System.Windows.Forms.Label();
            this.lab32 = new System.Windows.Forms.Label();
            this.lab31 = new System.Windows.Forms.Label();
            this.lab30 = new System.Windows.Forms.Label();
            this.lab29 = new System.Windows.Forms.Label();
            this.lab28 = new System.Windows.Forms.Label();
            this.lab27 = new System.Windows.Forms.Label();
            this.lab26 = new System.Windows.Forms.Label();
            this.lab25 = new System.Windows.Forms.Label();
            this.lab24 = new System.Windows.Forms.Label();
            this.lab23 = new System.Windows.Forms.Label();
            this.lab22 = new System.Windows.Forms.Label();
            this.lab21 = new System.Windows.Forms.Label();
            this.lab20 = new System.Windows.Forms.Label();
            this.lab19 = new System.Windows.Forms.Label();
            this.lab18 = new System.Windows.Forms.Label();
            this.lab17 = new System.Windows.Forms.Label();
            this.lab16 = new System.Windows.Forms.Label();
            this.lab15 = new System.Windows.Forms.Label();
            this.lab14 = new System.Windows.Forms.Label();
            this.lab13 = new System.Windows.Forms.Label();
            this.lab12 = new System.Windows.Forms.Label();
            this.lab11 = new System.Windows.Forms.Label();
            this.lab10 = new System.Windows.Forms.Label();
            this.lab9 = new System.Windows.Forms.Label();
            this.lab8 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.DECbox32 = new System.Windows.Forms.TextBox();
            this.Prinbox32 = new System.Windows.Forms.TextBox();
            this.DECbox31 = new System.Windows.Forms.TextBox();
            this.Prinbox31 = new System.Windows.Forms.TextBox();
            this.DECbox30 = new System.Windows.Forms.TextBox();
            this.Prinbox30 = new System.Windows.Forms.TextBox();
            this.DECbox29 = new System.Windows.Forms.TextBox();
            this.Prinbox29 = new System.Windows.Forms.TextBox();
            this.DECbox28 = new System.Windows.Forms.TextBox();
            this.Prinbox28 = new System.Windows.Forms.TextBox();
            this.DECbox27 = new System.Windows.Forms.TextBox();
            this.Prinbox27 = new System.Windows.Forms.TextBox();
            this.DECbox26 = new System.Windows.Forms.TextBox();
            this.Prinbox26 = new System.Windows.Forms.TextBox();
            this.DECbox25 = new System.Windows.Forms.TextBox();
            this.Prinbox25 = new System.Windows.Forms.TextBox();
            this.DECbox24 = new System.Windows.Forms.TextBox();
            this.Prinbox24 = new System.Windows.Forms.TextBox();
            this.DECbox23 = new System.Windows.Forms.TextBox();
            this.Prinbox23 = new System.Windows.Forms.TextBox();
            this.DECbox22 = new System.Windows.Forms.TextBox();
            this.Prinbox22 = new System.Windows.Forms.TextBox();
            this.DECbox21 = new System.Windows.Forms.TextBox();
            this.Prinbox21 = new System.Windows.Forms.TextBox();
            this.DECbox20 = new System.Windows.Forms.TextBox();
            this.Prinbox20 = new System.Windows.Forms.TextBox();
            this.DECbox19 = new System.Windows.Forms.TextBox();
            this.Prinbox19 = new System.Windows.Forms.TextBox();
            this.DECbox18 = new System.Windows.Forms.TextBox();
            this.Prinbox18 = new System.Windows.Forms.TextBox();
            this.DECbox17 = new System.Windows.Forms.TextBox();
            this.Prinbox17 = new System.Windows.Forms.TextBox();
            this.DECbox16 = new System.Windows.Forms.TextBox();
            this.Prinbox16 = new System.Windows.Forms.TextBox();
            this.DECbox15 = new System.Windows.Forms.TextBox();
            this.Prinbox15 = new System.Windows.Forms.TextBox();
            this.DECbox14 = new System.Windows.Forms.TextBox();
            this.Prinbox14 = new System.Windows.Forms.TextBox();
            this.DECbox13 = new System.Windows.Forms.TextBox();
            this.Prinbox13 = new System.Windows.Forms.TextBox();
            this.DECbox12 = new System.Windows.Forms.TextBox();
            this.Prinbox12 = new System.Windows.Forms.TextBox();
            this.DECbox11 = new System.Windows.Forms.TextBox();
            this.Prinbox11 = new System.Windows.Forms.TextBox();
            this.DECbox10 = new System.Windows.Forms.TextBox();
            this.Prinbox10 = new System.Windows.Forms.TextBox();
            this.DECbox9 = new System.Windows.Forms.TextBox();
            this.Prinbox9 = new System.Windows.Forms.TextBox();
            this.DECbox8 = new System.Windows.Forms.TextBox();
            this.Prinbox8 = new System.Windows.Forms.TextBox();
            this.DECbox7 = new System.Windows.Forms.TextBox();
            this.Prinbox7 = new System.Windows.Forms.TextBox();
            this.DECbox6 = new System.Windows.Forms.TextBox();
            this.Prinbox6 = new System.Windows.Forms.TextBox();
            this.DECbox5 = new System.Windows.Forms.TextBox();
            this.Prinbox5 = new System.Windows.Forms.TextBox();
            this.DECbox4 = new System.Windows.Forms.TextBox();
            this.Prinbox4 = new System.Windows.Forms.TextBox();
            this.DECbox3 = new System.Windows.Forms.TextBox();
            this.Prinbox3 = new System.Windows.Forms.TextBox();
            this.DECbox2 = new System.Windows.Forms.TextBox();
            this.Prinbox2 = new System.Windows.Forms.TextBox();
            this.AVtime1 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.DECbox1 = new System.Windows.Forms.TextBox();
            this.Prinbox1 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.GBZaprosAV = new System.Windows.Forms.GroupBox();
            this.TBTMAV = new System.Windows.Forms.TextBox();
            this.RBLLAV = new System.Windows.Forms.RadioButton();
            this.TBADAV = new System.Windows.Forms.TextBox();
            this.RBLHAV = new System.Windows.Forms.RadioButton();
            this.label84 = new System.Windows.Forms.Label();
            this.RBHLAV = new System.Windows.Forms.RadioButton();
            this.label81 = new System.Windows.Forms.Label();
            this.RBHHAV = new System.Windows.Forms.RadioButton();
            this.label83 = new System.Windows.Forms.Label();
            this.BTStartAV = new System.Windows.Forms.Button();
            this.label82 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.TBkREGAV = new System.Windows.Forms.TextBox();
            this.TBREGAV = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.GBPORT.SuspendLayout();
            this.GBDIOLOG.SuspendLayout();
            this.GBSOOB.SuspendLayout();
            this.GBzapros.SuspendLayout();
            this.GBzapic.SuspendLayout();
            this.GBchten.SuspendLayout();
            this.GBBitPacet.SuspendLayout();
            this.GBOhib.SuspendLayout();
            this.TCPervStr.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GBDiolAV.SuspendLayout();
            this.GBZaprosAV.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTEnd
            // 
            this.BTEnd.Location = new System.Drawing.Point(1065, 486);
            this.BTEnd.Name = "BTEnd";
            this.BTEnd.Size = new System.Drawing.Size(75, 23);
            this.BTEnd.TabIndex = 0;
            this.BTEnd.Text = "Выход";
            this.BTEnd.UseVisualStyleBackColor = true;
            this.BTEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBSerialPort
            // 
            this.CBSerialPort.FormattingEnabled = true;
            this.CBSerialPort.Location = new System.Drawing.Point(125, 20);
            this.CBSerialPort.Name = "CBSerialPort";
            this.CBSerialPort.Size = new System.Drawing.Size(70, 21);
            this.CBSerialPort.TabIndex = 1;
            this.CBSerialPort.Text = "COM1";
            this.CBSerialPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Порт";
            // 
            // TBSoob
            // 
            this.TBSoob.Location = new System.Drawing.Point(6, 63);
            this.TBSoob.Multiline = true;
            this.TBSoob.Name = "TBSoob";
            this.TBSoob.Size = new System.Drawing.Size(304, 23);
            this.TBSoob.TabIndex = 3;
            this.TBSoob.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBSoob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BTOpenport
            // 
            this.BTOpenport.Location = new System.Drawing.Point(234, 26);
            this.BTOpenport.Name = "BTOpenport";
            this.BTOpenport.Size = new System.Drawing.Size(86, 21);
            this.BTOpenport.TabIndex = 4;
            this.BTOpenport.Text = "Открыть";
            this.BTOpenport.UseVisualStyleBackColor = true;
            this.BTOpenport.Click += new System.EventHandler(this.BTOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(231, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // BTClose
            // 
            this.BTClose.Location = new System.Drawing.Point(326, 26);
            this.BTClose.Name = "BTClose";
            this.BTClose.Size = new System.Drawing.Size(86, 21);
            this.BTClose.TabIndex = 8;
            this.BTClose.Text = "Закрыть";
            this.BTClose.UseVisualStyleBackColor = true;
            this.BTClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(231, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // BTPEREDdata
            // 
            this.BTPEREDdata.Location = new System.Drawing.Point(214, 14);
            this.BTPEREDdata.Name = "BTPEREDdata";
            this.BTPEREDdata.Size = new System.Drawing.Size(96, 44);
            this.BTPEREDdata.TabIndex = 10;
            this.BTPEREDdata.Text = "Передать данные";
            this.BTPEREDdata.UseVisualStyleBackColor = true;
            this.BTPEREDdata.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Скорость ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Биты данных";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Стоповый бит";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Контроль ошибок";
            // 
            // CBSpeed
            // 
            this.CBSpeed.FormattingEnabled = true;
            this.CBSpeed.Items.AddRange(new object[] {
            "75",
            "110",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "128000"});
            this.CBSpeed.Location = new System.Drawing.Point(125, 46);
            this.CBSpeed.Name = "CBSpeed";
            this.CBSpeed.Size = new System.Drawing.Size(70, 21);
            this.CBSpeed.TabIndex = 15;
            this.CBSpeed.Text = "9600";
            // 
            // CBBTDAT
            // 
            this.CBBTDAT.AutoCompleteCustomSource.AddRange(new string[] {
            "7",
            "8",
            "9"});
            this.CBBTDAT.FormattingEnabled = true;
            this.CBBTDAT.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.CBBTDAT.Location = new System.Drawing.Point(125, 73);
            this.CBBTDAT.Name = "CBBTDAT";
            this.CBBTDAT.Size = new System.Drawing.Size(70, 21);
            this.CBBTDAT.TabIndex = 16;
            this.CBBTDAT.Text = "8";
            // 
            // CBSTOPbt
            // 
            this.CBSTOPbt.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "1.5",
            "2"});
            this.CBSTOPbt.FormattingEnabled = true;
            this.CBSTOPbt.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.CBSTOPbt.Location = new System.Drawing.Point(125, 100);
            this.CBSTOPbt.Name = "CBSTOPbt";
            this.CBSTOPbt.Size = new System.Drawing.Size(70, 21);
            this.CBSTOPbt.TabIndex = 17;
            this.CBSTOPbt.Text = "One";
            // 
            // CBOUT
            // 
            this.CBOUT.FormattingEnabled = true;
            this.CBOUT.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CBOUT.Location = new System.Drawing.Point(125, 127);
            this.CBOUT.Name = "CBOUT";
            this.CBOUT.Size = new System.Drawing.Size(70, 21);
            this.CBOUT.TabIndex = 18;
            this.CBOUT.Text = "None";
            // 
            // port1
            // 
            this.port1.ReadTimeout = 100;
            this.port1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port1_DataReceived);
            // 
            // TBDiol
            // 
            this.TBDiol.Location = new System.Drawing.Point(6, 76);
            this.TBDiol.Multiline = true;
            this.TBDiol.Name = "TBDiol";
            this.TBDiol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBDiol.Size = new System.Drawing.Size(334, 215);
            this.TBDiol.TabIndex = 19;
            this.TBDiol.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TIMEROPENport
            // 
            this.TIMEROPENport.Interval = 1000;
            this.TIMEROPENport.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 22;
            // 
            // BTCleanDIOL
            // 
            this.BTCleanDIOL.Location = new System.Drawing.Point(265, 11);
            this.BTCleanDIOL.Name = "BTCleanDIOL";
            this.BTCleanDIOL.Size = new System.Drawing.Size(75, 56);
            this.BTCleanDIOL.TabIndex = 23;
            this.BTCleanDIOL.Text = "Очистить диалог";
            this.BTCleanDIOL.UseVisualStyleBackColor = true;
            this.BTCleanDIOL.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(231, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 25;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 76);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(334, 215);
            this.textBox3.TabIndex = 40;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // BTASCII
            // 
            this.BTASCII.Location = new System.Drawing.Point(16, 172);
            this.BTASCII.Name = "BTASCII";
            this.BTASCII.Size = new System.Drawing.Size(80, 33);
            this.BTASCII.TabIndex = 41;
            this.BTASCII.Text = "ASCII";
            this.BTASCII.UseVisualStyleBackColor = true;
            this.BTASCII.Click += new System.EventHandler(this.button5_Click);
            // 
            // RBhex
            // 
            this.RBhex.AutoSize = true;
            this.RBhex.Location = new System.Drawing.Point(58, 41);
            this.RBhex.Name = "RBhex";
            this.RBhex.Size = new System.Drawing.Size(42, 17);
            this.RBhex.TabIndex = 43;
            this.RBhex.TabStop = true;
            this.RBhex.Text = "hex";
            this.RBhex.UseVisualStyleBackColor = true;
            this.RBhex.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RBbin
            // 
            this.RBbin.AutoSize = true;
            this.RBbin.Location = new System.Drawing.Point(155, 41);
            this.RBbin.Name = "RBbin";
            this.RBbin.Size = new System.Drawing.Size(53, 17);
            this.RBbin.TabIndex = 44;
            this.RBbin.TabStop = true;
            this.RBbin.Text = "binary";
            this.RBbin.UseVisualStyleBackColor = true;
            this.RBbin.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // RBdec
            // 
            this.RBdec.AutoSize = true;
            this.RBdec.Location = new System.Drawing.Point(106, 41);
            this.RBdec.Name = "RBdec";
            this.RBdec.Size = new System.Drawing.Size(43, 17);
            this.RBdec.TabIndex = 45;
            this.RBdec.TabStop = true;
            this.RBdec.Text = "dec";
            this.RBdec.UseVisualStyleBackColor = true;
            this.RBdec.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // RBchar
            // 
            this.RBchar.AutoSize = true;
            this.RBchar.Location = new System.Drawing.Point(6, 41);
            this.RBchar.Name = "RBchar";
            this.RBchar.Size = new System.Drawing.Size(46, 17);
            this.RBchar.TabIndex = 46;
            this.RBchar.TabStop = true;
            this.RBchar.Text = "char";
            this.RBchar.UseVisualStyleBackColor = true;
            this.RBchar.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // BTStop
            // 
            this.BTStop.Location = new System.Drawing.Point(184, 11);
            this.BTStop.Name = "BTStop";
            this.BTStop.Size = new System.Drawing.Size(75, 56);
            this.BTStop.TabIndex = 47;
            this.BTStop.Text = "Пауза";
            this.BTStop.UseVisualStyleBackColor = true;
            this.BTStop.Click += new System.EventHandler(this.button7_Click);
            // 
            // GBPORT
            // 
            this.GBPORT.Controls.Add(this.CBSerialPort);
            this.GBPORT.Controls.Add(this.CBSpeed);
            this.GBPORT.Controls.Add(this.CBBTDAT);
            this.GBPORT.Controls.Add(this.CBSTOPbt);
            this.GBPORT.Controls.Add(this.CBOUT);
            this.GBPORT.Controls.Add(this.label1);
            this.GBPORT.Controls.Add(this.label4);
            this.GBPORT.Controls.Add(this.label5);
            this.GBPORT.Controls.Add(this.label6);
            this.GBPORT.Controls.Add(this.label7);
            this.GBPORT.Location = new System.Drawing.Point(16, 6);
            this.GBPORT.Name = "GBPORT";
            this.GBPORT.Size = new System.Drawing.Size(205, 160);
            this.GBPORT.TabIndex = 48;
            this.GBPORT.TabStop = false;
            this.GBPORT.Text = "Параметры порта";
            // 
            // GBDIOLOG
            // 
            this.GBDIOLOG.Controls.Add(this.BTStop);
            this.GBDIOLOG.Controls.Add(this.TBDiol);
            this.GBDIOLOG.Controls.Add(this.textBox3);
            this.GBDIOLOG.Controls.Add(this.BTCleanDIOL);
            this.GBDIOLOG.Location = new System.Drawing.Point(435, 6);
            this.GBDIOLOG.Name = "GBDIOLOG";
            this.GBDIOLOG.Size = new System.Drawing.Size(346, 297);
            this.GBDIOLOG.TabIndex = 49;
            this.GBDIOLOG.TabStop = false;
            this.GBDIOLOG.Text = "Диалог";
            // 
            // GBSOOB
            // 
            this.GBSOOB.Controls.Add(this.RBchar);
            this.GBSOOB.Controls.Add(this.RBdec);
            this.GBSOOB.Controls.Add(this.RBbin);
            this.GBSOOB.Controls.Add(this.RBhex);
            this.GBSOOB.Controls.Add(this.BTPEREDdata);
            this.GBSOOB.Controls.Add(this.TBSoob);
            this.GBSOOB.Location = new System.Drawing.Point(16, 211);
            this.GBSOOB.Name = "GBSOOB";
            this.GBSOOB.Size = new System.Drawing.Size(317, 92);
            this.GBSOOB.TabIndex = 50;
            this.GBSOOB.TabStop = false;
            this.GBSOOB.Text = "Сообщение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Адрес";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Функция";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Первый регистр";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Количество регистров";
            // 
            // TBCRC16
            // 
            this.TBCRC16.Location = new System.Drawing.Point(53, 115);
            this.TBCRC16.Name = "TBCRC16";
            this.TBCRC16.Size = new System.Drawing.Size(67, 20);
            this.TBCRC16.TabIndex = 56;
            // 
            // TBFIRSTreg
            // 
            this.TBFIRSTreg.Location = new System.Drawing.Point(125, 67);
            this.TBFIRSTreg.Name = "TBFIRSTreg";
            this.TBFIRSTreg.Size = new System.Drawing.Size(69, 20);
            this.TBFIRSTreg.TabIndex = 58;
            // 
            // BTZapros
            // 
            this.BTZapros.Location = new System.Drawing.Point(126, 123);
            this.BTZapros.Name = "BTZapros";
            this.BTZapros.Size = new System.Drawing.Size(96, 43);
            this.BTZapros.TabIndex = 60;
            this.BTZapros.Text = "Сформировать запрос";
            this.BTZapros.UseVisualStyleBackColor = true;
            this.BTZapros.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "CRC16";
            // 
            // GBzapros
            // 
            this.GBzapros.Controls.Add(this.labsis4);
            this.GBzapros.Controls.Add(this.BTDOBcrc);
            this.GBzapros.Controls.Add(this.labsis3);
            this.GBzapros.Controls.Add(this.TBADRES);
            this.GBzapros.Controls.Add(this.labsis2);
            this.GBzapros.Controls.Add(this.TBKOLreg);
            this.GBzapros.Controls.Add(this.labsis1);
            this.GBzapros.Controls.Add(this.TBFUNK);
            this.GBzapros.Controls.Add(this.label8);
            this.GBzapros.Controls.Add(this.BTZapros);
            this.GBzapros.Controls.Add(this.label14);
            this.GBzapros.Controls.Add(this.TBFIRSTreg);
            this.GBzapros.Controls.Add(this.label9);
            this.GBzapros.Controls.Add(this.label12);
            this.GBzapros.Controls.Add(this.label13);
            this.GBzapros.Controls.Add(this.TBCRC16);
            this.GBzapros.Location = new System.Drawing.Point(16, 309);
            this.GBzapros.Name = "GBzapros";
            this.GBzapros.Size = new System.Drawing.Size(227, 171);
            this.GBzapros.TabIndex = 65;
            this.GBzapros.TabStop = false;
            this.GBzapros.Text = "Запрос";
            // 
            // labsis4
            // 
            this.labsis4.AutoSize = true;
            this.labsis4.Location = new System.Drawing.Point(196, 93);
            this.labsis4.Name = "labsis4";
            this.labsis4.Size = new System.Drawing.Size(25, 13);
            this.labsis4.TabIndex = 86;
            this.labsis4.Text = "dec";
            // 
            // BTDOBcrc
            // 
            this.BTDOBcrc.Location = new System.Drawing.Point(9, 139);
            this.BTDOBcrc.Name = "BTDOBcrc";
            this.BTDOBcrc.Size = new System.Drawing.Size(111, 23);
            this.BTDOBcrc.TabIndex = 81;
            this.BTDOBcrc.Text = "Добавить CRC";
            this.BTDOBcrc.UseVisualStyleBackColor = true;
            this.BTDOBcrc.Click += new System.EventHandler(this.button11_Click);
            // 
            // labsis3
            // 
            this.labsis3.AutoSize = true;
            this.labsis3.Location = new System.Drawing.Point(196, 70);
            this.labsis3.Name = "labsis3";
            this.labsis3.Size = new System.Drawing.Size(25, 13);
            this.labsis3.TabIndex = 85;
            this.labsis3.Text = "dec";
            // 
            // TBADRES
            // 
            this.TBADRES.Location = new System.Drawing.Point(125, 19);
            this.TBADRES.Name = "TBADRES";
            this.TBADRES.Size = new System.Drawing.Size(69, 20);
            this.TBADRES.TabIndex = 67;
            // 
            // labsis2
            // 
            this.labsis2.AutoSize = true;
            this.labsis2.Location = new System.Drawing.Point(196, 46);
            this.labsis2.Name = "labsis2";
            this.labsis2.Size = new System.Drawing.Size(24, 13);
            this.labsis2.TabIndex = 84;
            this.labsis2.Text = "hex";
            // 
            // TBKOLreg
            // 
            this.TBKOLreg.Location = new System.Drawing.Point(125, 90);
            this.TBKOLreg.Name = "TBKOLreg";
            this.TBKOLreg.Size = new System.Drawing.Size(69, 20);
            this.TBKOLreg.TabIndex = 69;
            // 
            // labsis1
            // 
            this.labsis1.AutoSize = true;
            this.labsis1.Location = new System.Drawing.Point(196, 22);
            this.labsis1.Name = "labsis1";
            this.labsis1.Size = new System.Drawing.Size(25, 13);
            this.labsis1.TabIndex = 82;
            this.labsis1.Text = "dec";
            // 
            // TBFUNK
            // 
            this.TBFUNK.Location = new System.Drawing.Point(126, 43);
            this.TBFUNK.Name = "TBFUNK";
            this.TBFUNK.Size = new System.Drawing.Size(69, 20);
            this.TBFUNK.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Количество байт данных";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Данные для записи";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // TBdecZap
            // 
            this.TBdecZap.Location = new System.Drawing.Point(70, 74);
            this.TBdecZap.Name = "TBdecZap";
            this.TBdecZap.Size = new System.Drawing.Size(90, 20);
            this.TBdecZap.TabIndex = 71;
            // 
            // GBzapic
            // 
            this.GBzapic.Controls.Add(this.label28);
            this.GBzapic.Controls.Add(this.label19);
            this.GBzapic.Controls.Add(this.label18);
            this.GBzapic.Controls.Add(this.TBhexZap);
            this.GBzapic.Controls.Add(this.label17);
            this.GBzapic.Controls.Add(this.RBHLzap);
            this.GBzapic.Controls.Add(this.TBhextotxZap);
            this.GBzapic.Controls.Add(this.RBLLzap);
            this.GBzapic.Controls.Add(this.RBHHzap);
            this.GBzapic.Controls.Add(this.RBLHzap);
            this.GBzapic.Controls.Add(this.TBdecZap);
            this.GBzapic.Controls.Add(this.label16);
            this.GBzapic.Controls.Add(this.label15);
            this.GBzapic.Location = new System.Drawing.Point(249, 309);
            this.GBzapic.Name = "GBzapic";
            this.GBzapic.Size = new System.Drawing.Size(269, 171);
            this.GBzapic.TabIndex = 73;
            this.GBzapic.TabStop = false;
            this.GBzapic.Text = "Запись данных";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 129);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 80;
            this.label28.Text = "HEX to TX";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 79;
            this.label19.Text = "HEX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 78;
            this.label18.Text = "DEC";
            // 
            // TBhexZap
            // 
            this.TBhexZap.Location = new System.Drawing.Point(70, 100);
            this.TBhexZap.Name = "TBhexZap";
            this.TBhexZap.Size = new System.Drawing.Size(90, 20);
            this.TBhexZap.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(214, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 74;
            this.label17.Text = "4";
            // 
            // RBHLzap
            // 
            this.RBHLzap.AutoSize = true;
            this.RBHLzap.Location = new System.Drawing.Point(173, 85);
            this.RBHLzap.Name = "RBHLzap";
            this.RBHLzap.Size = new System.Drawing.Size(90, 17);
            this.RBHLzap.TabIndex = 74;
            this.RBHLzap.TabStop = true;
            this.RBHLzap.Text = "HL HH LL LH";
            this.RBHLzap.UseVisualStyleBackColor = true;
            // 
            // TBhextotxZap
            // 
            this.TBhextotxZap.Location = new System.Drawing.Point(70, 126);
            this.TBhextotxZap.Name = "TBhextotxZap";
            this.TBhextotxZap.Size = new System.Drawing.Size(90, 20);
            this.TBhextotxZap.TabIndex = 76;
            // 
            // RBLLzap
            // 
            this.RBLLzap.AutoSize = true;
            this.RBLLzap.Location = new System.Drawing.Point(173, 133);
            this.RBLLzap.Name = "RBLLzap";
            this.RBLLzap.Size = new System.Drawing.Size(90, 17);
            this.RBLLzap.TabIndex = 75;
            this.RBLLzap.TabStop = true;
            this.RBLLzap.Text = "LL LH HL HH";
            this.RBLLzap.UseVisualStyleBackColor = true;
            // 
            // RBHHzap
            // 
            this.RBHHzap.AutoSize = true;
            this.RBHHzap.Location = new System.Drawing.Point(173, 62);
            this.RBHHzap.Name = "RBHHzap";
            this.RBHHzap.Size = new System.Drawing.Size(90, 17);
            this.RBHHzap.TabIndex = 73;
            this.RBHHzap.TabStop = true;
            this.RBHHzap.Text = "HH HL LH LL";
            this.RBHHzap.UseVisualStyleBackColor = true;
            // 
            // RBLHzap
            // 
            this.RBLHzap.AutoSize = true;
            this.RBLHzap.Location = new System.Drawing.Point(173, 108);
            this.RBLHzap.Name = "RBLHzap";
            this.RBLHzap.Size = new System.Drawing.Size(90, 17);
            this.RBLHzap.TabIndex = 72;
            this.RBLHzap.TabStop = true;
            this.RBLHzap.Text = "LH LL HH HL";
            this.RBLHzap.UseVisualStyleBackColor = true;
            // 
            // GBchten
            // 
            this.GBchten.Controls.Add(this.RBLLchen);
            this.GBchten.Controls.Add(this.RBLHchen);
            this.GBchten.Controls.Add(this.RBHLchen);
            this.GBchten.Controls.Add(this.RBHHchen);
            this.GBchten.Controls.Add(this.label33);
            this.GBchten.Controls.Add(this.label29);
            this.GBchten.Controls.Add(this.label27);
            this.GBchten.Controls.Add(this.label21);
            this.GBchten.Controls.Add(this.label20);
            this.GBchten.Controls.Add(this.TBdecChten);
            this.GBchten.Controls.Add(this.TBhexChten);
            this.GBchten.Location = new System.Drawing.Point(524, 309);
            this.GBchten.Name = "GBchten";
            this.GBchten.Size = new System.Drawing.Size(257, 171);
            this.GBchten.TabIndex = 79;
            this.GBchten.TabStop = false;
            this.GBchten.Text = "Чтение данных";
            // 
            // RBLLchen
            // 
            this.RBLLchen.AutoSize = true;
            this.RBLLchen.Location = new System.Drawing.Point(152, 145);
            this.RBLLchen.Name = "RBLLchen";
            this.RBLLchen.Size = new System.Drawing.Size(90, 17);
            this.RBLLchen.TabIndex = 88;
            this.RBLLchen.TabStop = true;
            this.RBLLchen.Text = "LL LH HL HH";
            this.RBLLchen.UseVisualStyleBackColor = true;
            // 
            // RBLHchen
            // 
            this.RBLHchen.AutoSize = true;
            this.RBLHchen.Location = new System.Drawing.Point(152, 109);
            this.RBLHchen.Name = "RBLHchen";
            this.RBLHchen.Size = new System.Drawing.Size(90, 17);
            this.RBLHchen.TabIndex = 87;
            this.RBLHchen.TabStop = true;
            this.RBLHchen.Text = "LH LL HH HL";
            this.RBLHchen.UseVisualStyleBackColor = true;
            // 
            // RBHLchen
            // 
            this.RBHLchen.AutoSize = true;
            this.RBHLchen.Location = new System.Drawing.Point(21, 144);
            this.RBHLchen.Name = "RBHLchen";
            this.RBHLchen.Size = new System.Drawing.Size(90, 17);
            this.RBHLchen.TabIndex = 86;
            this.RBHLchen.TabStop = true;
            this.RBHLchen.Text = "HL HH LL LH";
            this.RBHLchen.UseVisualStyleBackColor = true;
            // 
            // RBHHchen
            // 
            this.RBHHchen.AutoSize = true;
            this.RBHHchen.Location = new System.Drawing.Point(21, 107);
            this.RBHHchen.Name = "RBHHchen";
            this.RBHHchen.Size = new System.Drawing.Size(90, 17);
            this.RBHHchen.TabIndex = 85;
            this.RBHHchen.TabStop = true;
            this.RBHHchen.Text = "HH HL LH LL";
            this.RBHHchen.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 66);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 13);
            this.label33.TabIndex = 15;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 33);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 26);
            this.label29.TabIndex = 11;
            this.label29.Text = "       Время \r\nсинхронизации:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(33, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 13);
            this.label27.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(173, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "DEC";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(173, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "HEX";
            // 
            // TBdecChten
            // 
            this.TBdecChten.Location = new System.Drawing.Point(134, 75);
            this.TBdecChten.Name = "TBdecChten";
            this.TBdecChten.Size = new System.Drawing.Size(108, 20);
            this.TBdecChten.TabIndex = 4;
            // 
            // TBhexChten
            // 
            this.TBhexChten.Location = new System.Drawing.Point(134, 32);
            this.TBhexChten.Name = "TBhexChten";
            this.TBhexChten.Size = new System.Drawing.Size(108, 20);
            this.TBhexChten.TabIndex = 0;
            // 
            // TBbitpac
            // 
            this.TBbitpac.Location = new System.Drawing.Point(6, 27);
            this.TBbitpac.Multiline = true;
            this.TBbitpac.Name = "TBbitpac";
            this.TBbitpac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBbitpac.Size = new System.Drawing.Size(341, 264);
            this.TBbitpac.TabIndex = 80;
            // 
            // GBBitPacet
            // 
            this.GBBitPacet.Controls.Add(this.GBOhib);
            this.GBBitPacet.Controls.Add(this.TBbitpac);
            this.GBBitPacet.Location = new System.Drawing.Point(787, 6);
            this.GBBitPacet.Name = "GBBitPacet";
            this.GBBitPacet.Size = new System.Drawing.Size(353, 474);
            this.GBBitPacet.TabIndex = 81;
            this.GBBitPacet.TabStop = false;
            this.GBBitPacet.Text = "Битые пакеты";
            // 
            // GBOhib
            // 
            this.GBOhib.Controls.Add(this.TBochfunk);
            this.GBOhib.Controls.Add(this.label26);
            this.GBOhib.Controls.Add(this.TBochkolreg);
            this.GBOhib.Controls.Add(this.TBochreg);
            this.GBOhib.Controls.Add(this.TBochlong);
            this.GBOhib.Controls.Add(this.label25);
            this.GBOhib.Controls.Add(this.label24);
            this.GBOhib.Controls.Add(this.label23);
            this.GBOhib.Controls.Add(this.label22);
            this.GBOhib.Controls.Add(this.TBochcrc);
            this.GBOhib.Location = new System.Drawing.Point(6, 303);
            this.GBOhib.Name = "GBOhib";
            this.GBOhib.Size = new System.Drawing.Size(341, 161);
            this.GBOhib.TabIndex = 81;
            this.GBOhib.TabStop = false;
            this.GBOhib.Text = "Ошибки";
            // 
            // TBochfunk
            // 
            this.TBochfunk.Location = new System.Drawing.Point(160, 135);
            this.TBochfunk.Name = "TBochfunk";
            this.TBochfunk.Size = new System.Drawing.Size(100, 20);
            this.TBochfunk.TabIndex = 9;
            this.TBochfunk.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 138);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Функция";
            // 
            // TBochkolreg
            // 
            this.TBochkolreg.Location = new System.Drawing.Point(160, 108);
            this.TBochkolreg.Name = "TBochkolreg";
            this.TBochkolreg.Size = new System.Drawing.Size(100, 20);
            this.TBochkolreg.TabIndex = 7;
            this.TBochkolreg.Text = "0";
            // 
            // TBochreg
            // 
            this.TBochreg.Location = new System.Drawing.Point(160, 82);
            this.TBochreg.Name = "TBochreg";
            this.TBochreg.Size = new System.Drawing.Size(100, 20);
            this.TBochreg.TabIndex = 6;
            this.TBochreg.Text = "0";
            // 
            // TBochlong
            // 
            this.TBochlong.Location = new System.Drawing.Point(160, 56);
            this.TBochlong.Name = "TBochlong";
            this.TBochlong.Size = new System.Drawing.Size(100, 20);
            this.TBochlong.TabIndex = 5;
            this.TBochlong.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 111);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(121, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Количество регистров";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 85);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Регистр";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(17, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Длина пакета";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "CRC ";
            // 
            // TBochcrc
            // 
            this.TBochcrc.Location = new System.Drawing.Point(160, 30);
            this.TBochcrc.Name = "TBochcrc";
            this.TBochcrc.Size = new System.Drawing.Size(100, 20);
            this.TBochcrc.TabIndex = 0;
            this.TBochcrc.Text = "0";
            this.TBochcrc.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // TCPervStr
            // 
            this.TCPervStr.Controls.Add(this.tabPage1);
            this.TCPervStr.Controls.Add(this.tabPage2);
            this.TCPervStr.Location = new System.Drawing.Point(-5, -1);
            this.TCPervStr.Name = "TCPervStr";
            this.TCPervStr.SelectedIndex = 0;
            this.TCPervStr.Size = new System.Drawing.Size(1164, 545);
            this.TCPervStr.TabIndex = 82;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.GBPORT);
            this.tabPage1.Controls.Add(this.BTEnd);
            this.tabPage1.Controls.Add(this.GBBitPacet);
            this.tabPage1.Controls.Add(this.BTOpenport);
            this.tabPage1.Controls.Add(this.GBchten);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.GBDIOLOG);
            this.tabPage1.Controls.Add(this.GBzapic);
            this.tabPage1.Controls.Add(this.BTClose);
            this.tabPage1.Controls.Add(this.GBzapros);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.GBSOOB);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.BTASCII);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1156, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Порт";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(288, 152);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 84;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.BTAVotpr);
            this.groupBox11.Controls.Add(this.label45);
            this.groupBox11.Controls.Add(this.textBox24);
            this.groupBox11.Location = new System.Drawing.Point(339, 211);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(90, 92);
            this.groupBox11.TabIndex = 83;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Авто отпр.";
            // 
            // BTAVotpr
            // 
            this.BTAVotpr.Location = new System.Drawing.Point(6, 64);
            this.BTAVotpr.Name = "BTAVotpr";
            this.BTAVotpr.Size = new System.Drawing.Size(78, 22);
            this.BTAVotpr.TabIndex = 82;
            this.BTAVotpr.Text = "Выкл";
            this.BTAVotpr.UseVisualStyleBackColor = true;
            this.BTAVotpr.Click += new System.EventHandler(this.button12_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(17, 16);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(56, 13);
            this.label45.TabIndex = 49;
            this.label45.Text = "Интервал";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(6, 38);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(78, 20);
            this.textBox24.TabIndex = 48;
            this.textBox24.Text = "2000";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.BTCleanAV);
            this.tabPage2.Controls.Add(this.GBDiolAV);
            this.tabPage2.Controls.Add(this.AVtime32);
            this.tabPage2.Controls.Add(this.AVtime31);
            this.tabPage2.Controls.Add(this.AVtime30);
            this.tabPage2.Controls.Add(this.AVtime29);
            this.tabPage2.Controls.Add(this.AVtime28);
            this.tabPage2.Controls.Add(this.AVtime27);
            this.tabPage2.Controls.Add(this.AVtime26);
            this.tabPage2.Controls.Add(this.AVtime25);
            this.tabPage2.Controls.Add(this.AVtime24);
            this.tabPage2.Controls.Add(this.AVtime23);
            this.tabPage2.Controls.Add(this.AVtime22);
            this.tabPage2.Controls.Add(this.AVtime21);
            this.tabPage2.Controls.Add(this.AVtime20);
            this.tabPage2.Controls.Add(this.AVtime19);
            this.tabPage2.Controls.Add(this.AVtime18);
            this.tabPage2.Controls.Add(this.AVtime17);
            this.tabPage2.Controls.Add(this.AVtime16);
            this.tabPage2.Controls.Add(this.AVtime15);
            this.tabPage2.Controls.Add(this.AVtime14);
            this.tabPage2.Controls.Add(this.AVtime13);
            this.tabPage2.Controls.Add(this.AVtime12);
            this.tabPage2.Controls.Add(this.AVtime11);
            this.tabPage2.Controls.Add(this.AVtime10);
            this.tabPage2.Controls.Add(this.AVtime9);
            this.tabPage2.Controls.Add(this.AVtime8);
            this.tabPage2.Controls.Add(this.AVtime7);
            this.tabPage2.Controls.Add(this.AVtime6);
            this.tabPage2.Controls.Add(this.AVtime5);
            this.tabPage2.Controls.Add(this.AVtime4);
            this.tabPage2.Controls.Add(this.AVtime3);
            this.tabPage2.Controls.Add(this.AVtime2);
            this.tabPage2.Controls.Add(this.lab32);
            this.tabPage2.Controls.Add(this.lab31);
            this.tabPage2.Controls.Add(this.lab30);
            this.tabPage2.Controls.Add(this.lab29);
            this.tabPage2.Controls.Add(this.lab28);
            this.tabPage2.Controls.Add(this.lab27);
            this.tabPage2.Controls.Add(this.lab26);
            this.tabPage2.Controls.Add(this.lab25);
            this.tabPage2.Controls.Add(this.lab24);
            this.tabPage2.Controls.Add(this.lab23);
            this.tabPage2.Controls.Add(this.lab22);
            this.tabPage2.Controls.Add(this.lab21);
            this.tabPage2.Controls.Add(this.lab20);
            this.tabPage2.Controls.Add(this.lab19);
            this.tabPage2.Controls.Add(this.lab18);
            this.tabPage2.Controls.Add(this.lab17);
            this.tabPage2.Controls.Add(this.lab16);
            this.tabPage2.Controls.Add(this.lab15);
            this.tabPage2.Controls.Add(this.lab14);
            this.tabPage2.Controls.Add(this.lab13);
            this.tabPage2.Controls.Add(this.lab12);
            this.tabPage2.Controls.Add(this.lab11);
            this.tabPage2.Controls.Add(this.lab10);
            this.tabPage2.Controls.Add(this.lab9);
            this.tabPage2.Controls.Add(this.lab8);
            this.tabPage2.Controls.Add(this.lab7);
            this.tabPage2.Controls.Add(this.lab6);
            this.tabPage2.Controls.Add(this.lab5);
            this.tabPage2.Controls.Add(this.lab4);
            this.tabPage2.Controls.Add(this.lab3);
            this.tabPage2.Controls.Add(this.lab2);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.DECbox32);
            this.tabPage2.Controls.Add(this.Prinbox32);
            this.tabPage2.Controls.Add(this.DECbox31);
            this.tabPage2.Controls.Add(this.Prinbox31);
            this.tabPage2.Controls.Add(this.DECbox30);
            this.tabPage2.Controls.Add(this.Prinbox30);
            this.tabPage2.Controls.Add(this.DECbox29);
            this.tabPage2.Controls.Add(this.Prinbox29);
            this.tabPage2.Controls.Add(this.DECbox28);
            this.tabPage2.Controls.Add(this.Prinbox28);
            this.tabPage2.Controls.Add(this.DECbox27);
            this.tabPage2.Controls.Add(this.Prinbox27);
            this.tabPage2.Controls.Add(this.DECbox26);
            this.tabPage2.Controls.Add(this.Prinbox26);
            this.tabPage2.Controls.Add(this.DECbox25);
            this.tabPage2.Controls.Add(this.Prinbox25);
            this.tabPage2.Controls.Add(this.DECbox24);
            this.tabPage2.Controls.Add(this.Prinbox24);
            this.tabPage2.Controls.Add(this.DECbox23);
            this.tabPage2.Controls.Add(this.Prinbox23);
            this.tabPage2.Controls.Add(this.DECbox22);
            this.tabPage2.Controls.Add(this.Prinbox22);
            this.tabPage2.Controls.Add(this.DECbox21);
            this.tabPage2.Controls.Add(this.Prinbox21);
            this.tabPage2.Controls.Add(this.DECbox20);
            this.tabPage2.Controls.Add(this.Prinbox20);
            this.tabPage2.Controls.Add(this.DECbox19);
            this.tabPage2.Controls.Add(this.Prinbox19);
            this.tabPage2.Controls.Add(this.DECbox18);
            this.tabPage2.Controls.Add(this.Prinbox18);
            this.tabPage2.Controls.Add(this.DECbox17);
            this.tabPage2.Controls.Add(this.Prinbox17);
            this.tabPage2.Controls.Add(this.DECbox16);
            this.tabPage2.Controls.Add(this.Prinbox16);
            this.tabPage2.Controls.Add(this.DECbox15);
            this.tabPage2.Controls.Add(this.Prinbox15);
            this.tabPage2.Controls.Add(this.DECbox14);
            this.tabPage2.Controls.Add(this.Prinbox14);
            this.tabPage2.Controls.Add(this.DECbox13);
            this.tabPage2.Controls.Add(this.Prinbox13);
            this.tabPage2.Controls.Add(this.DECbox12);
            this.tabPage2.Controls.Add(this.Prinbox12);
            this.tabPage2.Controls.Add(this.DECbox11);
            this.tabPage2.Controls.Add(this.Prinbox11);
            this.tabPage2.Controls.Add(this.DECbox10);
            this.tabPage2.Controls.Add(this.Prinbox10);
            this.tabPage2.Controls.Add(this.DECbox9);
            this.tabPage2.Controls.Add(this.Prinbox9);
            this.tabPage2.Controls.Add(this.DECbox8);
            this.tabPage2.Controls.Add(this.Prinbox8);
            this.tabPage2.Controls.Add(this.DECbox7);
            this.tabPage2.Controls.Add(this.Prinbox7);
            this.tabPage2.Controls.Add(this.DECbox6);
            this.tabPage2.Controls.Add(this.Prinbox6);
            this.tabPage2.Controls.Add(this.DECbox5);
            this.tabPage2.Controls.Add(this.Prinbox5);
            this.tabPage2.Controls.Add(this.DECbox4);
            this.tabPage2.Controls.Add(this.Prinbox4);
            this.tabPage2.Controls.Add(this.DECbox3);
            this.tabPage2.Controls.Add(this.Prinbox3);
            this.tabPage2.Controls.Add(this.DECbox2);
            this.tabPage2.Controls.Add(this.Prinbox2);
            this.tabPage2.Controls.Add(this.AVtime1);
            this.tabPage2.Controls.Add(this.lab1);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.label42);
            this.tabPage2.Controls.Add(this.DECbox1);
            this.tabPage2.Controls.Add(this.Prinbox1);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.GBZaprosAV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Автоматический опрос";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1065, 486);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 140;
            this.button9.Text = "Выход";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // BTCleanAV
            // 
            this.BTCleanAV.Location = new System.Drawing.Point(258, 247);
            this.BTCleanAV.Name = "BTCleanAV";
            this.BTCleanAV.Size = new System.Drawing.Size(70, 36);
            this.BTCleanAV.TabIndex = 139;
            this.BTCleanAV.Text = "Очистить диалог";
            this.BTCleanAV.UseVisualStyleBackColor = true;
            this.BTCleanAV.Click += new System.EventHandler(this.button10_Click);
            // 
            // GBDiolAV
            // 
            this.GBDiolAV.Controls.Add(this.TBDIOLAV);
            this.GBDiolAV.Location = new System.Drawing.Point(13, 280);
            this.GBDiolAV.Name = "GBDiolAV";
            this.GBDiolAV.Size = new System.Drawing.Size(315, 233);
            this.GBDiolAV.TabIndex = 138;
            this.GBDiolAV.TabStop = false;
            this.GBDiolAV.Text = "Диалог АВТ опрос";
            // 
            // TBDIOLAV
            // 
            this.TBDIOLAV.Location = new System.Drawing.Point(6, 21);
            this.TBDIOLAV.Multiline = true;
            this.TBDIOLAV.Name = "TBDIOLAV";
            this.TBDIOLAV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBDIOLAV.Size = new System.Drawing.Size(303, 205);
            this.TBDIOLAV.TabIndex = 137;
            // 
            // AVtime32
            // 
            this.AVtime32.AutoSize = true;
            this.AVtime32.Location = new System.Drawing.Point(1029, 434);
            this.AVtime32.Name = "AVtime32";
            this.AVtime32.Size = new System.Drawing.Size(0, 13);
            this.AVtime32.TabIndex = 136;
            // 
            // AVtime31
            // 
            this.AVtime31.AutoSize = true;
            this.AVtime31.Location = new System.Drawing.Point(1029, 408);
            this.AVtime31.Name = "AVtime31";
            this.AVtime31.Size = new System.Drawing.Size(0, 13);
            this.AVtime31.TabIndex = 135;
            // 
            // AVtime30
            // 
            this.AVtime30.AutoSize = true;
            this.AVtime30.Location = new System.Drawing.Point(1029, 382);
            this.AVtime30.Name = "AVtime30";
            this.AVtime30.Size = new System.Drawing.Size(0, 13);
            this.AVtime30.TabIndex = 134;
            // 
            // AVtime29
            // 
            this.AVtime29.AutoSize = true;
            this.AVtime29.Location = new System.Drawing.Point(1029, 356);
            this.AVtime29.Name = "AVtime29";
            this.AVtime29.Size = new System.Drawing.Size(0, 13);
            this.AVtime29.TabIndex = 133;
            // 
            // AVtime28
            // 
            this.AVtime28.AutoSize = true;
            this.AVtime28.Location = new System.Drawing.Point(1029, 330);
            this.AVtime28.Name = "AVtime28";
            this.AVtime28.Size = new System.Drawing.Size(0, 13);
            this.AVtime28.TabIndex = 132;
            // 
            // AVtime27
            // 
            this.AVtime27.AutoSize = true;
            this.AVtime27.Location = new System.Drawing.Point(1029, 304);
            this.AVtime27.Name = "AVtime27";
            this.AVtime27.Size = new System.Drawing.Size(0, 13);
            this.AVtime27.TabIndex = 131;
            // 
            // AVtime26
            // 
            this.AVtime26.AutoSize = true;
            this.AVtime26.Location = new System.Drawing.Point(1029, 278);
            this.AVtime26.Name = "AVtime26";
            this.AVtime26.Size = new System.Drawing.Size(0, 13);
            this.AVtime26.TabIndex = 130;
            // 
            // AVtime25
            // 
            this.AVtime25.AutoSize = true;
            this.AVtime25.Location = new System.Drawing.Point(1029, 252);
            this.AVtime25.Name = "AVtime25";
            this.AVtime25.Size = new System.Drawing.Size(0, 13);
            this.AVtime25.TabIndex = 129;
            // 
            // AVtime24
            // 
            this.AVtime24.AutoSize = true;
            this.AVtime24.Location = new System.Drawing.Point(1029, 226);
            this.AVtime24.Name = "AVtime24";
            this.AVtime24.Size = new System.Drawing.Size(0, 13);
            this.AVtime24.TabIndex = 128;
            // 
            // AVtime23
            // 
            this.AVtime23.AutoSize = true;
            this.AVtime23.Location = new System.Drawing.Point(1029, 200);
            this.AVtime23.Name = "AVtime23";
            this.AVtime23.Size = new System.Drawing.Size(0, 13);
            this.AVtime23.TabIndex = 127;
            // 
            // AVtime22
            // 
            this.AVtime22.AutoSize = true;
            this.AVtime22.Location = new System.Drawing.Point(1029, 174);
            this.AVtime22.Name = "AVtime22";
            this.AVtime22.Size = new System.Drawing.Size(0, 13);
            this.AVtime22.TabIndex = 126;
            // 
            // AVtime21
            // 
            this.AVtime21.AutoSize = true;
            this.AVtime21.Location = new System.Drawing.Point(1029, 148);
            this.AVtime21.Name = "AVtime21";
            this.AVtime21.Size = new System.Drawing.Size(0, 13);
            this.AVtime21.TabIndex = 125;
            // 
            // AVtime20
            // 
            this.AVtime20.AutoSize = true;
            this.AVtime20.Location = new System.Drawing.Point(1029, 122);
            this.AVtime20.Name = "AVtime20";
            this.AVtime20.Size = new System.Drawing.Size(0, 13);
            this.AVtime20.TabIndex = 124;
            // 
            // AVtime19
            // 
            this.AVtime19.AutoSize = true;
            this.AVtime19.Location = new System.Drawing.Point(1029, 96);
            this.AVtime19.Name = "AVtime19";
            this.AVtime19.Size = new System.Drawing.Size(0, 13);
            this.AVtime19.TabIndex = 123;
            // 
            // AVtime18
            // 
            this.AVtime18.AutoSize = true;
            this.AVtime18.Location = new System.Drawing.Point(1029, 70);
            this.AVtime18.Name = "AVtime18";
            this.AVtime18.Size = new System.Drawing.Size(0, 13);
            this.AVtime18.TabIndex = 122;
            // 
            // AVtime17
            // 
            this.AVtime17.AutoSize = true;
            this.AVtime17.Location = new System.Drawing.Point(1029, 44);
            this.AVtime17.Name = "AVtime17";
            this.AVtime17.Size = new System.Drawing.Size(0, 13);
            this.AVtime17.TabIndex = 121;
            // 
            // AVtime16
            // 
            this.AVtime16.AutoSize = true;
            this.AVtime16.Location = new System.Drawing.Point(606, 434);
            this.AVtime16.Name = "AVtime16";
            this.AVtime16.Size = new System.Drawing.Size(0, 13);
            this.AVtime16.TabIndex = 120;
            // 
            // AVtime15
            // 
            this.AVtime15.AutoSize = true;
            this.AVtime15.Location = new System.Drawing.Point(606, 408);
            this.AVtime15.Name = "AVtime15";
            this.AVtime15.Size = new System.Drawing.Size(0, 13);
            this.AVtime15.TabIndex = 119;
            // 
            // AVtime14
            // 
            this.AVtime14.AutoSize = true;
            this.AVtime14.Location = new System.Drawing.Point(606, 382);
            this.AVtime14.Name = "AVtime14";
            this.AVtime14.Size = new System.Drawing.Size(0, 13);
            this.AVtime14.TabIndex = 118;
            // 
            // AVtime13
            // 
            this.AVtime13.AutoSize = true;
            this.AVtime13.Location = new System.Drawing.Point(606, 356);
            this.AVtime13.Name = "AVtime13";
            this.AVtime13.Size = new System.Drawing.Size(0, 13);
            this.AVtime13.TabIndex = 117;
            // 
            // AVtime12
            // 
            this.AVtime12.AutoSize = true;
            this.AVtime12.Location = new System.Drawing.Point(606, 330);
            this.AVtime12.Name = "AVtime12";
            this.AVtime12.Size = new System.Drawing.Size(0, 13);
            this.AVtime12.TabIndex = 116;
            // 
            // AVtime11
            // 
            this.AVtime11.AutoSize = true;
            this.AVtime11.Location = new System.Drawing.Point(606, 304);
            this.AVtime11.Name = "AVtime11";
            this.AVtime11.Size = new System.Drawing.Size(0, 13);
            this.AVtime11.TabIndex = 115;
            // 
            // AVtime10
            // 
            this.AVtime10.AutoSize = true;
            this.AVtime10.Location = new System.Drawing.Point(606, 278);
            this.AVtime10.Name = "AVtime10";
            this.AVtime10.Size = new System.Drawing.Size(0, 13);
            this.AVtime10.TabIndex = 114;
            // 
            // AVtime9
            // 
            this.AVtime9.AutoSize = true;
            this.AVtime9.Location = new System.Drawing.Point(606, 252);
            this.AVtime9.Name = "AVtime9";
            this.AVtime9.Size = new System.Drawing.Size(0, 13);
            this.AVtime9.TabIndex = 113;
            // 
            // AVtime8
            // 
            this.AVtime8.AutoSize = true;
            this.AVtime8.Location = new System.Drawing.Point(606, 226);
            this.AVtime8.Name = "AVtime8";
            this.AVtime8.Size = new System.Drawing.Size(0, 13);
            this.AVtime8.TabIndex = 112;
            // 
            // AVtime7
            // 
            this.AVtime7.AutoSize = true;
            this.AVtime7.Location = new System.Drawing.Point(606, 200);
            this.AVtime7.Name = "AVtime7";
            this.AVtime7.Size = new System.Drawing.Size(0, 13);
            this.AVtime7.TabIndex = 111;
            // 
            // AVtime6
            // 
            this.AVtime6.AutoSize = true;
            this.AVtime6.Location = new System.Drawing.Point(606, 174);
            this.AVtime6.Name = "AVtime6";
            this.AVtime6.Size = new System.Drawing.Size(0, 13);
            this.AVtime6.TabIndex = 110;
            // 
            // AVtime5
            // 
            this.AVtime5.AutoSize = true;
            this.AVtime5.Location = new System.Drawing.Point(606, 148);
            this.AVtime5.Name = "AVtime5";
            this.AVtime5.Size = new System.Drawing.Size(0, 13);
            this.AVtime5.TabIndex = 109;
            // 
            // AVtime4
            // 
            this.AVtime4.AutoSize = true;
            this.AVtime4.Location = new System.Drawing.Point(606, 122);
            this.AVtime4.Name = "AVtime4";
            this.AVtime4.Size = new System.Drawing.Size(0, 13);
            this.AVtime4.TabIndex = 108;
            // 
            // AVtime3
            // 
            this.AVtime3.AutoSize = true;
            this.AVtime3.Location = new System.Drawing.Point(606, 96);
            this.AVtime3.Name = "AVtime3";
            this.AVtime3.Size = new System.Drawing.Size(0, 13);
            this.AVtime3.TabIndex = 107;
            // 
            // AVtime2
            // 
            this.AVtime2.AutoSize = true;
            this.AVtime2.Location = new System.Drawing.Point(606, 70);
            this.AVtime2.Name = "AVtime2";
            this.AVtime2.Size = new System.Drawing.Size(0, 13);
            this.AVtime2.TabIndex = 106;
            // 
            // lab32
            // 
            this.lab32.AutoSize = true;
            this.lab32.Location = new System.Drawing.Point(767, 434);
            this.lab32.Name = "lab32";
            this.lab32.Size = new System.Drawing.Size(19, 13);
            this.lab32.TabIndex = 105;
            this.lab32.Text = "32";
            // 
            // lab31
            // 
            this.lab31.AutoSize = true;
            this.lab31.Location = new System.Drawing.Point(767, 408);
            this.lab31.Name = "lab31";
            this.lab31.Size = new System.Drawing.Size(19, 13);
            this.lab31.TabIndex = 104;
            this.lab31.Text = "31";
            // 
            // lab30
            // 
            this.lab30.AutoSize = true;
            this.lab30.Location = new System.Drawing.Point(767, 382);
            this.lab30.Name = "lab30";
            this.lab30.Size = new System.Drawing.Size(19, 13);
            this.lab30.TabIndex = 103;
            this.lab30.Text = "30";
            // 
            // lab29
            // 
            this.lab29.AutoSize = true;
            this.lab29.Location = new System.Drawing.Point(767, 356);
            this.lab29.Name = "lab29";
            this.lab29.Size = new System.Drawing.Size(19, 13);
            this.lab29.TabIndex = 102;
            this.lab29.Text = "29";
            // 
            // lab28
            // 
            this.lab28.AutoSize = true;
            this.lab28.Location = new System.Drawing.Point(767, 330);
            this.lab28.Name = "lab28";
            this.lab28.Size = new System.Drawing.Size(19, 13);
            this.lab28.TabIndex = 101;
            this.lab28.Text = "28";
            // 
            // lab27
            // 
            this.lab27.AutoSize = true;
            this.lab27.Location = new System.Drawing.Point(767, 304);
            this.lab27.Name = "lab27";
            this.lab27.Size = new System.Drawing.Size(19, 13);
            this.lab27.TabIndex = 100;
            this.lab27.Text = "27";
            // 
            // lab26
            // 
            this.lab26.AutoSize = true;
            this.lab26.Location = new System.Drawing.Point(767, 278);
            this.lab26.Name = "lab26";
            this.lab26.Size = new System.Drawing.Size(19, 13);
            this.lab26.TabIndex = 99;
            this.lab26.Text = "26";
            // 
            // lab25
            // 
            this.lab25.AutoSize = true;
            this.lab25.Location = new System.Drawing.Point(767, 252);
            this.lab25.Name = "lab25";
            this.lab25.Size = new System.Drawing.Size(19, 13);
            this.lab25.TabIndex = 98;
            this.lab25.Text = "25";
            // 
            // lab24
            // 
            this.lab24.AutoSize = true;
            this.lab24.Location = new System.Drawing.Point(767, 226);
            this.lab24.Name = "lab24";
            this.lab24.Size = new System.Drawing.Size(19, 13);
            this.lab24.TabIndex = 97;
            this.lab24.Text = "24";
            // 
            // lab23
            // 
            this.lab23.AutoSize = true;
            this.lab23.Location = new System.Drawing.Point(767, 200);
            this.lab23.Name = "lab23";
            this.lab23.Size = new System.Drawing.Size(19, 13);
            this.lab23.TabIndex = 96;
            this.lab23.Text = "23";
            // 
            // lab22
            // 
            this.lab22.AutoSize = true;
            this.lab22.Location = new System.Drawing.Point(767, 174);
            this.lab22.Name = "lab22";
            this.lab22.Size = new System.Drawing.Size(19, 13);
            this.lab22.TabIndex = 95;
            this.lab22.Text = "22";
            // 
            // lab21
            // 
            this.lab21.AutoSize = true;
            this.lab21.Location = new System.Drawing.Point(767, 148);
            this.lab21.Name = "lab21";
            this.lab21.Size = new System.Drawing.Size(19, 13);
            this.lab21.TabIndex = 94;
            this.lab21.Text = "21";
            // 
            // lab20
            // 
            this.lab20.AutoSize = true;
            this.lab20.Location = new System.Drawing.Point(767, 122);
            this.lab20.Name = "lab20";
            this.lab20.Size = new System.Drawing.Size(19, 13);
            this.lab20.TabIndex = 93;
            this.lab20.Text = "20";
            // 
            // lab19
            // 
            this.lab19.AutoSize = true;
            this.lab19.Location = new System.Drawing.Point(767, 96);
            this.lab19.Name = "lab19";
            this.lab19.Size = new System.Drawing.Size(19, 13);
            this.lab19.TabIndex = 92;
            this.lab19.Text = "19";
            // 
            // lab18
            // 
            this.lab18.AutoSize = true;
            this.lab18.Location = new System.Drawing.Point(767, 70);
            this.lab18.Name = "lab18";
            this.lab18.Size = new System.Drawing.Size(19, 13);
            this.lab18.TabIndex = 91;
            this.lab18.Text = "18";
            // 
            // lab17
            // 
            this.lab17.AutoSize = true;
            this.lab17.Location = new System.Drawing.Point(767, 44);
            this.lab17.Name = "lab17";
            this.lab17.Size = new System.Drawing.Size(19, 13);
            this.lab17.TabIndex = 90;
            this.lab17.Text = "17";
            // 
            // lab16
            // 
            this.lab16.AutoSize = true;
            this.lab16.Location = new System.Drawing.Point(334, 434);
            this.lab16.Name = "lab16";
            this.lab16.Size = new System.Drawing.Size(19, 13);
            this.lab16.TabIndex = 89;
            this.lab16.Text = "16";
            // 
            // lab15
            // 
            this.lab15.AutoSize = true;
            this.lab15.Location = new System.Drawing.Point(334, 408);
            this.lab15.Name = "lab15";
            this.lab15.Size = new System.Drawing.Size(19, 13);
            this.lab15.TabIndex = 88;
            this.lab15.Text = "15";
            // 
            // lab14
            // 
            this.lab14.AutoSize = true;
            this.lab14.Location = new System.Drawing.Point(334, 382);
            this.lab14.Name = "lab14";
            this.lab14.Size = new System.Drawing.Size(19, 13);
            this.lab14.TabIndex = 87;
            this.lab14.Text = "14";
            // 
            // lab13
            // 
            this.lab13.AutoSize = true;
            this.lab13.Location = new System.Drawing.Point(334, 356);
            this.lab13.Name = "lab13";
            this.lab13.Size = new System.Drawing.Size(19, 13);
            this.lab13.TabIndex = 86;
            this.lab13.Text = "13";
            // 
            // lab12
            // 
            this.lab12.AutoSize = true;
            this.lab12.Location = new System.Drawing.Point(334, 330);
            this.lab12.Name = "lab12";
            this.lab12.Size = new System.Drawing.Size(19, 13);
            this.lab12.TabIndex = 85;
            this.lab12.Text = "12";
            // 
            // lab11
            // 
            this.lab11.AutoSize = true;
            this.lab11.Location = new System.Drawing.Point(334, 304);
            this.lab11.Name = "lab11";
            this.lab11.Size = new System.Drawing.Size(19, 13);
            this.lab11.TabIndex = 84;
            this.lab11.Text = "11";
            // 
            // lab10
            // 
            this.lab10.AutoSize = true;
            this.lab10.Location = new System.Drawing.Point(334, 278);
            this.lab10.Name = "lab10";
            this.lab10.Size = new System.Drawing.Size(19, 13);
            this.lab10.TabIndex = 83;
            this.lab10.Text = "10";
            // 
            // lab9
            // 
            this.lab9.AutoSize = true;
            this.lab9.Location = new System.Drawing.Point(340, 252);
            this.lab9.Name = "lab9";
            this.lab9.Size = new System.Drawing.Size(13, 13);
            this.lab9.TabIndex = 82;
            this.lab9.Text = "9";
            // 
            // lab8
            // 
            this.lab8.AutoSize = true;
            this.lab8.Location = new System.Drawing.Point(340, 226);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(13, 13);
            this.lab8.TabIndex = 81;
            this.lab8.Text = "8";
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(340, 200);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(13, 13);
            this.lab7.TabIndex = 80;
            this.lab7.Text = "7";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(340, 174);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(13, 13);
            this.lab6.TabIndex = 79;
            this.lab6.Text = "6";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(340, 148);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(13, 13);
            this.lab5.TabIndex = 78;
            this.lab5.Text = "5";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(340, 122);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(13, 13);
            this.lab4.TabIndex = 77;
            this.lab4.Text = "4";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(340, 96);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(13, 13);
            this.lab3.TabIndex = 76;
            this.lab3.Text = "3";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(340, 70);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(13, 13);
            this.lab2.TabIndex = 75;
            this.lab2.Text = "2";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(596, 15);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(87, 26);
            this.label49.TabIndex = 74;
            this.label49.Text = "        Время \r\nсинхронизации:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(321, 15);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(56, 26);
            this.label48.TabIndex = 73;
            this.label48.Text = "  Номер \r\nрегистра:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(840, 15);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 13);
            this.label47.TabIndex = 72;
            this.label47.Text = "HEX";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(946, 15);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(29, 13);
            this.label46.TabIndex = 71;
            this.label46.Text = "DEC";
            // 
            // DECbox32
            // 
            this.DECbox32.Location = new System.Drawing.Point(912, 431);
            this.DECbox32.Name = "DECbox32";
            this.DECbox32.Size = new System.Drawing.Size(100, 20);
            this.DECbox32.TabIndex = 70;
            // 
            // Prinbox32
            // 
            this.Prinbox32.Location = new System.Drawing.Point(806, 431);
            this.Prinbox32.Name = "Prinbox32";
            this.Prinbox32.Size = new System.Drawing.Size(100, 20);
            this.Prinbox32.TabIndex = 69;
            // 
            // DECbox31
            // 
            this.DECbox31.Location = new System.Drawing.Point(912, 405);
            this.DECbox31.Name = "DECbox31";
            this.DECbox31.Size = new System.Drawing.Size(100, 20);
            this.DECbox31.TabIndex = 68;
            // 
            // Prinbox31
            // 
            this.Prinbox31.Location = new System.Drawing.Point(806, 405);
            this.Prinbox31.Name = "Prinbox31";
            this.Prinbox31.Size = new System.Drawing.Size(100, 20);
            this.Prinbox31.TabIndex = 67;
            // 
            // DECbox30
            // 
            this.DECbox30.Location = new System.Drawing.Point(912, 379);
            this.DECbox30.Name = "DECbox30";
            this.DECbox30.Size = new System.Drawing.Size(100, 20);
            this.DECbox30.TabIndex = 66;
            // 
            // Prinbox30
            // 
            this.Prinbox30.Location = new System.Drawing.Point(806, 379);
            this.Prinbox30.Name = "Prinbox30";
            this.Prinbox30.Size = new System.Drawing.Size(100, 20);
            this.Prinbox30.TabIndex = 65;
            // 
            // DECbox29
            // 
            this.DECbox29.Location = new System.Drawing.Point(912, 353);
            this.DECbox29.Name = "DECbox29";
            this.DECbox29.Size = new System.Drawing.Size(100, 20);
            this.DECbox29.TabIndex = 64;
            // 
            // Prinbox29
            // 
            this.Prinbox29.Location = new System.Drawing.Point(806, 353);
            this.Prinbox29.Name = "Prinbox29";
            this.Prinbox29.Size = new System.Drawing.Size(100, 20);
            this.Prinbox29.TabIndex = 63;
            // 
            // DECbox28
            // 
            this.DECbox28.Location = new System.Drawing.Point(912, 327);
            this.DECbox28.Name = "DECbox28";
            this.DECbox28.Size = new System.Drawing.Size(100, 20);
            this.DECbox28.TabIndex = 62;
            // 
            // Prinbox28
            // 
            this.Prinbox28.Location = new System.Drawing.Point(806, 327);
            this.Prinbox28.Name = "Prinbox28";
            this.Prinbox28.Size = new System.Drawing.Size(100, 20);
            this.Prinbox28.TabIndex = 61;
            // 
            // DECbox27
            // 
            this.DECbox27.Location = new System.Drawing.Point(912, 301);
            this.DECbox27.Name = "DECbox27";
            this.DECbox27.Size = new System.Drawing.Size(100, 20);
            this.DECbox27.TabIndex = 60;
            // 
            // Prinbox27
            // 
            this.Prinbox27.Location = new System.Drawing.Point(806, 301);
            this.Prinbox27.Name = "Prinbox27";
            this.Prinbox27.Size = new System.Drawing.Size(100, 20);
            this.Prinbox27.TabIndex = 59;
            // 
            // DECbox26
            // 
            this.DECbox26.Location = new System.Drawing.Point(912, 275);
            this.DECbox26.Name = "DECbox26";
            this.DECbox26.Size = new System.Drawing.Size(100, 20);
            this.DECbox26.TabIndex = 58;
            // 
            // Prinbox26
            // 
            this.Prinbox26.Location = new System.Drawing.Point(806, 275);
            this.Prinbox26.Name = "Prinbox26";
            this.Prinbox26.Size = new System.Drawing.Size(100, 20);
            this.Prinbox26.TabIndex = 57;
            // 
            // DECbox25
            // 
            this.DECbox25.Location = new System.Drawing.Point(912, 249);
            this.DECbox25.Name = "DECbox25";
            this.DECbox25.Size = new System.Drawing.Size(100, 20);
            this.DECbox25.TabIndex = 56;
            // 
            // Prinbox25
            // 
            this.Prinbox25.Location = new System.Drawing.Point(806, 249);
            this.Prinbox25.Name = "Prinbox25";
            this.Prinbox25.Size = new System.Drawing.Size(100, 20);
            this.Prinbox25.TabIndex = 55;
            // 
            // DECbox24
            // 
            this.DECbox24.Location = new System.Drawing.Point(912, 223);
            this.DECbox24.Name = "DECbox24";
            this.DECbox24.Size = new System.Drawing.Size(100, 20);
            this.DECbox24.TabIndex = 54;
            // 
            // Prinbox24
            // 
            this.Prinbox24.Location = new System.Drawing.Point(806, 223);
            this.Prinbox24.Name = "Prinbox24";
            this.Prinbox24.Size = new System.Drawing.Size(100, 20);
            this.Prinbox24.TabIndex = 53;
            // 
            // DECbox23
            // 
            this.DECbox23.Location = new System.Drawing.Point(912, 197);
            this.DECbox23.Name = "DECbox23";
            this.DECbox23.Size = new System.Drawing.Size(100, 20);
            this.DECbox23.TabIndex = 52;
            // 
            // Prinbox23
            // 
            this.Prinbox23.Location = new System.Drawing.Point(806, 197);
            this.Prinbox23.Name = "Prinbox23";
            this.Prinbox23.Size = new System.Drawing.Size(100, 20);
            this.Prinbox23.TabIndex = 51;
            // 
            // DECbox22
            // 
            this.DECbox22.Location = new System.Drawing.Point(912, 171);
            this.DECbox22.Name = "DECbox22";
            this.DECbox22.Size = new System.Drawing.Size(100, 20);
            this.DECbox22.TabIndex = 50;
            // 
            // Prinbox22
            // 
            this.Prinbox22.Location = new System.Drawing.Point(806, 171);
            this.Prinbox22.Name = "Prinbox22";
            this.Prinbox22.Size = new System.Drawing.Size(100, 20);
            this.Prinbox22.TabIndex = 49;
            // 
            // DECbox21
            // 
            this.DECbox21.Location = new System.Drawing.Point(912, 145);
            this.DECbox21.Name = "DECbox21";
            this.DECbox21.Size = new System.Drawing.Size(100, 20);
            this.DECbox21.TabIndex = 48;
            // 
            // Prinbox21
            // 
            this.Prinbox21.Location = new System.Drawing.Point(806, 145);
            this.Prinbox21.Name = "Prinbox21";
            this.Prinbox21.Size = new System.Drawing.Size(100, 20);
            this.Prinbox21.TabIndex = 47;
            // 
            // DECbox20
            // 
            this.DECbox20.Location = new System.Drawing.Point(912, 119);
            this.DECbox20.Name = "DECbox20";
            this.DECbox20.Size = new System.Drawing.Size(100, 20);
            this.DECbox20.TabIndex = 46;
            // 
            // Prinbox20
            // 
            this.Prinbox20.Location = new System.Drawing.Point(806, 119);
            this.Prinbox20.Name = "Prinbox20";
            this.Prinbox20.Size = new System.Drawing.Size(100, 20);
            this.Prinbox20.TabIndex = 45;
            // 
            // DECbox19
            // 
            this.DECbox19.Location = new System.Drawing.Point(912, 93);
            this.DECbox19.Name = "DECbox19";
            this.DECbox19.Size = new System.Drawing.Size(100, 20);
            this.DECbox19.TabIndex = 44;
            // 
            // Prinbox19
            // 
            this.Prinbox19.Location = new System.Drawing.Point(806, 93);
            this.Prinbox19.Name = "Prinbox19";
            this.Prinbox19.Size = new System.Drawing.Size(100, 20);
            this.Prinbox19.TabIndex = 43;
            // 
            // DECbox18
            // 
            this.DECbox18.Location = new System.Drawing.Point(912, 67);
            this.DECbox18.Name = "DECbox18";
            this.DECbox18.Size = new System.Drawing.Size(100, 20);
            this.DECbox18.TabIndex = 42;
            // 
            // Prinbox18
            // 
            this.Prinbox18.Location = new System.Drawing.Point(806, 67);
            this.Prinbox18.Name = "Prinbox18";
            this.Prinbox18.Size = new System.Drawing.Size(100, 20);
            this.Prinbox18.TabIndex = 41;
            // 
            // DECbox17
            // 
            this.DECbox17.Location = new System.Drawing.Point(912, 41);
            this.DECbox17.Name = "DECbox17";
            this.DECbox17.Size = new System.Drawing.Size(100, 20);
            this.DECbox17.TabIndex = 40;
            // 
            // Prinbox17
            // 
            this.Prinbox17.Location = new System.Drawing.Point(806, 41);
            this.Prinbox17.Name = "Prinbox17";
            this.Prinbox17.Size = new System.Drawing.Size(100, 20);
            this.Prinbox17.TabIndex = 39;
            // 
            // DECbox16
            // 
            this.DECbox16.Location = new System.Drawing.Point(484, 431);
            this.DECbox16.Name = "DECbox16";
            this.DECbox16.Size = new System.Drawing.Size(100, 20);
            this.DECbox16.TabIndex = 38;
            // 
            // Prinbox16
            // 
            this.Prinbox16.Location = new System.Drawing.Point(378, 431);
            this.Prinbox16.Name = "Prinbox16";
            this.Prinbox16.Size = new System.Drawing.Size(100, 20);
            this.Prinbox16.TabIndex = 37;
            // 
            // DECbox15
            // 
            this.DECbox15.Location = new System.Drawing.Point(484, 405);
            this.DECbox15.Name = "DECbox15";
            this.DECbox15.Size = new System.Drawing.Size(100, 20);
            this.DECbox15.TabIndex = 36;
            // 
            // Prinbox15
            // 
            this.Prinbox15.Location = new System.Drawing.Point(378, 405);
            this.Prinbox15.Name = "Prinbox15";
            this.Prinbox15.Size = new System.Drawing.Size(100, 20);
            this.Prinbox15.TabIndex = 35;
            // 
            // DECbox14
            // 
            this.DECbox14.Location = new System.Drawing.Point(484, 379);
            this.DECbox14.Name = "DECbox14";
            this.DECbox14.Size = new System.Drawing.Size(100, 20);
            this.DECbox14.TabIndex = 34;
            // 
            // Prinbox14
            // 
            this.Prinbox14.Location = new System.Drawing.Point(378, 379);
            this.Prinbox14.Name = "Prinbox14";
            this.Prinbox14.Size = new System.Drawing.Size(100, 20);
            this.Prinbox14.TabIndex = 33;
            // 
            // DECbox13
            // 
            this.DECbox13.Location = new System.Drawing.Point(484, 353);
            this.DECbox13.Name = "DECbox13";
            this.DECbox13.Size = new System.Drawing.Size(100, 20);
            this.DECbox13.TabIndex = 32;
            // 
            // Prinbox13
            // 
            this.Prinbox13.Location = new System.Drawing.Point(378, 353);
            this.Prinbox13.Name = "Prinbox13";
            this.Prinbox13.Size = new System.Drawing.Size(100, 20);
            this.Prinbox13.TabIndex = 31;
            // 
            // DECbox12
            // 
            this.DECbox12.Location = new System.Drawing.Point(484, 327);
            this.DECbox12.Name = "DECbox12";
            this.DECbox12.Size = new System.Drawing.Size(100, 20);
            this.DECbox12.TabIndex = 30;
            // 
            // Prinbox12
            // 
            this.Prinbox12.Location = new System.Drawing.Point(378, 327);
            this.Prinbox12.Name = "Prinbox12";
            this.Prinbox12.Size = new System.Drawing.Size(100, 20);
            this.Prinbox12.TabIndex = 29;
            // 
            // DECbox11
            // 
            this.DECbox11.Location = new System.Drawing.Point(484, 301);
            this.DECbox11.Name = "DECbox11";
            this.DECbox11.Size = new System.Drawing.Size(100, 20);
            this.DECbox11.TabIndex = 28;
            // 
            // Prinbox11
            // 
            this.Prinbox11.Location = new System.Drawing.Point(378, 301);
            this.Prinbox11.Name = "Prinbox11";
            this.Prinbox11.Size = new System.Drawing.Size(100, 20);
            this.Prinbox11.TabIndex = 27;
            // 
            // DECbox10
            // 
            this.DECbox10.Location = new System.Drawing.Point(484, 275);
            this.DECbox10.Name = "DECbox10";
            this.DECbox10.Size = new System.Drawing.Size(100, 20);
            this.DECbox10.TabIndex = 26;
            // 
            // Prinbox10
            // 
            this.Prinbox10.Location = new System.Drawing.Point(378, 275);
            this.Prinbox10.Name = "Prinbox10";
            this.Prinbox10.Size = new System.Drawing.Size(100, 20);
            this.Prinbox10.TabIndex = 25;
            // 
            // DECbox9
            // 
            this.DECbox9.Location = new System.Drawing.Point(484, 249);
            this.DECbox9.Name = "DECbox9";
            this.DECbox9.Size = new System.Drawing.Size(100, 20);
            this.DECbox9.TabIndex = 24;
            // 
            // Prinbox9
            // 
            this.Prinbox9.Location = new System.Drawing.Point(378, 249);
            this.Prinbox9.Name = "Prinbox9";
            this.Prinbox9.Size = new System.Drawing.Size(100, 20);
            this.Prinbox9.TabIndex = 23;
            // 
            // DECbox8
            // 
            this.DECbox8.Location = new System.Drawing.Point(484, 223);
            this.DECbox8.Name = "DECbox8";
            this.DECbox8.Size = new System.Drawing.Size(100, 20);
            this.DECbox8.TabIndex = 22;
            // 
            // Prinbox8
            // 
            this.Prinbox8.Location = new System.Drawing.Point(378, 223);
            this.Prinbox8.Name = "Prinbox8";
            this.Prinbox8.Size = new System.Drawing.Size(100, 20);
            this.Prinbox8.TabIndex = 21;
            // 
            // DECbox7
            // 
            this.DECbox7.Location = new System.Drawing.Point(484, 197);
            this.DECbox7.Name = "DECbox7";
            this.DECbox7.Size = new System.Drawing.Size(100, 20);
            this.DECbox7.TabIndex = 20;
            // 
            // Prinbox7
            // 
            this.Prinbox7.Location = new System.Drawing.Point(378, 197);
            this.Prinbox7.Name = "Prinbox7";
            this.Prinbox7.Size = new System.Drawing.Size(100, 20);
            this.Prinbox7.TabIndex = 19;
            // 
            // DECbox6
            // 
            this.DECbox6.Location = new System.Drawing.Point(484, 171);
            this.DECbox6.Name = "DECbox6";
            this.DECbox6.Size = new System.Drawing.Size(100, 20);
            this.DECbox6.TabIndex = 18;
            // 
            // Prinbox6
            // 
            this.Prinbox6.Location = new System.Drawing.Point(378, 171);
            this.Prinbox6.Name = "Prinbox6";
            this.Prinbox6.Size = new System.Drawing.Size(100, 20);
            this.Prinbox6.TabIndex = 17;
            // 
            // DECbox5
            // 
            this.DECbox5.Location = new System.Drawing.Point(484, 145);
            this.DECbox5.Name = "DECbox5";
            this.DECbox5.Size = new System.Drawing.Size(100, 20);
            this.DECbox5.TabIndex = 16;
            // 
            // Prinbox5
            // 
            this.Prinbox5.Location = new System.Drawing.Point(378, 145);
            this.Prinbox5.Name = "Prinbox5";
            this.Prinbox5.Size = new System.Drawing.Size(100, 20);
            this.Prinbox5.TabIndex = 15;
            // 
            // DECbox4
            // 
            this.DECbox4.Location = new System.Drawing.Point(484, 119);
            this.DECbox4.Name = "DECbox4";
            this.DECbox4.Size = new System.Drawing.Size(100, 20);
            this.DECbox4.TabIndex = 14;
            // 
            // Prinbox4
            // 
            this.Prinbox4.Location = new System.Drawing.Point(378, 119);
            this.Prinbox4.Name = "Prinbox4";
            this.Prinbox4.Size = new System.Drawing.Size(100, 20);
            this.Prinbox4.TabIndex = 13;
            // 
            // DECbox3
            // 
            this.DECbox3.Location = new System.Drawing.Point(484, 93);
            this.DECbox3.Name = "DECbox3";
            this.DECbox3.Size = new System.Drawing.Size(100, 20);
            this.DECbox3.TabIndex = 12;
            // 
            // Prinbox3
            // 
            this.Prinbox3.Location = new System.Drawing.Point(378, 93);
            this.Prinbox3.Name = "Prinbox3";
            this.Prinbox3.Size = new System.Drawing.Size(100, 20);
            this.Prinbox3.TabIndex = 11;
            // 
            // DECbox2
            // 
            this.DECbox2.Location = new System.Drawing.Point(484, 67);
            this.DECbox2.Name = "DECbox2";
            this.DECbox2.Size = new System.Drawing.Size(100, 20);
            this.DECbox2.TabIndex = 10;
            // 
            // Prinbox2
            // 
            this.Prinbox2.Location = new System.Drawing.Point(378, 67);
            this.Prinbox2.Name = "Prinbox2";
            this.Prinbox2.Size = new System.Drawing.Size(100, 20);
            this.Prinbox2.TabIndex = 9;
            // 
            // AVtime1
            // 
            this.AVtime1.AutoSize = true;
            this.AVtime1.Location = new System.Drawing.Point(606, 44);
            this.AVtime1.Name = "AVtime1";
            this.AVtime1.Size = new System.Drawing.Size(0, 13);
            this.AVtime1.TabIndex = 8;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(340, 44);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(13, 13);
            this.lab1.TabIndex = 7;
            this.lab1.Text = "1";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(517, 15);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(29, 13);
            this.label43.TabIndex = 6;
            this.label43.Text = "DEC";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(412, 15);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(29, 13);
            this.label42.TabIndex = 5;
            this.label42.Text = "HEX";
            // 
            // DECbox1
            // 
            this.DECbox1.Location = new System.Drawing.Point(484, 41);
            this.DECbox1.Name = "DECbox1";
            this.DECbox1.Size = new System.Drawing.Size(100, 20);
            this.DECbox1.TabIndex = 4;
            // 
            // Prinbox1
            // 
            this.Prinbox1.Location = new System.Drawing.Point(378, 41);
            this.Prinbox1.Name = "Prinbox1";
            this.Prinbox1.Size = new System.Drawing.Size(100, 20);
            this.Prinbox1.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1018, 15);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(87, 26);
            this.label41.TabIndex = 2;
            this.label41.Text = "        Время \r\nсинхронизации:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(752, 15);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 26);
            this.label40.TabIndex = 1;
            this.label40.Text = "  Номер \r\nрегистра:";
            // 
            // GBZaprosAV
            // 
            this.GBZaprosAV.Controls.Add(this.TBTMAV);
            this.GBZaprosAV.Controls.Add(this.RBLLAV);
            this.GBZaprosAV.Controls.Add(this.TBADAV);
            this.GBZaprosAV.Controls.Add(this.RBLHAV);
            this.GBZaprosAV.Controls.Add(this.label84);
            this.GBZaprosAV.Controls.Add(this.RBHLAV);
            this.GBZaprosAV.Controls.Add(this.label81);
            this.GBZaprosAV.Controls.Add(this.RBHHAV);
            this.GBZaprosAV.Controls.Add(this.label83);
            this.GBZaprosAV.Controls.Add(this.BTStartAV);
            this.GBZaprosAV.Controls.Add(this.label82);
            this.GBZaprosAV.Controls.Add(this.label38);
            this.GBZaprosAV.Controls.Add(this.label39);
            this.GBZaprosAV.Controls.Add(this.label37);
            this.GBZaprosAV.Controls.Add(this.TBkREGAV);
            this.GBZaprosAV.Controls.Add(this.TBREGAV);
            this.GBZaprosAV.Location = new System.Drawing.Point(13, 6);
            this.GBZaprosAV.Name = "GBZaprosAV";
            this.GBZaprosAV.Size = new System.Drawing.Size(244, 275);
            this.GBZaprosAV.TabIndex = 0;
            this.GBZaprosAV.TabStop = false;
            this.GBZaprosAV.Text = "Опрос";
            // 
            // TBTMAV
            // 
            this.TBTMAV.Location = new System.Drawing.Point(140, 147);
            this.TBTMAV.Name = "TBTMAV";
            this.TBTMAV.Size = new System.Drawing.Size(72, 20);
            this.TBTMAV.TabIndex = 106;
            this.TBTMAV.Text = "2000";
            // 
            // RBLLAV
            // 
            this.RBLLAV.AutoSize = true;
            this.RBLLAV.Location = new System.Drawing.Point(140, 251);
            this.RBLLAV.Name = "RBLLAV";
            this.RBLLAV.Size = new System.Drawing.Size(90, 17);
            this.RBLLAV.TabIndex = 109;
            this.RBLLAV.TabStop = true;
            this.RBLLAV.Text = "LL LH HL HH";
            this.RBLLAV.UseVisualStyleBackColor = true;
            // 
            // TBADAV
            // 
            this.TBADAV.Location = new System.Drawing.Point(140, 19);
            this.TBADAV.Name = "TBADAV";
            this.TBADAV.Size = new System.Drawing.Size(72, 20);
            this.TBADAV.TabIndex = 113;
            this.TBADAV.Text = "1";
            // 
            // RBLHAV
            // 
            this.RBLHAV.AutoSize = true;
            this.RBLHAV.Location = new System.Drawing.Point(140, 228);
            this.RBLHAV.Name = "RBLHAV";
            this.RBLHAV.Size = new System.Drawing.Size(90, 17);
            this.RBLHAV.TabIndex = 108;
            this.RBLHAV.TabStop = true;
            this.RBLHAV.Text = "LH LL HH HL";
            this.RBLHAV.UseVisualStyleBackColor = true;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(165, 51);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(19, 13);
            this.label84.TabIndex = 112;
            this.label84.Text = "03";
            // 
            // RBHLAV
            // 
            this.RBHLAV.AutoSize = true;
            this.RBHLAV.Location = new System.Drawing.Point(140, 205);
            this.RBHLAV.Name = "RBHLAV";
            this.RBHLAV.Size = new System.Drawing.Size(90, 17);
            this.RBHLAV.TabIndex = 107;
            this.RBHLAV.TabStop = true;
            this.RBHLAV.Text = "HL HH LL LH";
            this.RBHLAV.UseVisualStyleBackColor = true;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(218, 154);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(21, 13);
            this.label81.TabIndex = 106;
            this.label81.Text = "мс";
            // 
            // RBHHAV
            // 
            this.RBHHAV.AutoSize = true;
            this.RBHHAV.Location = new System.Drawing.Point(140, 182);
            this.RBHHAV.Name = "RBHHAV";
            this.RBHHAV.Size = new System.Drawing.Size(90, 17);
            this.RBHHAV.TabIndex = 106;
            this.RBHHAV.TabStop = true;
            this.RBHHAV.Text = "HH HL LH LL";
            this.RBHHAV.UseVisualStyleBackColor = true;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(6, 51);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(53, 13);
            this.label83.TabIndex = 111;
            this.label83.Text = "Функция";
            // 
            // BTStartAV
            // 
            this.BTStartAV.Location = new System.Drawing.Point(6, 182);
            this.BTStartAV.Name = "BTStartAV";
            this.BTStartAV.Size = new System.Drawing.Size(128, 86);
            this.BTStartAV.TabIndex = 4;
            this.BTStartAV.Text = "Начать опрос";
            this.BTStartAV.UseVisualStyleBackColor = true;
            this.BTStartAV.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(6, 22);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(38, 13);
            this.label82.TabIndex = 110;
            this.label82.Text = "Адрес";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 116);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(100, 13);
            this.label38.TabIndex = 2;
            this.label38.Text = "Конечный регистр";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 150);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(77, 13);
            this.label39.TabIndex = 3;
            this.label39.Text = "Время ответа";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 84);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(107, 13);
            this.label37.TabIndex = 1;
            this.label37.Text = "Начальный регистр";
            // 
            // TBkREGAV
            // 
            this.TBkREGAV.Location = new System.Drawing.Point(140, 113);
            this.TBkREGAV.Name = "TBkREGAV";
            this.TBkREGAV.Size = new System.Drawing.Size(72, 20);
            this.TBkREGAV.TabIndex = 2;
            this.TBkREGAV.Text = "32";
            // 
            // TBREGAV
            // 
            this.TBREGAV.Location = new System.Drawing.Point(140, 81);
            this.TBREGAV.Name = "TBREGAV";
            this.TBREGAV.Size = new System.Drawing.Size(72, 20);
            this.TBREGAV.TabIndex = 1;
            this.TBREGAV.Text = "1";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1150, 539);
            this.Controls.Add(this.TCPervStr);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Modbus v 0.2.0.15";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBPORT.ResumeLayout(false);
            this.GBPORT.PerformLayout();
            this.GBDIOLOG.ResumeLayout(false);
            this.GBDIOLOG.PerformLayout();
            this.GBSOOB.ResumeLayout(false);
            this.GBSOOB.PerformLayout();
            this.GBzapros.ResumeLayout(false);
            this.GBzapros.PerformLayout();
            this.GBzapic.ResumeLayout(false);
            this.GBzapic.PerformLayout();
            this.GBchten.ResumeLayout(false);
            this.GBchten.PerformLayout();
            this.GBBitPacet.ResumeLayout(false);
            this.GBBitPacet.PerformLayout();
            this.GBOhib.ResumeLayout(false);
            this.GBOhib.PerformLayout();
            this.TCPervStr.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GBDiolAV.ResumeLayout(false);
            this.GBDiolAV.PerformLayout();
            this.GBZaprosAV.ResumeLayout(false);
            this.GBZaprosAV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTEnd;
        private System.Windows.Forms.ComboBox CBSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTOpenport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTPEREDdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBSpeed;
        private System.Windows.Forms.ComboBox CBBTDAT;
        private System.Windows.Forms.ComboBox CBSTOPbt;
        private System.Windows.Forms.ComboBox CBOUT;
        private System.IO.Ports.SerialPort port1;
        private System.Windows.Forms.TextBox TBDiol;
        private System.Windows.Forms.Timer TIMEROPENport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTCleanDIOL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BTASCII;
        private System.Windows.Forms.RadioButton RBhex;
        private System.Windows.Forms.RadioButton RBbin;
        private System.Windows.Forms.RadioButton RBdec;
        private System.Windows.Forms.RadioButton RBchar;
        private System.Windows.Forms.Button BTStop;
        private System.Windows.Forms.GroupBox GBPORT;
        private System.Windows.Forms.GroupBox GBDIOLOG;
        private System.Windows.Forms.GroupBox GBSOOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TBCRC16;
        private System.Windows.Forms.TextBox TBFIRSTreg;
        private System.Windows.Forms.Button BTZapros;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox GBzapros;
        private System.Windows.Forms.TextBox TBADRES;
        private System.Windows.Forms.TextBox TBKOLreg;
        private System.Windows.Forms.TextBox TBFUNK;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TBdecZap;
        private System.Windows.Forms.GroupBox GBzapic;
        private System.Windows.Forms.RadioButton RBLLzap;
        private System.Windows.Forms.RadioButton RBHLzap;
        private System.Windows.Forms.RadioButton RBHHzap;
        private System.Windows.Forms.RadioButton RBLHzap;
        private System.Windows.Forms.TextBox TBhextotxZap;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TBhexZap;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox GBchten;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TBdecChten;
        private System.Windows.Forms.TextBox TBhexChten;
        private System.Windows.Forms.TextBox TBbitpac;
        private System.Windows.Forms.GroupBox GBBitPacet;
        private System.Windows.Forms.GroupBox GBOhib;
        private System.Windows.Forms.TextBox TBochkolreg;
        private System.Windows.Forms.TextBox TBochreg;
        private System.Windows.Forms.TextBox TBochlong;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TBochcrc;
        private System.Windows.Forms.TextBox TBochfunk;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton RBHLchen;
        private System.Windows.Forms.RadioButton RBHHchen;
        private System.Windows.Forms.TabControl TCPervStr;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lab32;
        private System.Windows.Forms.Label lab31;
        private System.Windows.Forms.Label lab30;
        private System.Windows.Forms.Label lab29;
        private System.Windows.Forms.Label lab28;
        private System.Windows.Forms.Label lab27;
        private System.Windows.Forms.Label lab26;
        private System.Windows.Forms.Label lab25;
        private System.Windows.Forms.Label lab24;
        private System.Windows.Forms.Label lab23;
        private System.Windows.Forms.Label lab22;
        private System.Windows.Forms.Label lab21;
        private System.Windows.Forms.Label lab20;
        private System.Windows.Forms.Label lab19;
        private System.Windows.Forms.Label lab18;
        private System.Windows.Forms.Label lab17;
        private System.Windows.Forms.Label lab16;
        private System.Windows.Forms.Label lab15;
        private System.Windows.Forms.Label lab14;
        private System.Windows.Forms.Label lab13;
        private System.Windows.Forms.Label lab12;
        private System.Windows.Forms.Label lab11;
        private System.Windows.Forms.Label lab10;
        private System.Windows.Forms.Label lab9;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox DECbox32;
        private System.Windows.Forms.TextBox Prinbox32;
        private System.Windows.Forms.TextBox DECbox31;
        private System.Windows.Forms.TextBox Prinbox31;
        private System.Windows.Forms.TextBox DECbox30;
        private System.Windows.Forms.TextBox Prinbox30;
        private System.Windows.Forms.TextBox DECbox29;
        private System.Windows.Forms.TextBox Prinbox29;
        private System.Windows.Forms.TextBox DECbox28;
        private System.Windows.Forms.TextBox Prinbox28;
        private System.Windows.Forms.TextBox DECbox27;
        private System.Windows.Forms.TextBox Prinbox27;
        private System.Windows.Forms.TextBox DECbox26;
        private System.Windows.Forms.TextBox Prinbox26;
        private System.Windows.Forms.TextBox DECbox25;
        private System.Windows.Forms.TextBox Prinbox25;
        private System.Windows.Forms.TextBox DECbox24;
        private System.Windows.Forms.TextBox Prinbox24;
        private System.Windows.Forms.TextBox DECbox23;
        private System.Windows.Forms.TextBox Prinbox23;
        private System.Windows.Forms.TextBox DECbox22;
        private System.Windows.Forms.TextBox Prinbox22;
        private System.Windows.Forms.TextBox DECbox21;
        private System.Windows.Forms.TextBox Prinbox21;
        private System.Windows.Forms.TextBox DECbox20;
        private System.Windows.Forms.TextBox Prinbox20;
        private System.Windows.Forms.TextBox DECbox19;
        private System.Windows.Forms.TextBox Prinbox19;
        private System.Windows.Forms.TextBox DECbox18;
        private System.Windows.Forms.TextBox Prinbox18;
        private System.Windows.Forms.TextBox DECbox17;
        private System.Windows.Forms.TextBox Prinbox17;
        private System.Windows.Forms.TextBox DECbox16;
        private System.Windows.Forms.TextBox Prinbox16;
        private System.Windows.Forms.TextBox DECbox15;
        private System.Windows.Forms.TextBox Prinbox15;
        private System.Windows.Forms.TextBox DECbox14;
        private System.Windows.Forms.TextBox Prinbox14;
        private System.Windows.Forms.TextBox DECbox13;
        private System.Windows.Forms.TextBox Prinbox13;
        private System.Windows.Forms.TextBox DECbox12;
        private System.Windows.Forms.TextBox Prinbox12;
        private System.Windows.Forms.TextBox DECbox11;
        private System.Windows.Forms.TextBox Prinbox11;
        private System.Windows.Forms.TextBox DECbox10;
        private System.Windows.Forms.TextBox Prinbox10;
        private System.Windows.Forms.TextBox DECbox9;
        private System.Windows.Forms.TextBox Prinbox9;
        private System.Windows.Forms.TextBox DECbox8;
        private System.Windows.Forms.TextBox Prinbox8;
        private System.Windows.Forms.TextBox DECbox7;
        private System.Windows.Forms.TextBox Prinbox7;
        private System.Windows.Forms.TextBox DECbox6;
        private System.Windows.Forms.TextBox Prinbox6;
        private System.Windows.Forms.TextBox DECbox5;
        private System.Windows.Forms.TextBox Prinbox5;
        private System.Windows.Forms.TextBox DECbox4;
        private System.Windows.Forms.TextBox Prinbox4;
        private System.Windows.Forms.TextBox DECbox3;
        private System.Windows.Forms.TextBox Prinbox3;
        private System.Windows.Forms.TextBox DECbox2;
        private System.Windows.Forms.TextBox Prinbox2;
        private System.Windows.Forms.Label AVtime1;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox DECbox1;
        private System.Windows.Forms.TextBox Prinbox1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox GBZaprosAV;
        private System.Windows.Forms.Button BTStartAV;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox TBkREGAV;
        private System.Windows.Forms.TextBox TBREGAV;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.RadioButton RBLLAV;
        public System.Windows.Forms.TextBox TBADAV;
        private System.Windows.Forms.RadioButton RBLHAV;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.RadioButton RBHLAV;
        private System.Windows.Forms.RadioButton RBHHAV;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        public System.Windows.Forms.TextBox TBTMAV;
        private System.Windows.Forms.Label AVtime32;
        private System.Windows.Forms.Label AVtime31;
        private System.Windows.Forms.Label AVtime30;
        private System.Windows.Forms.Label AVtime29;
        private System.Windows.Forms.Label AVtime28;
        private System.Windows.Forms.Label AVtime27;
        private System.Windows.Forms.Label AVtime26;
        private System.Windows.Forms.Label AVtime25;
        private System.Windows.Forms.Label AVtime24;
        private System.Windows.Forms.Label AVtime23;
        private System.Windows.Forms.Label AVtime22;
        private System.Windows.Forms.Label AVtime21;
        private System.Windows.Forms.Label AVtime20;
        private System.Windows.Forms.Label AVtime19;
        private System.Windows.Forms.Label AVtime18;
        private System.Windows.Forms.Label AVtime17;
        private System.Windows.Forms.Label AVtime16;
        private System.Windows.Forms.Label AVtime15;
        private System.Windows.Forms.Label AVtime14;
        private System.Windows.Forms.Label AVtime13;
        private System.Windows.Forms.Label AVtime12;
        private System.Windows.Forms.Label AVtime11;
        private System.Windows.Forms.Label AVtime10;
        private System.Windows.Forms.Label AVtime9;
        private System.Windows.Forms.Label AVtime8;
        private System.Windows.Forms.Label AVtime7;
        private System.Windows.Forms.Label AVtime6;
        private System.Windows.Forms.Label AVtime5;
        private System.Windows.Forms.Label AVtime4;
        private System.Windows.Forms.Label AVtime3;
        private System.Windows.Forms.Label AVtime2;
        private System.Windows.Forms.GroupBox GBDiolAV;
        private System.Windows.Forms.Button BTCleanAV;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.TextBox TBDIOLAV;
        private System.Windows.Forms.Button BTDOBcrc;
        private System.Windows.Forms.Label label45;
        public System.Windows.Forms.TextBox textBox24;
        public System.Windows.Forms.TextBox TBSoob;
        private System.Windows.Forms.Button BTAVotpr;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.RadioButton RBLLchen;
        private System.Windows.Forms.RadioButton RBLHchen;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Label labsis4;
        private System.Windows.Forms.Label labsis3;
        private System.Windows.Forms.Label labsis2;
        private System.Windows.Forms.Label labsis1;
        private System.Windows.Forms.Button button13;
    }
}

