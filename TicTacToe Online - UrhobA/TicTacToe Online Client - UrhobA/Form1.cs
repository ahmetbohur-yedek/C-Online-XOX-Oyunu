using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Online_Client___UrhobA
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void ciktilar_TextChanged(object sender, EventArgs e)
        {

        }

        private void baslat_durdur_button_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(hostIP.Text);
            client.Connect(hostIP.Text, Convert.ToInt32(hostPort.Text));
            //client.WriteLineAndGetReply("client_id = " + kullanici_adi.Text, TimeSpan.FromSeconds(1));
            baglan_button.Enabled = false;
        }

        private void urhoba_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.urhoba.net");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;

        }

        public char karakter;
        public string[] parcalar;

        public void BittimiKontrol(SimpleTCP.Message e)
        {
            if (e.MessageString.Contains("Kazandı"))
            {
                button1.Invoke((MethodInvoker)delegate ()
                {
                    button1.Text = "";
                });

                button2.Invoke((MethodInvoker)delegate ()
                {
                    button2.Text = "";
                });

                button3.Invoke((MethodInvoker)delegate ()
                {
                    button3.Text = "";
                });

                button4.Invoke((MethodInvoker)delegate ()
                {
                    button4.Text = "";
                });

                button5.Invoke((MethodInvoker)delegate ()
                {
                    button5.Text = "";
                });

                button6.Invoke((MethodInvoker)delegate ()
                {
                    button6.Text = "";
                });

                button7.Invoke((MethodInvoker)delegate ()
                {
                    button7.Text = "";
                });

                button8.Invoke((MethodInvoker)delegate ()
                {
                    button8.Text = "";
                });

                button9.Invoke((MethodInvoker)delegate ()
                {
                    button9.Text = "";
                });

                client.Disconnect();
                baglan_button.Invoke((MethodInvoker)delegate (){
                    baglan_button.Enabled = true;
                });
            }
            else
            {
                SiraKimde(e);
            }
        }
        public void SiraKimde(SimpleTCP.Message e)
        {
            int sayac = 0;
            string gelenKelime = e.MessageString.ToLower();

            if (gelenKelime.Contains("sıra sende"))
            {
                if (gelenKelime.Contains("sıra sende:x"))
                    karakter = 'x';
                else
                    karakter = 'o';

                parcalar = gelenKelime.Split(',',':');

                if (gelenKelime.Contains("buton1:nan"))
                {
                    button1.Invoke((MethodInvoker)delegate ()
                    {
                        button1.Enabled = true;
                    });
                }
                else
                {
                    button1.Invoke((MethodInvoker)delegate ()
                    {
                        button1.Text = parcalar[6];
                        sayac++;
                    });
                }
                if (gelenKelime.Contains("buton2:nan"))
                {
                    button2.Invoke((MethodInvoker)delegate ()
                {
                    button2.Enabled = true;
                });
                }
                else
                {
                    button2.Invoke((MethodInvoker)delegate ()
                    {
                        button2.Text = parcalar[8];
                        sayac++;

                    });
                }
                if (gelenKelime.Contains("buton3:nan"))
                {
                    button3.Invoke((MethodInvoker)delegate ()
                {
                    button3.Enabled = true;
                });
                }
                else
                {
                    button3.Invoke((MethodInvoker)delegate ()
                    {
                        button3.Text = parcalar[10];
                        sayac++;

                    });
                }
                if (gelenKelime.Contains("buton4:nan"))
                {
                    button4.Invoke((MethodInvoker)delegate ()
                {
                    button4.Enabled = true;
                });
                }
                else
                {
                    button4.Invoke((MethodInvoker)delegate ()
                    {
                        button4.Text = parcalar[12];
                        sayac++;

                    });
                }
                if (gelenKelime.Contains("buton5:nan"))
                {
                    button5.Invoke((MethodInvoker)delegate ()
                {
                    button5.Enabled = true;
                });
                }
                else
                {
                    button5.Invoke((MethodInvoker)delegate ()
                    {
                        button5.Text = parcalar[14];
                        sayac++;

                    });
                }
                if (gelenKelime.Contains("buton6:nan"))
                {
                    button6.Invoke((MethodInvoker)delegate ()
                {
                    button6.Enabled = true;
                });
                }
                else
                {
                    button6.Invoke((MethodInvoker)delegate ()
                    {
                        button6.Text = parcalar[16];
                        sayac++;

                    });
                }
                if (gelenKelime.Contains("buton7:nan"))
                {
                    button7.Invoke((MethodInvoker)delegate ()
                {
                    button7.Enabled = true;
                });
                }
                else
                {
                    button7.Invoke((MethodInvoker)delegate ()
                    {
                        button7.Text = parcalar[18];
                        sayac++;

                    });
                }
                if (gelenKelime.Contains("buton8:nan"))
                {
                    button8.Invoke((MethodInvoker)delegate ()
                {
                    button8.Enabled = true;
                });
                }
                else
                {
                    button8.Invoke((MethodInvoker)delegate ()
                    {
                        button8.Text = parcalar[20];
                        sayac++;

                    });
                }
                if (gelenKelime.Contains("buton9:nan"))
                {
                    button9.Invoke((MethodInvoker)delegate ()
                {
                    button9.Enabled = true;
                });
                }
                else
                {
                    button9.Invoke((MethodInvoker)delegate ()
                    {
                        button9.Text = parcalar[22];
                        sayac++;

                    });
                }

                if(sayac == 9)
                {
                    button1.Invoke((MethodInvoker)delegate ()
                    {
                        button1.Text = "";
                    });

                    button2.Invoke((MethodInvoker)delegate ()
                    {
                        button2.Text = "";
                    });

                    button3.Invoke((MethodInvoker)delegate ()
                    {
                        button3.Text = "";
                    });

                    button4.Invoke((MethodInvoker)delegate ()
                    {
                        button4.Text = "";
                    });

                    button5.Invoke((MethodInvoker)delegate ()
                    {
                        button5.Text = "";
                    });

                    button6.Invoke((MethodInvoker)delegate ()
                    {
                        button6.Text = "";
                    });

                    button7.Invoke((MethodInvoker)delegate ()
                    {
                        button7.Text = "";
                    });

                    button8.Invoke((MethodInvoker)delegate ()
                    {
                        button8.Text = "";
                    });

                    button9.Invoke((MethodInvoker)delegate ()
                    {
                        button9.Text = "";
                    });

                    ciktilar.Invoke((MethodInvoker)delegate ()
                    {
                        ciktilar.Text = "Oyun berabere bitti!";
                    });
                    client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:0,Karakter:" + karakter, TimeSpan.FromSeconds(1));
                    client.Disconnect();
                    baglan_button.Invoke((MethodInvoker)delegate () {
                        baglan_button.Enabled = true;
                    });
                }

            }

        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            BittimiKontrol(e);
            ciktilar.Invoke((MethodInvoker)delegate ()
            {
                ciktilar.Text += e.MessageString;

            });
        }

        private void gonder_button_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kullanici_adi_TextChanged(object sender, EventArgs e)
        {

        }

        void ButonlariKapat()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button1.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:"+parcalar[1]+",Buton:1,Karakter:"+karakter, TimeSpan.FromSeconds(1));
            
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            ButonlariKapat();
            button2.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:2,Karakter:" + karakter, TimeSpan.FromSeconds(1));
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button3.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:3,Karakter:" + karakter, TimeSpan.FromSeconds(1));
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button4.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:4,Karakter:" + karakter, TimeSpan.FromSeconds(1));
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button5.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:5,Karakter:" + karakter, TimeSpan.FromSeconds(1));
            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button6.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:6,Karakter:" + karakter, TimeSpan.FromSeconds(1));
            


        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button7.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:7,Karakter:" + karakter, TimeSpan.FromSeconds(1));
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button8.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:8,Karakter:" + karakter, TimeSpan.FromSeconds(1));
            


        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButonlariKapat();
            button9.Text = karakter.ToString();
            client.WriteLineAndGetReply("\nOda:" + parcalar[1] + ",Buton:9,Karakter:" + karakter, TimeSpan.FromSeconds(1));
            


        }
    }
}
