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
    public partial class formCizgi : MetroForm
    {
        public formCizgi()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;" +
            "Trusted_Connection=True;");

        private void formCizgi_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("SELECT KonuAdi,dogruSayisi FROM tblSoru INNER JOIN tblKonu ON tblSoru.KonuID = tblKonu.KonuID", connect);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                chartCizgi.Series["Konular"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));

            }
            connect.Close();


        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOgrenciAna frmAna = new frmOgrenciAna();
            frmAna.ShowDialog();
            
        }
    }
}
