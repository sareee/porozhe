namespace فروش
{
    partial class PrintOptions
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
            this.chklst = new System.Windows.Forms.CheckedListBox();
            this.printtitle = new System.Windows.Forms.TextBox();
            this.rdoallrow = new System.Windows.Forms.RadioButton();
            this.rdoselectedrow = new System.Windows.Forms.RadioButton();
            this.btnok = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chklst
            // 
            this.chklst.FormattingEnabled = true;
            this.chklst.Location = new System.Drawing.Point(297, 57);
            this.chklst.Name = "chklst";
            this.chklst.Size = new System.Drawing.Size(166, 154);
            this.chklst.TabIndex = 0;
            // 
            // printtitle
            // 
            this.printtitle.Location = new System.Drawing.Point(12, 159);
            this.printtitle.Multiline = true;
            this.printtitle.Name = "printtitle";
            this.printtitle.Size = new System.Drawing.Size(247, 52);
            this.printtitle.TabIndex = 1;
            this.printtitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdoallrow
            // 
            this.rdoallrow.AutoSize = true;
            this.rdoallrow.Location = new System.Drawing.Point(157, 12);
            this.rdoallrow.Name = "rdoallrow";
            this.rdoallrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoallrow.Size = new System.Drawing.Size(102, 17);
            this.rdoallrow.TabIndex = 2;
            this.rdoallrow.TabStop = true;
            this.rdoallrow.Text = "چاپ همه سطر ها";
            this.rdoallrow.UseVisualStyleBackColor = true;
            // 
            // rdoselectedrow
            // 
            this.rdoselectedrow.AutoSize = true;
            this.rdoselectedrow.Location = new System.Drawing.Point(128, 44);
            this.rdoselectedrow.Name = "rdoselectedrow";
            this.rdoselectedrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoselectedrow.Size = new System.Drawing.Size(131, 17);
            this.rdoselectedrow.TabIndex = 3;
            this.rdoselectedrow.TabStop = true;
            this.rdoselectedrow.Text = "چاپ سطر های انتخابی";
            this.rdoselectedrow.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(12, 273);
            this.btnok.Name = "btnok";
            this.btnok.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnok.Size = new System.Drawing.Size(88, 30);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "تایید";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(133, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "اندازه صفحه چاپ شود";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = ":عنوان";
            // 
            // PrintOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.rdoselectedrow);
            this.Controls.Add(this.rdoallrow);
            this.Controls.Add(this.printtitle);
            this.Controls.Add(this.chklst);
            this.Name = "PrintOptions";
            this.Text = "PrintOptions";
            this.Load += new System.EventHandler(this.PrintOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklst;
        private System.Windows.Forms.TextBox printtitle;
        private System.Windows.Forms.RadioButton rdoallrow;
        private System.Windows.Forms.RadioButton rdoselectedrow;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;

    }
}