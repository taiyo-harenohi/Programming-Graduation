using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _53_Panacek
{
    public partial class Form1 : Form
    {
        public int xPanacka = 50;
        public int yPanacka = 50;
        public int width = 50;
        public int height = 50;

        public Image picture = Properties.Resources.panacek;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            yPanacka -= 5;
            panel1.Refresh();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            yPanacka += 5;
            panel1.Refresh();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            xPanacka += 5;
            panel1.Refresh();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            xPanacka -= 5;
            panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string keyboard = e.KeyCode.ToString();

            switch (keyboard)
            {
                case "W":
                    yPanacka -= 5;
                    panel1.Refresh();
                    break;
                case "S":
                    yPanacka += 5;
                    panel1.Refresh();
                    break; 
                case "A":
                    xPanacka -= 5;
                    panel1.Refresh();
                    break;
                case "D":
                    xPanacka += 5;
                    panel1.Refresh();
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            kp.DrawImage(picture, xPanacka, yPanacka, width, height);
        }
    }
}
