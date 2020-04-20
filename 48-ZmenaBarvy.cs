using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_ZmenaBarvy
{
    public partial class Form1 : Form
    {
        public string colorName;
        public Form1()
        {
            InitializeComponent();
        }

        // determining which radiobutten is picked
        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            colorName = "red";
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            colorName = "green";
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            colorName = "blue";
        }

        private void rbYellow_CheckedChanged(object sender, EventArgs e)
        {
            colorName = "yellow";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // using switch just because I can
            // to change color of the background => this.BackColor = Color.whichevercolorIwant;
            switch (colorName)
            {
                case "red":
                    this.BackColor = Color.Red;
                    break;
                case "green":
                    this.BackColor = Color.Green;
                    break;
                case "blue":
                    this.BackColor = Color.Blue;
                    break;
                case "yellow":
                    this.BackColor = Color.Yellow;
                    break;
            }
        }
    }
}
