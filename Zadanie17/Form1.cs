using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int posX;
        int posY;
        int maxX;
        int maxY;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            maxX = form.Size.Width;
            maxY = form.Size.Height;
            posX = panel.Location.X;
            posY = panel.Location.Y;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Nadanie panelowi nowego położenia XY
            panel.Location = GeneratePoint();
            // Nadanie panelowi nowego koloru
            panel.BackColor = GenerateColor();
        }

        private Point GeneratePoint()
        {
            // Generowanie połóżenia X
            posX += random.Next(-75, 75);
            if (posX < 0)
            {
                posX = 0;
            }
            else if (posX > maxX - panel.Width)
            {
                posX = maxX - panel.Width;
            }
            // generowanie położenia Y
            posY += random.Next(-75, 75);
            if (posY < 0)
            {
                posY = 0;
            }
            else if (posY > maxY - panel.Height)
            {
                posY = maxY - panel.Height;
            }

            Point point = new Point(posX, posY);
            return point;
        }

        private Color GenerateColor()
        {
            byte r = (byte)random.Next(0, 255);
            byte g = (byte)random.Next(0, 255);
            byte b = (byte)random.Next(0, 255);

            Color color = new Color();
            color = Color.FromArgb(r, g, b);

            return color;
        }
    }
}
