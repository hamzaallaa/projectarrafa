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

namespace Menu
{
    public partial class affix : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=الجمعية_الرأفة_2020;Integrated Security=True");
        data1 d = new data1();
        
        public affix()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
       public void afficher()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Beneficiaire_2020", con);
            da.Fill(ds, "pr");
            dataGridView1.DataSource = ds.Tables["pr"];
        }
        private void affix_Load(object sender, EventArgs e)
        {
            try
            {
                d.dt = new DataTable();
                d.connect();
                d.cmd = new SqlCommand();
                d.cmd.CommandType = CommandType.Text;
                d.cmd.CommandText = " select * from Beneficiaire_2020 ";
                d.cmd.Connection = d.con;
                d.dr = d.cmd.ExecuteReader(); 
                 d.dt.Load(d.dr);
                dataGridView1.DataSource = d.dt;
                d.dr.Close();
                d.decconter();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afficher();
        }
    }
}
