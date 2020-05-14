using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int pasek1Opor = 0;
        int pasek2Opor = 0;
        double mnoznik = 1;
        double tolerancja = 0;

        private void cbPasek1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPasek1.SelectedIndex > -1)
            {
                switch (cbPasek1.SelectedItem)
                {
                    case "Czarny":
                        pasek1Opor = 0;
                        cbPasek1.BackColor = Color.Black;
                        cbPasek1.ForeColor = Color.White;
                        break;
                    case "Brązowy":
                        pasek1Opor = 1;
                        cbPasek1.BackColor = Color.Brown;
                        cbPasek1.ForeColor = Color.White;

                        break;
                    case "Czerwony":
                        pasek1Opor = 2;
                        cbPasek1.BackColor = Color.Red;
                        cbPasek1.ForeColor = Color.White;

                        break;
                    case "Pomarańczowy":
                        pasek1Opor = 3;
                        cbPasek1.BackColor = Color.Orange;
                        cbPasek1.ForeColor = Color.White;

                        break;
                    case "Żółty":
                        pasek1Opor = 4;
                        cbPasek1.BackColor = Color.Yellow;
                        cbPasek1.ForeColor = Color.Black;

                        break;
                    case "Zielony":
                        pasek1Opor = 5;
                        cbPasek1.BackColor = Color.Green;
                        cbPasek1.ForeColor = Color.White;

                        break;
                    case "Niebieski":
                        pasek1Opor = 6;
                        cbPasek1.BackColor = Color.Blue;
                        cbPasek1.ForeColor = Color.White;

                        break;
                    case "Fioletowy":
                        pasek1Opor = 7;
                        cbPasek1.BackColor = Color.Violet;
                        cbPasek1.ForeColor = Color.White;

                        break;
                    case "Szary":
                        pasek1Opor = 8;
                        cbPasek1.BackColor = Color.LightGray;
                        cbPasek1.ForeColor = Color.Black;

                        break;
                    case "Biały":
                        pasek1Opor = 9;
                        cbPasek1.BackColor = Color.White;
                        cbPasek1.ForeColor = Color.Black;

                        break;
                    default:
                        pasek1Opor = 0;
                        cbPasek1.BackColor = Color.White;
                        cbPasek1.ForeColor = Color.Black;

                        break;

                }

                lblObliczenie.Text = string.Format("{0}Ω {1}%", (pasek1Opor * 10 + pasek2Opor) * mnoznik, tolerancja);

            }
        }

        private void cbPasek2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPasek2.SelectedIndex > -1)
            {
                switch (cbPasek2.SelectedItem)
                {
                    case "Czarny":
                        pasek2Opor = 0;
                        cbPasek2.BackColor = Color.Black;
                        cbPasek2.ForeColor = Color.White;
                        break;
                    case "Brązowy":
                        pasek2Opor = 1;
                        cbPasek2.BackColor = Color.Brown;
                        cbPasek2.ForeColor = Color.White;
                        break;
                    case "Czerwony":
                        pasek2Opor = 2;
                        cbPasek2.BackColor = Color.Red;
                        cbPasek2.ForeColor = Color.White;
                        break;
                    case "Pomarańczowy":
                        pasek2Opor = 3;
                        cbPasek2.BackColor = Color.Orange;
                        cbPasek2.ForeColor = Color.White;

                        break;
                    case "Żółty":
                        pasek2Opor = 4;
                        cbPasek2.BackColor = Color.Yellow;
                        cbPasek2.ForeColor = Color.Black;
                        break;
                    case "Zielony":
                        pasek2Opor = 5;
                        cbPasek2.BackColor = Color.Green;
                        cbPasek2.ForeColor = Color.White;
                        break;
                    case "Niebieski":
                        pasek2Opor = 6;
                        cbPasek2.BackColor = Color.Blue;
                        cbPasek2.ForeColor = Color.White;
                        break;
                    case "Fioletowy":
                        pasek2Opor = 7;
                        cbPasek2.BackColor = Color.Violet;
                        cbPasek2.ForeColor = Color.White;
                        break;
                    case "Szary":
                        pasek2Opor = 8;
                        cbPasek2.BackColor = Color.LightGray;
                        cbPasek2.ForeColor = Color.Black;
                        break;
                    case "Biały":
                        pasek2Opor = 9;
                        cbPasek2.BackColor = Color.White;
                        cbPasek2.ForeColor = Color.Black;
                        break;
                    default:
                        pasek2Opor = 0;
                        cbPasek2.BackColor = Color.White;
                        cbPasek2.ForeColor = Color.Black;
                        break;

                }

                lblObliczenie.Text = string.Format("{0}Ω {1}%", (pasek1Opor * 10 + pasek2Opor) * mnoznik, tolerancja);

            }
        }

        private void cbMnoznik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMnoznik.SelectedIndex > -1)
            {
                switch (cbMnoznik.SelectedItem)
                {
                    case "Srebrny":
                        mnoznik = 0.01;
                        cbMnoznik.BackColor = Color.LightGray;
                        cbMnoznik.ForeColor = Color.Black;
                        break;
                    case "Złoty":
                        mnoznik = 0.1;
                        cbMnoznik.BackColor = Color.Gold;
                        cbMnoznik.ForeColor = Color.Black;
                        break;
                    case "Czarny":
                        mnoznik = 1;
                        cbMnoznik.BackColor = Color.Black;
                        cbMnoznik.ForeColor = Color.White;
                        break;
                    case "Brązowy":
                        mnoznik = 10;
                        cbMnoznik.BackColor = Color.Brown;
                        cbMnoznik.ForeColor = Color.White;

                        break;
                    case "Czerwony":
                        mnoznik = 100;
                        cbMnoznik.BackColor = Color.Red;
                        cbMnoznik.ForeColor = Color.White;
                        break;
                    case "Pomarańczowy":
                        mnoznik = 1000;
                        cbMnoznik.BackColor = Color.Orange;
                        cbMnoznik.ForeColor = Color.White;

                        break;
                    case "Żółty":
                        mnoznik = 10000;
                        cbMnoznik.BackColor = Color.Yellow;
                        cbMnoznik.ForeColor = Color.Black;
                        break;
                    case "Zielony":
                        mnoznik = 100000;
                        cbMnoznik.BackColor = Color.Green;
                        cbMnoznik.ForeColor = Color.White;
                        break;
                    case "Niebieski":
                        mnoznik = 1000000;
                        cbMnoznik.BackColor = Color.Blue;
                        cbMnoznik.ForeColor = Color.White;
                        break;
                    case "Fioletowy":
                        mnoznik = 10000000;
                        cbMnoznik.BackColor = Color.Violet;
                        cbMnoznik.ForeColor = Color.White;
                        break;
                    case "Szary":
                        mnoznik = 100000000;
                        cbMnoznik.BackColor = Color.LightGray;
                        cbMnoznik.ForeColor = Color.Black;
                        break;
                    case "Biały":
                        mnoznik = 1000000000;
                        cbMnoznik.BackColor = Color.White;
                        cbMnoznik.ForeColor = Color.Black;
                        break;
                    default:
                        mnoznik = 0;
                        cbMnoznik.BackColor = Color.White;
                        cbMnoznik.ForeColor = Color.Black;
                        break;

                }

                lblObliczenie.Text = string.Format("{0}Ω {1}%", (pasek1Opor * 10 + pasek2Opor) * mnoznik, tolerancja);

            }

        }

        private void cbTolerancja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTolerancja.SelectedIndex > -1)
            {
                switch (cbTolerancja.SelectedItem)
                {
                    case "Brak":
                        tolerancja = 20;
                        cbTolerancja.BackColor = Color.White;
                        cbTolerancja.ForeColor = Color.Black;
                        break;
                    case "Srebrny":
                        tolerancja = 10;
                        cbTolerancja.BackColor = Color.LightGray;
                        cbTolerancja.ForeColor = Color.Black;
                        break;
                    case "Złoty":
                        tolerancja = 5;
                        cbTolerancja.BackColor = Color.Gold;
                        cbTolerancja.ForeColor = Color.Black;
                        break;
                    case "Brązowy":
                        tolerancja = 1;
                        cbTolerancja.BackColor = Color.Brown;
                        cbTolerancja.ForeColor = Color.White;
                        break;
                    case "Czerwony":
                        tolerancja = 2;
                        cbTolerancja.BackColor = Color.Red;
                        cbTolerancja.ForeColor = Color.White;
                        break;
                    case "Zielony":
                        tolerancja = 0.5;
                        cbTolerancja.BackColor = Color.Green;
                        cbTolerancja.ForeColor = Color.White;
                        break;
                    case "Niebieski":
                        tolerancja = 0.25;
                        cbTolerancja.BackColor = Color.Blue;
                        cbTolerancja.ForeColor = Color.White;
                        break;
                    case "Fioletowy":
                        tolerancja = 0.1;
                        cbTolerancja.BackColor = Color.Violet;
                        cbTolerancja.ForeColor = Color.White;
                        break;
                    case "Szary":
                        tolerancja = 0.05;
                        cbTolerancja.BackColor = Color.LightGray;
                        cbTolerancja.ForeColor = Color.Black;
                        break;
                    default:
                        tolerancja = 0;
                        cbTolerancja.BackColor = Color.White;
                        cbTolerancja.ForeColor = Color.Black;
                        break;

                }

                lblObliczenie.Text = string.Format("{0}Ω {1}%", (pasek1Opor * 10 + pasek2Opor) * mnoznik, tolerancja);

            }

        }
    }
}
