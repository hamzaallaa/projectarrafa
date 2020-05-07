using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    static class Program
    {
        //ext_codeM.Text=code
        //text_nom_prenom_f.Text;
        //text_np.Text;
        //text_adress.Text;
        //text_cin.Text;
        //date_n.Value;
        //text_age.Text;
        //combobox_sex.Text;
        //date_اتحاق_بالموسسة.Value;
        //combobox_parcor_s.Text;
        //combobox_niveu_s.Text;
        static public string codeM="", nom_a = "", nom_f = "", adrisse = "", cin = "", sex = "", parcour_s = "", niv_s = "", date_n = "", date_scolair = "", age = "";
 
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login1());
        }
    }
}
