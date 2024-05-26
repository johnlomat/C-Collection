using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cashier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text;
            string Name = textBox1.Text;

            if (Name == "-Enter your name-")
                MessageBox.Show("You must enter your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (Name == "")
                MessageBox.Show("You must enter your name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Double  P1, P2, P3, P4, P5, Q1, Q2, Q3, Q4, Q5, IN1, IN2, IN3, IN4, IN5,T;
            
            P1 = Double.Parse(textBox3.Text);
            P2 = Double.Parse(textBox6.Text);
            P3 = Double.Parse(textBox9.Text);
            P4 = Double.Parse(textBox12.Text);
            P5 = Double.Parse(textBox15.Text);
            Q1 = Double.Parse(textBox4.Text);
            Q2 = Double.Parse(textBox7.Text);
            Q3 = Double.Parse(textBox10.Text);
            Q4 = Double.Parse(textBox13.Text);
            Q5 = Double.Parse(textBox16.Text);

            IN1 = P1 * Q1;
            IN2 = P2 * Q2;
            IN3 = P3 * Q3;
            IN4 = P4 * Q4;
            IN5 = P5 * Q5;
            T = IN1 + IN2 + IN3 + IN4 + IN5;

            textBox17.Text = T.ToString();


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double C, Ch, V, T;

            T = Double.Parse(textBox17.Text);
            C = Double.Parse(textBox18.Text);
            Ch = C - T;
            V = T * .12;

            textBox19.Text = Ch.ToString();
            textBox20.Text = V.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-Enter your name-";
            textBox3.Text = "0";
            textBox4.Text = "0";            
            textBox6.Text = "0";
            textBox7.Text = "0";            
            textBox9.Text = "0";
            textBox10.Text = "0";           
            textBox12.Text = "0";
            textBox13.Text = "0";            
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Fried Chicken")
            {
                textBox3.Text = "20";
            }
            if (comboBox1.SelectedItem == "Spaghetti")
            {
                textBox3.Text = "15";
            }
            if (comboBox1.SelectedItem == "Beef Tapa")
            {
                textBox3.Text = "23";
            }
            if (comboBox1.SelectedItem == "Hamburger")
            {
                textBox3.Text = "22";
            }
            if (comboBox1.SelectedItem == "Rice")
            {
                textBox3.Text = "8";
            }
            if (comboBox1.SelectedItem == "Egg")
            {
                textBox3.Text = "7";
            }
            if (comboBox1.SelectedItem == "Lugaw Plain")
            {
                textBox3.Text = "10";
            }
            if (comboBox1.SelectedItem == "Lugaw w/ Tokwa")
            {
                textBox3.Text = "15";
            }
            if (comboBox1.SelectedItem == "Sinigang na Isda")
            {
                textBox3.Text = "21";
            }

            if (comboBox1.SelectedItem == "Coke 1.5 L")
            {
                textBox3.Text = "45";
            }
            if (comboBox1.SelectedItem == "Sprite 1.5L")
            {
                textBox3.Text = "42";
            }           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Fried Chicken")
            {
                textBox6.Text = "20";
            }
            if (comboBox2.SelectedItem == "Spaghetti")
            {
                textBox6.Text = "15";
            }
            if (comboBox2.SelectedItem == "Beef Tapa")
            {
                textBox6.Text = "23";
            }
            if (comboBox2.SelectedItem == "Hamburger")
            {
                textBox6.Text = "22";
            }
            if (comboBox2.SelectedItem == "Rice")
            {
                textBox6.Text = "8";
            }
            if (comboBox2.SelectedItem == "Egg")
            {
                textBox6.Text = "7";
            }
            if (comboBox2.SelectedItem == "Lugaw Plain")
            {
                textBox6.Text = "10";
            }
            if (comboBox2.SelectedItem == "Lugaw w/ Tokwa")
            {
                textBox6.Text = "15";
            }
            if (comboBox2.SelectedItem == "Sinigang na Isda")
            {
                textBox6.Text = "21";
            }

            if (comboBox2.SelectedItem == "Coke 1.5 L")
            {
                textBox6.Text = "45";
            }
            if (comboBox2.SelectedItem == "Sprite 1.5L")
            {
                textBox6.Text = "42";
            }         
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Fried Chicken")
            {
                textBox9.Text = "20";
            }
            if (comboBox3.SelectedItem == "Spaghetti")
            {
                textBox9.Text = "15";
            }
            if (comboBox3.SelectedItem == "Beef Tapa")
            {
                textBox9.Text = "23";
            }
            if (comboBox3.SelectedItem == "Hamburger")
            {
                textBox9.Text = "22";
            }
            if (comboBox3.SelectedItem == "Rice")
            {
                textBox9.Text = "8";
            }
            if (comboBox3.SelectedItem == "Egg")
            {
                textBox9.Text = "7";
            }
            if (comboBox3.SelectedItem == "Lugaw Plain")
            {
                textBox9.Text = "10";
            }
            if (comboBox3.SelectedItem == "Lugaw w/ Tokwa")
            {
                textBox9.Text = "15";
            }
            if (comboBox3.SelectedItem == "Sinigang na Isda")
            {
                textBox9.Text = "21";
            }

            if (comboBox3.SelectedItem == "Coke 1.5 L")
            {
                textBox9.Text = "45";
            }
            if (comboBox3.SelectedItem == "Sprite 1.5L")
            {
                textBox9.Text = "42";
            }         
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == "Fried Chicken")
            {
                textBox12.Text = "20";
            }
            if (comboBox4.SelectedItem == "Spaghetti")
            {
                textBox12.Text = "15";
            }
            if (comboBox4.SelectedItem == "Beef Tapa")
            {
                textBox12.Text = "23";
            }
            if (comboBox1.SelectedItem == "Hamburger")
            {
                textBox12.Text = "22";
            }
            if (comboBox4.SelectedItem == "Rice")
            {
                textBox12.Text = "8";
            }
            if (comboBox4.SelectedItem == "Egg")
            {
                textBox12.Text = "7";
            }
            if (comboBox4.SelectedItem == "Lugaw Plain")
            {
                textBox12.Text = "10";
            }
            if (comboBox4.SelectedItem == "Lugaw w/ Tokwa")
            {
                textBox12.Text = "15";
            }
            if (comboBox4.SelectedItem == "Sinigang na Isda")
            {
                textBox12.Text = "21";
            }

            if (comboBox4.SelectedItem == "Coke 1.5 L")
            {
                textBox12.Text = "45";
            }
            if (comboBox4.SelectedItem == "Sprite 1.5L")
            {
                textBox12.Text = "42";
            }         
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem == "Fried Chicken")
            {
                textBox15.Text = "20";
            }
            if (comboBox5.SelectedItem == "Spaghetti")
            {
                textBox15.Text = "15";
            }
            if (comboBox1.SelectedItem == "Beef Tapa")
            {
                textBox15.Text = "23";
            }
            if (comboBox5.SelectedItem == "Hamburger")
            {
                textBox15.Text = "22";
            }
            if (comboBox5.SelectedItem == "Rice")
            {
                textBox15.Text = "8";
            }
            if (comboBox1.SelectedItem == "Egg")
            {
                textBox15.Text = "7";
            }
            if (comboBox5.SelectedItem == "Lugaw Plain")
            {
                textBox15.Text = "10";
            }
            if (comboBox5.SelectedItem == "Lugaw w/ Tokwa")
            {
                textBox15.Text = "15";
            }
            if (comboBox1.SelectedItem == "Sinigang na Isda")
            {
                textBox15.Text = "21";
            }

            if (comboBox5.SelectedItem == "Coke 1.5 L")
            {
                textBox15.Text = "45";
            }
            if (comboBox5.SelectedItem == "Sprite 1.5L")
            {
                textBox15.Text = "42";
            }         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Show();
            }
             else
            {
              this.Close();
            }
            
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Clear();
        }
    }
}
