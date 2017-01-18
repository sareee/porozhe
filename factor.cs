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
        int s;
        public void connect3(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=forush;Integrated Security=True");
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
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=forush;Integrated Security=True");
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
            string sql = "insert into buy_factor values("+number+",'"+code_kala+"','"+name_kala+"','"+mark_kala+"','"+date_kala+"','"+date+"','"+code_cursor+"','"+time+"','"+code_gerner+"','"+comment+"')";
            connect(sql);
        }
        public void save_buy_factor2(int number,string code_seller,string date,int cost)
        {
            string sql = "insert into buy_factor_2 values("+number+",'"+code_seller+"','"+date+"',"+cost+")";
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
            string sql = "declare @num int=1 select @num=number+1 from sal_factor select @num ";
            connect4(sql);
        }
        public void numberic_buy_factor()
        {
            string sql = "declare @num int=1 select @num=number+1 from buy_factor select @num ";
            connect4(sql);
        }
        public void resive(int number,int takhfif,int naqdi,int kartkhan,int digari,int qesti,string sanduq,string hesab_code,string number_kart,string comment,string code_cursor)
        {
            string sql = "insert into resive values (" + number + "," + takhfif + "," + naqdi + "," + kartkhan + "," + digari + "," + qesti + ",'" + sanduq + "','" + hesab_code + "','" + number_kart + "','" + comment + "','" + code_cursor + "')";
            connect(sql);
        }
        public void pardakht(int number,int takhfif,int naqdi,int kartkhan,string sanduq,string hesab_code,string number_kart,string comment,string code_saller)
        {
            string sql = "insert into pardakht values ("+number+","+takhfif+","+naqdi+","+kartkhan+",'"+sanduq+"','"+hesab_code+"','"+number_kart+"','"+comment+"','"+code_saller+"')";
            connect(sql);
        }
        public void gozaresh_rozane(string date_1,string date_2)
        {
            string sql = "select sum(cost) from sal_factor2 where date between '"+date_1+"' and '"+date_2+"' ";
            connect3(sql);
        }
        public void gozaresh_rozane2(string date_1, string date_2)
        {
               string sql = "select sum(naqdi) from resive where number in(select number from sal_factor2 where date between '" + date_1 + "' and '" + date_2 + "' )";
               connect3(sql);
        }
        public void gozaresh_rozane3(string date_1, string date_2)
        {
            string sql = "select sum(kartkhan) from resive where number in(select number from sal_factor2 where date between '" + date_1 + "' and '" + date_2 + "' )";
            connect3(sql);
        }
        public void gozaresh_rozane4(string date_1, string date_2)
        {
            string sql = "select sum(qesti) from resive where number in(select number from sal_factor2 where date between '" + date_1 + "' and '" + date_2 + "' )";
            connect3(sql);
        }
        public void gozaresh_pardakht1(string date_1, string date_2)
        {
            string sql = "select sum(cost) from buy_factor_2 where date between '" + date_1 + "' and '" + date_2 + "'";
            connect3(sql);
        }
        public void gozaresh_pardakht2(string date_1,string date_2)
        {
            string sql = "select sum(naqdi) from pardakht where number in(select number from buy_factor_2 where date between '" + date_1 + "' and '" + date_2 + "')";
            connect3(sql);
        }
        public void gozaresh_pardakht3(string date_1, string date_2)
        {
            string sql = "select sum(kartkhan) from pardakht where number in(select number from buy_factor_2 where date between '" + date_1 + "' and '" + date_2 + "')";
            connect3(sql);
        }
    }
}

