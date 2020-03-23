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
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable dt = new DataTable();

        void CreateDataTable()
        {
            dt.Columns.Add("رقم المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("نسبة الخصم (%)");
            dt.Columns.Add("المبلغ الإجمالي");
            dgList.DataSource = dt;
        }
        void ResizeDGV()
        {
            this.dgList.RowHeadersWidth = 56;
            this.dgList.Columns[0].Width = 76;
            this.dgList.Columns[1].Width = 130;
            this.dgList.Columns[2].Width = 76;
            this.dgList.Columns[3].Width = 81;
            this.dgList.Columns[4].Width = 86;
            this.dgList.Columns[5].Width = 99;
            this.dgList.Columns[6].Width = 99;
        }
        void CalcAmount()
        {
            if (txtPPRISE.Text != string.Empty && txtPQTE.Text != string.Empty)
            {
                double Amount = Convert.ToDouble(txtPPRISE.Text) * Convert.ToInt32(txtPQTE.Text);
                txtAMOUNT.Text = Amount.ToString();
            }
        }
        void CalcTotalAmount()
        {
            if (txtDISCOUNT.Text != string.Empty && txtAMOUNT.Text!=string.Empty)
            {
                double Discount = Convert.ToDouble(txtDISCOUNT.Text);
                double Amount = Convert.ToDouble(txtAMOUNT.Text);
                double TAmount = Amount - (Amount * (Discount / 100));
                txtTAMOUNT.Text = TAmount.ToString();
            }
        }

        public FRM_ORDERS()
        {
            InitializeComponent();
            CreateDataTable();
            ResizeDGV();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtID.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btnAdd.Enabled=false;
            btnSave.Enabled=true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            FRM_CUST_LIST frm = new FRM_CUST_LIST();
            frm.ShowDialog();
            this.txtCName.Text = frm.dgvcust.CurrentRow.Cells[1].Value.ToString();
            this.txtCLName.Text = frm.dgvcust.CurrentRow.Cells[2].Value.ToString();
            this.txtCTel.Text = frm.dgvcust.CurrentRow.Cells[3].Value.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnPSearch_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS_LIST frm = new FRM_PRODUCTS_LIST();
            frm.ShowDialog();
            txtPID.Text = frm.dgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtPNAME.Text = frm.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtPPRISE.Text = frm.dgvProducts.CurrentRow.Cells[3].Value.ToString();
            txtDISCOUNT.Text = (0).ToString();
            txtPQTE.Focus();



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPQTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtPPRISE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txtPPRISE_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtPPRISE.Text !=string.Empty )
            {
                txtPQTE.Focus();
            }
        }

        private void txtPQTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPQTE.Text != string.Empty)
            {
                txtDISCOUNT.Focus();
            }
        }

        private void txtDISCOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtPPRISE_KeyUp(object sender, KeyEventArgs e)
        {
            CalcAmount();
            CalcTotalAmount();
        }

        private void txtPQTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPQTE_KeyUp(object sender, KeyEventArgs e)
        {
            CalcAmount();
            CalcTotalAmount();
        }

        private void txtDISCOUNT_KeyUp(object sender, KeyEventArgs e)
        {
            CalcTotalAmount();
        }
    }
}
