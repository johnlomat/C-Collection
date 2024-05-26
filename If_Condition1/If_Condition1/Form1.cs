using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace If_Condition1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int T = 6;
        private void timer1_Tick(object sender, EventArgs e)
        {
            T--;
            label1.Text = "This Form will close automatically in " + T.ToString() + " Seconds...";

            if (T == 0)
                this.Close();

        }
    }
}
