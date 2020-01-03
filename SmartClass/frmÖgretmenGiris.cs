using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace SmartClass
{
    public partial class frmÖgretmenGiris : MetroForm
    {
        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;Trusted_Connection=True;");

        public frmÖgretmenGiris()
        {
            InitializeComponent();
        }


        private void frmÖgretmenGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            form_giris frmGiris = new form_giris();
            this.Hide();
            frmGiris.ShowDialog();
        }

        public bool Giris(string user,string pass)
        {
            
            SqlCommand kmt = new SqlCommand("Select * from tblOgretmen Where OgretmenAdi=@adi and OgretmenParola=@pass", connect);
            kmt.Parameters.AddWithValue("@adi", user);
            kmt.Parameters.AddWithValue("@pass", pass);
            SqlDataReader oku = kmt.ExecuteReader();

            if(oku.Read())
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

        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            connect.Open();
            bool girisislemi = Giris(txtbxOgretmenAdi.Text, txtbxOgretmenParola.Text);
            if(girisislemi == true)
            {
                MessageBox.Show("Giriş Başarılı Hoş Geldiniz");

                this.Hide();
                formOgretmen frmogretmen = new formOgretmen();
                frmogretmen.ShowDialog();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifrenizi kontrol ediniz. ");
            }
            
        }

        private void btnOgretmenKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgretKaydol frm = new frmOgretKaydol();
            frm.ShowDialog();
        }
    }
}
