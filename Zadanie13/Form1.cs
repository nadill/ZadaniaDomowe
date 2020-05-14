using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (number2==null && number1 !=null)
            {
                number2 = Convert.ToDouble(tbWindow.Text);

                switch (operation)
                {
                    case "+":
                        tbWindow.Text = (number1 + number2).ToString();
                        break;

                    case "-":
                        tbWindow.Text = (number1 - number2).ToString();
                        break;

                    case "*":
                        tbWindow.Text = (number1 * number2).ToString();
                        break;

                    case "/":
                        if (number2 == 0) {
                            MessageBox.Show("Nie dzielimy przez 0");
                        } else {
                            tbWindow.Text = (number1 / number2).ToString();
                        }
                        break;
                  
                }
                number1 = null;
                number2 = null;
                operation = "";
            }

        }

        double? number1 = null;
        double? number2 = null;
        string operation = "";

        //List<double> numbers = new List<double>();
        //List<string> operations = new List<string>();



        private void btnDigit_Click(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            if ((string)key.Tag == "." && tbWindow.Text.Contains(","))
            {

            }
            else if (tbWindow.Text.Equals("0") && (string)key.Tag == ".")
            {
                tbWindow.Text = "0,";
            } else
            {
                tbWindow.Text = (tbWindow.Text.Equals("0")) ? key.Text : tbWindow.Text + key.Text;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbWindow.Text = "0";
            number1 = null;
            number2 = null;
            operation = "";
            //numbers.Clear();
        }

        private void btnOperator_Click (object sender, EventArgs e)
        {
            if (number1 == null && operation.Equals(""))
            {
                number1 = Convert.ToDouble(tbWindow.Text);
                Button key = (Button)sender;
                operation = key.Text;
                tbWindow.Text = "";
            }
        }


    }
}
