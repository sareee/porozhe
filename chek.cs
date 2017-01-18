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
    public partial class chek : Form
    {
        public string kind, value, a, b, c, d, f, g, h, i;
        public chek(ref string a, ref string b, ref string c, ref string d, ref string f, ref string g, ref string h, ref string i)
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
        private void chek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'forushDataSet3.chek' table. You can move, or remove it, as needed.
            this.chekTableAdapter1.Fill(this.forushDataSet3.chek);
            comboBox1.Items.Add("شماره چک");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = this.data.CurrentRow.Cells[0].Value.ToString();
            b = this.data.CurrentRow.Cells[1].Value.ToString();
            c = this.data.CurrentRow.Cells[2].Value.ToString();
            d = this.data.CurrentRow.Cells[3].Value.ToString();
            f = this.data.CurrentRow.Cells[4].Value.ToString();
            g = this.data.CurrentRow.Cells[5].Value.ToString();
            h = this.data.CurrentRow.Cells[6].Value.ToString();
            i = this.data.CurrentRow.Cells[7].Value.ToString();
            Close();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt;
            this.value = textBox1.Text;
            this.kind = comboBox1.Text;
            sabt_hazine ah = new sabt_hazine();
            dt = ah.searcg_check_daryafti(kind, value);
            data.DataSource = dt;
        }
    }
}
