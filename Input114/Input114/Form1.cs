using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Input114
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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Text = "-Enter your name-";
        }
    }
}
