using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Online_Server___UrhobA
{
    public partial class Form1 : Form
    {

        public int odaSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;


        private void baslat_durdur_button_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                ciktilar.Text = "Server durduruluyor.";
                //bagliclientsayisi.Enabled = false;
                server.StringEncoder = Encoding.UTF8;
                server.Broadcast("Sunucu kapatıldığı için bütün maçlar iptal edilmiştir.");
                server.Stop();
                baslat_durdur_button.Text = "Başlat";
                ciktilar.Text = "Server durduruldu.";
            }
            else
            {

                ciktilar.Text = "www.urhoba.net \n" +
                    "Server başlatılıyor.. \n";
                try
                {
                    // bagliclientsayisi.Enabled = true;
                    System.Net.IPAddress ip = System.Net.IPAddress.Parse(hostIP.Text);
                    server.Start(ip, Convert.ToInt32(hostPort.Text));
                    baslat_durdur_button.Text = "Durdur";
                    ciktilar.Text += "Server başlatıldı.";
                }
                catch (Exception)
                {
                    ciktilar.Text += "Server başlatılırken bir hata ile karşılaştık.";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.Default;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;

        }




        private void Server_ClientDisconnected(object sender, System.Net.Sockets.TcpClient e)
        {
            clientler.Invoke((MethodInvoker)delegate ()
            {

                clientler.Items.Remove(e.Client.RemoteEndPoint.ToString());

            });
        }


        public List<Odalar> odalar = new List<Odalar>();


        public void OyunBaslat(int gecerliOda)
        {
            Byte[] sendBytes = Encoding.UTF8.GetBytes("Oda:" + gecerliOda + ",\nSıra Sende:x,\nKalan Hamleler:" + odalar[gecerliOda].hamleler);
            odalar[gecerliOda].oyuncu1.GetStream().Write(sendBytes, 0, sendBytes.Length);
        }

        public void OdaKontrol(System.Net.Sockets.TcpClient e)
        {
            if (server.ConnectedClientsCount % 2 == 0)
            {
                odalar[odaSayisi].oyuncuSayisi = 2;
                odalar[odaSayisi].oyuncu2 = e;
                Byte[] sendBytes = Encoding.UTF8.GetBytes(odalar[odaSayisi].odaNumarasi.ToString() + " Numaralı odaya sistem tarafından eklendiniz.\n" +
                    "Odadaki ikinci oyuncu sizsiniz bu yüzden O olarak oyuna devam edeceksiniz.\n");
                e.GetStream().Write(sendBytes, 0, sendBytes.Length);
                OyunBaslat(odaSayisi);
                odaSayisi++;

            }
            else
            {
                odalar.Add(new Odalar() { odaNumarasi = odaSayisi, oyuncuSayisi = 1, oyuncu1 = e, });
                Byte[] sendBytes = Encoding.UTF8.GetBytes(odalar[odaSayisi].odaNumarasi.ToString() + " Numaralı odaya sistem tarafından eklendiniz.\n" +
                    "Odadaki ilk oyuncu sizsiniz bu yüzden X olarak oyuna ilk siz başlayacaksınız.\n" +
                    "Diğer oyuncunun girmesi bekleniyor.\n");

                e.GetStream().Write(sendBytes, 0, sendBytes.Length);
            }
        }

        public void Server_ClientConnected(object sender, System.Net.Sockets.TcpClient e)
        {
            clientler.Invoke((MethodInvoker)delegate ()
            {
                clientler.Items.Add(e.Client.RemoteEndPoint.ToString());
                Byte[] sendBytes = Encoding.UTF8.GetBytes("Sunucuya sorunsuz bir şekilde bağlandın. \n");
                e.GetStream().Write(sendBytes, 0, sendBytes.Length);
            });

            OdaKontrol(e);
        }

        public void KazananKontrol(SimpleTCP.Message e, ref string sonuc)
        {
            sonuc = " ";
            string[] gelenParcala;
            gelenParcala = e.MessageString.Split(',', ':');
            string hamleler = odalar[Convert.ToInt32(gelenParcala[1])].hamleler;
            string[] hamlelerParcala = hamleler.Split(',', ':');         
                if (hamlelerParcala[1].Contains("x") & hamlelerParcala[3].Contains("x") & hamlelerParcala[5].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[1].Contains("x") & hamlelerParcala[9].Contains("x") & hamlelerParcala[17].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[1].Contains("x") & hamlelerParcala[7].Contains("x") & hamlelerParcala[13].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[3].Contains("x") & hamlelerParcala[9].Contains("x") & hamlelerParcala[15].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[5].Contains("x") & hamlelerParcala[9].Contains("x") & hamlelerParcala[13].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[5].Contains("x") & hamlelerParcala[11].Contains("x") & hamlelerParcala[17].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[7].Contains("x") & hamlelerParcala[9].Contains("x") & hamlelerParcala[11].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[13].Contains("x") & hamlelerParcala[15].Contains("x") & hamlelerParcala[17].Contains("x"))
                    sonuc = "X Kazandı";
                if (hamlelerParcala[1].Contains("o") & hamlelerParcala[3].Contains("o") & hamlelerParcala[5].Contains("o"))
                    sonuc = "o Kazandı";
                if (hamlelerParcala[1].Contains("o") & hamlelerParcala[9].Contains("o") & hamlelerParcala[17].Contains("o"))
                    sonuc = "o Kazandı";
                if (hamlelerParcala[1].Contains("o") & hamlelerParcala[7].Contains("o") & hamlelerParcala[13].Contains("o"))
                    sonuc = "o Kazandı";
                if (hamlelerParcala[3].Contains("o") & hamlelerParcala[9].Contains("o") & hamlelerParcala[15].Contains("o"))
                    sonuc = "o Kazandı";
                if (hamlelerParcala[5].Contains("o") & hamlelerParcala[9].Contains("o") & hamlelerParcala[13].Contains("o"))
                    sonuc = "o Kazandı";
                if (hamlelerParcala[5].Contains("o") & hamlelerParcala[11].Contains("o") & hamlelerParcala[17].Contains("o"))
                    sonuc = "o Kazandı";
                if (hamlelerParcala[7].Contains("o") & hamlelerParcala[9].Contains("o") & hamlelerParcala[11].Contains("o"))
                    sonuc = "o Kazandı";
                if (hamlelerParcala[13].Contains("o") & hamlelerParcala[15].Contains("o") & hamlelerParcala[17].Contains("o"))
                    sonuc = "o Kazandı";
            


        }
        public void KullaniciDegistir(SimpleTCP.Message e)
        {
            string[] gelenParcala;
            gelenParcala = e.MessageString.Split(',', ':');
            string kazanankontrol = "";

            if (gelenParcala[5].Contains('o'))
            {
                string hamleler = odalar[Convert.ToInt32(gelenParcala[1])].hamleler.Replace("buton" + gelenParcala[3] + ":NaN", "buton" + gelenParcala[3] + ":o");
                odalar[Convert.ToInt32(gelenParcala[1])].hamleler = hamleler;
                KazananKontrol(e, ref kazanankontrol);
                if (kazanankontrol == " ")
                {
                    Byte[] sendBytes = Encoding.UTF8.GetBytes("Oda:" + gelenParcala[1] + ",\nSıra Sende:x,\nKalan Hamleler:" + odalar[Convert.ToInt32(gelenParcala[1])].hamleler);
                    odalar[Convert.ToInt32(gelenParcala[1])].oyuncu1.GetStream().Write(sendBytes, 0, sendBytes.Length);
                }
                else
                {
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(kazanankontrol);
                    odalar[Convert.ToInt32(gelenParcala[1])].oyuncu1.GetStream().Write(sendBytes, 0, sendBytes.Length);
                    odalar[Convert.ToInt32(gelenParcala[1])].oyuncu2.GetStream().Write(sendBytes, 0, sendBytes.Length);

                }


            }
            else
            {

                string hamleler = odalar[Convert.ToInt32(gelenParcala[1])].hamleler.Replace("buton" + gelenParcala[3] + ":NaN", "buton" + gelenParcala[3] + ":x");
                odalar[Convert.ToInt32(gelenParcala[1])].hamleler = hamleler;
                KazananKontrol(e, ref kazanankontrol);
                if (kazanankontrol == " ")
                {                    
                    Byte[] sendBytes = Encoding.UTF8.GetBytes("Oda:" + gelenParcala[1] + ",\nSıra Sende:o,\nKalan Hamleler:" + odalar[Convert.ToInt32(gelenParcala[1])].hamleler);
                    odalar[Convert.ToInt32(gelenParcala[1])].oyuncu2.GetStream().Write(sendBytes, 0, sendBytes.Length);
                }
                else
                {
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(kazanankontrol);
                    odalar[Convert.ToInt32(gelenParcala[1])].oyuncu1.GetStream().Write(sendBytes, 0, sendBytes.Length);
                    odalar[Convert.ToInt32(gelenParcala[1])].oyuncu2.GetStream().Write(sendBytes, 0, sendBytes.Length);

                }
            }

        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            ciktilar.Invoke((MethodInvoker)delegate ()
            {
                ciktilar.Text += e.MessageString + "\n";
                e.ReplyLine(e.MessageString + "\n");
            });
            KullaniciDegistir(e);
        }

        private void urhoba_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.urhoba.net");

        }

    }

    public class Odalar
    {
        public int odaNumarasi;
        public int oyuncuSayisi;
        public System.Net.Sockets.TcpClient oyuncu1;
        public System.Net.Sockets.TcpClient oyuncu2;
        public string hamleler = "buton1:NaN,buton2:NaN,buton3:NaN,buton4:NaN,buton5:NaN,buton6:NaN,buton7:NaN,buton8:NaN,buton9:NaN";
    }
}
