using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace SmartClass
{
    public partial class formTest : MetroFramework.Forms.MetroForm
    {
        public formTest()
        {
            InitializeComponent();
        }

        Database dbislemleri = new Database();
        SoruObjesi donecekSoru = new SoruObjesi();


        private void formTest_Load(object sender, EventArgs e)
        {
            timersure.Stop();
            btnSinaviBitir.Visible = false;
            
        }

        public void YeniSoru()// yeni soru olusturmak icin gereken islemler
        {
            SoruGetir();
            lblSoruMetni.Text = donecekSoru.soru.Trim();
            Random rnd = new Random();
            int dogruSecenek = rnd.Next(1, 4);
            if (dogruSecenek == 1)
            {
                btnAsecenegi.Text = donecekSoru.dogruCevap;
                btnBsecenegi.Text = soruIcinSecenekGetir();
                btnCsecenegi.Text = soruIcinSecenekGetir();
                btnDsecenegi.Text = soruIcinSecenekGetir();
            }
            else if (dogruSecenek == 2)
            {
                btnAsecenegi.Text = soruIcinSecenekGetir();
                btnBsecenegi.Text = donecekSoru.dogruCevap;
                btnCsecenegi.Text = soruIcinSecenekGetir();
                btnDsecenegi.Text = soruIcinSecenekGetir();
            }
            else if (dogruSecenek == 3)
            {
                btnAsecenegi.Text = soruIcinSecenekGetir();
                btnBsecenegi.Text = soruIcinSecenekGetir();
                btnCsecenegi.Text = donecekSoru.dogruCevap;
                btnDsecenegi.Text = soruIcinSecenekGetir();
            }
            else if (dogruSecenek == 4)
            {
                btnAsecenegi.Text = soruIcinSecenekGetir();
                btnBsecenegi.Text = soruIcinSecenekGetir();
                btnCsecenegi.Text = soruIcinSecenekGetir();
                btnDsecenegi.Text = donecekSoru.dogruCevap;
            }
        }
        public SoruObjesi SoruGetir()//az bilinen soruları getirmek icin
        {
            Database dbislemleri = new Database();
            DataTable dt = new DataTable();
            string sorgu = "SELECT * FROM tblSoru WHERE kacinciOgrenme = 0 "; // konularin bilinme sayisina gore sorgu yapıyoruz
            dt = dbislemleri.VeriTablosuDondur(sorgu);
            if (dt.Rows.Count == 0)
            {
                dt = dbislemleri.VeriTablosuDondur("SELECT * FROM tblSoru where kacinciOgrenme = -1");// az bilinme sayisina gore sorgu yapıyoruz
                if (dt.Rows.Count == 0)
                {
                    dt = dbislemleri.VeriTablosuDondur("SELECT * FROM tblSoru where kacinciOgrenme = 1");// cok bilinme sayisina gore sorgu yapıyoruz
                    if (dt.Rows.Count == 0)
                    {
                        SoruObjesi soru = new SoruObjesi();
                        donecekSoru = soru;
                        return soru;
                    }
                }
            }
            Random rnd = new Random();
            int sayi = rnd.Next(0, dt.Rows.Count);
            DataRow k = dt.NewRow();
            k = dt.Rows[sayi];
            donecekSoru.soruID = Convert.ToInt32(k[0].ToString());
            donecekSoru.soru = k[1].ToString();
            donecekSoru.dogruCevap = k[2].ToString();
            donecekSoru.kacinciOgrenme = Convert.ToInt32(k[3].ToString());
            return donecekSoru;
        }

        Random rnd = new Random();
        public String soruIcinSecenekGetir()
        {
            string kelime = "";
            do
            {
                Database dbislemleri = new Database();
                DataTable dt = new DataTable();
                dt = dbislemleri.VeriTablosuDondur("SELECT dogruCevap FROM tblSoru");//cevapları dogruCevap sutununden aliyor

                int sayi = rnd.Next(0, dt.Rows.Count);
                kelime = dt.Rows[sayi][0].ToString();


            } while (kelime == donecekSoru.dogruCevap);
            return kelime;
        }


        private void timersure_Tick(object sender, EventArgs e)
        {
            int sure = int.Parse(lblSayac.Text);
            sure++;
            lblSayac.Text = sure.ToString();
            
        }

        private void btnSinavaBasla_Click(object sender, EventArgs e)
        {
            timersure.Start();
            YeniSoru();
            btnSinavaBasla.Visible = false;
            btnGeri.Enabled = false;
            btnSinaviBitir.Visible = true;

        }
        
        private void btnDsecenegi_MouseClick(object sender, MouseEventArgs e)//güncelleme ve tarih islemleri bu metodta yapılıyor
        {
            Button buton = sender as Button;
            Database dbislemleri = new Database();
            if (buton.Text == donecekSoru.dogruCevap)//dogruCevap kontrolunu saglıyor
            {
                dbislemleri.sorguCalistir("UPDATE tblSoru set dogruSayisi = (dogruSayisi + 1), ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                if (donecekSoru.kacinciOgrenme == 1)
                {
                    dbislemleri.sorguCalistir("UPDATE tblSoru set kacinciOgrenme = -2, ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                }
                else
                {
                    dbislemleri.sorguCalistir("UPDATE tblSoru set kacinciOgrenme = (kacinciOgrenme + 1), ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                }
                MessageBox.Show("Doğru Cevap");
                
            }
            else
            {
                if (donecekSoru.kacinciOgrenme != 0)
                {
                    dbislemleri.sorguCalistir("UPDATE tblSoru set kacinciOgrenme = (kacinciOgrenme - 1), ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                }
                MessageBox.Show("Yanlış Cevap");
                
            }
            YeniSoru();
        }
        public class SoruObjesi 
        {
            public int soruID { get; set; }
            public string soru { get; set; }
            public string dogruCevap { get; set; }
            public int kacinciOgrenme { get; set; }
        }


        private void pictureBoxDegis_Click(object sender, EventArgs e)
        {
            YeniSoru();
        }

        private void btnSinaviBitir_Click(object sender, EventArgs e)
        {
            timersure.Stop();
            btnSinaviBitir.Text = "TEST BİTTİ";
            btnSinaviBitir.Enabled = false;
            btnGeri.Enabled = true;

            MessageBox.Show("TESTİ BİTİRME SÜRENİZ : " + lblSayac.Text + " Saniye");

            lblSayac.Text = "0";
            lblSoruMetni.Text = "";
            btnAsecenegi.Text = "";
            btnBsecenegi.Text = "";
            btnCsecenegi.Text = "";
            btnDsecenegi.Text = "";

            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenciAna frm = new frmOgrenciAna();
            frm.ShowDialog();
            
        }
    }
}
