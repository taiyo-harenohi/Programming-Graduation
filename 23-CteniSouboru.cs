using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _23_CteniSouboru
{
    public partial class Form1 : Form
    {
        public string tlacitko;
        public Form1()
        {
            InitializeComponent();
        }

        // opens the dialog window to get the txt file
        private void btnVychozi_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbVychozi.Text = openFileDialog1.FileName;
        }

        // user can chose where to save the new file
        private void btnVysledny_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            tbVysledny.Text = saveFileDialog1.FileName;
        }

        private void btnProved_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // using switch to determine which radiobutton is chosen
                    switch (tlacitko)
                    {
                        // reading the file via characters
                        case "znak":
                            int znak;
                            while ((znak = sr.Read()) != -1)
                            {
                                char novy = (char)znak;
                                sw.WriteLine(novy);
                            }
                            break;
                        // reading the file via lines
                        case "radek":
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine(line);
                            }
                            break;
                        // reading the full file at once
                        case "soubor":
                            sw.WriteLine(sr.ReadToEnd());
                            break;
                            // just a fun Easter Egg, lol
                        default:
                            MessageBox.Show("Tohle se ani nezobrazí, lol", "Proč tohle dělám?", MessageBoxButtons.OKCancel);
                            break;
                    }
                }
            }
        }

        // determining what radiobutton is picked

        private void rbZnak_CheckedChanged(object sender, EventArgs e)
        {
            tlacitko = "znak";
        }

        private void rbRadek_CheckedChanged(object sender, EventArgs e)
        {
            tlacitko = "radek";
        }

        private void rbVse_CheckedChanged(object sender, EventArgs e)
        {
            tlacitko = "soubor";
        }
    }
}
