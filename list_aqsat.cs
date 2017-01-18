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
    public partial class list_aqsat : Form
    {
        public string item = "";
        public list_aqsat(ref string item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void list_aqsat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'forushDataSet7.list_aqsat' table. You can move, or remove it, as needed.
            this.list_aqsatTableAdapter1.Fill(this.forushDataSet7.list_aqsat);
            if (item == "")
            {
                // TODO: This line of code loads data into the 'فروشDataSet13.list_aqsat' table. You can move, or remove it, as needed.
                //this.list_aqsatTableAdapter.Fill(this.فروشDataSet13.list_aqsat);
                this.list_aqsatTableAdapter1.Fill(this.forushDataSet7.list_aqsat);
            }
            else
            {
                aqsat_1 aq = new aqsat_1();
                aq.search2(item);
            }

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                string date = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string s = DateTime.Today.Date.ToString();
                bPersianCalenderTextBox1.Today_Click(s, e);
                string s1 = bPersianCalenderTextBox1.Text;
                string[] t = new string[3];
                string[] t1 = new string[3];
                t = date.Split('/');
                t1 = s1.Split('/');
                for (int j = 0; j < 3; j++)
                {
                    t[0] += t[j];
                    t1[0] += t[j];
                }
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "پرداخت نشده" && date == s1)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Honeydew;
                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "پرداخت نشده" && Convert.ToInt32(t[0]) < Convert.ToInt32(t1))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "پرداخت شده")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
