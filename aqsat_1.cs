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
    class aqsat_1
    {
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
        public DataTable search(string item,string kind)
        {
            DataTable t = null;
            if (kind == "نام مشتری")
            {
                string sql = "select* from aqsat where code_cursor=(select* from information_cursor where name like '" + item + "%')";
                t = connect2(sql);
            }
            else if (kind == "شماره فاکتور")
            {
                string sql = "select* from aqsat where number like '"+item+"%'";
                t = connect2(sql);
            }
            else if (kind == "تاریخ سررسید")
            {
                string sql = "select* from aqsat where date like '"+item+"%'";
                t = connect2(sql);
            }
            return t;
        }
        public DataTable search2(string item)
        {
            DataTable t = null;
            string sql = "select* from list_aqsat where number="+item+"";
            connect2(sql);
            return t;
        }
        public DataTable tasvie_daryafti()
        {
            DataTable dt = null;
            string sql = "select * from list_aqsat where status='پرداخت نشده' and number in (select number from resive)";
            connect2(sql);
            return dt;
        }
        public void save(int number,string code_cursor,int cost,string date,string count ,string date_sar_resid,int darsad,int day,string comment)
        {
            string sql = "insert into aqsat values("+number+",'"+code_cursor+"',"+cost+",'"+date+"','"+count+"','"+date_sar_resid+"',"+darsad+","+day+",'"+comment+"')";
            connect(sql);
        }
        public void save2(int number, int cost,string date_sar_resid,string status)
        {
            string sql = "declare @num int=1 select @num=number+1 from list_aqsat  insert into list_aqsat values(@num,"+number+","+cost+",'"+date_sar_resid+"','"+status+"')";
            connect(sql);
        }
        public void tasvie(int number,int number_qest,int cost)
        {
            string sql = "update list_aqsat set status= 'پرداخت شده' where number_qest="+number_qest+" and number="+number+"";
            connect2(sql);
           // sql = "update cost_qest set cost+="+cost+" where number="+number+" and number_qest="+number_qest;
            sql = "insert into cost_qest values("+number+","+number_qest+","+cost+")";
            connect2(sql);
        }

    }
}
