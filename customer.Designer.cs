namespace فروش
{
    partial class customer
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
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darsadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkbedehiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkchekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noemissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badcursorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationcursorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.فروشDataSet3 = new فروش.فروشDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.information_cursorTableAdapter = new فروش.فروشDataSet3TableAdapters.information_cursorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationcursorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.grouhDataGridViewTextBoxColumn,
            this.relationDataGridViewTextBoxColumn,
            this.darsadDataGridViewTextBoxColumn,
            this.deactiveDataGridViewTextBoxColumn,
            this.checkbedehiDataGridViewTextBoxColumn,
            this.amount1DataGridViewTextBoxColumn,
            this.checkchekDataGridViewTextBoxColumn,
            this.amount2DataGridViewTextBoxColumn,
            this.noemissionDataGridViewTextBoxColumn,
            this.saltipDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.badcursorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.informationcursorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(245, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد مشتری";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام مشتری";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // grouhDataGridViewTextBoxColumn
            // 
            this.grouhDataGridViewTextBoxColumn.DataPropertyName = "grouh";
            this.grouhDataGridViewTextBoxColumn.HeaderText = "grouh";
            this.grouhDataGridViewTextBoxColumn.Name = "grouhDataGridViewTextBoxColumn";
            this.grouhDataGridViewTextBoxColumn.Visible = false;
            // 
            // relationDataGridViewTextBoxColumn
            // 
            this.relationDataGridViewTextBoxColumn.DataPropertyName = "relation";
            this.relationDataGridViewTextBoxColumn.HeaderText = "relation";
            this.relationDataGridViewTextBoxColumn.Name = "relationDataGridViewTextBoxColumn";
            this.relationDataGridViewTextBoxColumn.Visible = false;
            // 
            // darsadDataGridViewTextBoxColumn
            // 
            this.darsadDataGridViewTextBoxColumn.DataPropertyName = "darsad";
            this.darsadDataGridViewTextBoxColumn.HeaderText = "darsad";
            this.darsadDataGridViewTextBoxColumn.Name = "darsadDataGridViewTextBoxColumn";
            this.darsadDataGridViewTextBoxColumn.Visible = false;
            // 
            // deactiveDataGridViewTextBoxColumn
            // 
            this.deactiveDataGridViewTextBoxColumn.DataPropertyName = "deactive";
            this.deactiveDataGridViewTextBoxColumn.HeaderText = "deactive";
            this.deactiveDataGridViewTextBoxColumn.Name = "deactiveDataGridViewTextBoxColumn";
            this.deactiveDataGridViewTextBoxColumn.Visible = false;
            // 
            // checkbedehiDataGridViewTextBoxColumn
            // 
            this.checkbedehiDataGridViewTextBoxColumn.DataPropertyName = "check_bedehi";
            this.checkbedehiDataGridViewTextBoxColumn.HeaderText = "check_bedehi";
            this.checkbedehiDataGridViewTextBoxColumn.Name = "checkbedehiDataGridViewTextBoxColumn";
            this.checkbedehiDataGridViewTextBoxColumn.Visible = false;
            // 
            // amount1DataGridViewTextBoxColumn
            // 
            this.amount1DataGridViewTextBoxColumn.DataPropertyName = "amount_1";
            this.amount1DataGridViewTextBoxColumn.HeaderText = "amount_1";
            this.amount1DataGridViewTextBoxColumn.Name = "amount1DataGridViewTextBoxColumn";
            this.amount1DataGridViewTextBoxColumn.Visible = false;
            // 
            // checkchekDataGridViewTextBoxColumn
            // 
            this.checkchekDataGridViewTextBoxColumn.DataPropertyName = "check_chek";
            this.checkchekDataGridViewTextBoxColumn.HeaderText = "check_chek";
            this.checkchekDataGridViewTextBoxColumn.Name = "checkchekDataGridViewTextBoxColumn";
            this.checkchekDataGridViewTextBoxColumn.Visible = false;
            // 
            // amount2DataGridViewTextBoxColumn
            // 
            this.amount2DataGridViewTextBoxColumn.DataPropertyName = "amount_2";
            this.amount2DataGridViewTextBoxColumn.HeaderText = "amount_2";
            this.amount2DataGridViewTextBoxColumn.Name = "amount2DataGridViewTextBoxColumn";
            this.amount2DataGridViewTextBoxColumn.Visible = false;
            // 
            // noemissionDataGridViewTextBoxColumn
            // 
            this.noemissionDataGridViewTextBoxColumn.DataPropertyName = "_no_emission";
            this.noemissionDataGridViewTextBoxColumn.HeaderText = "_no_emission";
            this.noemissionDataGridViewTextBoxColumn.Name = "noemissionDataGridViewTextBoxColumn";
            this.noemissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // saltipDataGridViewTextBoxColumn
            // 
            this.saltipDataGridViewTextBoxColumn.DataPropertyName = "sal_tip";
            this.saltipDataGridViewTextBoxColumn.HeaderText = "sal_tip";
            this.saltipDataGridViewTextBoxColumn.Name = "saltipDataGridViewTextBoxColumn";
            this.saltipDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Visible = false;
            // 
            // badcursorDataGridViewTextBoxColumn
            // 
            this.badcursorDataGridViewTextBoxColumn.DataPropertyName = "bad_cursor";
            this.badcursorDataGridViewTextBoxColumn.HeaderText = "bad_cursor";
            this.badcursorDataGridViewTextBoxColumn.Name = "badcursorDataGridViewTextBoxColumn";
            this.badcursorDataGridViewTextBoxColumn.Visible = false;
            // 
            // informationcursorBindingSource
            // 
            this.informationcursorBindingSource.DataMember = "information_cursor";
            this.informationcursorBindingSource.DataSource = this.فروشDataSet3;
            // 
            // فروشDataSet3
            // 
            this.فروشDataSet3.DataSetName = "فروشDataSet3";
            this.فروشDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // information_cursorTableAdapter
            // 
            this.information_cursorTableAdapter.ClearBeforeFill = true;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "customer";
            this.Text = "مشتری";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationcursorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.فروشDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private فروشDataSet3 فروشDataSet3;
        private System.Windows.Forms.BindingSource informationcursorBindingSource;
        private فروشDataSet3TableAdapters.information_cursorTableAdapter information_cursorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grouhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn darsadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkbedehiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkchekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noemissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badcursorDataGridViewTextBoxColumn;
    }
}