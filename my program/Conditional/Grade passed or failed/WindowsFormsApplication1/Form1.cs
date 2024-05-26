using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double M, M1, M2, Q, Q1, A, A1, A2, S, S1, TM, TQ, TA, TS, FG, VM, VQ, VA, VS;

            M = Double.Parse(textBox1.Text);
            M1 = Double.Parse(textBox2.Text);
            M2 = Double.Parse(textBox3.Text);
            Q = Double.Parse(textBox4.Text);
            Q1 = Double.Parse(textBox5.Text);
            A = Double.Parse(textBox6.Text);
            A1 = Double.Parse(textBox7.Text);
            A2 = Double.Parse(textBox8.Text);
            S = Double.Parse(textBox9.Text);
            S1 = Double.Parse(textBox10.Text);
            TM = (M + M1 + M2);
            TQ = (Q + Q1);
            TA = (A + A1 + A2);
            TS = (S + S1);
            VM = ((TM / 3 * .40));
            VQ = ((TQ / 2 * .30));
            VA = ((TA / 3 * .15));
            VS = ((TS / 2 * .15));
            FG = (VM + VQ + VA + VS);
            textBox11.Text = FG.ToString();
            if (FG >= 75)
            {
                MessageBox.Show(" Passed ");
            }
            else
                if (FG < 75)
                {
                    MessageBox.Show(" Failed ");
                }

        }
    }
}
