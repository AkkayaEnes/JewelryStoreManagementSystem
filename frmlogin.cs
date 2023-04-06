using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KuyumcuYonetimSistemiV1
{
    public partial class frmlogin : DevExpress.XtraEditors.XtraForm
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaForm ekle = new frmAnaForm();
            ekle.ShowDialog();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
