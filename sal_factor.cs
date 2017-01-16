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
    public partial class فاکتور_خرید : Form
    {
        public string a, b, c, d, k1, o1_str, mali_str,cost_str;
        public double o, maliat, o1 = 0d;
        public string shomare_faktr = "";
        public int y = 0, z3 = 0, cost_1 = 0, k3 = 0;
        public فاکتور_خرید(ref string  shomare_faktr)
        {
            InitializeComponent();
            this.shomare_faktr = shomare_faktr;
        }

        private void فاکتور_خرید_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'فروشDataSet1.kala' table. You can move, or remove it, as needed.
            //this.kalaTableAdapter.Fill(this.فروشDataSet1.kala);
            label3.Text = k1;
            label5.Text = k1;
            factor num = new factor();
            num.numberic();
            textBox1.Text = Convert.ToString(num.N);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a = "", b = "", c = "", d = "", f = "", g = "", h = "", i = "", j = "", k = "", l = "";
            انتخاب_کالا add = new انتخاب_کالا(ref a, ref b, ref c, ref d, ref f, ref g, ref h, ref i, ref j, ref k, ref l);
            add.ShowDialog();
            a = add.a;
            b = add.b;
            c = add.c;
            d = add.d;
            f = add.f;
            g = add.g;
            h = add.h;
            i = add.i;
            this.dataGridView1.Rows.Add(new object[] {a,b,c,d,f,g,h,i});
            string[,] kala_data = new string[4, dataGridView1.RowCount - 1];
            for (int x = 0; x < 4; x++)
            {
                for (y = 0; y < dataGridView1.Rows.Count - 1; y++)
                {
                    kala_data[x, y] = this.dataGridView1.Rows[y].Cells[x].Value.ToString();
                }
            }
            kala m = new kala();
            m.sum(kala_data[0, dataGridView1.Rows.Count - 2], kala_data[1, dataGridView1.Rows.Count - 2], kala_data[2, dataGridView1.Rows.Count - 2], kala_data[3, dataGridView1.Rows.Count - 2]);
            k1 = m.summ;//قیمت یک کالا
            int k2 = Convert.ToInt32(k1);
            k3 += k2;//قیمت همه کالاها
            string k3_string = Convert.ToString(k3);
            label3.Text = k3_string;
            factor s = new factor();
            s.cost(kala_data[0, dataGridView1.Rows.Count - 2], kala_data[1, dataGridView1.Rows.Count - 2], kala_data[2, dataGridView1.Rows.Count - 2], kala_data[3, dataGridView1.Rows.Count - 2]);
            o1 = s.o;
            double o2 = s.o / 100;
            // o1 += o;//محموع درصد مالیاتها
            maliat = o2 * k2;//درصد مالیات*قیمت کالا
            int maliat_int = Convert.ToInt32(maliat);
            // cost = maliat + k3;//قیمت نهایی 
            o1_str = Convert.ToString(o1);
            mali_str = Convert.ToString(maliat_int);
            string c1 = "مالیات";
            string c2 = "+";
            this.dataGridView2.Rows.Add(new object[] { c1, c2, o1_str, mali_str });
            string z;
            int z2;
            for (int u = 0; u < dataGridView2.RowCount - 1; u++)
            {
                z = this.dataGridView2.Rows[u].Cells[3].Value.ToString();
                z2 = Convert.ToInt32(z);
                z3 += z2;
            }
            cost_1 = z3 + k3;
            cost_str = Convert.ToString(cost_1);
            label18.Text = cost_str;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code="", name="";
            customer cs = new customer(ref code,ref name);
            cs.ShowDialog();
            code = cs.code;
            name = cs.name;
            textBox2.Text = code;
            textBox3.Text = name;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = "", name = "";
            garner gn = new garner(ref code, ref name);
            gn.ShowDialog();
            code = gn.code;
            name = gn.name;
            textBox8.Text = code;
            textBox7.Text = name;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code = "", name = "";
            sal_center s = new sal_center(ref code, ref name);
            s.ShowDialog();
            code = s.code;
            name = s.name;
            textBox6.Text = code;
            textBox5.Text = name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string code = "", name = "";
            customer cs = new customer(ref code, ref name);
            cs.ShowDialog();
            code = cs.code;
            name = cs.name;
            textBox10.Text = code;
            textBox9.Text = name;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            shomare_faktr = textBox1.Text;
            int mablaq=0;
            int number = Convert.ToInt32(textBox1.Text);
            string date = bPersianCalenderTextBox1.Text;
            string code_cursor = textBox2.Text;
            string name_cursor = textBox3.Text;
            string code_center = textBox6.Text;
            string code_gerner = textBox8.Text;
            string code_vaset = textBox10.Text;
            string name_vaset = textBox9.Text;
            string darsad = textBox11.Text;
            if(textBox12.Text!="")
            {
                mablaq = Convert.ToInt32(textBox12.Text);
            }
            string location = textBox13.Text;
            string sending = textBox14.Text;
            string comment = textBox15.Text;
            int hou = DateTime.Today.Hour;
            int min = DateTime.Today.Minute;
            int second = DateTime.Today.Second;
            string time = hou + ":" + min + ":" + second;
            double k3=0;
            factor s = new factor();
          //  double o1=0d;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                a = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                b = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                c = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                d = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
                s.save(number,a,b,c,d,date,code_cursor,time,code_center,code_gerner,code_vaset,location,sending,comment,cost_1);
                //kala k = new kala();
                //k.sum(a, b, c, d);
                //k1 = k.summ;
                //int k2 = Convert.ToInt32(k1);
                //k3+=k2;
                //s.cost(a, b, c, d);
                //o1 += o;
            }
            s.save2(number,code_cursor ,date, cost_1);
            //maliat = o1 * k3;
            //cost = maliat + k3;
            //o1_str = Convert.ToString(o1);
            //cost_str = Convert.ToString(cost);
            //if(checkBox1.Checked)
            //{
            //    factor s2 = new factor();
            //    s2.vaset_save(number, code_vaset, name_vaset, darsad, mablaq);
            //}
            //string c1 = "مالیات";
            //string c2 = "+";
            //this.dataGridView2.Rows.Add(new object[] { c1, c2, o1_str, cost_str });
            string temp = "";
            daryaft r = new daryaft(ref code_cursor, ref name_cursor, ref k3, ref number, ref temp);
            r.ShowDialog();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string c1 = "مالیات";
            //string c2 = "+";
            //this.dataGridView2.Rows.Add(new object[] {c1,c2,o1_str,cost_str });
        }
    }
}
