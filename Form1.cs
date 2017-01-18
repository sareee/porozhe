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
            Hide();
            login log = new login();
            Show();
            log.vorud(karbari, ramz);
            string error = log.error;
            if (error != null)
            { label3.Text = error; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    try
            //    {
            //        SqlConnection con = new SqlConnection();
            //        con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            //        con.Open();

            //        string str = "EXECUTE sp_attach_db @dbname = N'فروش' , " + " @filename1 = N'" + Application.StartupPath + "\\فروش.mdf'," + "@filename2 = N'" + Application.StartupPath + "\\فروش_log.ldf'";

            //        SqlCommand cmd = new SqlCommand(str, con);
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show(" شد Attach ديتابيس با موفقيت");

            //    }
            //    catch (Exception x)
            //    {
            //        if (x.Message.IndexOf("already exists") >= 0)
            //            MessageBox.Show("ديتابيس موجود است");
            //        else
            //            MessageBox.Show(x.Message);
            //    }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
