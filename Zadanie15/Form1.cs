using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            // dodajemy wybrane elementy do listBox2
            foreach (var item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }

            // definiuję ilość wybranych elementów w listBox1
            int selectedCount = listBox1.SelectedItems.Count;

            for (int i = 0; i < selectedCount; i++)
            {
                // usuwam elementy zaznaczone w indexie 0 (usuwany element zmienia 
                // indexy nastepnych elementów w kolekcji)
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(String.Format("Opcja {0}", i));
                listBox2.Items.Add(String.Format("Opcja {0}", (char)(i + (int)'A')));
            }

        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            // dodajemy wybrane elementy do listBox2
            foreach (var item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(item);
            }

            // definiuję ilość wybranych elementów w listBox1
            int selectedCount = listBox2.SelectedItems.Count;

            for (int i = 0; i < selectedCount; i++)
            {
                // usuwam elementy zaznaczone w indexie 0 (usuwany element zmienia 
                // indexy nastepnych elementów w kolekcji)
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }
    }
}
