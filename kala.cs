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
    class kala
    {
        public string summ;
        public void connect(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=forush;Integrated Security=True");
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
        public DataTable connect2(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=forush;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataReader dr;
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
             return dt;
        }
        public void connect3(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=forush;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sql;
            double i = Convert.ToDouble(cmd.ExecuteScalar());//(double)cmd.ExecuteScalar();
            summ = Convert.ToString(i);
            conn.Close();
        }
        public void insert(string code, string name, string brand, string unit, string group_kala, string date_old, string comment, int cost_buy, int cost_sal, float count, float darsad)
        {
            try
            {
                string sql = "declare @code nchar(20),@name nchar(50),@brand nchar(50),@date nchar(10) select @code='nul',@name='nul',@brand='nul',@date='nul' select @code=code,@name=name,@brand=brand,@date=date_old from kala where code='" + code + "'and name='" + name + "' and brand='" + brand + "' and date_old='" + date_old + "' if @code='nul' or @name='nul' or @brand='nul' or @date='nul' insert into kala values('" + code + "','" + name + "','" + brand + "','" + date_old + "'," + count + ",'" + unit + "','" + group_kala + "'," + cost_buy + "," + cost_sal + "," + darsad + ",'" + comment + "') else update kala set count=count+"+count+" where code='" + code + "'and name='" + name + "' and brand='" + brand + "' and date_old='" + date_old + "'";
                connect(sql);
                MessageBox.Show("کالا ثبت شد","اعلام نتیجه عملیات");
            }
            catch
            {
                MessageBox.Show("بررسی کنید کد کالا,نام کالا,مارک,تاریخ انقضا را ئارد کرده اید ","خطا");
            }
        }
        public DataTable Refresh()
        {
            DataTable t = null;
            string sql = "select* from kala";
           t= connect2(sql);
            return t;
        }
        public DataTable quicksearch(string kind, string value)
        {
            DataTable t = null;
            if (kind == "کد کالا")
            {
                string sql = " select* from kala where code like '" + value + "%'";
                t = connect2(sql);
            }
            else if (kind == "نام کالا")
            {
                string sql = " select* from kala where name like '" + value + "%'";
                t = connect2(sql);
            }
            else if (kind == "گروه کالا")
            {
                string sql = " select* from kala where group_kala like '" + value + "%'";
                t = connect2(sql);
            }
            return t;
        }
        public void delete(string code,string name,string brand,string date)
        {
            string sql = "delete from kala where code='"+code+"' and name='"+name+"' and brand='"+brand+"' and date_old='"+date+"'";
            connect(sql);
           // MessageBox.Show("کالا حذف شد", "اعلام نتیجه عملیات");
        }
        public void sum(string a,string b,string c, string d)
        {
            string sql = "select sum(cost_sal) from kala where code='"+a+"' and name='"+b+"' and brand='"+c+"' and date_old='"+d+"'";
            connect3(sql);

        }
        public void sum_buy_factor(string a, string b, string c, string d)
        {
            string sql = "select sum(cost_buy) from kala where code='" + a + "' and name='" + b + "' and brand='" + c + "' and date_old='" + d + "'";
            connect3(sql);

        }
        public DataTable search(string item)
        {
            DataTable dt = null;
            string sql = "select* from kala where date_old like '"+item+"%'";
            connect2(sql);
            return dt;
        }
    }
}
