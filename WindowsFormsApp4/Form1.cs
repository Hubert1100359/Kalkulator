﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private decimal x;
        private decimal wynik;
        private string op;

        public Form1()
        {
            InitializeComponent();
        }
       
            
            private void button10_Click(object sender, EventArgs e)
            {
                x = Convert.ToDecimal(label1.Text);
                label1.Text = "";
            op = button10.Text;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                label1.Text += "1";
            }

            private void button2_Click(object sender, EventArgs e)
            {
                label1.Text += "2";
            }

            private void button3_Click(object sender, EventArgs e)
            {
                label1.Text += "3";
            }

            private void button4_Click(object sender, EventArgs e)
            {
                label1.Text += "4";
            }

            private void button5_Click(object sender, EventArgs e)
            {
                label1.Text += "5";
            }

            private void button6_Click(object sender, EventArgs e)
            {
                label1.Text += "6";
            }

            private void button7_Click(object sender, EventArgs e)
            {
                label1.Text += "7";
            }

            private void button8_Click(object sender, EventArgs e)
            {
                label1.Text += "8";
            }

            private void button9_Click(object sender, EventArgs e)
            {
                label1.Text += "9";
            }

            private void button11_Click(object sender, EventArgs e)
            {
            x = Convert.ToDecimal(label1.Text);
            label1.Text = "";
            op = button11.Text;
        }

            private void button12_Click(object sender, EventArgs e)
            {
            x = Convert.ToDecimal(label1.Text);
            label1.Text = "";
            op = button12.Text;
        }

            private void button13_Click(object sender, EventArgs e)
            {
            x = Convert.ToDecimal(label1.Text);
            label1.Text = "";
            op = button13.Text;
        }

            private void button14_Click(object sender, EventArgs e)
            {
                switch (op)
            {
                case "+":
                    wynik = Convert.ToDecimal(label1.Text) + x;
                    break;
                case "-":
                    wynik = x - Convert.ToDecimal(label1.Text);
                    break;
                case "*":
                    wynik = x * Convert.ToDecimal(label1.Text) ;
                    break;
                case "/":
                    if (label1.Text=="0")
                    {
                        label1.Text = null;
                        MessageBox.Show("Nie można podzielić przez 0");
                        
                    }
                    else
                    wynik = x / Convert.ToDecimal(label1.Text);
                    break;


            }

            label1.Text = wynik.ToString();

            }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            x = 0;
        }
    }
}
