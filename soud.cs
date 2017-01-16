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
    public partial class soud : Form
    {
        public Double sud = 0d;
        public soud()
        {

            InitializeComponent();
            comboBox1.Items.Add("سود بانکی");
            comboBox1.Items.Add("اعمال سود دلخواه");
            comboBox1.Items.Add("بدون سود");
            if(textBox4.Text!="")
            this.sud=Convert.ToDouble(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem.ToString();
            if (s == "سود بانکی")
            {
                int t = (Convert.ToInt32(textBox1.Text) * 18) / 2400;
                int t1 = Convert.ToInt32(textBox3.Text);
                int t2 = (t1 + 1) * t;
                textBox4.Text = Convert.ToString(t2);
            }
            else if (s == "اعمال سود دلخواه")
            {
                int t = (Convert.ToInt32(textBox1.Text) * (Convert.ToInt32(textBox2.Text))) / 2400;
                int t1 = Convert.ToInt32(textBox3.Text);
                int t2 = (t1 + 1) * t;
                textBox4.Text = Convert.ToString(t2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem.ToString();
            if (textBox4.Text == null || textBox4.Text == "")
            {
                if (s == "سود بانکی")
                {
                    int t = (Convert.ToInt32(textBox1.Text) * 18) / 2400;
                    int t1 = Convert.ToInt32(textBox3.Text);
                    int t2 = (t1 + 1) * t;
                    textBox4.Text = Convert.ToString(t2);
                }
                else if (s == "اعمال سود دلخواه")
                {
                    int t = (Convert.ToInt32(textBox1.Text) * (Convert.ToInt32(textBox2.Text))) / 2400;
                    int t1 = Convert.ToInt32(textBox3.Text);
                    int t2 = (t1 + 1) * t;
                    textBox4.Text = Convert.ToString(t2);
                }
            }
            string shomare_factor = Convert.ToString(0); ////از فرم مهسا دریافت شود
            string mande_factor = textBox1.Text;
            string tedad_aqsat = textBox3.Text;
            string darsad_sud;
            if (s == "سود بانکی")
            {
                darsad_sud = "18";
            }
            else darsad_sud = textBox2.Text;
            string sud_bedast_amade = textBox4.Text;
            string sql = "insert into [محاسبه سود]([شماره فاکتور] , [مانده فاکتور] , [تعداد اقساط] , [درصد سود] , [سود کسب شده]) values(" + shomare_factor + "," + mande_factor + "," + tedad_aqsat + "," + darsad_sud + "," + sud_bedast_amade + ")";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "سود بانکی")
            {
                textBox2.Visible = false;
                label4.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "اعمال سود دلخواه")
            {
                textBox2.Visible = true;
                label4.Visible = true;
                textBox2.Text = "";
            }
            else
            {
                textBox2.Visible = true;
                label4.Visible = true;
                textBox2.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

