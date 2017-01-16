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
    public partial class تغییر_نام_کاربری_و_رمز_عبور : Form
    {
        string karbari, ramz, karbari_new, ramz_new1, ramz_new2;
        public تغییر_نام_کاربری_و_رمز_عبور()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.karbari = textBox1.Text;
            this.ramz = textBox2.Text;
            this.karbari_new = textBox3.Text;
            this.ramz_new1 = textBox4.Text;
            this.ramz_new2 = textBox5.Text;
            login log = new login();
            log.change(karbari, ramz, karbari_new, ramz_new1, ramz_new2);
            string error = log.error;
            if (error != null)
            { label6.Text = error; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
