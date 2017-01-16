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
    public partial class add_kala_buy_factor : Form
    {
        public string kind, value, a, b, c, d, f, g, h, i, j, k, l;
        public int flag = 0;
        public add_kala_buy_factor(ref string a, ref string b, ref string c, ref string d, ref string f, ref string g, ref string h, ref string i, ref string j, ref string k, ref string l)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
            this.l = l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag++;
            //if (this.dataGridView1.CurrentRow != null)
            //{
            /* if (this.dataGridView2.ColumnCount == 0)
             {
                 this.dataGridView2.Columns.Add("column1", "column1");
                 this.dataGridView2.Columns.Add("column2", "column2");
                 this.dataGridView2.Columns.Add("column3", "column3");
             }*/
            //  dataGridView1.SelectedCells = 0;
            a = this.data.CurrentRow.Cells[0].Value.ToString();
            b = this.data.CurrentRow.Cells[1].Value.ToString();
            c = this.data.CurrentRow.Cells[2].Value.ToString();
            d = this.data.CurrentRow.Cells[3].Value.ToString();
            f = this.data.CurrentRow.Cells[4].Value.ToString();
            g = this.data.CurrentRow.Cells[5].Value.ToString();
            h = this.data.CurrentRow.Cells[7].Value.ToString();
            i = this.data.CurrentRow.Cells[9].Value.ToString();
            //j = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //k = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //l = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            // this.dataGridView2.Rows.Add(new object[] { name, family, age });
            Close();
            //}
        }

        private void add_kala_buy_factor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'فروشDataSet2.kala' table. You can move, or remove it, as needed.
            this.kalaTableAdapter.Fill(this.فروشDataSet2.kala);
            comboBox1.Items.Add("کد کالا");
            comboBox1.Items.Add("نام کالا");
            comboBox1.Items.Add("گروه کالا");
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
