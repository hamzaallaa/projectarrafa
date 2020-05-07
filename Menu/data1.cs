using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Menu
{
    class data1
    {
        public SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=الجمعية_الرأفة_2020;Integrated Security=True");
        public SqlCommand cmd;

        public SqlDataAdapter da;
        public SqlDataReader dr;
        public DataTable dt;
        public DataSet ds;
        public void connect()
        {
            if(con.State==ConnectionState.Closed || con.State==ConnectionState.Broken)
            {
                con.Open();
            }
        }
        public void decconter()
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
