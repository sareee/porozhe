namespace فروش
{
    partial class list_aqsat
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberqestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mablaqqestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sarresidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaqsatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.forushDataSet7 = new فروش.forushDataSet7();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listaqsatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.فروشDataSet13 = new فروش.فروشDataSet13();
            this.list_aqsatTableAdapter = new فروش.فروشDataSet13TableAdapters.list_aqsatTableAdapter();
            this.list_aqsatTableAdapter1 = new فروش.forushDataSet7TableAdapters.list_aqsatTableAdapter();
            this.bPersianCalenderTextBox1 = new BPersianCalender.BPersianCalenderTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaqsatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forushDataSet7)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaqsatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.numberqestDataGridViewTextBoxColumn,
            this.mablaqqestDataGridViewTextBoxColumn,
            this.sarresidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listaqsatBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "شماره فاکتور";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // numberqestDataGridViewTextBoxColumn
            // 
            this.numberqestDataGridViewTextBoxColumn.DataPropertyName = "number_qest";
            this.numberqestDataGridViewTextBoxColumn.HeaderText = "شماره قسط";
            this.numberqestDataGridViewTextBoxColumn.Name = "numberqestDataGridViewTextBoxColumn";
            // 
            // mablaqqestDataGridViewTextBoxColumn
            // 
            this.mablaqqestDataGridViewTextBoxColumn.DataPropertyName = "mablaq_qest";
            this.mablaqqestDataGridViewTextBoxColumn.HeaderText = "مبلغ قسط";
            this.mablaqqestDataGridViewTextBoxColumn.Name = "mablaqqestDataGridViewTextBoxColumn";
            // 
            // sarresidDataGridViewTextBoxColumn
            // 
            this.sarresidDataGridViewTextBoxColumn.DataPropertyName = "sar_resid";
            this.sarresidDataGridViewTextBoxColumn.HeaderText = "تاریخ سررسید";
            this.sarresidDataGridViewTextBoxColumn.Name = "sarresidDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "وضعیت";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // listaqsatBindingSource1
            // 
            this.listaqsatBindingSource1.DataMember = "list_aqsat";
            this.listaqsatBindingSource1.DataSource = this.forushDataSet7;
            // 
            // forushDataSet7
            // 
            this.forushDataSet7.DataSetName = "forushDataSet7";
            this.forushDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.textBox18);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Location = new System.Drawing.Point(175, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 90);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "خلاصه وضعیت اقساط";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Location = new System.Drawing.Point(338, 22);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(23, 12);
            this.textBox15.TabIndex = 65;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(185, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "پرداخت نشده و سررسید رسیده";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(183, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 15);
            this.label23.TabIndex = 60;
            this.label23.Text = "پرداخت نشده و سررسید گذشته";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.Red;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Location = new System.Drawing.Point(338, 52);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(23, 12);
            this.textBox18.TabIndex = 63;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(21, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "پرداخت شده در سررسید";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.Lime;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(167, 23);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(23, 12);
            this.textBox13.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "بستن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaqsatBindingSource
            // 
            this.listaqsatBindingSource.DataMember = "list_aqsat";
            this.listaqsatBindingSource.DataSource = this.فروشDataSet13;
            // 
            // فروشDataSet13
            // 
            this.فروشDataSet13.DataSetName = "فروشDataSet13";
            this.فروشDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // list_aqsatTableAdapter
            // 
            this.list_aqsatTableAdapter.ClearBeforeFill = true;
            // 
            // list_aqsatTableAdapter1
            // 
            this.list_aqsatTableAdapter1.ClearBeforeFill = true;
            // 
            // bPersianCalenderTextBox1
            // 
            this.bPersianCalenderTextBox1.Location = new System.Drawing.Point(12, 300);
            this.bPersianCalenderTextBox1.Miladi = new System.DateTime(((long)(0)));
            this.bPersianCalenderTextBox1.Name = "bPersianCalenderTextBox1";
            this.bPersianCalenderTextBox1.NowDateSelected = false;
            this.bPersianCalenderTextBox1.ReadOnly = true;
            this.bPersianCalenderTextBox1.SelectedDate = null;
            this.bPersianCalenderTextBox1.Shamsi = null;
            this.bPersianCalenderTextBox1.Size = new System.Drawing.Size(100, 20);
            this.bPersianCalenderTextBox1.TabIndex = 22;
            this.bPersianCalenderTextBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(154, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 12);
            this.textBox1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "پرداخت نشده وسرسید نرسیده";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // list_aqsat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 388);
            this.Controls.Add(this.bPersianCalenderTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "list_aqsat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست اقساط";
            this.Load += new System.EventHandler(this.list_aqsat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaqsatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forushDataSet7)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaqsatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button1;
        private فروشDataSet13 فروشDataSet13;
        private System.Windows.Forms.BindingSource listaqsatBindingSource;
        private فروشDataSet13TableAdapters.list_aqsatTableAdapter list_aqsatTableAdapter;
        private forushDataSet7 forushDataSet7;
        private System.Windows.Forms.BindingSource listaqsatBindingSource1;
        private forushDataSet7TableAdapters.list_aqsatTableAdapter list_aqsatTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberqestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mablaqqestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarresidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BPersianCalender.BPersianCalenderTextBox bPersianCalenderTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}