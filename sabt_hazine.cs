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
    class sabt_hazine
    {
        public string summ;
        public void connect3(string sql)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=فروش;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = sql;
            double i = Convert.ToDouble(cmd.ExecuteScalar());
            summ = Convert.ToString(i);
            conn.Close();
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
        public void sum(int a)
        {
            string sql = "select sum(cost) from chek where number=" + a + "";
            connect3(sql);

        }
        public void sum2(int a)
        {
            string sql = "select sum(cost) from chek_pardakhti where number=" + a + "";
            connect3(sql);

        }
        public void add(int a,string b,string c,string d,string f,string g,string h,int i)
        {
            string sql = "insert into chek_pardakhti values("+a+",'"+b+"','"+c+"','"+d+"','"+f+"','"+g+"','"+h+"',"+i+")";
            connect(sql);
        }
        public void save(string source,string date,string sanduq,int cost_sanduq,string bank,int cost_bank,int num_daryafti,int num_pardakhti,int total_cost)
        {
            string sql = "declare @code int=0 select @code=code from hazine insert into hazine values(@code+1,'"+source+"','"+date+"','"+sanduq+"',"+cost_sanduq+",'"+bank+"',"+cost_bank+","+num_daryafti+","+num_pardakhti+","+total_cost+")";
            connect(sql);
        }
    }
}
