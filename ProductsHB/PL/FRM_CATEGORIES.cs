using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace ProductsHB.PL
{
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=.;Database=Product_DB; Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmbd;
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select id_cat as 'رقم الصنف',DESCRIPTION_CAT as 'اسم الصنف' from categories", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "رقم الصنف");
            txtDes.DataBindings.Add("text", dt, "اسم الصنف");
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position+1) + "/" + bmb.Count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmb.Position +=1;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0])+1;
            txtID.Text = id.ToString();
            txtDes.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNew.Enabled = true;
            btnAdd.Enabled = false;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;//
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;//

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;//

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_category myReport = new RPT.rpt_single_category();
            PdfFormatOptions pdfformat = new PdfFormatOptions();
            //crate export qptions
            ExportOptions export = new ExportOptions();
            //create object for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            //set the path of destination
            dfoptions.DiskFileName = @"F:\المحاسبة\Program\ProductsHB\Categories.pdf";
            export = myReport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfformat;
            export.ExportDestinationOptions = dfoptions;
            
            myReport.SetParameterValue("@id", Convert.ToInt32(txtID.Text));
            myReport.Export();
            MessageBox.Show("!تم حفظ اللائحة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
