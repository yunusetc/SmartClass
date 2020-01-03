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
    public partial class formOgrenciTakip : MetroForm
    {
        SqlConnection connect = new SqlConnection("Server=localhost;Database=SmartClassDB;" +
            "Trusted_Connection=True;");
        public formOgrenciTakip()
        {
            InitializeComponent();
        }

        private void formOgrenciTakip_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            listViewTakip.Columns.Add("Adı", 150);
            listViewTakip.Columns.Add("Soyadı", 150);
            listViewTakip.Columns.Add("Son Giriş Tarihi", 150);

            listViewTakip.View = View.Details;
            listViewTakip.GridLines = true;

            ListViewItem item = new ListViewItem();

            connect.Open();
            SqlCommand cmd = new SqlCommand("SELECT KullaniciAdi,KullaniciSoyadi,SonGiris FROM tblOgrenci", connect);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                item = listViewTakip.Items.Add(dr.GetString(0));
                item.SubItems.Add(dr.GetString(1));
                item.SubItems.Add(dr.GetDateTime(2).ToString());
            }

            connect.Close();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            this.Hide();

            formOgretmen frm = new formOgretmen();

            frm.ShowDialog();
        }

        
    }
}
