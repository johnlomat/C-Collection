using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            label3.Text = label3.Text + b.Text;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label3.Text;
            label2.Text = "+";
            label3.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = label3.Text;
            label2.Text = "-";
            label3.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = label3.Text;
            label2.Text = "*";
            label3.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = label3.Text;
            label2.Text = "/";
            label3.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Double a, b, S, D, P, Q;
            string Plus = label2.Text;
            string Sub = label2.Text;
            string Mul = label2.Text;
            string Div = label2.Text;
            
            a = Double.Parse(label1.Text);
            b = Double.Parse(label3.Text);

            if (Plus == "+")
            {
                S = a + b;
                label1.Text = "";
                label2.Text = "";
                label3.Text = S.ToString();
            }
             else
              if (Sub == "-")
              {
                 D = a - b;
                 label1.Text = "";
                 label2.Text = "";
                 label3.Text = D.ToString();

              }
              else
               if (Mul == "*")
               {
                   P = a * b;
                   label1.Text = "";
                   label2.Text = "";
                   label3.Text = P.ToString();
               }
                 else
                   if (Div == "/")
                   {
                       Q = a / b;
                       label1.Text = "";
                       label2.Text = "";
                       label3.Text = Q.ToString();
                   }               
        }                       
    }
}
