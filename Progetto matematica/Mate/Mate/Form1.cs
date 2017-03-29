using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mate
{
    public partial class Form1 : Form
    {
        string espressione = "";
        string sottoEspressione = "";
        private string sotto_Espressione;

        public void riscrivi_Espressione()//riscrive espressione
            {


        }
        public void semplifica() //semplifica l'espressione data
        {

            string a = "";
            int primoNumero = 0;
            string b = "";
            int secondoNumero = 0;
            int i = 0;
            int inizio_staccoFraNumeri = 0;
            int fine_staccoFraNumeri = 0;
            while (espressione.Substring(i, 1) == "1" || espressione.Substring(i, 1) == "2" || espressione.Substring(i, 1) == "3" || espressione.Substring(i, 1) == "4" || espressione.Substring(i, 1) == "5" || espressione.Substring(i, 1) == "6" || espressione.Substring(i, 1) == "7" || espressione.Substring(i, 1) == "8" || espressione.Substring(i, 1) == "9" || espressione.Substring(i, 1) == "0")
            {
                a += espressione.Substring(i, 1);
                i += 1;
            }
            inizio_staccoFraNumeri = i;
            while (!(espressione.Substring(i, 1) == "1" || espressione.Substring(i, 1) == "2" || espressione.Substring(i, 1) == "3" || espressione.Substring(i, 1) == "4" || espressione.Substring(i, 1) == "5" || espressione.Substring(i, 1) == "6" || espressione.Substring(i, 1) == "7" || espressione.Substring(i, 1) == "8" || espressione.Substring(i, 1) == "9" || espressione.Substring(i, 1) == "0"))
            {
                i += 1;
            }
            fine_staccoFraNumeri = i;
            while (i < espressione.Length)
            {
                if ((espressione.Substring(i, 1) == "1" || espressione.Substring(i, 1) == "2" || espressione.Substring(i, 1) == "3" || espressione.Substring(i, 1) == "4" || espressione.Substring(i, 1) == "5" || espressione.Substring(i, 1) == "6" || espressione.Substring(i, 1) == "7" || espressione.Substring(i, 1) == "8" || espressione.Substring(i, 1) == "9" || espressione.Substring(i, 1) == "0"))
                {
                    b += espressione.Substring(i, 1);
                    i += 1;
                }
            }
            primoNumero = Convert.ToInt32(a);
            secondoNumero = Convert.ToInt32(b);
            if (fine_staccoFraNumeri - inizio_staccoFraNumeri == 1)
            {
                if (espressione.Substring(inizio_staccoFraNumeri, 1) == "*")
                {
                    sotto_Espressione = Convert.ToString(primoNumero * secondoNumero);
                }
                else if (espressione.Substring(inizio_staccoFraNumeri, 1) == "/")
                {

                    sotto_Espressione = Convert.ToString(primoNumero) + "/" + Convert.ToString(secondoNumero);
                }
                else if (espressione.Substring(inizio_staccoFraNumeri, 1) == "+")
                {
                    sotto_Espressione = Convert.ToString(primoNumero + secondoNumero);
                }
                else if (espressione.Substring(inizio_staccoFraNumeri, 1) == "-")
                {
                    sotto_Espressione = Convert.ToString(primoNumero - secondoNumero);
                }
            }
        }


        
        public Form1()
        {
            InitializeComponent();
        }

        private void nuovaEspressioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            espressione = Input_textbox.Text;
        }

        private void semplificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                semplifica();
            textBox1.Text = espressione; 
        }
    }
}
