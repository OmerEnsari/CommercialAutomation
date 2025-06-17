using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace ApplicationLayer
{
    public partial class FrmMainPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMainPage()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            xtraTabbedMdiManager1.MdiParent = this;
        }

        private Form1 fr;

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Form1();
                fr.MdiParent = this;
                fr.Show();
            }
            else
            {
                fr.Activate();
            }
        }
    }
}