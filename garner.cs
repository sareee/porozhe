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
    public partial class garner : Form
    {
        public string code, name;
        public garner(ref string code, ref string name)
        {
            InitializeComponent();
            this.code = code;
            this.name = name;
        }

        private void garner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'فروشDataSet4.anbar' table. You can move, or remove it, as needed.
            this.anbarTableAdapter.Fill(this.فروشDataSet4.anbar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            code = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
