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
    public partial class منو : Form
    {
        public string kind, value, b;
        public int flag = 0;
        public منو()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);

        }

        private void کالاToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void weeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt;
            kala refresh = new kala();
            dt=refresh.Refresh();
            dataGridView1.DataSource = dt;
        }

        private void منو_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'فروشDataSet.kala' table. You can move, or remove it, as needed.
            this.kalaTableAdapter.Fill(this.فروشDataSet.kala);
            comboBox1.Items.Add("کد کالا");
            comboBox1.Items.Add("نام کالا");
            comboBox1.Items.Add("گروه کالا");
            comboBox2.Items.Add("1390");
            comboBox2.Items.Add("1391");
            comboBox2.Items.Add("1392");
            comboBox2.Items.Add("1393");
            comboBox2.Items.Add("1394");
            comboBox2.Items.Add("1395");
            comboBox2.Items.Add("1396");
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            tabControl1.ClientSize = new Size(w, h);
            dataGridView1.ClientSize = new Size(w, h);
            groupBox1.ClientSize = new Size(w, h);
            groupBox2.ClientSize = new Size(w, h);
            dataGridView2.ClientSize = new Size(w/2, h);
            dataGridView3.ClientSize = new Size(w,h);
            dataGridView4.ClientSize = new Size(w, h/4);
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ثبت_کالا sabt = new ثبت_کالا();
            sabt.ShowDialog();
        }

        private void تغییررمزعبورونامکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            تغییر_نام_کاربری_و_رمز_عبور change = new تغییر_نام_کاربری_و_رمز_عبور();
            change.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt ;
            this.kind = comboBox1.Text;
            this.value = textBox1.Text;
            kala searching = new kala();
            dt = searching.quicksearch(kind, value);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            label2.Text = comboBox1.Text;
            textBox1.Visible = true;
            //button1.Visible = true;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
         
            int a;
            //حذف_کالا delete = new حذف_کالا();
            //delete.ShowDialog();
      
            if (MessageBox.Show("هشدار", "آيا از حذف سطر فعلي مطمئن هستيد؟", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                b = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                a = dataGridView1.CurrentRow.Index;
                this.dataGridView1.Rows.RemoveAt(a);
            }
            //MessageBox.Show(b);   
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        } 

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string s = "";
            فاکتور_خرید kharid = new فاکتور_خرید(ref s);
            kharid.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
         
        }
        public void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete && dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ثبتاطلاعاتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            information_customer ic = new information_customer();
            ic.Show();
        }

        private void انبارگردانیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            garner_checking gs = new garner_checking();
            gs.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            hazine h = new hazine();
            h.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tabPage2.Text = " گزارش آنالیز ماهانه";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void گزارشآنالیزروزانهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            tabPage3.Text = "گزارش عملکرد روزانه";

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                string[] a = new string[13];
                a[0] = "فروردین"; a[1] = "اردیبهشت"; a[2] = "خرداد"; a[3] = "تیر "; a[4] = "مرداد"; a[5] = "شهریور"; a[6] = "مهر";
                a[7] = "آبان"; a[8] = "آذر"; a[9] = "دی"; a[10] = "بهمن"; a[11] = "اسفند"; a[12] = "مجموع";
                string date = comboBox2.Text;
                gozaresh g = new gozaresh();
                g.daramad(date );
                string daramad = g.summ;
                int daramad_int = Convert.ToInt32(daramad);
                g.hazine(date);
                string hazine = g.summ;
                int hazine_int = Convert.ToInt32(hazine);
                int soud = daramad_int - hazine_int;
                g.daramad2(date);
                string daramad2 = g.summ;
                int daramad2_int = Convert.ToInt32(daramad2);
                g.hazine2(date);
                string hazine2 = g.summ;
                int hazine2_int = Convert.ToInt32(hazine2);
                int soud2 = daramad2_int - hazine2_int;
                g.daramad3(date);
                string daramad3 = g.summ;
                int daramad3_int = Convert.ToInt32(daramad3);
                g.hazine3(date);
                string hazine3 = g.summ;
                int hazine3_int = Convert.ToInt32(hazine3);
                int soud3 = daramad3_int - hazine3_int;
                g.daramad4(date);
                string daramad4 = g.summ;
                int daramad4_int = Convert.ToInt32(daramad4);
                g.hazine4(date);
                string hazine4 = g.summ;
                int hazine4_int = Convert.ToInt32(hazine4);
                int soud4 = daramad4_int - hazine4_int;
                g.daramad5(date);
                string daramad5 = g.summ;
                int daramad5_int = Convert.ToInt32(daramad5);
                g.hazine5(date);
                string hazine5 = g.summ;
                int hazine5_int = Convert.ToInt32(hazine5);
                int soud5 = daramad5_int - hazine5_int;
                g.daramad6(date);
                string daramad6 = g.summ;
                int daramad6_int = Convert.ToInt32(daramad6);
                g.hazine6(date);
                string hazine6 = g.summ;
                int hazine6_int = Convert.ToInt32(hazine6);
                int soud6 = daramad6_int - hazine6_int;
                g.daramad7(date);
                string daramad7 = g.summ;
                int daramad7_int = Convert.ToInt32(daramad7);
                g.hazine7(date);
                string hazine7 = g.summ;
                int hazine7_int = Convert.ToInt32(hazine7);
                int soud7 = daramad7_int - hazine7_int;
                g.daramad8(date);
                string daramad8 = g.summ;
                int daramad8_int = Convert.ToInt32(daramad8);
                g.hazine8(date);
                string hazine8 = g.summ;
                int hazine8_int = Convert.ToInt32(hazine8);
                int soud8 = daramad8_int - hazine8_int;
                g.daramad9(date);
                string daramad9 = g.summ;
                int daramad9_int = Convert.ToInt32(daramad9);
                g.hazine9(date);
                string hazine9 = g.summ;
                int hazine9_int = Convert.ToInt32(hazine9);
                int soud9 = daramad9_int - hazine9_int;
                g.daramad10(date);
                string daramad10 = g.summ;
                int daramad10_int = Convert.ToInt32(daramad10);
                g.hazine10(date);
                string hazine10 = g.summ;
                int hazine10_int = Convert.ToInt32(hazine10);
                int soud10 = daramad10_int - hazine10_int;
                g.daramad11(date);
                string daramad11 = g.summ;
                int daramad11_int = Convert.ToInt32(daramad11);
                g.hazine11(date);
                string hazine11 = g.summ;
                int hazine11_int = Convert.ToInt32(hazine11);
                int soud11 = daramad11_int - hazine11_int;
                g.daramad12(date);
                string daramad12 = g.summ;
                int daramad12_int = Convert.ToInt32(daramad12);
                g.hazine12(date);
                string hazine12 = g.summ;
                int hazine12_int = Convert.ToInt32(hazine12);
                int soud12 = daramad12_int - hazine12_int;
                this.dataGridView2.Rows.Add(new object[] { a[0], daramad, hazine,soud });
                this.dataGridView2.Rows.Add(new object[] { a[1], daramad2, hazine2,soud2 });
                this.dataGridView2.Rows.Add(new object[] { a[2], daramad3, hazine3, soud3 });
                this.dataGridView2.Rows.Add(new object[] { a[3], daramad4, hazine4, soud4 });
                this.dataGridView2.Rows.Add(new object[] { a[4], daramad5, hazine5, soud5 });
                this.dataGridView2.Rows.Add(new object[] { a[5], daramad6, hazine6, soud6 });
                this.dataGridView2.Rows.Add(new object[] { a[6], daramad7, hazine7, soud7 });
                this.dataGridView2.Rows.Add(new object[] { a[7], daramad8, hazine8, soud8 });
                this.dataGridView2.Rows.Add(new object[] { a[8], daramad9, hazine9, soud9 });
                this.dataGridView2.Rows.Add(new object[] { a[9], daramad10, hazine10, soud10 });
                this.dataGridView2.Rows.Add(new object[] { a[10], daramad11, hazine11, soud11 });
                this.dataGridView2.Rows.Add(new object[] { a[11], daramad12, hazine12, soud12 });
                this.dataGridView2.Rows.Add(new object[] { a[12] });
            }
            flag++;
        }

        private void ثبتفاکتورخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buy_factor buy = new buy_factor();
            buy.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string date1 = bPersianCalenderTextBox1.Text;
            string date2 = bPersianCalenderTextBox2.Text;
            this.dataGridView3.Rows.Add(new object[] { "فاکتور فروش"});

        }
    }
}
