using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tax
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

            Double HR, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31, DS1, DS2, DSA, DSB, DS, MS, GI, TE, T, NI, B, C;
            Double HRD1, HRD2, HRD3, HRD4, HRD5, HRD6, HRD7, HRD8, HRD9, HRD10, HRD11, HRD12, HRD13, HRD14, HRD15, HRD16, HRD17, HRD18, HRD19, HRD20, HRD21, HRD22, HRD23, HRD24, HRD25, HRD26, HRD27, HRD28, HRD29, HRD30, HRD31;
            
            HR = Double.Parse(textBox2.Text);
            D1 = Double.Parse(textBox3.Text);            
            D2 = Double.Parse(textBox4.Text);
            D3 = Double.Parse(textBox5.Text);
            D4 = Double.Parse(textBox6.Text);
            D5 = Double.Parse(textBox7.Text);
            D6 = Double.Parse(textBox8.Text);
            D7 = Double.Parse(textBox9.Text);
            D8 = Double.Parse(textBox10.Text);
            D9 = Double.Parse(textBox11.Text);
            D10 = Double.Parse(textBox12.Text);
            D11 = Double.Parse(textBox13.Text);
            D12 = Double.Parse(textBox14.Text);
            D13 = Double.Parse(textBox15.Text);
            D14 = Double.Parse(textBox16.Text);
            D15 = Double.Parse(textBox17.Text);
            D16 = Double.Parse(textBox18.Text);
            D17 = Double.Parse(textBox19.Text);
            D18 = Double.Parse(textBox20.Text);
            D19 = Double.Parse(textBox21.Text);
            D20 = Double.Parse(textBox22.Text);
            D21 = Double.Parse(textBox23.Text);
            D22 = Double.Parse(textBox24.Text);
            D23 = Double.Parse(textBox25.Text);
            D24 = Double.Parse(textBox26.Text);
            D25 = Double.Parse(textBox27.Text);
            D26 = Double.Parse(textBox28.Text);
            D27 = Double.Parse(textBox29.Text);
            D28 = Double.Parse(textBox30.Text);
            D29 = Double.Parse(textBox31.Text);
            D30 = Double.Parse(textBox32.Text);
            D31 = Double.Parse(textBox33.Text);
            //Hourly Rate times Days.
            HRD1 = HR * D1;
            HRD2 = HR * D2;
            HRD3 = HR * D3;
            HRD4 = HR * D4;
            HRD5 = HR * D5;
            HRD6 = HR * D6;
            HRD7 = HR * D7;
            HRD8 = HR * D8;
            HRD9 = HR * D9;
            HRD10 = HR * D10;
            HRD11 = HR * D11;
            HRD12 = HR * D12;
            HRD13 = HR * D13;
            HRD14 = HR * D14;
            HRD15 = HR * D15;
            HRD16 = HR * D16;
            HRD17 = HR * D17;
            HRD18 = HR * D18;
            HRD19 = HR * D19;
            HRD20 = HR * D20;
            HRD21 = HR * D21;
            HRD22 = HR * D22;
            HRD23 = HR * D23;
            HRD24 = HR * D24;
            HRD25 = HR * D25;
            HRD26 = HR * D26;
            HRD27 = HR * D27;
            HRD28 = HR * D28;
            HRD29 = HR * D29;
            HRD30 = HR * D30;
            HRD31 = HR * D31;
            //15 Days Salary 1 and 2.
            DS1 = HRD1 + HRD2 + HRD3 + HRD4 + HRD5 + HRD6 + HRD7 + HRD8 + HRD9 + HRD10 + HRD11 + HRD12 + HRD13 + HRD14 + HRD15;
            DS2 = HRD16 + HRD17 + HRD18 + HRD19 + HRD20 + HRD21 + HRD22 + HRD23 + HRD24 + HRD25 + HRD26 + HRD27 + HRD28 + HRD29 + HRD30 + HRD31;
            DSA = DS1;
            DSB = DS2;            
            MS = DSA + DSB;
            //Gross Income.
            GI = MS;

            //Tax

            if (GI >= 500000)
                T = ((GI * .34) + 125000);
            else
                if (GI > 250000)
                    T = ((GI * .30) + 50000);
                else
                    if (GI > 140000)
                        T = ((GI * .25) + 22500);
                    else
                        if (GI > 70000)
                            T = ((GI * .20) + 8500);
                        else
                            if (GI > 30000)
                                T = ((GI * .15) + 2500);
                            else
                                if (GI > 10000)
                                    T = ((GI * .10) + 500);
                                 else
                                    T = (GI * .05);
                                        NI = (GI - T);

            //Branches

            if (radioButton1.Checked == true)
                TE = 0;
             else
                if (radioButton2.Checked == true)
                    TE = GI * .05;
                 else
                    if (radioButton3.Checked == true)
                        TE = GI * .05;
                     else
                        if (radioButton4.Checked == true)
                            TE = GI * (.05 / 2);
                         else
                            if (radioButton5.Checked == true)
                                TE = GI * (.05 / 3);
                            else
                                if (radioButton6.Checked == true)
                                    TE = GI * .1;
                                else
                                  if (radioButton7.Checked == true)
                                    TE = GI * .05;
                                   else
                                    if (radioButton8.Checked == true)
                                        TE = GI * .05;
                                      else
                                        if(radioButton9.Checked == true)
                                           TE = GI * .1;
                                          else
                                             TE = GI * .1;
                                               NI = (NI + TE);

            textBox36.Text = DSA.ToString();
            textBox37.Text = DSB.ToString();
            textBox38.Text = MS.ToString();
            textBox39.Text = GI.ToString();
            textBox40.Text = T.ToString();
            textBox41.Text = TE.ToString();
            textBox42.Text = NI.ToString();


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
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
            textBox25.Text = "0";
            textBox26.Text = "0";
            textBox27.Text = "0";
            textBox28.Text = "0";
            textBox29.Text = "0";
            textBox30.Text = "0";
            textBox31.Text = "0";
            textBox32.Text = "0";
            textBox33.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
            textBox25.Text = "0";
            textBox26.Text = "0";
            textBox27.Text = "0";
            textBox28.Text = "0";
            textBox29.Text = "0";
            textBox30.Text = "0";
            textBox31.Text = "0";
            textBox32.Text = "0";
            textBox33.Text = "0";
            textBox34.Text = "0";
            textBox35.Text = "0";
            textBox36.Text = "0";
            textBox37.Text = "0";
            textBox38.Text = "0";
            textBox39.Text = "0";
            textBox40.Text = "0";
            textBox41.Text = "0";
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
