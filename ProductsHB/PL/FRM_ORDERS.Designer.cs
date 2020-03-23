namespace ProductsHB.PL
{
    partial class FRM_ORDERS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtSUM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPPRISE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPNAME = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTAMOUNT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDISCOUNT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAMOUNT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPQTE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnPSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtSName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(368, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاريخ البيع:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "وصف الفاتورة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "اسم البائع:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCTel);
            this.groupBox2.Controls.Add(this.txtCLName);
            this.groupBox2.Controls.Add(this.txtCName);
            this.groupBox2.Location = new System.Drawing.Point(386, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCName
            // 
            this.txtCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCName.Location = new System.Drawing.Point(58, 26);
            this.txtCName.Name = "txtCName";
            this.txtCName.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(165, 20);
            this.txtCName.TabIndex = 1;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(76, 56);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDes.Size = new System.Drawing.Size(217, 51);
            this.txtDes.TabIndex = 0;
            // 
            // txtSName
            // 
            this.txtSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSName.Location = new System.Drawing.Point(76, 149);
            this.txtSName.Name = "txtSName";
            this.txtSName.ReadOnly = true;
            this.txtSName.Size = new System.Drawing.Size(217, 20);
            this.txtSName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "الاسم الشخصي:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "اسم العائلة:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "رقم الهاتف:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCLName
            // 
            this.txtCLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCLName.Location = new System.Drawing.Point(58, 72);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.ReadOnly = true;
            this.txtCLName.Size = new System.Drawing.Size(165, 20);
            this.txtCLName.TabIndex = 1;
            // 
            // txtCTel
            // 
            this.txtCTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCTel.Location = new System.Drawing.Point(58, 113);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.ReadOnly = true;
            this.txtCTel.Size = new System.Drawing.Size(165, 20);
            this.txtCTel.TabIndex = 1;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(100, 149);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "...";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTAMOUNT);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtDISCOUNT);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtAMOUNT);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtPQTE);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtPPRISE);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtPNAME);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtPID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dgList);
            this.groupBox3.Controls.Add(this.txtSUM);
            this.groupBox3.Controls.Add(this.btnPSearch);
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 209);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // dgList
            // 
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.ColumnHeadersVisible = false;
            this.dgList.Location = new System.Drawing.Point(3, 64);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(703, 109);
            this.dgList.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(540, 179);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(162, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "حذف السطر المحدد";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // txtSUM
            // 
            this.txtSUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSUM.Location = new System.Drawing.Point(29, 180);
            this.txtSUM.Name = "txtSUM";
            this.txtSUM.ReadOnly = true;
            this.txtSUM.Size = new System.Drawing.Size(165, 20);
            this.txtSUM.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "المجموع:";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "جديد";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(258, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(353, 405);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "طباعة الفاتورة";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(448, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(76, 113);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(217, 20);
            this.dtp.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(126, 26);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(167, 20);
            this.txtID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(650, 16);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3);
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "اختيار";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPID
            // 
            this.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPID.Location = new System.Drawing.Point(573, 38);
            this.txtPID.Name = "txtPID";
            this.txtPID.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(78, 20);
            this.txtPID.TabIndex = 6;
            this.txtPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(573, 16);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "رقم المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPPRISE
            // 
            this.txtPPRISE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPPRISE.Location = new System.Drawing.Point(367, 38);
            this.txtPPRISE.MaxLength = 8;
            this.txtPPRISE.Name = "txtPPRISE";
            this.txtPPRISE.Size = new System.Drawing.Size(77, 20);
            this.txtPPRISE.TabIndex = 10;
            this.txtPPRISE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPPRISE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPPRISE_KeyDown);
            this.txtPPRISE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPPRISE_KeyPress);
            this.txtPPRISE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPPRISE_KeyUp);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(367, 16);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(77, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "الثمن";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPNAME
            // 
            this.txtPNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNAME.Location = new System.Drawing.Point(442, 38);
            this.txtPNAME.Name = "txtPNAME";
            this.txtPNAME.ReadOnly = true;
            this.txtPNAME.Size = new System.Drawing.Size(132, 20);
            this.txtPNAME.TabIndex = 8;
            this.txtPNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPNAME.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(442, 16);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(132, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "اسم المنتج";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTAMOUNT
            // 
            this.txtTAMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTAMOUNT.Location = new System.Drawing.Point(3, 38);
            this.txtTAMOUNT.Name = "txtTAMOUNT";
            this.txtTAMOUNT.ReadOnly = true;
            this.txtTAMOUNT.Size = new System.Drawing.Size(100, 20);
            this.txtTAMOUNT.TabIndex = 18;
            this.txtTAMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(3, 16);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 17;
            this.label14.Text = "المبلغ الإجمالي";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDISCOUNT
            // 
            this.txtDISCOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDISCOUNT.Location = new System.Drawing.Point(102, 38);
            this.txtDISCOUNT.MaxLength = 3;
            this.txtDISCOUNT.Name = "txtDISCOUNT";
            this.txtDISCOUNT.Size = new System.Drawing.Size(100, 20);
            this.txtDISCOUNT.TabIndex = 16;
            this.txtDISCOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDISCOUNT.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtDISCOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDISCOUNT_KeyPress);
            this.txtDISCOUNT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDISCOUNT_KeyUp);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(102, 16);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 15;
            this.label15.Text = "الخصم(%)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAMOUNT
            // 
            this.txtAMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAMOUNT.Location = new System.Drawing.Point(200, 38);
            this.txtAMOUNT.Name = "txtAMOUNT";
            this.txtAMOUNT.ReadOnly = true;
            this.txtAMOUNT.Size = new System.Drawing.Size(87, 20);
            this.txtAMOUNT.TabIndex = 14;
            this.txtAMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(200, 16);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(87, 23);
            this.label16.TabIndex = 13;
            this.label16.Text = "المبلغ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPQTE
            // 
            this.txtPQTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPQTE.Location = new System.Drawing.Point(286, 38);
            this.txtPQTE.MaxLength = 8;
            this.txtPQTE.Name = "txtPQTE";
            this.txtPQTE.Size = new System.Drawing.Size(82, 20);
            this.txtPQTE.TabIndex = 12;
            this.txtPQTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPQTE.TextChanged += new System.EventHandler(this.txtPQTE_TextChanged);
            this.txtPQTE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPQTE_KeyDown);
            this.txtPQTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPQTE_KeyPress);
            this.txtPQTE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPQTE_KeyUp);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(286, 16);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(82, 23);
            this.label17.TabIndex = 11;
            this.label17.Text = "الكمية";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // btnPSearch
            // 
            this.btnPSearch.Location = new System.Drawing.Point(650, 38);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(56, 20);
            this.btnPSearch.TabIndex = 19;
            this.btnPSearch.Text = "...";
            this.btnPSearch.UseVisualStyleBackColor = true;
            this.btnPSearch.Click += new System.EventHandler(this.btnPSearch_Click);
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 440);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عملية البيع";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCTel;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.TextBox txtSUM;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTAMOUNT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDISCOUNT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAMOUNT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPQTE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPPRISE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPNAME;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPSearch;
    }
}