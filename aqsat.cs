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
    public partial class aqsat : Form
    {
        public aqsat()
        {

            comboBox1.Items.Add("نام مشتری");
            comboBox1.Items.Add("شماره فاکتور");
            comboBox1.Items.Add("تاریخ سررسید");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // flag++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Enabled = true;
            textBox1.Enabled = true;
            if (comboBox1.Text == "نام مشتری")
            {
                label2.Text = "نام مشتری مورد نظر: ";
            }
            else if (comboBox1.Text == "شماره فاکتور")
            {
                label2.Text = "شماره فاکتور موردنظر: ";
            }
            else if (comboBox1.Text == "تاریخ سررسید")
            {
                label2.Text = "تاریخ سر رسید فاکتور مورد نظر: ";
            }
        }
    }
}
