﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsHB.RPT
{
    public partial class FRM_RPT_PRODUCT : Form
    {
        public FRM_RPT_PRODUCT()
        {
            InitializeComponent();
        }

        private void FRM_RPT_PRODUCT_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
