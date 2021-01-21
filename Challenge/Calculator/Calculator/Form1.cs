using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double hitung = 0;
        string pengolahan;
        bool mencet = false;

        private void angka_Click(object sender, EventArgs e)
        {
            if (textBoxpengolahan.Text == "0" || mencet)
            {
                textBoxpengolahan.Clear();
            }
            mencet = false;

            Button angka = (Button)sender;
            if (angka.Text == ",")
            {
                if (!textBoxpengolahan.Text.Contains(","))
                {
                    textBoxpengolahan.Text = textBoxpengolahan.Text + angka.Text;
                }
            }
            else
            {
                textBoxpengolahan.Text = textBoxpengolahan.Text + angka.Text;
            }
        }
        private void menghitung_Click(object sender, EventArgs e)
        {
            Button angka = (Button)sender;
            hitung = Double.Parse(textBoxpengolahan.Text);
            pengolahan = angka.Text;
            labelpengolahan.Text = hitung + " " + pengolahan;
            mencet = true;
        }
        private void buttonc_Click(object sender, EventArgs e)
        {
            textBoxpengolahan.Text = "0";
            labelpengolahan.Text = "";
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            textBoxpengolahan.Text = "0";
           
        }

        private void buttonsamadengan_Click(object sender, EventArgs e)
        {
            labelpengolahan.Text = hitung + " " + pengolahan + " " + textBoxpengolahan.Text;
            switch (pengolahan)
            {
                case "+":
                    textBoxpengolahan.Text = (hitung + Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                case "-":
                    textBoxpengolahan.Text = (hitung - Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                case "*":
                    textBoxpengolahan.Text = (hitung * Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                case "/":
                    textBoxpengolahan.Text = (hitung / Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                case "±":
                    textBoxpengolahan.Text = (hitung + Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                case "√":
                    textBoxpengolahan.Text = (hitung / Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                case "%":
                    textBoxpengolahan.Text = (hitung % Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                case "1 / X":
                    textBoxpengolahan.Text = (hitung / Double.Parse(textBoxpengolahan.Text)).ToString();
                    break;
                default:
                    break;
            }
            

        }


        private void memori_click(object sender, EventArgs e)
        {

        }
    }
}
