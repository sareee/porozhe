using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace فروش
{
    public partial class customer : Form
    {
        public string code, name;
        public customer(ref string code, ref string name)
        {
            InitializeComponent();
            this.code = code;
            this.name = name;
        }

        private void customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'فروشDataSet3.information_cursor' table. You can move, or remove it, as needed.
            this.information_cursorTableAdapter.Fill(this.فروشDataSet3.information_cursor);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.information_cursorTableAdapter.FillBy(this.فروشDataSet3.information_cursor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            code=this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
