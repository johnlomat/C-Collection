using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputOutput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, c;
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            c = a / b;
            textBox3.Text = c.ToString();

        }
    }
}
