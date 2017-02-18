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
    public partial class TspMain : Form
    {
        int NumberOfCity;
        int INFINITY = 999;
        int MAX = 100;
        TextBox[] CostInputBox = new TextBox[1000];
        int[,] CostMatrix = new int[100,100];

        public TspMain(Int32 NoCity)
        {
            InitializeComponent();

            NumberOfCity = NoCity; // globalna varijabla primi broj gradova
            NumberLabel.Text = NoCity.ToString(); // ispis broja gradova
            CostLabel.Visible = false; //sakrijemo labelu CostLabel 
            PathLabel.Visible = false; //sakrijemo labelu PathLabel 

            GenerateMatrix(); // poziv funkcije GenerateMatrix u konstruktoru
        }

        // Generira polja za unos podataka
        public void GenerateMatrix()
        {
            int col, row, PosX = 20, PosY = 100, i = 0;

            Label[] CityRowLabel = new Label[100];
            Label[] CityColumnLabel = new Label[100];
            char RowLabel = 'A';
            char ColumnLabel = 'A';

            // Cost Matrix
            for (row = 0; row < NumberOfCity; row++)
            {   
                for (col = 0; col < NumberOfCity; col++)
                {
                    if (PosY == 100) // Ako je PosY jednak početnoj PosY, ispisuj imena stupaca
                    {   
                        // ispis labeli stupaca
                        CityColumnLabel[col] = new Label();
                        CityColumnLabel[col].Location = new Point(PosX+30, PosY);
                        CityColumnLabel[col].Size = new Size(20, 20);
                        CityColumnLabel[col].BackColor = Color.Transparent;
                        CityColumnLabel[col].Text = Convert.ToString(ColumnLabel);
                        Controls.Add(CityColumnLabel[col]);
                        ColumnLabel++;
                    }
                    // ispis polja za unos
                    CostInputBox[i] = new TextBox();
                    CostInputBox[i].Location = new Point(PosX+30, PosY+20);
                    CostInputBox[i].Size = new Size(40, 20);
                    CostInputBox[i].Text = Convert.ToString(0);
                    CostInputBox[i].TabIndex = 2;
                    Controls.Add(CostInputBox[i]);

                    PosX = PosX + 45;
                    i++;
                }
                PosY = PosY + 25;
                col = 0;
                PosX = 20;

                // ispis imena redaka
                CityRowLabel[row] = new Label();
                CityRowLabel[row].Location = new Point(20, PosY);
                CityRowLabel[row].Size = new Size(20, 20);
                CityRowLabel[row].BackColor = Color.Transparent;
                CityRowLabel[row].Text = Convert.ToString(RowLabel);
                StartCityComboBox.Items.Add(RowLabel); // dodaj u kolekciju odabira Start grada
                Controls.Add(CityRowLabel[row]);
                RowLabel++;
            }
            // ispis lokacije botuna i labeli
            StartBttn.Location = new Point(50, PosY + 30);
            PathLabel.Location = new Point(50, PosY + 80);
            CostLabel.Location = new Point(50, PosY + 120);
        }

        public int TSP_Dinamic(int[,] c, int[] tour, int start, int n)
        {
            int i, j, k; /* Loop counters. */
            int[] temp = new int[MAX]; /* Temporary during calculations. */
            int[] mintour = new int [MAX]; /* Minimal tour array. */
            int mincost; /* Minimal cost. */
            int ccost; /* Current cost. */

            /* End of recursion condition. */
            if (start == n - 2)
                return c[tour[n - 2], tour[n - 1]] + c[tour[n - 1], 0];

            /* Compute the tour starting from the current city. */
            mincost = INFINITY;
            for (i = start + 1; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    temp[j] = tour[j];

                /* Adjust positions. */
                temp[start + 1] = tour[i];
                temp[i] = tour[start + 1];

                /* Found a better cycle? (Recurrence derivable.) */
                if (c[tour[start], tour[i]] +
                    (ccost = TSP_Dinamic(c, temp, start + 1, n)) < mincost)
                {
                    mincost = c[tour[start], tour[i]] + ccost;
                    for (k = 0; k < n; k++)
                        mintour[k] = temp[k];
                }
            }

            /* Set the minimum-tour array. */
            for (i = 0; i < n; i++)
                tour[i] = mintour[i];

            return mincost;
        }

        private void NoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TspWelcome form2 = new TspWelcome(); //instanciraj novu TspWelcome formu 
            this.Hide();     //sakrij mi trenutnu (TspMain) formu
            form2.ShowDialog(); //prikazi mi TspWelcome formu
            this.Close();  //zatvori mi trenutnu (TspMain) formu
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //zatvori mi trenutnu (TspMain) formu
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unesite matricu troška na način da \npočetni grad predstavlja grad 'A'"); //poruka koja se prva prikaže
            MessageBox.Show("Zatim pritisnite tipku 'Start'"); //poruka koja se druga prikaže
            MessageBox.Show("Ukoliko ste sve ispravno unijeli,\ndobivate optimalni put i najmanji trošak puta."); //poruka koja se treća prikaže
        }

        private void StartBttn_Click(object sender, EventArgs e)
        {
            int i = 0;
            int cost; // Najmanji trošak
            int[] Tour = new int[100]; // Tour niz za rute
            int err = 0; //brojač grešaka u unosu CostInputBox matrice
            PathLabel.Text = "Optimalna ruta: ";

            // punjenje CostMatrix matrice
            for (int row = 0; row < NumberOfCity; row++)
            {
                for (int col = 0; col < NumberOfCity; col++)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(CostInputBox[i].Text, "[^0-9]")) // provjeri jesu li unoseni brojevi
                    {
                        MessageBox.Show("Molimo unesite samo brojeve.");
                        CostInputBox[i].Text = Convert.ToString(0); // vrati na 0
                        err++; //uvećaj brojač greški
                    }
                    else
                        CostMatrix[row, col] = Convert.ToInt32(CostInputBox[i].Text); // napunimo CostMatrix sa podacima iz CostInputBox
                    i++;
                }
            }
            // punjenje tour niza za rute
            for (i = 0; i < NumberOfCity; i++)
                Tour[i] = i;

            if (err == 0) //ukoliko je sve ispravno uneseno
            {
                cost = TSP_Dinamic(CostMatrix, Tour, 0, NumberOfCity); //poziv funkcije TSP_Dinamic koja vraća minimalni trošak puta

                PathLabel.Visible = true; //prikažemo labelu PathLabel 
                for (i = 0; i < NumberOfCity; i++)
                {
                    char city = (char)(Tour[i] + 65); // dodajemo ASCI vrijednost slova A
                    PathLabel.Text = PathLabel.Text + city + " --> "; //ispis optimalne rute
                }
                PathLabel.Text = PathLabel.Text + " A"; //+ start grad u koji se vraćamo

                CostLabel.Visible = true; // prikažemo labelu CostLabel
                CostLabel.Text = "Minimalni trošak: " + cost;
            }
        }
    }
}
