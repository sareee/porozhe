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
    public partial class qest_bandi : Form
    {
        public int number;
        public double cost;
        public string code_cursor, name_cursor;
        public qest_bandi(ref int number,ref double cost,ref string code_cursor,ref string name_cursor)
        {
            InitializeComponent();
           // comboBox1.Items.Add("");
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("12");
            comboBox1.Items.Add("18");
            comboBox2.Items.Add("شنبه");
            comboBox2.Items.Add("یکشنبه");
            comboBox2.Items.Add("دوشنبه");
            comboBox2.Items.Add("سه شنبه");
            comboBox2.Items.Add("چهارشنبه");
            comboBox2.Items.Add("پنج شنبه");
            comboBox2.Items.Add("جمعه");
            comboBox3.Items.Add("سود بانکی");
            comboBox3.Items.Add("اعمال سود دلخواه");
            comboBox3.Items.Add("بدون سود");
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (flag == 0)
            //{

            //}
            // MessageBox.Show("قبلا ذخیره شده است");
            //محاسبه_سود_قسط_بندی m = new محاسبه_سود_قسط_بندی();
            //m.ShowDialog();
            //ghest_bandi gh = new ghest_bandi(); // ذخیره تیبل (شماره فاکتور-ایدی طرف حساب-تاریخ شروع-تعداد اقساط-مبلغ فاکتور-نوع دوره-درصدجریمه)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string sql="select* from list_qest";
            //connect(sql);
            //ghest_bandi gh = new ghest_bandi();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            //textBox7.Text = "1";
            //textBox1.Text = "202";
            //textBox2.Text = "2000000";
            //textBox2.Enabled = false;
            //textBox4.Text = "mohiya";
            //textBox4.Enabled = false;
            //textBox3.Text = "1202";
            //textBox3.Enabled = false;
            //switch (comboBox1.Text)
            //{
            //    case ("1 "): textBox5.Text = "1"; break;
            //    case ("3 ماهه"): textBox5.Text = "3"; break;
            //    case ("6 ماهه"): textBox5.Text = "6"; break;
            //    case ("12 ماهه"): textBox5.Text = "12"; break;
            //    case ("18 ماهه"): textBox5.Text = "18"; break;
            //}
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label13.Enabled = true;
                textBox10.Enabled = true;
            }
            else
            {
                label13.Enabled = false;
                textBox10.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox7.Enabled = true;
                label9.Enabled = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            else
            {
                textBox7.Enabled = false;
                label10.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox2.Enabled = true;
                label10.Enabled = true;
                radioButton3.Checked = false;
                radioButton1.Checked = false;
            }
            else
            {
                comboBox2.Enabled = false;
                label11.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox8.Enabled = true;
                label11.Enabled = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else
            {
                textBox8.Enabled = false;
                label12.Enabled = false;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)// قسط بندی
        {
            //if (comboBox1.Text == "")
            //{
            //    aqsat q = new aqsat(ref flag);
            //    q.ShowDialog();
            //}
            //else
            //{
                dataGridView1.Rows.Clear();
                label27.Text = textBox2.Text;
                string shomare_faktor = textBox1.Text;
                string custor = textBox3.Text;
                string cost_total = textBox2.Text;
                string date_today = dateTimePicker1.Text;
                string tedad_aqsat = textBox5.Text;
                string date_sar_resid = dateTimePicker2.Text;
                double cost1 = Convert.ToInt32(cost_total) / Convert.ToInt32(tedad_aqsat);
                int cost2 = Convert.ToInt32(cost_total) / Convert.ToInt32(tedad_aqsat);
                double cost3 = cost1 - cost2;
                string[] date = new string[3];
                date = date_sar_resid.Split('/');
                string date1 = "", dore;
                int t = 0, t1 = 0, t2 = 0;
                for (int i = 0; i < Convert.ToInt32(tedad_aqsat); i++)
                {
                    if (i == 0)
                    {
                        cost1 = cost3 + cost2;
                        date1 = date[1] + "/" + date[0] + "/" + date[2];
                    }
                    else
                    {
                        cost1 = cost2;
                        if (radioButton1.Checked)
                        {
                            dore = "ماهانه";
                            t2 = Convert.ToInt32(date[1]);
                            t = Convert.ToInt32(date[0]) + (Convert.ToInt32(textBox7.Text));
                            t1 = Convert.ToInt32(date[2]);
                            if (t > 12)
                            {
                                t = 1;
                                t1 = Convert.ToInt32(date[2]) + 1;
                                date1 = t2 + "/" + t + "/" + t1;
                            }
                            else
                            {
                                date1 = t2 + "/" + t + "/" + t1;
                            }
                        }
                        else if (radioButton2.Checked)
                        {
                            dore = "هفتگی";
                            t2 = Convert.ToInt32(date[1]) + 7;
                            t1 = Convert.ToInt32(date[2]);
                            t = Convert.ToInt32(date[0]);
                            if (t2 > 30)
                            {
                                t2 = t2 - 30;
                                t = Convert.ToInt32(date[0]) + 1;
                                if (t > 12)
                                {
                                    t = t - 12;
                                    t1 = Convert.ToInt32(date[2]) + 1;
                                    date1 = t2 + "/" + t + "/" + t1;
                                }
                                else
                                {
                                    date1 = t2 + "/" + t + "/" + t1;
                                }
                            }
                            else
                            {
                                date1 = t2 + "/" + t + "/" + t1;
                            }
                        }
                        else if (radioButton3.Checked)
                        {
                            dore = "روزانه";
                            t2 = Convert.ToInt32(date[1]) + (Convert.ToInt32(textBox8.Text));
                            t1 = Convert.ToInt32(date[2]);
                            t = Convert.ToInt32(date[0]);
                            if (t2 > 30)
                            {
                                t2 = t2 - 30;
                                t = Convert.ToInt32(date[0]) + 1;
                                if (t > 12)
                                {
                                    t = t - 12;
                                    t1 = Convert.ToInt32(date[2]) + 1;
                                    date1 = t2 + "/" + t + "/" + t1;
                                }
                                else
                                {
                                    date1 = t2 + "/" + t + "/" + t1;
                                }
                            }
                            else
                            {
                                date1 = t2 + "/" + t + "/" + t1;
                            }
                        }
                        date[1] = Convert.ToString(t2);
                        date[0] = Convert.ToString(t);
                        date[2] = Convert.ToString(t1);
                    }
                    this.dataGridView1.Rows.Add(new object[] { this.dataGridView1.Rows.Count, date1, cost1, "پرداخت نشده" });
                }
           // }
        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "سود بانکی")
            {
                textBox20.Enabled = false;
                label30.Enabled = false;
                textBox20.Text = "18";
            }
            else if (comboBox3.SelectedItem.ToString() == "اعمال سود دلخواه")
            {
                textBox20.Enabled = true;
                label30.Enabled = true;
                textBox20.Text = "0";
            }
            else
            {
                textBox20.Enabled = false;
                label30.Enabled = false;
                textBox20.Text = "0";
                // textBox4.Text = "0";
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s = comboBox3.SelectedItem.ToString();
                if (s == "سود بانکی")
                {
                    double t = (Convert.ToDouble(textBox2.Text) * 18) / 2400;
                    double t1 = Convert.ToDouble(textBox5.Text);
                    int mah =Convert.ToInt32( comboBox1.Text);
                    double t2 = ((t1 + 1) * t)*(mah/1200);
                    textBox22.Text = Convert.ToString(t2);
                }
                else if (s == "اعمال سود دلخواه")
                {
                    decimal t = (Convert.ToDecimal(textBox2.Text) * (Convert.ToDecimal(textBox20.Text))) / 2400;
                    int mah = Convert.ToInt32(comboBox1.Text);
                    decimal t1 = Convert.ToDecimal(textBox5.Text);
                    decimal t2 = ((t1 + 1) * t) * (mah / 1200);
                    textBox22.Text = Convert.ToString(t2);
                }
                else
                {
                    textBox22.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("بایستی مبلغ , تعداد اقساط و درصد را واردکنید");
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            add_chek_pardakhti acp = new add_chek_pardakhti();
            acp.ShowDialog();
        }
    }
}

