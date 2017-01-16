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
    public partial class sal_center : Form
    {
        public string code, name;
        public sal_center(ref string code, ref string name)
        {
            InitializeComponent();
            this.code = code;
            this.name=name;
        }

        private void sal_center_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'فروشDataSet5.sal_center' table. You can move, or remove it, as needed.
            this.sal_centerTableAdapter.Fill(this.فروشDataSet5.sal_center);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            code = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
