using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Threading;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string dataIn;
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        private int _ticks;
        private int _ticks2;
        public String c;
       public string dddd;
        string Data;
        string srt;
        byte[] by;
        string r;
        int f;
        int num;
        int n = 0;
        int y;
        byte[] regdata = new byte[4];
        string predprin = "";
        int h;
        int nymer = 23;
        float _timeouttik = 0;
        float timeout = 0;
        static string StatusText;
        string syyb;
        int prob = 0;
        string f1;
        public string fdata;
        public string СRCpochu;
        public int dopcrcshet;
        public int doppshet =0;
        public string tmot;
        public string stroka1;
        public int shet1 = 0;
        public string stroka2;
        public int shet2 = 0;

       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();


            Thread rdt = new Thread(new ThreadStart(this.ThreadTask1));
            rdt.IsBackground = true;
            rdt.Start();
            string[] ports = SerialPort.GetPortNames(); // Поиск открытых портов
            foreach (string port in ports)   // присвоим CB название этих портов 
            {
                CBSerialPort.Items.Add(port);
            }
            groupBox11.Enabled = false;   // Смена состояний кнопок 
            GBzapros.Enabled = false;
            GBDIOLOG.Enabled = false;
            GBSOOB.Enabled = false;
            label15.Enabled = false;
            GBzapic.Enabled = false;
            GBBitPacet.Enabled = false;
            GBchten.Enabled = false;
            RBchar.Checked = true;
            RBHHAV.Checked = true;
            this.BTAVotpr.ForeColor = System.Drawing.Color.Red;
            //  radioButton1.Checked = true;
            GBZaprosAV.Enabled = false;
            GBDiolAV.Enabled = false;
            BTCleanAV.Enabled = false;
           

        }

        private void comboBoxSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (port1.IsOpen == false)
            {
                port1.PortName = CBSerialPort.Text.ToString();
              //  port1.DataReceived += new SerialDataReceivedEventHandler(port1_DataReceived);
                port1.BaudRate = 9600;
                port1.WriteTimeout = 500;
                port1.ReadTimeout = 500;
            }
        }

        private void BTOpen_Click(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            timer4.Start();
            TIMEROPENport.Start();
            GBZaprosAV.Enabled = true;
            RBHHzap.Checked = true;
            RBchar.Checked = true;
            RBhex.Enabled = true;
            RBbin.Enabled = true;
            RBdec.Enabled = true;
            BTCleanDIOL.Enabled = true;
            BTStop.Enabled = true;
            GBBitPacet.Enabled = true;
            RBHHchen.Checked = true;
            GBDiolAV.Enabled = true;
            BTCleanAV.Enabled = true;

            try
            {
                port1.PortName = CBSerialPort.Text;
                port1.BaudRate = Convert.ToInt32(CBSpeed.Text);
                y = Convert.ToInt32(CBBTDAT.Text);
                if (y == 9)
                {
                    port1.DataBits = Convert.ToInt32(CBBTDAT.Text) - 1;
                }
                else
                {
                    port1.DataBits = Convert.ToInt32(CBBTDAT.Text);
                }
                port1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBSTOPbt.Text);
                port1.Parity = (Parity)Enum.Parse(typeof(Parity), CBOUT.Text);
                port1.Open();
            }
            catch (Exception err)
            {

            }

            if (CBSerialPort.Text.Trim().Length == 0)
            {
                MessageBox.Show("Выберите порт", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (port1.IsOpen)
            {
                GBDIOLOG.Enabled = true;
                GBSOOB.Enabled = true;
                GBzapros.Enabled = true;
                BTPEREDdata.Enabled = true;
                label2.Text = port1.PortName + " Порт подключен";
                label3.Text = "";
                BTOpenport.Enabled = false;
                BTClose.Enabled = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)  // Кнопка открытия порта
        {
            label10.Text = "Время сессии порта: " + _ticks.ToString() + " сек."; // Время открытие порта
            TIMEROPENport.Stop();
            if (port1.IsOpen)
            {
                BTPEREDdata.Enabled = false;
                port1.Close();
                _ticks = 0;
            }
            n = 0;
            BTStop.Text = "Пауза";
            label2.Text = "";
            label3.Text = port1.PortName + " Порт отключен";
            BTOpenport.Enabled = true;
            BTClose.Enabled = false;
            GBzapros.Enabled = false;
            GBDIOLOG.Enabled = false;
            GBSOOB.Enabled = false;
            GBZaprosAV.Enabled = false;
            GBBitPacet.Enabled = false;
            RBHHchen.Checked = false;
            RBHHzap.Checked = false;
            GBDiolAV.Enabled = false;
            BTCleanAV.Enabled = false;


        }



        private void button1_Click_2(object sender, EventArgs e)  // Передача данных 
        {
            labsis1.Text = "dec";
          //  labsis2.Text = "dec";
            labsis3.Text = "dec";
            labsis4.Text = "dec";
            if (port1.IsOpen)
            {
                TBDiol.ScrollToCaret();

                Data = TBSoob.Text + "\n";
                if (RBchar.Checked == true)  
                {
                    string data = TBSoob.Text;


                    byte[] retval = System.Text.Encoding.ASCII.GetBytes(data);


                    srt = BitConverter.ToString(retval).Replace("-", "");
                    Data = srt;
                    TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                    port1.WriteLine(Data);
                  
                }
                if (RBbin.Checked == true)
                {
                    h = Data.Length - 1;
                    if (h % 8 == 0)
                    {
                        srt = "";
                        string binary = TBSoob.Text;
                        int integer = Convert.ToInt32(binary, 2);

                        r = Convert.ToString(integer);
                        num = Int32.Parse(r);
                        srt = srt + num.ToString("x2");
                        Data = srt;
                        TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                        port1.WriteLine(Data);
                       
                    }
                    else
                    {
                        MessageBox.Show("Неверный ввод!\r\nВведите количество символов кратное 8.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                if (RBhex.Checked == true)
                {
                  //  h = Data.Length - 1;
                   // if (h % 2 == 0)
                  //  {
                        Data = TBSoob.Text;
                        srt = Data;
                        Data = srt;
                        TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                        port1.WriteLine(Data);
                    
                    //  }
                    //  else
                    //  {
                    //    MessageBox.Show("Неверный ввод!\r\nВведите четное количество символов.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //  }
                    /* if (Data.Length <= 2)
                     {
                         srt = "";
                         srt = Data;
                     }

                     else
                     {

                         srt = "";
                         for (int i = 0; i < Data.Length-1; i++)
                         {
                             if (i + 2 == Data.Length)
                             {
                                 srt = srt  + Data[i];
                                 i++;
                             }
                             else
                             {
                                 srt = srt  + Data[i]+Data[i+1];
                                 i++;
                             }


                         }

                     }*/
                }
                if (RBdec.Checked == true)
                {

                    int g = 0;
                    f = Data.Length - 1;
                    srt = "";
                    for (int i = 0; i < Data.Length; i++)
                    {
                        if ((Data[i] == ' ') | (g == f))
                        {
                            num = 0;
                            num = Int32.Parse(r);
                            if (num > 255)
                            {
                                MessageBox.Show("Неверный ввод!\r\nВведенное число превышает 255.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                r = "";
                            }
                            else
                            {
                                srt = srt + num.ToString("x2");
                                r = "";
                                g++;
                                num = 0;
                            }
                        }
                        else
                        {
                            r = r + Data[i];
                            g++;

                        }


                    }
                    if (num < 255)
                    {
                        Data = srt;
                        TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                        port1.WriteLine(Data); // отправка данных
                        
                    }



                }


            }


        }

        private void button4_Click(object sender, EventArgs e) // Очистка дивлога
        {
            TBDiol.Text = "";
        }

        int yt = 0;


        private void timer1_Tick(object sender, EventArgs e) // Таймер открытого порта 
        {
         
            // int a = Int16.Parse(FUNK.Text);
            if (TBSoob.Text != "")
            {
                groupBox11.Enabled = true;
            }
           else
            {
                groupBox11.Enabled = false;
            }
            if (port1.IsOpen)
            {
                label10.Text = "Время сессии порта: " + _ticks.ToString() + " сек.";
                _ticks++;
            }
            try
            {
                int a = Int16.Parse(TBFUNK.Text); // Перевод систем счисления 
                if (a == 10)
                {
                    label15.Enabled = true;
                  //  textBox4.Enabled = true;
                    GBzapic.Enabled = true;
                  //  radioButtonHH.Checked = true;
                }
                else
                {
                    label15.Enabled = false;
                   // textBox4.Enabled = false;
                    GBzapic.Enabled = false;
                  //  radioButtonHH.Checked = false;
                }
            }
            catch
            {
                label15.Enabled = false;
               // textBox4.Enabled = false;
                GBzapic.Enabled = false;
              //  radioButtonHH.Checked = false;
                //  label15.Enabled = true;
                // textBox4.Enabled = true;
            }
            try
            {
                if (TBdecZap.Text != "")
                {
                    int i = Convert.ToInt32(TBdecZap.Text);
                    TBhextotxZap.Text = Convert.ToString(i, 16);
                    for (int poi = 8; TBhextotxZap.Text.Length < poi; poi = 8)
                    {
                        TBhextotxZap.Text = "0" + TBhextotxZap.Text;
                    }
                    // Смена мест в зависимости от HH HL ...
                    string das = TBhextotxZap.Text;
                    TBhexZap.Text = (das[0].ToString() + das[1].ToString() + " " + das[2].ToString() + das[3].ToString() + " " + das[4].ToString() + das[5].ToString() + " " + das[6].ToString() + das[7].ToString());
                    if (RBHHzap.Checked == true)
                    {
                        TBhextotxZap.Text = (das[0].ToString() + das[1].ToString() + " " + das[2].ToString() + das[3].ToString() + " " + das[4].ToString() + das[5].ToString() + " " + das[6].ToString() + das[7].ToString());
                    }//                    1          A            2         B             3          C          4          D
                    if (RBHLzap.Checked == true)
                    {
                        TBhextotxZap.Text = (das[2].ToString() + das[3].ToString() + " " + das[0].ToString() + das[1].ToString() + " " + das[6].ToString() + das[7].ToString() + " " + das[4].ToString() + das[5].ToString()).ToString();
                    }
                    if (RBLHzap.Checked == true)
                    {
                        TBhextotxZap.Text = (das[4].ToString() + das[5].ToString() + " " + das[6].ToString() + das[7] + " " + das[0].ToString() + das[1].ToString() + " " + das[2].ToString() + das[3].ToString()).ToString();
                    }
                    if (RBLLzap.Checked == true)
                    {
                        TBhextotxZap.Text = (das[6].ToString() + das[7].ToString() + " " + das[4].ToString() + das[5].ToString() + " " + das[2].ToString() + das[3].ToString() + " " + das[0].ToString() + das[1].ToString()).ToString();
                    }
                }
                if (TBdecZap.Text == "" && TBhexZap.Text != "")
                {
                    yt++;
                 
                    if (yt % 5 == 0)
                    {
                        
                        for (int poi = 8; TBhexZap.Text.Length < poi; poi = 8)
                        { 
                        TBhexZap.Text = "0" + TBhexZap.Text;

                        }
                    }
                    string daas = TBhexZap.Text;
                    // Смена мест в зависимости от HH HL ...
                    if (RBHHzap.Checked == true)
                    {
                        
                        TBhextotxZap.Text = (daas[0].ToString() + daas[1].ToString() + " " + daas[2].ToString() + daas[3].ToString() + " " + daas[4].ToString() + daas[5].ToString() + " " + daas[6].ToString() + daas[7].ToString());
                    }//                    1          A            2         B             3          C          4          D
                    if (RBHLzap.Checked == true)
                    {
                       
                        TBhextotxZap.Text = (daas[2].ToString() + daas[3].ToString() + " " + daas[0].ToString() + daas[1].ToString() + " " + daas[6].ToString() + daas[7].ToString() + " " + daas[4].ToString() + daas[5].ToString()).ToString();
                    }
                    if (RBLHzap.Checked == true)
                    {
                       
                        TBhextotxZap.Text = (daas[4].ToString() + daas[5].ToString() + " " + daas[6].ToString() + daas[7] + " " + daas[0].ToString() + daas[1].ToString() + " " + daas[2].ToString() + daas[3].ToString()).ToString();
                    }
                    if (RBLLzap.Checked == true)
                    {
                        
                        TBhextotxZap.Text = (daas[6].ToString() + daas[7].ToString() + " " + daas[4].ToString() + daas[5].ToString() + " " + daas[2].ToString() + daas[3].ToString() + " " + daas[0].ToString() + daas[1].ToString()).ToString();
                    }
                   
                }
                
            }
            catch
            {

            }
            try
            {
                // Смена мест в зависимости от HH HL ...
                if (TBhexChten.Text != "")
                {
                    string daq = dataIn;
                    if (RBHLchen.Checked == true)
                    {
                        TBhexChten.Text = daq[6].ToString() + daq[7].ToString() + daq[8].ToString() + daq[9].ToString() + daq[10].ToString() + daq[11].ToString() + daq[12].ToString() + daq[13].ToString();
            
                    }
                    if (RBHHchen.Checked == true)
                    {
                        TBhexChten.Text = daq[8].ToString() + daq[9].ToString() + daq[6].ToString() + daq[7].ToString() + daq[12].ToString() + daq[13].ToString() + daq[10].ToString() + daq[11].ToString();



                    }
                    if (RBLHchen.Checked == true)
                    {
                        TBhexChten.Text = daq[10].ToString() + daq[11].ToString() + daq[12].ToString() + daq[13].ToString() + daq[6].ToString() + daq[7].ToString() + daq[8].ToString() + daq[9].ToString();

                    }
                    if (RBLLchen.Checked == true)
                    {
                        TBhexChten.Text = daq[12].ToString() + daq[13].ToString() + daq[10].ToString() + daq[11].ToString() + daq[8].ToString() + daq[9].ToString() + daq[6].ToString() + daq[7].ToString();
                    }

                    TBdecChten.Text = Convert.ToInt32(TBhexChten.Text, 16).ToString();
               
                }
            }
            catch
            {

            }


        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TBDiol.SelectionStart = TBDiol.Text.Length;
            TBDiol.ScrollToCaret();

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TBDiol.SelectionStart = TBDiol.Text.Length;
            TBDiol.ScrollToCaret();

        }


        private void port1_DataReceived(object sender, SerialDataReceivedEventArgs e) // Чтение данных с буфера 
        {
             Thread.Sleep(3000); // Ждем 3000 мс потом читаем 
               if (n % 2 == 0)
               {
            port1.DataReceived += new SerialDataReceivedEventHandler(port1_DataReceived);
            dataIn = port1.ReadExisting();
         //    dddd = port1.ReadLine();
            this.Invoke(new EventHandler(ShowData));
       

                }

            }
        private void ShowData(object sender, EventArgs e)
        {
            Thread.Sleep(3500);

            // 110308AE415652434049AD604C

            string daq = dataIn;
          //  TBbitpac.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [CRC OK]" + "\r\n";
         
            
                int b = 0;
                try
                {
                    if (dataIn.Length - 1 % 2 == 0)
                    {
                    TBbitpac.Text = TBbitpac.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [LENGTH ERROR]" + "\r\n";
                    TBochlong.Text = (Convert.ToInt32(TBochlong.Text) + 1).ToString();
                      
                    }
                    byte[] fata = new byte[(dataIn.Length / 2) - 2];
                    for (int i = 0; i < dataIn.Length - 4; i = i + 2)
                    {

                        fata[b] = Byte.Parse((daq[i].ToString() + daq[i + 1].ToString()), System.Globalization.NumberStyles.HexNumber);
                        b++;

                    }




                    byte[] checkSUM = new byte[2];
                    int reg = 0xFFFF;
                    for (int i = 0; i < fata.Length; i++)
                    {
                        reg ^= fata[i];
                        for (int j = 0; j < 8; j++)
                        {
                            if ((reg & 0x01) == 1)
                            {
                                reg = ((reg >> 1) ^ 0xA001);
                            }
                            else
                            {
                                reg = (reg >> 1);
                            }
                        }
                    }


                    checkSUM[1] = (byte)((reg >> 8) & 0xFF);
                    checkSUM[0] = (byte)(reg & 0xFF);


                    string INFUNK = daq[2].ToString() + daq[3].ToString();
                    string INCRC = daq[dataIn.Length - 4].ToString() + daq[dataIn.Length - 3].ToString() + daq[dataIn.Length - 2].ToString() + daq[dataIn.Length - 1].ToString();

         
                    string NAHCRC = checkSUM[1].ToString("x2") + checkSUM[0].ToString("x2");

                    if (INCRC.ToUpper() != NAHCRC.ToUpper())
                    {
                    TBbitpac.Text = TBbitpac.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [CRC ERROR]" + "\r\n";
                    TBochcrc.Text = (Convert.ToInt32(TBochcrc.Text) + 1).ToString();
                    }
                    if (INFUNK != "10" && INFUNK != "03")
                    {
                    TBbitpac.Text = TBbitpac.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [FUNK ERROR]" + "\r\n";
                    TBochfunk.Text = (Convert.ToInt32(TBochfunk.Text) + 1).ToString();
                    }

                    if (((dataIn.Length) % 2 == 0) && (INFUNK == "10" || INFUNK == "03"))
                    {
                        if (INFUNK == "10" && (INCRC.ToUpper() == NAHCRC.ToUpper()))
                        {




                        TBhexChten.Text = "";

                        TBdecChten.Text = "";

                            string INREGTEN = daq[10].ToString() + daq[11].ToString();
                            if (INREGTEN != "04")
                            {
                            TBbitpac.Text = TBbitpac.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [REG ERROR]" + "\r\n";
                            TBochreg.Text = (Convert.ToInt32(TBochreg.Text) + 1).ToString();
                            TBochkolreg.Text = (Convert.ToInt32(TBochkolreg.Text) + 1).ToString();
                            }
                            else
                            {
                            GBchten.Enabled = false;
                            TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [CRC OK]" + "\r\n";
                            }

                        }
                        if ((lok % 2 == 1))
                        {
                            predprin = "";
                        }
                        if ((lok % 2 == 1) && (INCRC.ToUpper() == NAHCRC.ToUpper()) && INFUNK == "03")
                        {

                            string prinyt = dataIn;
                        // Авто прием не верный текстбокс берет 
                            string soob = Data;
                            int glob = Int32.Parse(soob[6].ToString() + soob[7].ToString());
                            if (glob < 10)
                            {
                                syyb = soob[7].ToString();
                            }
                            else
                            {
                                syyb = soob[6].ToString() + soob[7].ToString();
                            }

                            if (prinyt != predprin && nymer <= Int32.Parse(TBkREGAV.Text))
                            {
                            TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [CRC OK]" + "\r\n";
                                if (RBHHAV.Checked == true)
                                {
                                    tabPage2.Controls["Prinbox" + syyb.ToString()].Text = prinyt[6].ToString() + prinyt[7].ToString() + prinyt[8].ToString() + prinyt[9].ToString() + prinyt[10].ToString() + prinyt[11].ToString() + prinyt[12].ToString() + prinyt[13].ToString();
                                }
                                if (RBHLAV.Checked == true)
                                {
                                    tabPage2.Controls["Prinbox" + syyb.ToString()].Text = prinyt[8].ToString() + prinyt[9].ToString() + prinyt[6].ToString() + prinyt[7].ToString() + prinyt[12].ToString() + prinyt[13].ToString() + prinyt[10].ToString() + prinyt[11].ToString();
                                }
                                if (RBLHAV.Checked == true)
                                {
                                    tabPage2.Controls["Prinbox" + syyb.ToString()].Text = prinyt[10].ToString() + prinyt[11].ToString() + prinyt[12].ToString() + prinyt[13].ToString() + prinyt[6].ToString() + prinyt[7].ToString() + prinyt[8].ToString() + prinyt[9].ToString();
                                }
                                if (RBLLAV.Checked == true)
                                {
                                    tabPage2.Controls["Prinbox" + syyb.ToString()].Text = prinyt[12].ToString() + prinyt[13].ToString() + prinyt[10].ToString() + prinyt[11].ToString() + prinyt[8].ToString() + prinyt[9].ToString() + prinyt[6].ToString() + prinyt[7].ToString();
                                }
                                
                                tabPage2.Controls["AVtime" + syyb.ToString()].Text = DateTime.Now.ToString("HH:mm:ss:ff ");
                                tabPage2.Controls["DECbox" + syyb.ToString()].Text = (Convert.ToInt32(tabPage2.Controls["Prinbox" + syyb.ToString()].Text, 16)).ToString();
                                
                                predprin = prinyt;
                                _timeouttik = 0;
                                nymer++;

                            }

                            if (nymer == Int32.Parse(TBkREGAV.Text))
                            {
                                nymer = Int32.Parse(TBREGAV.Text);
                            }

                            if (glob < 10)
                            {
                                syyb = soob[7].ToString();
                            }
                            else
                            {
                                syyb = soob[6].ToString() + soob[7].ToString();
                            }


                        }
                        else
                        {
                            nymer++;
                            if (INFUNK == "03" && (INCRC.ToUpper() == NAHCRC.ToUpper()))
                            {

                                string INREGTH = daq[4].ToString() + daq[5].ToString();
                                if (INREGTH != "04")
                                {
                                // textBox12.Text = textBox12.Text + dataIn.Length.ToString();
                                TBbitpac.Text = TBbitpac.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [REG ERROR]" + "\r\n";
                                TBochreg.Text = (Convert.ToInt32(TBochreg.Text) + 1).ToString();
                                TBochkolreg.Text = (Convert.ToInt32(TBochkolreg.Text) + 1).ToString();
                                }
                                else
                                {

                                //  asdasdasd 
                                GBchten.Enabled = true;
                                    label27.Text = DateTime.Now.ToString("HH:mm:ss:ff ");

                                TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [CRC OK]" + "\r\n";






                                    if (TBFIRSTreg.Text != "")
                                    {
                                        string regnow = TBFIRSTreg.Text;
                                        label33.Text = (Convert.ToInt32(regnow[2].ToString() + regnow[3].ToString(), 16)).ToString();
                                    }

                                    if (RBHHchen.Checked == true)
                                    {
                                    TBhexChten.Text = daq[6].ToString() + daq[7].ToString() + daq[8].ToString() + daq[9].ToString() + daq[10].ToString() + daq[11].ToString() + daq[12].ToString() + daq[13].ToString();
                                    }
                                    if (RBHLchen.Checked == true)
                                    {
                                    TBhexChten.Text = daq[8].ToString() + daq[9].ToString() + daq[6].ToString() + daq[7].ToString() + daq[12].ToString() + daq[13].ToString() + daq[10].ToString() + daq[11].ToString();
                                    }
                                    if (RBLHchen.Checked == true)
                                    {
                                    TBhexChten.Text = daq[10].ToString() + daq[11].ToString() + daq[12].ToString() + daq[13].ToString() + daq[6].ToString() + daq[7].ToString() + daq[8].ToString() + daq[9].ToString();
                                    }
                                    if (RBLLchen.Checked == true)
                                    {
                                    TBhexChten.Text = daq[12].ToString() + daq[13].ToString() + daq[10].ToString() + daq[11].ToString() + daq[8].ToString() + daq[9].ToString() + daq[6].ToString() + daq[7].ToString();
                                    }


                                TBdecChten.Text = Convert.ToInt32(TBhexChten.Text, 16).ToString();
                                }

                            }
                        }

                    }



                }
                catch
                {
                // textBox7.Text = textBox7.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [LENGTH ERROR]" + "\r\n";
                // textBox9.Text = (Convert.ToInt32(textBox9.Text) + 1).ToString();
                TBbitpac.Text = TBbitpac.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "RX: " + "\n" + dataIn + " [REG ERROR]" + "\r\n";
                }



           

        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            if (n % 2 == 0)
            {
                TBDiol.Visible = false;

            }
            else
            {
                TBDiol.Visible = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (RBchar.Checked == true)
            {

            }
            if (RBbin.Checked == true)
            {
                if (c != 49 && c != 48 && c != 8 && c != 46 && c != ',')
                {
                    e.Handled = true;
                }
            }
            if (RBhex.Checked == true)
            {
                char uppercase = char.ToUpper(c);
                if (!char.IsDigit(uppercase) && uppercase != 8 && uppercase != 46 && uppercase != ',' && !(uppercase >= 65 && uppercase <= 70))
                {
                    e.Handled = true;
                }
            }
            if (RBdec.Checked == true)
            {

                if (!char.IsDigit(c) && c != 8 && c != 46 && c != ',' && c != ' ')
                {
                    e.Handled = true;
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.SelectionStart = textBox3.Text.Length;
            textBox3.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 AS = new Form2();
            AS.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TBDiol.Visible = true;
            dataIn = " ";

            port1.Close();
            port1.Open();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (RBchar.Checked == true)
            {
                TBSoob.Text = "";
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RBbin.Checked == true)
            {
                TBSoob.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBhex.Checked == true)
            {
                TBSoob.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RBdec.Checked == true)
            {
                TBSoob.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n = n + 1;

            if (n % 2 == 0)
            {
                TBDiol.Visible = true;
                port1.Close();
                port1.Open();
                BTStop.Text = "Пауза";
            }
            else
            {
                BTStop.Text = "Старт";

            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            labsis1.Text = "hex";
            labsis2.Text = "hex";
            labsis3.Text = "hex";
            labsis4.Text = "hex";

             try
             {
                 if (TBADRES.Text != "")
                 {
                     int AD = Convert.ToInt32(TBADRES.Text);
                     TBADRES.Text = Convert.ToString(AD, 16);
                 }
               //  if (FUNK.Text != "")
               //  {
               //      int FU = Convert.ToInt32(FUNK.Text);
               //     FUNK.Text = Convert.ToString(FU, 16);
                // }
                 if (TBFIRSTreg.Text != "")
                 {
                     int FI = Convert.ToInt32(TBFIRSTreg.Text);
                     TBFIRSTreg.Text = Convert.ToString(FI, 16);
                 }
                 if (TBKOLreg.Text != "")
                 {
                     int KO = Convert.ToInt32(TBKOLreg.Text);
                     TBKOLreg.Text = Convert.ToString(KO, 16);
                 }
             }
             catch { }
            
            // ADRES.Text = Convert.ToInt32(ADRES.Text, 16).ToString();
            // FUNK.Text = Convert.ToInt32(FUNK.Text, 16).ToString();
            //  FIRSTreg.Text = Convert.ToInt32(FIRSTreg.Text, 16).ToString();
           //   KOLreg.Text = Convert.ToInt32(KOLreg.Text, 16).ToString();
            for (int i = 2; TBADRES.Text.Length < i; i = 2)
            {
                TBADRES.Text = "0" + TBADRES.Text;
            }
            for (int i = 2; TBFUNK.Text.Length < i; i = 2)
            {
                TBFUNK.Text = "0" + TBFUNK.Text;
            }
            for (int i = 4; TBFIRSTreg.Text.Length < i; i = 4)
            {
                TBFIRSTreg.Text = "0" + TBFIRSTreg.Text;
            }
            for (int i = 4; TBKOLreg.Text.Length < i; i = 4)
            {
                TBKOLreg.Text = "0" + TBKOLreg.Text;
            }


            


            if (TBADRES.Text==" " || TBFUNK.Text == " " || TBFIRSTreg.Text == " " || TBKOLreg.Text == " " )
                    
            {
                MessageBox.Show("Неверный запрос!\r\nВведите все данные.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
               {

                    //  byte[] funk10 = new byte[Int32.Parse(textBox4.Text)];
                    // byte[] fata = new byte[10];
                    int l = Int16.Parse(TBFUNK.Text);
                    if (l == 10)
                    {
                        byte a = Byte.Parse(TBADRES.Text, System.Globalization.NumberStyles.HexNumber);
                        byte b = Byte.Parse(TBFUNK.Text, System.Globalization.NumberStyles.HexNumber);
                        //byte c = Byte.Parse((Int16.Parse(FIRSTreg.Text) >> 8).ToString(), System.Globalization.NumberStyles.HexNumber);
                        byte c = Byte.Parse(TBFIRSTreg.Text, System.Globalization.NumberStyles.HexNumber);
                        var t = c >> 8;
                        byte d = Byte.Parse(TBFIRSTreg.Text, System.Globalization.NumberStyles.HexNumber);
                        // byte f = Byte.Parse((Int16.Parse(KOLreg.Text) >> 8).ToString(), System.Globalization.NumberStyles.HexNumber);
                        byte f = Byte.Parse(TBKOLreg.Text, System.Globalization.NumberStyles.HexNumber);
                        var r = f >> 8;
                        byte g = Byte.Parse(TBKOLreg.Text, System.Globalization.NumberStyles.HexNumber);
                        // fata[0] = (byte)Int16.Parse(ADRES.Text);//a
                        //  fata[1] = (byte)Int16.Parse(FUNK.Text);//b
                        //  fata[2] = (byte)(Int16.Parse(FIRSTreg.Text) >> 8);//c
                        //  fata[3] = (byte)Int16.Parse(FIRSTreg.Text);//d
                        // fata[4] = (byte)(Int16.Parse(KOLreg.Text) >> 8);//f
                        //  fata[5] = (byte)Int16.Parse(KOLreg.Text);//g
                        // byte[] fata = new byte[6] { a, b, (byte)t, d, (byte)r, g };
                        string[] split = TBhextotxZap.Text.Split(new Char[] { ' ', '=', '\n' });
                  
                    string spli1 = (split[0]).ToString(); //+ (split[2]).ToString();
                        string spli2 = split[1].ToString(); //+ split[3].ToString();
                        string spli3 = split[2].ToString();// + split[5].ToString();
                        string spli4 = split[3].ToString(); //+ split[7].ToString();
                       
                        byte o = Byte.Parse(spli1, System.Globalization.NumberStyles.HexNumber);
                        byte w = Byte.Parse(spli2, System.Globalization.NumberStyles.HexNumber);
                        byte z = Byte.Parse(spli3, System.Globalization.NumberStyles.HexNumber);
                        byte y = Byte.Parse(spli4, System.Globalization.NumberStyles.HexNumber);
                      
                        byte[] fata = new byte[11] { a, b, (byte)t, d, (byte)r, g, 04,(byte)o, (byte)w, (byte)z, (byte)y };





                        //    byte[] fata = new byte[6] {a,b, (byte)t, d, (byte)r, g  };




                        //
                        //  fata[0] = a;
                        //  fata[1] = b;
                        //  fata[2] = (byte)t;
                        //  fata[3] = d;
                        //  fata[4] = (byte)r;
                        //  fata[5] = g;
                        // funk10[1] = g;


                        byte[] checkSUM = new byte[2];
                        int reg = 0xFFFF;
                        for (int i = 0; i < fata.Length; i++)
                        {
                            reg ^= fata[i];
                            for (int j = 0; j < 8; j++)
                            {
                                if ((reg & 0x01) == 1)
                                {
                                    reg = ((reg >> 1) ^ 0xA001);
                                }
                                else
                                {
                                    reg = (reg >> 1);
                                }
                            }
                        }

                        checkSUM[1] = (byte)((reg >> 8) & 0xFF);
                        checkSUM[0] = (byte)(reg & 0xFF);

                        // CRC16.Text = reg.ToString("x2");
                        TBCRC16.Text = checkSUM[1].ToString("x2") + checkSUM[0].ToString("x2");
                        string ggd = TBhextotxZap.Text;
                         string gg = (ggd[0].ToString() + ggd[1].ToString() + ggd[3].ToString() + ggd[4].ToString() + ggd[6].ToString() + ggd[7].ToString() + ggd[9].ToString() + ggd[10].ToString()).ToString();

                        // textBox1.Text = ADRES.Text + FUNK.Text + FIRSTreg.Text + KOLreg.Text+"04"+gg.ToString() + checkSUM[0].ToString("x2") + checkSUM[1].ToString("x2");
                        TBSoob.Text = TBADRES.Text + TBFUNK.Text + TBFIRSTreg.Text + TBKOLreg.Text + "04" + gg.ToString();
                        СRCpochu = checkSUM[0].ToString("x2") + checkSUM[1].ToString("x2");
                    }
                
                    else
                    {
                        byte a = Byte.Parse(TBADRES.Text, System.Globalization.NumberStyles.HexNumber);
                        byte b = Byte.Parse(TBFUNK.Text, System.Globalization.NumberStyles.HexNumber);
                        //byte c = Byte.Parse((Int16.Parse(FIRSTreg.Text) >> 8).ToString(), System.Globalization.NumberStyles.HexNumber);
                        byte c = Byte.Parse(TBFIRSTreg.Text, System.Globalization.NumberStyles.HexNumber);
                        var t = c >> 8;
                        byte d = Byte.Parse(TBFIRSTreg.Text, System.Globalization.NumberStyles.HexNumber);
                        // byte f = Byte.Parse((Int16.Parse(KOLreg.Text) >> 8).ToString(), System.Globalization.NumberStyles.HexNumber);
                        byte f = Byte.Parse(TBKOLreg.Text, System.Globalization.NumberStyles.HexNumber);
                        var r = f >> 8;
                        byte g = Byte.Parse(TBKOLreg.Text, System.Globalization.NumberStyles.HexNumber);
                        // fata[0] = (byte)Int16.Parse(ADRES.Text);//a
                        //  fata[1] = (byte)Int16.Parse(FUNK.Text);//b
                        //  fata[2] = (byte)(Int16.Parse(FIRSTreg.Text) >> 8);//c
                        //  fata[3] = (byte)Int16.Parse(FIRSTreg.Text);//d
                        // fata[4] = (byte)(Int16.Parse(KOLreg.Text) >> 8);//f
                        //  fata[5] = (byte)Int16.Parse(KOLreg.Text);//g
                        // byte[] fata = new byte[6] { a, b, (byte)t, d, (byte)r, g };



                        byte[] fata = new byte[6] { a, b, (byte)t, d, (byte)r, g };





                        //    byte[] fata = new byte[6] {a,b, (byte)t, d, (byte)r, g  };




                        //
                        //  fata[0] = a;
                        //  fata[1] = b;
                        //  fata[2] = (byte)t;
                        //  fata[3] = d;
                        //  fata[4] = (byte)r;
                        //  fata[5] = g;
                        // funk10[1] = g;

                        byte[] checkSUM = new byte[2];
                        int reg = 0xFFFF;
                        for (int i = 0; i < fata.Length; i++)
                        {
                            reg ^= fata[i];
                            for (int j = 0; j < 8; j++)
                            {
                                if ((reg & 0x01) == 1)
                                {
                                    reg = ((reg >> 1) ^ 0xA001);
                                }
                                else
                                {
                                    reg = (reg >> 1);
                                }
                            }
                        }

                        checkSUM[1] = (byte)((reg >> 8) & 0xFF);
                        checkSUM[0] = (byte)(reg & 0xFF);

                        // CRC16.Text = reg.ToString("x2");
                        TBCRC16.Text = checkSUM[1].ToString("x2") + checkSUM[0].ToString("x2");
                      //  textBox1.Text = ADRES.Text + FUNK.Text + FIRSTreg.Text + KOLreg.Text + checkSUM[0].ToString("x2") + checkSUM[1].ToString("x2");
                        TBSoob.Text = TBADRES.Text + TBFUNK.Text + TBFIRSTreg.Text + TBKOLreg.Text;
                        СRCpochu = checkSUM[0].ToString("x2") + checkSUM[1].ToString("x2");
                    }
                }
               
                catch
                {
                    MessageBox.Show("Неверный запрос!\r\nВведенные данные слишком большие.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
          
                }



        }



        private void label8_Click(object sender, EventArgs e)
        {

        }



        
            private void label16_Click(object sender, EventArgs e)
        {

        }
        int tik = 3;
        private void timer3_Tick(object sender, EventArgs e)
        {
             _timeouttik++;
            Thread.Sleep(1000);
            if (_timeouttik == timeout )
            {
                _timeouttik = 0;
            }

           



        }
        public delegate void MyDelegate(Label myControl, string myArg2);
        int lok = 0;
        private void button8_Click_1(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>() { lab1, lab2, lab3, lab4, lab5, lab6,
lab7, lab8, lab9, lab10, lab11, lab12, lab13, lab14, lab15, lab16, lab17, lab18, lab19, lab20, lab21,
                lab22 , lab23, lab24, lab25, lab26, lab27, lab28, lab29, lab30, lab31, lab32};
            int nahregin = Int32.Parse( TBREGAV.Text );
            
            for (int i =0; i < 32; i++)
            {
                labels[i].Text = nahregin.ToString();
                nahregin++;
            }
            timer6.Start();
           // timer4.Start();
            _timeouttik = 0;
           nymer = (Int32.Parse(TBREGAV.Text));
            // textBox23.Text = dataIn.ToString();
            lok++;
            if (lok % 2 == 1)
            {
                timer3.Start();
                BTStartAV.Text = "Закончить опрос";
                shet2 = 1;
            }
            else
            {
                timer3.Stop();
                BTStartAV.Text = "Начать опрос";
            }
            // string fasd = textBox87.Text;
            Data = "";
            timeout = (float)(Int32.Parse(TBTMAV.Text))/1000;
          //  textBox80.Text = timeout.ToString();
        }

     
      
        private void ThreadTask() // Новый поток для авто запросов 
        {
            // int haf = Int32.Parse(comboBox5.Text);
            // Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            //  trd.IsBackground = true;
            // trd.Start();
           // string fasd = textBox87.Text;
            for (; ; )
            {
                
                if (lok % 2 == 1)
                {
                   // Data = "2";

                   // port1.WriteLine(Data);
                    for (int regnum = Int32.Parse(TBREGAV.Text); regnum <= Int32.Parse(TBkREGAV.Text); regnum++)
                    {
                        if (lok % 2 == 1)
                        {
                            string adres = TBADAV.Text;
                            if (adres.Length-1<1)
                            {
                                adres = "0" + adres;
                            }
                            string timeoutr = TBTMAV.Text;
                            if (regnum < 10)
                            {
                                string sumreg = "0" + regnum.ToString();
                                byte a = Byte.Parse(adres, System.Globalization.NumberStyles.HexNumber);
                                byte s = Byte.Parse("03", System.Globalization.NumberStyles.HexNumber);
                                byte d = Byte.Parse("00", System.Globalization.NumberStyles.HexNumber);
                                byte f = Byte.Parse("00", System.Globalization.NumberStyles.HexNumber);
                                byte g = Byte.Parse("02", System.Globalization.NumberStyles.HexNumber);

                                byte[] fata = new byte[6] { a, s, d, (byte)(Int32.Parse(sumreg)), f, g };
                              
                                byte[] checkSUM = new byte[2];
                                int reg = 0xFFFF;
                                for (int i = 0; i < fata.Length; i++)
                                {
                                    reg ^= fata[i];
                                    for (int j = 0; j < 8; j++)
                                    {
                                        if ((reg & 0x01) == 1)
                                        {
                                            reg = ((reg >> 1) ^ 0xA001);
                                        }
                                        else
                                        {
                                            reg = (reg >> 1);
                                        }
                                    }
                                }

                                checkSUM[1] = (byte)((reg >> 8) & 0xFF);
                                checkSUM[0] = (byte)(reg & 0xFF);

                               
                                string CRCGG = checkSUM[1].ToString("x2") + checkSUM[0].ToString("x2");
                                 Data = adres + "0300" + sumreg.ToString() + "0002" + checkSUM[0].ToString("x2") + checkSUM[1].ToString("x2");
                                //textBox23.Text = textBox23.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                                fdata = DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                                port1.WriteLine(Data);
                              
                                shet2++;
                               // textBox23.Text = fdata;
                                Thread.Sleep(Int32.Parse(timeoutr));
                            }
                            else
                            {
                                byte a = Byte.Parse(adres, System.Globalization.NumberStyles.HexNumber);
                                byte s = Byte.Parse("03", System.Globalization.NumberStyles.HexNumber);
                                byte d = Byte.Parse("00", System.Globalization.NumberStyles.HexNumber);
                                byte f = Byte.Parse("00", System.Globalization.NumberStyles.HexNumber);
                                byte g = Byte.Parse("02", System.Globalization.NumberStyles.HexNumber);
                                byte[] fata = new byte[6] { a, s, d, (byte)regnum, f, g};
                                byte[] checkSUM = new byte[2];
                                int reg = 0xFFFF;
                                for (int i = 0; i < fata.Length; i++)
                                {
                                    reg ^= fata[i];
                                    for (int j = 0; j < 8; j++)
                                    {
                                        if ((reg & 0x01) == 1)
                                        {
                                            reg = ((reg >> 1) ^ 0xA001);
                                        }
                                        else
                                        {
                                            reg = (reg >> 1);
                                        }
                                    }
                                }

                                checkSUM[1] = (byte)((reg >> 8) & 0xFF);
                                checkSUM[0] = (byte)(reg & 0xFF);

                                
                                string CRCGG = checkSUM[1].ToString("x2") + checkSUM[0].ToString("x2");
                                Data = adres+ "0300" + regnum.ToString() + "0002" + checkSUM[1].ToString("x2") + checkSUM[0].ToString("x2");
                                fdata = DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                                shet2++;
                                port1.WriteLine(Data);
                             

                                Thread.Sleep(Int32.Parse(timeoutr));
                            }
                        }
                    }
                }
            }
        }
        
        private void timer4_Tick(object sender, EventArgs e)
        {
           
            dopcrcshet++;
           // Thread.Sleep(4000);
            if ( dopcrcshet == 15)
            {
                BTDOBcrc.Enabled = true;
                dopcrcshet = 20;
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TBDIOLAV.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer4.Start();

            string fgas = TBCRC16.Text.ToUpper();
                TBSoob.Text = (TBSoob.Text +fgas[2].ToString()+fgas[3].ToString()+fgas[0].ToString()+fgas[1].ToString()).ToUpper();
            
                BTDOBcrc.Enabled = false;
                dopcrcshet = 0;
            

        }
        private void ThreadTask1()
        {
           // string tmot = textBox24.Text;
            for (; ; )
            {

                try
                {
                    tmot = textBox24.Text;
                }
                catch { }
                if (doppshet % 2 == 1)
                {



                    if (port1.IsOpen)
                    {
                      //  textBox2.ScrollToCaret();

                        Data = TBSoob.Text + "\n";
                        if (RBchar.Checked == true)
                        {
                            string data = TBSoob.Text;


                            byte[] retval = System.Text.Encoding.ASCII.GetBytes(data);


                            srt = BitConverter.ToString(retval).Replace("-", "");
                            Data = srt;
                           // textBox2.Text = textBox2.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                            port1.WriteLine(Data);
                            
                            shet1++;
                        }
                        if (RBbin.Checked == true)
                        {
                            h = Data.Length - 1;
                            if (h % 8 == 0)
                            {
                                srt = "";
                                string binary = TBSoob.Text;
                                int integer = Convert.ToInt32(binary, 2);

                                r = Convert.ToString(integer);
                                num = Int32.Parse(r);
                                srt = srt + num.ToString("x2");
                                Data = srt;
                              //  textBox2.Text = textBox2.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                                port1.WriteLine(Data);
                              
                                shet1++;
                            }
                            else
                            {
                              
                                // MessageBox.Show("Неверный ввод!\r\nВведите количество символов кратное 8.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        if (RBhex.Checked == true)
                        {
                            //  h = Data.Length - 1;
                            // if (h % 2 == 0)
                            //  {
                            Data = TBSoob.Text;
                            srt = Data;
                            Data = srt;
                           // textBox2.Text = textBox2.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                            port1.WriteLine(Data);
                           
                            shet1++;

                        }
                        if (RBdec.Checked == true)
                        {

                            int g = 0;
                            f = Data.Length - 1;
                            srt = "";
                            for (int i = 0; i < Data.Length; i++)
                            {
                                if ((Data[i] == ' ') | (g == f))
                                {
                                    num = 0;
                                    num = Int32.Parse(r);
                                    if (num > 255)
                                    {
                                        MessageBox.Show("Неверный ввод!\r\nВведенное число превышает 255.", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        r = "";
                                    }
                                    else
                                    {
                                        srt = srt + num.ToString("x2");
                                        r = "";
                                        g++;
                                        num = 0;
                                    }
                                }
                                else
                                {
                                    r = r + Data[i];
                                    g++;

                                }


                            }
                            if (num < 255)
                            {
                                Data = srt;
                              //  textBox2.Text = textBox2.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + Data + "\r\n";
                                port1.WriteLine(Data);
                             
                                shet1++;
                            }



                        }


                    }

                    Thread.Sleep(Int32.Parse(tmot));

                }















/*
                try
                {
                    tmot = textBox24.Text;
                }
                catch { }
                if (doppshet % 2 == 1)
                    {
                        Data = textBox1.Text;
                        port1.WriteLine(Data);
                        Thread.Sleep(Int32.Parse(tmot));

                    }
               // Thread.Sleep(Int32.Parse(tmot));
*/
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if (doppshet % 2 == 0)
            {
                this.BTAVotpr.ForeColor = System.Drawing.Color.Green;
                BTAVotpr.Text = "Вкл";
                timer5.Start();
                shet1=1;
            }
            else
            {
                this.BTAVotpr.ForeColor = System.Drawing.Color.Red;
                BTAVotpr.Text = "Выкл";
                timer5.Stop();
            }
            doppshet++;

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
           // textBox7.Text = shet1.ToString();
            if ((shet1 %2 == 0) )
            {
                TBDiol.Text = TBDiol.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + TBSoob.Text + "\r\n";
                shet1++;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if ((shet2 % 2 == 0))
            {
                TBDIOLAV.Text = TBDIOLAV.Text + DateTime.Now.ToString("HH:mm:ss:ff ") + "TX: " + fdata;
                shet2++;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Data = "0303001A0002E42E";
            port1.WriteLine(Data);
            TBDiol.Text = Data;
        }

        
    }

    //110304022B56521F21    - ошибка 
    //110304022B56521F24
    //110304022B5653DFE5




}












