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
    class gozaresh
    {
        public string summ,selected;
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
            double i = Convert.ToDouble(cmd.ExecuteScalar());//(double)cmd.ExecuteScalar();
            summ = Convert.ToString(i);
            conn.Close();
        }
        public void daramad(string date)
        {
            string date_2 = date + "/01";
            string sql = "select number from sal_factor2 where number like '"+date_2+"%'";
            connect3(sql);
            if (summ != "0")
            {
                sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad2(string date)
        {
            string date_2 = date + "/02";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad3(string date)
        {
            string date_2 = date + "/03";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad4(string date)
        {
            string date_2 = date + "/04";
            string sql = "select number from sal_factor2 where number like '" + date + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad5(string date)
        {
            string date_2 = date + "/05";
            string sql = "select number from sal_factor2 where number like '" + date + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad6(string date)
        {
            string date_2 = date + "/06";
            string sql = "select number from sal_factor2 where number like '" + date + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad7(string date)
        {
            string date_2 = date + "/07";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad8(string date)
        {
            string date_2 = date + "/08";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad9(string date)
        {
            string date_2 = date + "/09";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad10(string date)
        {
            string date_2 = date + "/10";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad11(string date)
        {
            string date_2 = date + "/11";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void daramad12(string date)
        {
            string date_2 = date + "/12";
            string sql = "select number from sal_factor2 where number like '" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                 sql = "select sum(cost) from sal_factor2 where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void hazine(string date)
        {
            string date_2 = date + "/01";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
            connect3(sql);
            if (summ != "0")
            {
                sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                connect3(sql);
            }
        }
        public void hazine2(string date)
        {
            string date_2 = date + "/02";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine3(string date)
        {
            string date_2 = date + "/03";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine4(string date)
        {
            string date_2 = date + "/04";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine5(string date)
        {
            string date_2 = date + "/05";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine6(string date)
        {
            string date_2 = date + "/06";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine7(string date)
        {
            string date_2 = date + "/07";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine8(string date)
        {
            string date_2 = date + "/08";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine9(string date)
        {
            string date_2 = date + "/09";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine10(string date)
        {
            string date_2 = date + "/10";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine11(string date)
        {
            string date_2 = date + "/11";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
        public void hazine12(string date)
        {
            string date_2 = date + "/12";
            string sql = "select code from hazine where date like'" + date_2 + "%'";
             connect3(sql);
             if (summ != "0")
             {
                 sql = "select sum (total_cost) from hazine where date like '" + date_2 + "%' ";
                 connect3(sql);
             }
        }
    }
}
