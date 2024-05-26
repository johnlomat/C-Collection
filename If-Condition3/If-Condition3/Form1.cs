using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace If_Condition3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                MessageBox.Show("You chose Blue", "Choosing a color", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            if (radioButton2.Checked == true)
                MessageBox.Show("You chose Red", "Choosing a color", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            if (radioButton3.Checked == true)
                MessageBox.Show("You chose Green", "Choosing a color", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            if (radioButton4.Checked == true)
                MessageBox.Show("You chose Yellow", "Choosing a color", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else           
                MessageBox.Show("You chose Black", "Choosing a color", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }        

        }
    }

