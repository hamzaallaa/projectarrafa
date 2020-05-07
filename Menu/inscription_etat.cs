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
    public partial class inscription_etat : Form
    {
        data1 d = new data1();
        string orphel_p; string orphel_m ; string orphel_pm; string non_pm; string non_p;
        string etat_t; string prison_pm; string abri; string faible; string auter;
        public inscription_etat()
        {
            InitializeComponent();
          

        }
        public string ajouter_social()
        {
            try
            {
                d.cmd = new SqlCommand();
                d.connect();
                d.cmd.CommandType = CommandType.StoredProcedure;
                d.cmd.CommandText = "[P_Ajouter_Social]";
                d.cmd.Parameters.Add("@codM", SqlDbType.VarChar,50).Value = text_codeM.Text;
                d.cmd.Parameters.Add("@orphel_p", SqlDbType.NVarChar, 10).Value = orphel_p;
                d.cmd.Parameters.Add("@orphel_m", SqlDbType.VarChar, 10).Value = orphel_m;
                d.cmd.Parameters.Add("@orphel_pm", SqlDbType.NVarChar, 10).Value = orphel_pm;
                d.cmd.Parameters.Add("@non_pm", SqlDbType.NVarChar, 10).Value = non_pm;
                d.cmd.Parameters.Add("@non_p", SqlDbType.VarChar,10).Value = non_p;
                d.cmd.Parameters.Add("@etat_t", SqlDbType.VarChar, 10).Value = etat_t;
                d.cmd.Parameters.Add("@prison_pm", SqlDbType.VarChar, 10).Value = prison_pm;
                d.cmd.Parameters.Add("@abri", SqlDbType.VarChar,10).Value = abri;
                d.cmd.Parameters.Add("@faible", SqlDbType.VarChar, 10).Value = faible;
                d.cmd.Parameters.Add("@auter", SqlDbType.VarChar, 10).Value = auter;
                SqlParameter ok = new SqlParameter("@ok", SqlDbType.Int);
                ok.Direction = ParameterDirection.Output;
                d.cmd.Parameters.Add(ok);
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                d.decconter();
                 orphel_p = ""; orphel_m = ""; orphel_pm = ""; non_pm = ""; non_p = "";
                etat_t = ""; prison_pm = ""; abri = ""; faible = ""; auter = "";
                return ok.Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (Checkbox1.Checked==true)
            {
                orphel_p = "*";
                if(ajouter_social()== "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox2.Checked == true)
            {
                orphel_m = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox3.Checked == true)
            {
                orphel_pm = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox4.Checked == true)
            {
                non_pm = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbo5.Checked == true)
            {
                non_p = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox6.Checked == true)
            {
                etat_t = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox7.Checked == true)
            {
                prison_pm = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox8.Checked == true)
            {
                abri = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox9.Checked == true)
            {
                faible = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
            if (Checkbox10.Checked == true)
            {
                auter = "*";
                if (ajouter_social() == "1")
                {
                    MessageBox.Show("هل تريد حفض", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    MessageBox.Show("تم حفظ");
                }
                else
                {
                    MessageBox.Show("تم ادراج هذا شخص");
                }
            }
        }

        private void inscription_etat_Load(object sender, EventArgs e)
        {
             orphel_p = "";  orphel_m = "";  orphel_pm = "";  non_pm = "";  non_p = "";
             etat_t = "";  prison_pm = "";  abri = "";  faible = "";  auter = "";
        }
    }
}
