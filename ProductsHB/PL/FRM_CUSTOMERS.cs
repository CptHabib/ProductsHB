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
    public partial class FRM_CUSTOMERS : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        int position,ID,pos;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dgList.DataSource = cust.GET_ALL_CUSTEMORS();
            dgList.Columns[0].Visible = false;
            lblPosition.Text = pos+"/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cust.ADD_CUSTOMER(txtName.Text, txtLName.Text, txtTel.Text);
            MessageBox.Show("تمت الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dgList.DataSource = cust.GET_ALL_CUSTEMORS();
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lblPosition.Text = pos + "/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLName.Clear();
            txtTel.Clear();
            txtName.Focus();
            btnAdd.Enabled = true;
            btnNew.Enabled = false;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtLName.Focus();
            }
        }

        private void txtLName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTel.Focus();
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID =Convert.ToInt32(dgList.CurrentRow.Cells[0].Value);
            this.txtName.Text = dgList.CurrentRow.Cells[1].Value.ToString();
            this.txtLName.Text = dgList.CurrentRow.Cells[2].Value.ToString();
            this.txtTel.Text = dgList.CurrentRow.Cells[3].Value.ToString();
            pos = dgList.CurrentRow.Index+1;
            lblPosition.Text = pos + "/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);
            position = dgList.CurrentRow.Index;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("لم يتم تحديد عميل للتعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cust.EDIT_CUSTOMER(txtName.Text, txtLName.Text, txtTel.Text,ID);
            MessageBox.Show("تم تعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dgList.DataSource = cust.GET_ALL_CUSTEMORS();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ID==0)
            {
                MessageBox.Show("لم يتم تحديد عميل للحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("هل تريد بالتأكيد حذف هذا العميل؟", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cust.DEL_CUSTOMER(ID);
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgList.DataSource = cust.GET_ALL_CUSTEMORS();
            }
            lblPosition.Text = pos + "/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgList.DataSource = cust.SEARCH_CUSTOMER(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgList.DataSource = cust.SEARCH_CUSTOMER(txtSearch.Text);
            }
        }
        void Navigate(int index)
        {
            
            DataRowCollection drc = cust.GET_ALL_CUSTEMORS().Rows;
            ID =Convert.ToInt32(drc[index][0]);
            txtName.Text = drc[index][1].ToString();
            txtLName.Text = drc[index][2].ToString();
            txtTel.Text = drc[index][3].ToString();
            dgList.ClearSelection();
            dgList.Rows[index].Selected = true;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Navigate(0);
            pos = 1;
            lblPosition.Text = pos + "/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            position = cust.GET_ALL_CUSTEMORS().Rows.Count - 1;
            Navigate(position);
            pos = cust.GET_ALL_CUSTEMORS().Rows.Count;
            lblPosition.Text = pos + "/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(position!=0)
            { 
                position -= 1;
                pos -= 1;
            }
            Navigate(position);
            lblPosition.Text = pos + "/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (position != cust.GET_ALL_CUSTEMORS().Rows.Count - 1)
            {
                position += 1;
                pos += 1;
            }
            Navigate(position);
            lblPosition.Text = pos + "/" + (cust.GET_ALL_CUSTEMORS().Rows.Count);
        }
    }
}
