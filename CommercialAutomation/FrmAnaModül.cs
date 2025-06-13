using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomation
{
    public partial class FrmAnaModül : Form
    {
        public FrmAnaModül()
        {
            InitializeComponent();
        }

        private FrmUrunler fr;
        private FrmMusteri fr2;
        private FrmFirmalar fr3;

        private void bar_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }

        }

        private void FrmAnaModül_Load(object sender, EventArgs e)
        {

        }

        private void bar_Customer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FrmMusteri();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        /// <summary>
        /// removes the page from the tab control when it is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (e.Page.MdiChild is FrmUrunler)
            {
                fr = null; // Clear the reference to the product form
            }
            else if (e.Page.MdiChild is FrmMusteri)
            {
                fr2 = null; // Clear the reference to the customer form
            }
            else if (e.Page.MdiChild is FrmFirmalar)
            {
                fr3 = null;
            }

        }

        private void bar_Firm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmFirmalar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
    }
}
