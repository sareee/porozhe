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
    public partial class chek_pardakhti : Form
    {
        public string kind, value, a, b, c, d, f, g, h, i;
        public chek_pardakhti(ref string a, ref string b, ref string c, ref string d, ref string f, ref string g, ref string h, ref string i)
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chek_pardakhti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'forushDataSet4.chek_pardakhti' table. You can move, or remove it, as needed.
            this.chek_pardakhtiTableAdapter2.Fill(this.forushDataSet4.chek_pardakhti);
            comboBox1.Items.Add("شماره چک");
            comboBox1.Items.Add("نام بانک");
            comboBox1.Items.Add("سررسید");
            comboBox1.Items.Add("مبلغ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = this.data2.CurrentRow.Cells[0].Value.ToString();
            b = this.data2.CurrentRow.Cells[1].Value.ToString();
            c = this.data2.CurrentRow.Cells[2].Value.ToString();
            d = this.data2.CurrentRow.Cells[3].Value.ToString();
            f = this.data2.CurrentRow.Cells[4].Value.ToString();
            g = this.data2.CurrentRow.Cells[5].Value.ToString();
            h = this.data2.CurrentRow.Cells[6].Value.ToString();
            i = this.data2.CurrentRow.Cells[7].Value.ToString();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_chek_pardakhti add = new add_chek_pardakhti();
            add.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kind = comboBox1.Text;
            string value = textBox1.Text;
        }
    }
}
