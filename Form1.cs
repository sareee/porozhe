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
    public partial class Form1 : Form
    {
        public string karbari, ramz;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.karbari = textBox1.Text;
            this.ramz = textBox2.Text;
            login log = new login();
            log.vorud(karbari, ramz);
            string error = log.error;
            if (error != null)
            { label3.Text = error; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
