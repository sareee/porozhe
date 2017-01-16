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
    class factor
    {
        public double o = 0d;
        public int N = 0;
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
        public void connect3(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=فروش;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sql;
            o = Convert.ToDouble(cmd.ExecuteScalar());//(double)cmd.ExecuteScalar();
            // w = Convert.ToString(i);
            conn.Close();
        }
        public void connect4(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=فروش;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sql;
            N = Convert.ToInt32(cmd.ExecuteScalar());//(double)cmd.ExecuteScalar();
            // w = Convert.ToString(i);
            conn.Close();
        }
        public void save(int number, string a, string b, string c, string d, string date,string code_cursor,string time, string code_center,string code_gerner,string code_vaset, string location, string sending, string comment,int cost)
        {
            string sql = "insert into sal_factor values(" + number + ",'" + a + "','" + b + "','" + c + "','" + d + "','" + date + "','" + code_cursor + "','" + time + "','" + code_center + "','" + code_gerner + "','" + code_vaset + "','" + location + "','" + sending + "','" + comment + "','"+cost+"')";
            connect(sql);
        }
        public void save2(int number, string code_cursor, string date,int cost)
        {
            string sql = "insert into sal_factor2 values("+number+",'"+code_cursor+"','"+date+"',"+cost+")";
            connect(sql);
        }
        public void save_buy_factor(int number, string code_kala, string name_kala, string mark_kala, string date_kala, string date, string code_cursor, string time, string code_gerner, string comment)
        {
            string sql = "";
            connect(sql);
        }
        public void cost(string a, string b, string c, string d)
        {
            string sql = "select darsad from kala where code='"+a+"' and name='"+b+"' and brand='"+c+"' and date_old='"+d+"'";
            connect3(sql);
        }
        public void vaset_save(int number,string code_vaset,string name_vaset,string darsad, int mablaq)
        {
            string sql = "insert into vaset values("+number+",'"+code_vaset+"','"+name_vaset+"','"+darsad+"',"+mablaq+")";
            connect(sql);
        }
        public void numberic()
        {
            string sql = "declare @num int=0 select @num=number+1 from sal_factor select @num ";
            connect4(sql);
        }
    }
}

