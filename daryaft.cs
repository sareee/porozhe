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
    public partial class daryaft : Form
    {
        public string code_c, name_c, shomare_faktor;
        public double cost,y;
        public int number;
        public daryaft(ref string code_cursor,ref string name_cursor,ref int cost,ref int number,ref string shomare_faktor)
        {
            InitializeComponent();
            this.code_c = code_cursor;
            this.name_c = name_cursor;
            this.cost = cost;
           // this.number = number;
            this.shomare_faktor =Convert.ToString( number);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = code_c;
            textBox16.Text = name_c;
            string k3_string = Convert.ToString(cost);
            textBox5.Text = k3_string;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string code = "", name = "";
            customer cs = new customer(ref code, ref name);
            cs.ShowDialog();
            code = cs.code;
            name = cs.name;
            textBox12.Text = code;
            textBox17.Text = name;
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
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int takhfif = 0, kartkhan = 0, naqdi = 0, nesiye = 0, digari = 0, qesti = 0, baqi = 0;
            if(textBox2.Text!="")
            {
                 takhfif = Convert.ToInt32(textBox2.Text);
            }
            if(textBox3.Text!="")
            {
                 naqdi = Convert.ToInt32(textBox3.Text);
            }
            if(textBox4.Text!="")
            {
                 kartkhan = Convert.ToInt32(textBox4.Text);
            }
            if(textBox10.Text!="")
            {
                nesiye = Convert.ToInt32(textBox10.Text);
            }
            if(textBox11.Text!="")
            {
                digari = Convert.ToInt32(textBox11.Text);
            }
            if(textBox15.Text!="")
            {
                qesti = Convert.ToInt32(textBox15.Text);
            }
            if(textBox13.Text!="")
            {
                baqi = Convert.ToInt32(textBox13.Text);
            }
            string sanduq = comboBox1.Text;
            string hesab_code = textBox6.Text;
            string number_kart = textBox8.Text;
            string comment = textBox9.Text;
            string tasvie = numericUpDown1.Value.ToString();
            string date = dateTimePicker1.Text;
            string code_cursor = textBox12.Text;
         //   string porsant = textBox14.Text;
            //string sql = "insert into resive_cost values ("+number+","+takhfif+","+naqdi+","+kartkhan+","+nesiye+","+digari+","+qesti+","+baqi+",'"+sanduq+"','"+hesab_code+"','"+number_kart+"','"+comment+"','"+tasvie+"','"+date+"','"+code_cursor+"','"+porsant+"')";
           // connect(sql);
          //  double s1=0d;
            
            MessageBox.Show("ok");      
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string code = "", name = "";
            customer cs = new customer(ref code, ref name);
            cs.ShowDialog();
            code = cs.code;
            name = cs.name;
            textBox6.Text = code;
            textBox18.Text = name;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // string shomare_faktor = "";
           // //daryaft d = new daryaft(ref shomare_faktor);
           // فاکتور_خرید f = new فاکتور_خرید(ref shomare_faktor);
           // shomare_faktor = f.shomare_faktr;
           ////double sud = 0d;
           //// soud s = new soud();
           //// s.ShowDialog();
           //// sud = s.sud;
           //// textBox14.Text = Convert.ToString(sud);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //double s1;
            //soud ss = new soud();
            //s1 = ss.sud;
            //y = cost + s1;
            int shomare_faktor_i = Convert.ToInt32(shomare_faktor);
            code_c = textBox1.Text;
            name_c = textBox16.Text;
            //qest_bandi q = new qest_bandi(ref shomare_faktor_i, ref y, ref  code_cursor, ref name_c);
            //qest_bandi q = new qest_bandi(ref shomare_faktor_i, ref y, ref code_cursor, ref name_cursor);
            qest_bandi q = new qest_bandi(ref shomare_faktor_i, ref cost, ref code_c, ref name_c);
            q.ShowDialog();
           // qest_bandi q = new qest_bandi(ref number,ref y,ref code_c,ref name_c);
          //  q.ShowDialog();
        }
    }
}
