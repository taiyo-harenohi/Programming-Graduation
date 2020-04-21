using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60_Kalkulacka
{
    public partial class Form1 : Form
    {
        public int left;
        public int right;
        public string vyber;
        public int vysledek;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            left = int.Parse(tbLeft.Text);
            right = int.Parse(tbRight.Text);

            switch (vyber)
            {
                case "plus":
                    tbChosenAction.Text = left + " + " + right;
                    vysledek = left + right;
                    tbResult.Text = vysledek.ToString();
                    break;
                case "minus":
                    tbChosenAction.Text = left + " - " + right;
                    vysledek = left - right;
                    tbResult.Text = vysledek.ToString();
                    break;  
                case "nasobeni":
                    tbChosenAction.Text = left + " * " + right;
                    vysledek = left * right;
                    tbResult.Text = vysledek.ToString();
                    break;
                case "deleni":
                    tbChosenAction.Text = left + " / " + right;
                    vysledek = left / right;
                    tbResult.Text = vysledek.ToString();
                    break;
                case "zbytek":
                    tbChosenAction.Text = left + " % " + right;
                    vysledek = left % right;
                    tbResult.Text = vysledek.ToString();
                    break;
            }
        }

        private void rbPlus_CheckedChanged(object sender, EventArgs e)
        {
            vyber = "plus";
        }

        private void rbMinus_CheckedChanged(object sender, EventArgs e)
        {
            vyber = "minus";
        }

        private void rbMultiply_CheckedChanged(object sender, EventArgs e)
        {
            vyber = "nasobeni";
        }

        private void rbDivide_CheckedChanged(object sender, EventArgs e)
        {
            vyber = "deleni";
        }

        private void rbRest_CheckedChanged(object sender, EventArgs e)
        {
            vyber = "zbytek";
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
