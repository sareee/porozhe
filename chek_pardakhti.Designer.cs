namespace فروش
{
    partial class chek_pardakhti
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
            this.data2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chekpardakhtiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.فروشDataSet10 = new فروش.فروشDataSet10();
            this.فروشDataSet8 = new فروش.فروشDataSet8();
            this.chekpardakhtiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chek_pardakhtiTableAdapter = new فروش.فروشDataSet8TableAdapters.chek_pardakhtiTableAdapter();
            this.chek_pardakhtiTableAdapter1 = new فروش.فروشDataSet10TableAdapters.chek_pardakhtiTableAdapter();
            this.forushDataSet4 = new فروش.forushDataSet4();
            this.chekpardakhtiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.chek_pardakhtiTableAdapter2 = new فروش.forushDataSet4TableAdapters.chek_pardakhtiTableAdapter();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameshobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numhesabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekpardakhtiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekpardakhtiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forushDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekpardakhtiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // data2
            // 
            this.data2.AutoGenerateColumns = false;
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.banknameDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameshobeDataGridViewTextBoxColumn,
            this.numhesabDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.data2.DataSource = this.chekpardakhtiBindingSource2;
            this.data2.Location = new System.Drawing.Point(-1, 61);
            this.data2.Name = "data2";
            this.data2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data2.Size = new System.Drawing.Size(679, 196);
            this.data2.TabIndex = 0;
            this.data2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "معرفی چک جدید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "افزودن";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chekpardakhtiBindingSource1
            // 
            this.chekpardakhtiBindingSource1.DataMember = "chek_pardakhti";
            this.chekpardakhtiBindingSource1.DataSource = this.فروشDataSet10;
            // 
            // فروشDataSet10
            // 
            this.فروشDataSet10.DataSetName = "فروشDataSet10";
            this.فروشDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // فروشDataSet8
            // 
            this.فروشDataSet8.DataSetName = "فروشDataSet8";
            this.فروشDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chekpardakhtiBindingSource
            // 
            this.chekpardakhtiBindingSource.DataMember = "chek_pardakhti";
            this.chekpardakhtiBindingSource.DataSource = this.فروشDataSet8;
            // 
            // chek_pardakhtiTableAdapter
            // 
            this.chek_pardakhtiTableAdapter.ClearBeforeFill = true;
            // 
            // chek_pardakhtiTableAdapter1
            // 
            this.chek_pardakhtiTableAdapter1.ClearBeforeFill = true;
            // 
            // forushDataSet4
            // 
            this.forushDataSet4.DataSetName = "forushDataSet4";
            this.forushDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chekpardakhtiBindingSource2
            // 
            this.chekpardakhtiBindingSource2.DataMember = "chek_pardakhti";
            this.chekpardakhtiBindingSource2.DataSource = this.forushDataSet4;
            // 
            // chek_pardakhtiTableAdapter2
            // 
            this.chek_pardakhtiTableAdapter2.ClearBeforeFill = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "شماره چک";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "سررسید";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // banknameDataGridViewTextBoxColumn
            // 
            this.banknameDataGridViewTextBoxColumn.DataPropertyName = "bank_name";
            this.banknameDataGridViewTextBoxColumn.HeaderText = "نام بانک";
            this.banknameDataGridViewTextBoxColumn.Name = "banknameDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد شعبه";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameshobeDataGridViewTextBoxColumn
            // 
            this.nameshobeDataGridViewTextBoxColumn.DataPropertyName = "name_shobe";
            this.nameshobeDataGridViewTextBoxColumn.HeaderText = "نام شعبه";
            this.nameshobeDataGridViewTextBoxColumn.Name = "nameshobeDataGridViewTextBoxColumn";
            // 
            // numhesabDataGridViewTextBoxColumn
            // 
            this.numhesabDataGridViewTextBoxColumn.DataPropertyName = "num_hesab";
            this.numhesabDataGridViewTextBoxColumn.HeaderText = "شماره حساب";
            this.numhesabDataGridViewTextBoxColumn.Name = "numhesabDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "وضعیت";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "مبلغ";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ":جستجو بر اساس";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(456, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chek_pardakhti
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 301);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data2);
            this.Name = "chek_pardakhti";
            this.Text = "چک پرداختی";
            this.Load += new System.EventHandler(this.chek_pardakhti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekpardakhtiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekpardakhtiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forushDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekpardakhtiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data2;
        private System.Windows.Forms.Button button1;
        private فروشDataSet8 فروشDataSet8;
        private System.Windows.Forms.BindingSource chekpardakhtiBindingSource;
        private فروشDataSet8TableAdapters.chek_pardakhtiTableAdapter chek_pardakhtiTableAdapter;
        private System.Windows.Forms.Button button2;
        private فروشDataSet10 فروشDataSet10;
        private System.Windows.Forms.BindingSource chekpardakhtiBindingSource1;
        private فروشDataSet10TableAdapters.chek_pardakhtiTableAdapter chek_pardakhtiTableAdapter1;
        private forushDataSet4 forushDataSet4;
        private System.Windows.Forms.BindingSource chekpardakhtiBindingSource2;
        private forushDataSet4TableAdapters.chek_pardakhtiTableAdapter chek_pardakhtiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameshobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numhesabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}