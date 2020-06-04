using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Menu
{
    class data1
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=الجمعية_الرأفة_121;Integrated Security=True");
        public SqlCommand cmd;

        public SqlDataAdapter da;
        public SqlDataReader dr;
        public DataTable dt;
        public DataSet ds;
        public data1()
        {
            connect();
        }
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
        public DataTable Readdata(string requet)
        {

            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter(requet, con);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public bool IUDData(string requete)
        {
            try
            {
                cmd = new SqlCommand(requete, con);
                connect();
                cmd.ExecuteNonQuery();
                decconter();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
