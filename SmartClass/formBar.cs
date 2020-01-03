using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace SmartClass
{
    public partial class formBar : MetroForm
    {
        public formBar()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;" +
            "Trusted_Connection=True;");

        private void formIstatistik_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("SELECT KonuAdi,dogruSayisi FROM tblSoru INNER JOIN tblKonu ON tblSoru.KonuID = tblKonu.KonuID",connect);
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                chartKonu.Series["Konular"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString())); // chart olusturmak icin

            }
            connect.Close();


        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenciAna frmOgrenci = new frmOgrenciAna();
            frmOgrenci.ShowDialog();
        }
    }
}
