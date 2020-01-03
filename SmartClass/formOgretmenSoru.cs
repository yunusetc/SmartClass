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
    public partial class formOgretmenSoru : MetroForm
    {
        // baglanti yolu
        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;" +
            "Trusted_Connection=True;");

        public formOgretmenSoru()
        {
            InitializeComponent();
        }

        private void formOgretmenAna_Load(object sender, EventArgs e)
        {

        }

        private void btnogretmenCikis_Click(object sender, EventArgs e)
        {
            this.Hide();

            formOgretmen frmOgretmen = new formOgretmen();

            frmOgretmen.ShowDialog();
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string kayit = "insert into tblSoru (Soru,KonuID,DogruCevap) values (@soru,@konu,@cevap)";//gereken sorgu yazildi

                SqlCommand komut = new SqlCommand(kayit, connect);

                komut.Parameters.AddWithValue("@soru", txtbxSoru.Text);
                komut.Parameters.AddWithValue("@konu", txtbxKonu.Text);
                komut.Parameters.AddWithValue("@cevap", txtbxCevap.Text);


                komut.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Yeni soru eklendi.");

                txtbxKonu.Clear();
                txtbxSoru.Clear();
                txtbxCevap.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Soru ekleme sırasında hata oluştu." + hata.Message);//eger hata olusursa
            }
        }

        private void txtbxKonu_KeyPress(object sender, KeyPressEventArgs e)// yazilan karakterin sadece sayi olmasi icin
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtbxKonu_Leave(object sender, EventArgs e)// textbox kontrolunu saglamak icin method
        {
            try
            {
                if (Convert.ToInt32(txtbxKonu.Text) < 1 || Convert.ToInt32(txtbxKonu.Text) > 10)
                {
                    MessageBox.Show("Konu Numarası 1-10 arasında olmalı");
                    txtbxKonu.Text = "";
                    
                }
            }
            catch
            {
                txtbxKonu.Text = "";
            }
        }
    }
}
