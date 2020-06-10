using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61_ObsluhaMysi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            string pressed;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    pressed = "levé";
                    break;
                case MouseButtons.Right:
                    pressed = "pravé";
                    break;
                case MouseButtons.Middle:
                    pressed = "prostřední";
                    break;
                default:
                    pressed = "What was that :c";
                    break;
            }
            int mysX = e.X;
            int mysY = e.Y;

            lbPress.Text = pressed;
            lbWhere.Text = "na souřadnicích [" + mysX.ToString() + ", " + mysY.ToString() + "].";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string modif = null;
            if (e.Control)
            {
                modif += "Control+";
            }
            if (e.Alt)
            {
                modif += "Alt+";
            }
            if (e.Shift)
            {
                modif += "Shift+";
            }
            string klavesa;
            klavesa = e.KeyCode.ToString();
            switch (e.KeyCode)
            {
                case Keys.ControlKey:
                case Keys.Menu:
                case Keys.ShiftKey:
                    klavesa = null;
                    break;
            }
            lbPress.Text = "Klávesa: " + modif + klavesa;
        }
    }
}
