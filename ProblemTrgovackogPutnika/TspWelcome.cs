using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemTrgovackogPutnika
{
    public partial class TspWelcome : Form
    {
        public TspWelcome()
        {
            InitializeComponent();
        }

        private void NoCityButton_Click(object sender, EventArgs e)
        {
            // Provjeri jeli unosen broj
            if (System.Text.RegularExpressions.Regex.IsMatch(NoCityButtonTxtBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Molimo unesite samo brojeve.");
                NoCityButtonTxtBox.Text = "";
            }
            else
            {
                int NoCity = Convert.ToInt32(NoCityButtonTxtBox.Text); // Pretvori sadržaj NoCityButtonTxtBox u int broj

                this.Hide();
                TspMain f2 = new TspMain(NoCity);
                f2.ShowDialog();
                this.Close();
            }
        }

        private void noviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TspWelcome form = new TspWelcome(); //instanciraj novu TspWelcome formu 
            this.Hide();     //sakrij mi trenutnu (TspWelcome) formu
            form.ShowDialog(); //prikazi mi TspWelcome formu
            this.Close();  //zatvori mi trenutnu (TspWelcome) formu 
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //zatvori mi trenutnu (TspWelcome) formu
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unesite broj gradova u polje za unos..."); //poruka koja se prva prikaže
            MessageBox.Show("...zatim pritisnite tipku 'Unesi'"); //poruka koja se druga prikaže
        }
    }
}
