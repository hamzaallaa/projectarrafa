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
    public partial class rechercher : Form
    {
        data1 d = new data1();
        public rechercher()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Textbox_search_MouseEnter(object sender, EventArgs e)
        {
            if(Textbox_search.text=="ادخل رقم هاتفك")
            {
                Textbox_search.text = "";
                Textbox_search.ForeColor = Color.Black;
            }
        }
        //---------------------------------------------------- afficher
        public void afficher()
        {
            d.dt = new DataTable();
            if (d.dt.Rows.Count != 0)
            {
                d.dt.Rows.Clear();
            }
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
        //---------------------------------------------------- search
        public bool search()
        {
            d.dt = new DataTable();
            if (d.dt.Rows.Count != 0)
            {
                d.dt.Rows.Clear();
            }
            d.connect();
            d.cmd = new SqlCommand();
            d.cmd.CommandType = CommandType.Text;
            d.cmd.CommandText = " select * from Beneficiaire_2020 where [Code Masar]='"+Textbox_search.text + "' or [CIN]='"+Textbox_search.text+"'";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            if(d.dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = d.dt;
                return true;
            }
            else
            {
                MessageBox.Show("هدا شخص لا يوجد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            d.dr.Close();
            d.decconter();

        }

        private void rechercher_Load(object sender, EventArgs e)
        {
            afficher();
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

         
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void Textbox_search_OnTextChange(object sender, EventArgs e)
        {
            if (Textbox_search.text == "" || Textbox_search.text == " ")
            {
                afficher();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(search()==true)
            {
                //static public string codeM, nom_a, nom_f, adrisse, cin, sex, parcour_s, niv_s;
                //static public int age;
                //static public DateTime date_n, date_scolair;
                Program.codeM= dataGridView1.Rows[0].Cells[1].Value.ToString();
                Program.nom_f = dataGridView1.Rows[0].Cells[2].Value.ToString();
                Program.nom_a= dataGridView1.Rows[0].Cells[3].Value.ToString();               
                Program.adrisse= dataGridView1.Rows[0].Cells[4].Value.ToString();
                Program.cin= dataGridView1.Rows[0].Cells[5].Value.ToString();
                Program.date_n = DateTime.Parse(dataGridView1.Rows[0].Cells[6].Value.ToString()).ToString();
                Program.age= dataGridView1.Rows[0].Cells[7].Value.ToString();
                Program.sex = dataGridView1.Rows[0].Cells[8].Value.ToString();
                Program.date_scolair = DateTime.Parse(dataGridView1.Rows[0].Cells[9].Value.ToString()).ToString();
                Program.parcour_s= dataGridView1.Rows[0].Cells[10].Value.ToString();
                Program.niv_s = dataGridView1.Rows[0].Cells[11].Value.ToString();
                Form2 f = new Form2();
                f.Show();
            }
        }
    }
}
