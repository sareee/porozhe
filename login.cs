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
    class login
    {
        public string error;
        //  public string karbari, ramz;
        private void connection(string sql)
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
        public void vorud(string karbari, string ramz)
        {
            //try
            //{
                string sql = "declare @user char(20),@pass char(20),@flag int select @user =name from log select @pass=ramz from log if @user!='" + karbari + "' or @pass!='" + ramz + "' select @flag='1234D' ";
                connection(sql);
                منو menu = new منو();
                menu.ShowDialog();
            //}
            //catch
            //{
            //    // MessageBox.Show("error");
            //    error = "نام کاربری یا پسورد اشتباه است";
            //}
        }
        public void change(string karbari, string ramz,string karbari_new,string ramz_new1,string ramz_new2)
        {
            if (ramz_new1 == ramz_new2)
            {
                try
                {
                    string sql = "declare @user char(20),@pass char(20),@flag int select @user =name from log select @pass=ramz from log if @user!='" + karbari + "' or @pass!='" + ramz + "' select @flag='1234D' else update log set name='" + karbari_new + "',ramz='" + ramz_new2 + "'";
                    connection(sql);
                    MessageBox.Show("نام کاربری و رمز عبور با موفقیت تغییر یافت");
                }
                catch
                {
                    error = "نام کاربری یا پسورد فعلی اشتباه است";
                }
            }
            else { error = "رمز جدید رادرست وارد نکردید"; }

        }
    }
}
