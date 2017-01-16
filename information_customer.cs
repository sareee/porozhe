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
    public partial class information_customer : Form
    {
        public information_customer()
        {
            InitializeComponent();
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //GroupBox authorGroup = new GroupBox();
            //authorGroup.ForeColor = Color.Maroon;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a="", b="", c="", d="", f="", g="", h="",i="";
            float darsad=0.0f;
            int etebar_bedehi=0, etebar_chek=0,code_1=0;
            if (textBox1.Text != "")
            {
                code_1 = Convert.ToInt32(textBox1.Text);
            }
            string name_1 = textBox2.Text;
            string code_2 = textBox4.Text;
            string name_2 = textBox3.Text;
            string code_3 = textBox5.Text;
            string name_3 = textBox9.Text;
            string group = comboBox2.Text;
            if (textBox10.Text!= "")
            {
                darsad = Convert.ToInt32(textBox10.Text);
            }
            if (textBox6.Text != " ")
            {
                etebar_bedehi = Convert.ToInt32(textBox6.Text);
            }
            if (textBox7.Text != "")
            {
                etebar_chek = Convert.ToInt32(textBox7.Text);
            }
            string sal_tip = comboBox1.Text;
            string tasvie = textBox8.Text;
            if (checkBox1.Checked)
            {
                a = "خریدار";
                darsad = 0.0f;
            }
            else if(checkBox2.Checked)
            {
                a = "فروشنده";
                darsad = 0.0f;
            }
            else if (checkBox3.Checked)
                a = "واسط";
            if (checkBox5.Checked)
                b = "فعال";
            else
                b = "NO";
            if(checkBox6.Checked)
                c = "فعال";
            else
                c = "غیرفعال";
            if (checkBox4.Checked)
                d = "غیرفعال";
            else
                d = "OK";
            if (checkBox7.Checked)
                f = "OK";
            else
                f = "OK";
            if (checkBox8.Checked)
                g = "OK";
            else 
                g = "NO";
            if (checkBox9.Checked)
                h = "OK";
            else
                h = "بدحساب";
            if (radioButton2.Checked)
            {
                i = "شخص";
                
                string sql = "insert into information_cursor values("+code_1+",'"+name_1+"','"+i+"','"+a+"',"+darsad+",'"+d+"','"+b+"',"+etebar_bedehi+",'"+c+"',"+etebar_chek+",'"+f+"','"+sal_tip+"','"+tasvie+"','"+g+"','"+h+"')";
                connect(sql);
            }
            if(radioButton3.Checked)
            {
                i = "شرکت";
                string sql = "insert into information_cursor values(" + code_2 + ",'" + name_2 + "','" + i + "','" + a + "'," + darsad + ",'" + d + "','" + b + "'," + etebar_bedehi + ",'" + c + "'," + etebar_chek + ",'" + f + "','" + sal_tip + "','" + tasvie + "','" + g + "','" + h + "')";
                connect(sql);
            }
            if (radioButton1.Checked)
            {
                string sql = "insert into information_cursor values(" + code_3 + ",'" + name_3 + "','" + group + "','" + a + "'," + darsad + ",'" + d + "','" + b + "'," + etebar_bedehi + ",'" + c + "'," + etebar_chek + ",'" + f + "','" + sal_tip + "','" + tasvie + "','" + g + "','" + h + "')";
                connect(sql);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void information_customer_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("مشتری");
        }
    }
}
