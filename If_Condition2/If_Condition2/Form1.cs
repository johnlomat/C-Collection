using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace If_Condition2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 6;

        private void button1_Click(object sender, EventArgs e)
        {
            Double b;

            a--;
            if (a == 5)
                label1.Text = a.ToString();
            else
                if (a == 4)
                {
                    label2.Text = a.ToString();

                }
                else
                    if (a == 3)
                    {
                        label3.Text = a.ToString();

                    }
                    else
                        if (a == 2)
                        {
                            label4.Text = a.ToString();

                        }
                        else
                            if (a == 1)
                            {
                                label5.Text = a.ToString();

                            }
                            else
                            {
                                label6.Text = a.ToString();
                                a = 6;
                                MessageBox.Show("Done!");
                            }

        }
    }
}
