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
    public partial class garner_checking : Form
    {
        public string value, kind;
        public garner_checking()
        {
            InitializeComponent();
        }

        private void garner_checking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'فروشDataSet6.anbar_gardani' table. You can move, or remove it, as needed.
            this.anbar_gardaniTableAdapter.Fill(this.فروشDataSet6.anbar_gardani);
            comboBox1.Items.Add("کد کالا");
            comboBox1.Items.Add("نام کالا");
            comboBox1.Items.Add("گروه کالا");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt;
            //this.kind = comboBox1.Text;
            //this.value = textBox2.Text;
            //kala searching = new kala();
            //dt = searching.quicksearch(kind, value);
            //dataGridView1.DataSource = dt;
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
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
