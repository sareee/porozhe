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
    public partial class حذف_کالا : Form
    {
        public string code, name, brand, date;
        public حذف_کالا()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.code = textBox1.Text;
            this.name = textBox2.Text;
            this.brand = textBox3.Text;
            this.date = textBox4.Text;
            kala del = new kala();
            del.delete(code,name,brand,date);
        }

        private void حذف_کالا_Load(object sender, EventArgs e)
        {

        }
    }
}
