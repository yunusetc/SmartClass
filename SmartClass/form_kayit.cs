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
using System.Data.SqlClient;


namespace SmartClass
{
    public partial class form_kayit : MetroForm
    {
        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;" +
            "Trusted_Connection=True;");
        
        public form_kayit()
        {
            InitializeComponent();
        }

        private void form_kayit_Load(object sender, EventArgs e)
        {

        }

        private void button_kayit_geri_Click(object sender, EventArgs e)
        {
            form_giris frmgrs = new form_giris();
            frmgrs.ShowDialog();
            this.Close();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                
                string kayit = "insert into tblOgrenci (KullaniciAdi,KullaniciSoyadi,KullaniciParola) values (@adi,@soyadi,@parola)";
                
                SqlCommand komut = new SqlCommand(kayit, connect);
                
                komut.Parameters.AddWithValue("@adi", txtbxAdi.Text);
                komut.Parameters.AddWithValue("@soyadi", txtbxSoyadi.Text);
                komut.Parameters.AddWithValue("@parola", txtbxParola.Text);

                
                komut.ExecuteNonQuery();
                
                connect.Close();
                MessageBox.Show("Öğrenci Kayıt İşlemi Gerçekleşti.");

                txtbxAdi.Clear();
                txtbxSoyadi.Clear();
                txtbxParola.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
    }
}
