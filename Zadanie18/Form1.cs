using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int passLength = 1;
        int passCount = 1;
        Random random = new Random();





        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lbGeneratedPass.Items.Clear();

            for (int i = 0; i < passCount; i++)
            {
                string password="";
                for (int j = 0; j < passLength; j++)
                {
                    int unicode = 0;
                    if (rbAll.Checked)
                    {
                        unicode = random.Next(33, 127);
                    }
                    else if (rbDigits.Checked)
                    {
                        unicode = random.Next(48, 58);
                    }
                    else if (rbDigChar.Checked)
                    {
                        unicode = random.Next(1, 3);
                        unicode = (unicode == 1) ? random.Next(48, 58) : random.Next(65, 91);
                    }
                    
                    char ansii = (char)unicode;
                    string character = ansii.ToString();
                    password = password + character;
                }
                if (lbGeneratedPass.Items.Contains(password))
                {
                    i--;
                }
                else
                {
                    lbGeneratedPass.Items.Add(password);
                }
                

            }
        }

        private void dudPassLen_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                passLength = Convert.ToInt32(dudPassLen.Text);
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dudPassCount_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                passCount = Convert.ToInt32(dudPassCount.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void lbGeneratedPass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lbGeneratedPass.SelectedIndex > -1)
            {
                Clipboard.SetText(lbGeneratedPass.SelectedItem.ToString());
            }
        }
    }
}
