using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace courseWork
{
    class DBConnection
    {
        private static DBConnection instance;

        private DBConnection()
        { }

        public static DBConnection getInstance()
        {
            if (instance == null)
                instance = new DBConnection();

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["pricesTable"].ConnectionString;
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from dbo.prices";
            //cmd.Connection = con;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("dbo.prices");
            //da.Fill(dt);

            //g1.ItemsSource = dt.DefaultView;
            //instance = da;

            return instance;
        }
    }
}
