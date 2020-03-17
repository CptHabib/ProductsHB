using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Products_Managment.PL
{
    public partial class FRM_ADD_PRODUCTS : Form
    {
        public string state = "add";
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();

        public FRM_ADD_PRODUCTS()
        {
            InitializeComponent();
            cmbCategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT";
            cmbCategories.ValueMember = "ID_CAT";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG;*.PNG;*.GIF;*.BMP ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pBox.Image.Save(ms, pBox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                prd.ADD_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text, txtRef.Text
                              , Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);

                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MemoryStream ms = new MemoryStream();
                pBox.Image.Save(ms, pBox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                prd.UPDATE_PRODUCTS(Convert.ToInt32(cmbCategories.SelectedValue), txtDes.Text, txtRef.Text
                                  , Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage);


            }

            MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FRM_PRODUCTS.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();

        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.VerifyProductID1(txtRef.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }



   


    }
}
