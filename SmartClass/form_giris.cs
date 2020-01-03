using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace SmartClass
{
    public partial class form_giris : MetroForm
    {
        public form_giris()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;" +
            "Trusted_Connection=True;");

        public string test;

        private void btnKayit_Click(object sender, EventArgs e)
        {
            this.Hide();

            form_kayit formkayit = new form_kayit();

            formkayit.ShowDialog();
        }

        private void form_giris_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult giriskapanis = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);

        }

        private void btnOgretmenSayfa_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmÖgretmenGiris frmOgretmen = new frmÖgretmenGiris();

            frmOgretmen.ShowDialog();
            
        }

        public bool Giris(string user, string pass)// giris islemini  yapacak olan method
        {
            
            SqlCommand kmt = new SqlCommand("Select * from tblOgrenci Where KullaniciAdi=@adi and KullaniciParola=@pass", connect);
            kmt.Parameters.AddWithValue("@adi", user);
            kmt.Parameters.AddWithValue("@pass", pass);

            
            
            SqlDataReader oku = kmt.ExecuteReader();

            if (oku.Read())
            {
                
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            connect.Open();
            bool girisislemi = Giris(txtbxAdi.Text, txtbxParola.Text);
            if (girisislemi == true)
            {
                MessageBox.Show("Giriş Başarılı Hoş Geldiniz");

                connect.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE tblOgrenci SET SonGiris=@p1 WHERE trim(KullaniciAdi)=@p2", connect);
                cmd1.Parameters.AddWithValue("@p1", DateTime.Now);
                cmd1.Parameters.AddWithValue("@p2", txtbxAdi.Text);
                cmd1.ExecuteNonQuery();

                this.Hide();
                frmOgrenciAna frmogrenciana = new frmOgrenciAna();
                frmogrenciana.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifrenizi kontrol ediniz. ");
            }

            connect.Close();

        }
        

        
    }
}
