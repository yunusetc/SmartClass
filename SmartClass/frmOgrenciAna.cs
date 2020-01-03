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
    public partial class frmOgrenciAna : MetroForm
    {
        public frmOgrenciAna()
        {
            InitializeComponent();
        }

        private void frmOgrenciAna_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenciCikis_Click(object sender, EventArgs e)
        {
            this.Hide();

            form_giris frm = new form_giris();

            frm.ShowDialog();
        }

        private void btnTestCöz_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTest frmTest = new formTest();
            frmTest.ShowDialog();
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formBar frmBar = new formBar();
            frmBar.ShowDialog();
        }

        private void btnCizgi_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCizgi frmCizgi = new formCizgi();
            frmCizgi.ShowDialog();
            
        }
    }
}
