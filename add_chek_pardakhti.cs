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
    public partial class add_chek_pardakhti : Form
    {
        public add_chek_pardakhti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;
            int a = Convert.ToInt32(textBox1.Text);
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = textBox4.Text;
            string f = textBox5.Text;
            string g = textBox6.Text;
            string h = textBox7.Text;
            if (textBox8.Text != "")
            {
                i = Convert.ToInt32(textBox8.Text);
            }
            sabt_hazine s = new sabt_hazine();
            s.add(a, b, c, d, f, g, h, i);
            MessageBox.Show("ثبت شد");
        }
    }
}
