using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tbValue.Text);
                if (listBox1.SelectedIndex > -1)
                {
                    if (tbValue.Text == "") tbValue.Text = "0";

                    switch (listBox1.SelectedItem)
                    {
                        case "kg -> funty":
                            if (value < 0)
                            {
                                value *= -1;
                                tbValue.Text = value.ToString();
                            }
                            value *= 2.2046;
                                tbResult.Text = string.Format("{0:0.00}funt", value);
                                break;
                        case "funty -> kg":
                            if (value < 0)
                            {
                                value *= -1;
                                tbValue.Text = value.ToString();
                            }
                            value /= 2.2046;
                                tbResult.Text = string.Format("{0:0.00}kg", value);
                                break;
                        case "C -> F":
                            value = value*1.8 + 32;
                                tbResult.Text = string.Format("{0:0.00}F", value);
                                break;
                        case "F -> C":
                            value = (value-32)/1.8;
                                tbResult.Text = string.Format("{0:0.00}C", value);
                                break;
                        case "km/h -> kts":
                            if (value < 0)
                            {
                                value *= -1;
                                tbValue.Text = value.ToString();
                            }
                            value *= 0.62;
                                tbResult.Text = string.Format("{0:0.00}kts", value);
                                break;
                        case "kts -> km/h":
                            if (value < 0)
                            {
                                value *= -1;
                                tbValue.Text = value.ToString();
                            }
                            value *= 1.61;
                                tbResult.Text = string.Format("{0:0.00}km/h", value);
                                break;
                    
                    }
                }
                else
                {
                    tbResult.Text = "0";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }
    }
}
