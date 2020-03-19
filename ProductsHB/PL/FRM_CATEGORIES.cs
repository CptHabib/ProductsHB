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

namespace ProductsHB.PL
{
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=.;Database=Product_DB; Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from categories", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
