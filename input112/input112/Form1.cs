using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace input112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Clear();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = "-Enter your name here-";
            comboBox1.Text = "MMM";
            comboBox2.Text = "DD";
            comboBox3.Text = "YYYY";
        }      

    }
}
