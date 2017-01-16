namespace فروش
{
    partial class انتخاب_کالا
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
            this.data = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupkalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costbuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costsalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darsadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.فروشDataSet2 = new فروش.فروشDataSet2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kalaTableAdapter = new فروش.فروشDataSet2TableAdapters.kalaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoGenerateColumns = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.dateoldDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.groupkalaDataGridViewTextBoxColumn,
            this.costbuyDataGridViewTextBoxColumn,
            this.costsalDataGridViewTextBoxColumn,
            this.darsadDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.data.DataSource = this.kalaBindingSource;
            this.data.Location = new System.Drawing.Point(-7, 61);
            this.data.Name = "data";
            this.data.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data.Size = new System.Drawing.Size(616, 262);
            this.data.TabIndex = 0;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد کالا";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "مارک";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // dateoldDataGridViewTextBoxColumn
            // 
            this.dateoldDataGridViewTextBoxColumn.DataPropertyName = "date_old";
            this.dateoldDataGridViewTextBoxColumn.HeaderText = "تاریخ انقضا";
            this.dateoldDataGridViewTextBoxColumn.Name = "dateoldDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "واحد";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // groupkalaDataGridViewTextBoxColumn
            // 
            this.groupkalaDataGridViewTextBoxColumn.DataPropertyName = "group_kala";
            this.groupkalaDataGridViewTextBoxColumn.HeaderText = "گروه کالا";
            this.groupkalaDataGridViewTextBoxColumn.Name = "groupkalaDataGridViewTextBoxColumn";
            // 
            // costbuyDataGridViewTextBoxColumn
            // 
            this.costbuyDataGridViewTextBoxColumn.DataPropertyName = "cost_buy";
            this.costbuyDataGridViewTextBoxColumn.HeaderText = "قیمت خرید";
            this.costbuyDataGridViewTextBoxColumn.Name = "costbuyDataGridViewTextBoxColumn";
            // 
            // costsalDataGridViewTextBoxColumn
            // 
            this.costsalDataGridViewTextBoxColumn.DataPropertyName = "cost_sal";
            this.costsalDataGridViewTextBoxColumn.HeaderText = "قیمت فروش";
            this.costsalDataGridViewTextBoxColumn.Name = "costsalDataGridViewTextBoxColumn";
            // 
            // darsadDataGridViewTextBoxColumn
            // 
            this.darsadDataGridViewTextBoxColumn.DataPropertyName = "darsad";
            this.darsadDataGridViewTextBoxColumn.HeaderText = "درصد مالیات";
            this.darsadDataGridViewTextBoxColumn.Name = "darsadDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // kalaBindingSource
            // 
            this.kalaBindingSource.DataMember = "kala";
            this.kalaBindingSource.DataSource = this.فروشDataSet2;
            // 
            // فروشDataSet2
            // 
            this.فروشDataSet2.DataSetName = "فروشDataSet2";
            this.فروشDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(338, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ":جستجوی سریع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kalaTableAdapter
            // 
            this.kalaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // انتخاب_کالا
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.data);
            this.Name = "انتخاب_کالا";
            this.Text = "انتخاب کالا";
            this.Load += new System.EventHandler(this.انتخاب_کالا_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private فروشDataSet2 فروشDataSet2;
        private System.Windows.Forms.BindingSource kalaBindingSource;
        private فروشDataSet2TableAdapters.kalaTableAdapter kalaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupkalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costbuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costsalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darsadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}