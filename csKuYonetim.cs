using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuyumcuYonetimSistemiV1
{
    
    static class csKuYonetim
    {
        #region Form İşlemleri
        //MDI Formlar İçin
        public static void FormAc(Form frmAna, Form frmAc)
        {

        }

        //Normal Modlar İçin
        public static void FormAc(Form frmAc,bool durum)
        {
            //Durum true ise showdialog modu false ise show modunda
            frmAc.MaximizeBox = false;
            frmAc.MinimizeBox = false;
            frmAc.FormClosing += FrmAc_FormClosing;
            frmAc.StartPosition= FormStartPosition.CenterScreen;


            
        }

        private static void FrmAc_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException("Data Source = DESKTOP - MQ6MQBDSQLEXPRESS; Initial Catalog = Stok_Takip; Integrated Security = True");
        }
        #endregion
    }
}
