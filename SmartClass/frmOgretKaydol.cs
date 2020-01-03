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
    public partial class frmOgretKaydol : MetroForm
    {
        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;" +
            "Trusted_Connection=True;");

        public frmOgretKaydol()
        {
            InitializeComponent();
        }

        private void frmOgretKaydol_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string kayit = "insert into tblOgretmen (OgretmenAdi,OgretmenParola) values (@adi,@parola)";

                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@adi", textBoxAdi.Text);
                komut.Parameters.AddWithValue("@parola", textBoxParola.Text);

                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Öğretmen Kayıt İşlemi Gerçekleşti.");

                textBoxAdi.Clear();
                textBoxParola.Clear();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void btnKayitGeri_Click(object sender, EventArgs e)
        {
            frmÖgretmenGiris frm = new frmÖgretmenGiris();
            frm.ShowDialog();
            this.Close();
        }
    }
}
