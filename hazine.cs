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
    public partial class hazine : Form
    {
        public int cost_daryafti = 0,cost_int2=0,cost_pardakhti=0,a_int=0,a1_int=0;
        public hazine()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hazine_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("هزینه برق");
            comboBox1.Items.Add("هزینه آب");
            comboBox1.Items.Add("هزینه تلفن");
            comboBox1.Items.Add("هزینه تعمیرات");
            comboBox1.Items.Add("هزینه حقوق و دستمزد");
            comboBox1.Items.Add("هزینه حمل کالا");
            comboBox1.Items.Add("هزینه اجاره محل");
            comboBox1.Items.Add("هزینه ایاب و ذهاب");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int  s1;
            string s;
            string a = "", b = "", c = "", d = "", f = "", g = "", h = "", i = "";
            chek ch = new chek(ref a, ref b, ref c, ref d, ref f, ref g, ref h, ref i);
            if (e.ColumnIndex == 0)
            {
                ch.ShowDialog();
                a = ch.a;
                b = ch.b;
                c = ch.c;
                d = ch.d;
                f = ch.f;
                g = ch.g;
                h = ch.h;
                i = ch.i;
                this.dataGridView1.Rows.Add(new object[] { a, b, c, d, f, g, h, i });
                a_int = Convert.ToInt32(a);
                for (int u = 0; u < dataGridView1.RowCount - 1; u++)
                {
                    s = this.dataGridView1.Rows[u].Cells[7].Value.ToString();
                    s1 = Convert.ToInt32(s);
                    cost_daryafti += s1;
                }
                string s2_str = Convert.ToString(cost_daryafti);
                label9.Text = s2_str;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int s1;
            string s;
              string a1 = "", b = "", c = "", d = "", f = "", g = "", h = "", i = "";
            chek_pardakhti ch = new chek_pardakhti(ref a1, ref b, ref c, ref d, ref f, ref g, ref h, ref i);
            if (e.ColumnIndex == 0)
            {
                ch.ShowDialog();
                a1 = ch.a;
                b = ch.b;
                c = ch.c;
                d = ch.d;
                f = ch.f;
                g = ch.g;
                h = ch.h;
                i = ch.i;
                this.dataGridView2.Rows.Add(new object[] { a1, b, c, d, f, g, h, i });
                a1_int = Convert.ToInt32(a1);
                for (int u = 0; u < dataGridView2.RowCount - 1; u++)
                {
                    s = this.dataGridView2.Rows[u].Cells[7].Value.ToString();
                    s1 = Convert.ToInt32(s);
                    cost_pardakhti += s1;
                }
                string s2_str = Convert.ToString(cost_pardakhti);
                label10.Text = s2_str;
             }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = comboBox1.Text;
            string date = bPersianCalenderTextBox1.Text;
            string sanduq = textBox1.Text;
            string bank = textBox2.Text;
            int cost_sanduq = 0, cost_bank = 0;
            if (checkBox1.Checked && textBox3.Text != "")
            {
                cost_sanduq = Convert.ToInt32(textBox3.Text);
            }
            if (checkBox2.Checked && textBox4.Text != "")
            {
                cost_bank = Convert.ToInt32(textBox4.Text);
            }
            int cost = cost_daryafti + cost_pardakhti+ cost_sanduq + cost_bank;
            label11.Text = Convert.ToString(cost);
            sabt_hazine sh = new sabt_hazine();
            sh.save(source, date, sanduq, cost_sanduq, bank, cost_bank, a_int, a1_int, cost);
            MessageBox.Show("ثبت هزینه با موفقیت انجام شد");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bPersianCalenderTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}
