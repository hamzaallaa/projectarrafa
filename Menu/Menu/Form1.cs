using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        data1 d = new data1();
        public Form1()
        {
            InitializeComponent();
        }
       public void rempler_dgv()
        {
            string requete = "select * from moyen";
            d.dt = new DataTable();
            d.dt = d.Readdata(requete);
            dgv.DataSource = d.dt;
        }
        public void rempler_nom()
        {
            string requte = "select * from Beneficiaire_2020";
            d.dt = new DataTable();
            d.dt = d.Readdata(requte);
            comb_nom.DataSource = d.dt;
            if (d.dt.Rows.Count != 0)
            {
                comb_nom.DisplayMember = "الاسم النسب";
                comb_nom.ValueMember = "الاسم النسب";
            } 
        }
        public void rempler_code_massar()
        {
            string requte = "select  [code masar] from Beneficiaire_2020";
            d.dt = new DataTable();
            d.dt = d.Readdata(requte);
            comb_massra.DataSource = d.dt;
            comb_massra.DisplayMember = "code masar";
            comb_massra.ValueMember = "code masar";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            rempler_dgv();
            rempler_code_massar();
            rempler_nom();
            comb_massra.Text = "";
            comb_nom.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string requete = $"insert into moyen values('{comb_massra.SelectedValue}',N'{comb_nom.SelectedValue}',N'{comb_niveau.Text}',{text_note.Text})";
          if(text_note.Text!="")
            {
                if (d.IUDData(requete) == true)
                {
                    MessageBox.Show("تم إضافة", "تحقق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = null;
                    rempler_dgv();
                    comb_massra.Text = "";
                    comb_nom.Text = "";
                    text_note.Text = "";

                }
                else
                {
                    MessageBox.Show("تم اضافته من قبل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          else
            {
                MessageBox.Show("تحقق من المعدل", "خظأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comb_massra.Text=="")
            {
                MessageBox.Show("حدد الشخص الذي تريد البحت عنه", "خظأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string requte = $"select * from moyen where [code massar]='{comb_massra.SelectedValue}'";
                d.dt = new DataTable();
                d.dt = d.Readdata(requte);
                dgv.DataSource = null;
                dgv.DataSource = d.dt;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comb_massra.Text = "";
            comb_nom.Text = "";
            text_note.Text = "";
            rempler_dgv();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgv.Rows.Count==1)
            {
                btn_save.Visible = btn_cancel.Visible = true;
                comb_massra.Text = dgv.Rows[0].Cells[0].Value.ToString();
                comb_nom.Text= dgv.Rows[0].Cells[1].Value.ToString();
                comb_niveau.Text= dgv.Rows[0].Cells[2].Value.ToString();
                text_note.Text =dgv.Rows[0].Cells[3].Value.ToString();
                comb_massra.Enabled = false;
            }
            else
            {
                MessageBox.Show("اختار شخص الدي تريد تعديله", "خظأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("تم تعديل", "تحقق", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                rempler_dgv();
                comb_massra.Text = "";
                comb_nom.Text = "";
                text_note.Text = "";
                comb_massra.Enabled = true;
                btn_cancel.Visible = btn_save.Visible = false;
            }
        }
       
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            string requte = $"update moyen set [Nom prenom]=N'{comb_nom.SelectedValue}',[Niveau Scolaire]=N'{comb_niveau.Text}',[moyene]={text_note.Text} where [Code Massar]='{comb_massra.SelectedValue}'";
          if(  MessageBox.Show("هل تريد تعديل ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            if (d.IUDData(requte) == true)
            {
                MessageBox.Show("تم تعديل", "تحقق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null;
                rempler_dgv();
                comb_massra.Text = "";
                comb_nom.Text = "";
                text_note.Text = "";
                comb_massra.Enabled = true;
                btn_cancel.Visible = btn_save.Visible = false;
            }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comb_massra_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
