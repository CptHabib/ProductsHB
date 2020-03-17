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
    
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();

        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(textID.Text, textPWD.Text);
                if (Dt.Rows.Count>0)
                {
                    MessageBox.Show("Log");
                    /*FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    this.Close();*/
                
                
                
                }
                else
                {
                    MessageBox.Show("Login Failed !");
                }

        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
