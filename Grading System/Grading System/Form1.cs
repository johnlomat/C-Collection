using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
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

            Double A, H, A1, I1, A2,I2, A3, I3, Q1, QI1, Q2, QI2, M, MI1, FG, Att, Act1, Act2, Act3, Act, Qu1, Qu2, Qu, ME;

            A = Double.Parse(textBox2.Text);
            H = Double.Parse(textBox3.Text);
            A1 = Double.Parse(textBox4.Text);
            I1 = Double.Parse(textBox5.Text);
            A2 = Double.Parse(textBox6.Text);
            I2 = Double.Parse(textBox7.Text);
            A3 = Double.Parse(textBox8.Text);
            I3 = Double.Parse(textBox9.Text);
            Q1 = Double.Parse(textBox10.Text);
            QI1 = Double.Parse(textBox11.Text);
            Q2 = Double.Parse(textBox12.Text);
            QI2 = Double.Parse(textBox13.Text);
            M = Double.Parse(textBox14.Text);
            MI1 = Double.Parse(textBox15.Text);
            
            Att = ((A / H * 50 + 50) * (.1));
            Act1 = ((A1 / I1 * 50 + 50));
            Act2 = ((A2 / I2 * 50 + 50));
            Act3 = ((A3 / I3 * 50 + 50));
            Act = (((Act1 + Act2 + Act3) / 3) * .2);
            Qu1 = ((Q1 / QI1 * 50 + 50));
            Qu2 = (Q2 / QI2 * 50 + 50);
            Qu = (((Qu1 + Qu2) / 2) * .3);
            ME = ((M / MI1 * 50 + 50) * (.4));
            FG = Att + Act + Qu + ME;
           
            textBox16.Text = FG.ToString();
           
                                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-Enter your name-";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double FG;
            FG = Double.Parse(textBox16.Text);



            if (FG == 100)           
                MessageBox.Show("     Excellent!", "Grade");           
            else
                if (FG > 95)
                    MessageBox.Show("     Very Good!", "Grade");
                else
                    if (FG > 93)
                        MessageBox.Show("     Good!", "Grade");
                    else
                        if (FG > 88)
                            MessageBox.Show("     Very Nice!", "Grade");
                        else
                            if (FG > 84)
                                MessageBox.Show("     Nice!", "Grade");
                            else
                                if (FG > 79)
                                    MessageBox.Show("     Not Bad!", "Grade");
                                else
                                    if (FG > 76)
                                        MessageBox.Show("     Fair Enough!", "Grade");
                                    else
                                        if (FG > 75)
                                            MessageBox.Show("     Fair!", "Grade");
                                        else
                                            MessageBox.Show(" Better Luck Next Time!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                this.Show();
            else
                this.Close();
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Clear();
        }             
    }
}
