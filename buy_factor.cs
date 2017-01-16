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
    public partial class buy_factor : Form
    {
        public string a, b, c, d, k1, o1_str, mali_str, cost_str;
        public double o, maliat, o1 = 0d;
        public string shomare_faktr = "";
        public int y = 0, z3 = 0, cost_1 = 0, k3 = 0;
        public buy_factor()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = 0;
            if(e.ColumnIndex==0)
            {
                string a = "", b = "", c = "", d = "", f = "", g = "", h = "", i = "", j = "", k = "", l = "";
                add_kala_buy_factor add = new add_kala_buy_factor(ref a, ref b, ref c, ref d, ref f, ref g, ref h, ref i, ref j, ref k, ref l);
                add.ShowDialog();
                a = add.a;
                b = add.b;
                c = add.c;
                d = add.d;
                f = add.f;
                g = add.g;
                h = add.h;
                i = add.i;
                this.dataGridView1.Rows.Add(new object[] { a, b, c, d, f, g, h, i });
                string[,] kala_data = new string[4, dataGridView1.RowCount - 1];
                for (int x = 0; x < 4; x++)
                {
                    for (y = 0; y < dataGridView1.Rows.Count - 1; y++)
                    {
                        kala_data[x, y] = this.dataGridView1.Rows[y].Cells[x].Value.ToString();
                    }
                }
                kala m = new kala();
                m.sum(kala_data[0, dataGridView1.Rows.Count - 2], kala_data[1, dataGridView1.Rows.Count - 2], kala_data[2, dataGridView1.Rows.Count - 2], kala_data[3, dataGridView1.Rows.Count - 2]);
                k1 = m.summ;//قیمت یک کالا
                int k2 = Convert.ToInt32(k1);
                k3 += k2;//قیمت همه کالاها
                string k3_string = Convert.ToString(k3);
                label3.Text = k3_string;
                factor s = new factor();
                s.cost(kala_data[0, dataGridView1.Rows.Count - 2], kala_data[1, dataGridView1.Rows.Count - 2], kala_data[2, dataGridView1.Rows.Count - 2], kala_data[3, dataGridView1.Rows.Count - 2]);
                o1 = s.o;
                double o2 = s.o / 100;
                // o1 += o;//محموع درصد مالیاتها
                maliat = o2 * k2;//درصد مالیات*قیمت کالا
                int maliat_int = Convert.ToInt32(maliat);
                // cost = maliat + k3;//قیمت نهایی 
                o1_str = Convert.ToString(o1);
                mali_str = Convert.ToString(maliat_int);
                string c1 = "مالیات";
                string c2 = "+";
                this.dataGridView2.Rows.Add(new object[] { c1, c2, o1_str, mali_str });
                string z;
                int z2;
                for (int u = 0; u < dataGridView2.RowCount - 1; u++)
                {
                    z = this.dataGridView2.Rows[u].Cells[3].Value.ToString();
                    z2 = Convert.ToInt32(z);
                    z3 += z2;
                }
                cost_1 = z3 + k3;
                cost_str = Convert.ToString(cost_1);
                label18.Text = cost_str;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string code_gerner = textBox8.Text;
            string code_cursor = textBox2.Text;
            string time = textBox4.Text;
            string comment = textBox15.Text;
            factor f = new factor();
           // f.save();
        }
    }
}
