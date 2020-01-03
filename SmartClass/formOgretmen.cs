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

namespace SmartClass
{
    public partial class formOgretmen : MetroForm
    {
        public formOgretmen()
        {
            InitializeComponent();
        }

        private void formOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmÖgretmenGiris frm = new frmÖgretmenGiris();

            frm.ShowDialog();
        }

        private void buttonSoruEkle_Click(object sender, EventArgs e)
        {
            this.Hide();

            formOgretmenSoru frm = new formOgretmenSoru();

            frm.ShowDialog();
        }

        private void buttonTakip_Click(object sender, EventArgs e)
        {
            this.Hide();

            formOgrenciTakip frm = new formOgrenciTakip();

            frm.ShowDialog();
        }
    }
}
