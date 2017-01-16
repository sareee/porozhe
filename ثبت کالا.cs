using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace فروش
{
    public partial class ثبت_کالا : Form
    {
        public string code, name, brand,unit, group_kala, date_old,comment;
        public int  cost_buy, cost_sal;
        public float count, darsad;
        public ثبت_کالا()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.code = textBox1.Text;
            this.name = textBox2.Text;
            this.brand = textBox3.Text;
            if (textBox4.Text != "")
            {
                this.count = Convert.ToInt32(textBox4.Text);
            }
            else this.count = 0.0f;
            this.unit = comboBox1.Text;
            this.group_kala = comboBox2.Text;
            this.date_old = textBox5.Text;
            if (textBox5.Text != "")
            {
                this.cost_buy = Convert.ToInt32(textBox5.Text);
            }
            else this.cost_buy = 0;
            if (textBox6.Text != "")
            {
                this.cost_sal = Convert.ToInt32(textBox6.Text);
            }
            else this.cost_sal = 0;
            if (textBox7.Text != "")
            {
                this.darsad = Convert.ToInt32(textBox7.Text);
            }
            else this.darsad = 0.0f;
            this.comment = textBox8.Text;
            kala sabt = new kala();
            sabt.insert(code, name, brand, unit, group_kala, date_old, comment, cost_buy, cost_sal, count, darsad);
        }

        private void ثبت_کالا_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("عدد");
            comboBox2.Items.Add("لبنیات");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label10.Text = "درصد مالیات";
                textBox8.Visible = true;

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                label12.Text = "";
            if (textBox1.Text == "")
                label12.Text = "*";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
                label13.Text = "";
            if (textBox2.Text == "")
                label13.Text = "*";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
                label14.Text = "";
            if (textBox3.Text == "")
                label14.Text = "*";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != null)
                label15.Text = "";
            if (textBox5.Text == "")
                label15.Text = "*";
        }
        public void connect(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=فروش;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataReader dr;
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            // return dt;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string sql;
            string code_anbar, name_anbar,code_markaz, name_markaz;
            code_anbar = textBox10.Text;
            name_anbar = textBox11.Text;
            code_markaz=textBox12.Text;
            name_markaz=textBox13.Text;
            sql = "insert into anbar values("+code_anbar+",'"+name_anbar+"')";
            connect(sql);
            sql = "insert into sal_center values(" + code_markaz + ",'" + name_markaz + "')";
            connect(sql);
        }
    }
}
