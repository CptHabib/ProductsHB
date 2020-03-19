using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsHB.PL
{
    public partial class FRM_MAIN : Form
    {
        
        //single instance
        private static FRM_MAIN frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
        frm= null;
        }

        public static FRM_MAIN getMainForm{
        get 
        {
            if (frm == null)
            {
                frm=new FRM_MAIN();
                frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            }
         return frm;

        }
        
        }
        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm==null)
                frm=this;
            this.المنتوجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةمنتوججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCTS frm = new FRM_ADD_PRODUCTS();
            frm.ShowDialog();

        }

        private void ادارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }
    }
}
