using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Laps_timer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stopwatch sw = new Stopwatch { };
        int i = 0;
        int s = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Enabled = true;
                sw.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                sw.Start();
                button1.Text = "Start";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            s++;

            if (s == 1)
                label3.Text = label3.Text + label1.Text + " !";
             else
              if (s == 2)
                  label4.Text = label4.Text + label1.Text + " !";
                else
                 if (s == 3)
                     label5.Text = label5.Text + label1.Text + " !";
                  else
                   if (s == 4)
                       label6.Text = label6.Text + label1.Text + " !";
                     else
                      if (s == 5)
                          label7.Text = label7.Text + label1.Text + " !";
                        else
                         if (s == 6)
                             label8.Text = label8.Text + label1.Text + " !";
                           else
                            if (s == 7)
                                label9.Text = label9.Text + label1.Text + " !";
                              else
                               if (s == 8)
                                   label10.Text = label10.Text + label1.Text + " !";
                                 else
                                  if (s == 9)
                                      label11.Text = label11.Text + label1.Text + " !";
                                    else
                                     if (s == 10)
                                         label12.Text = label12.Text + label1.Text + " !";
                                       else
                                        if (s == 11)
                                           {
                                             button2.Text = "Reset";
                                             sw.Stop();
                                           }
                                          else  
                                            if(s == 12)
                                              {
                                                 button2.Text = "Laps";
                                                 sw.Reset();
                                                 label3.Text = "Lap 1: ";
                                                 label4.Text = "Lap 2: ";
                                                 label5.Text = "Lap 3: ";
                                                 label6.Text = "Lap 4: ";
                                                 label7.Text = "Lap 5: ";
                                                 label8.Text = "Lap 6: ";
                                                 label9.Text = "Lap 7: ";
                                                 label10.Text = "Lap 8: ";
                                                 label11.Text = "Lap 9: ";
                                                 label12.Text = "Lap 10: ";                                                 
                                              }
                                                 else
                                                      s = 0;                                                                                             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hrs = sw.Elapsed.Hours, mins = sw.Elapsed.Minutes, sec = sw.Elapsed.Seconds, mil = sw.Elapsed.Milliseconds;
            label1.Text = hrs + ":";
            if (mins < 10)
                label1.Text += "0" + mins + ":";
             else
                 label1.Text += mins + ":";
              if (sec < 10)
                  label1.Text += "0" + sec + ":";
               else
                    label1.Text += sec + ":";
                if (mil < 10)
                     label1.Text += "0" + mil + ":";
                 else
                      label1.Text += mil + "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit this application", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                this.Show();
            else
                this.Close();
        }      
    }
}
