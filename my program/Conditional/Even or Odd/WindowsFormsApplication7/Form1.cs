using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;

            
           
                  num  = int.Parse(textBox1.Text);
                  if (num % 2 == 0)
                  {
                      MessageBox.Show(" Even ");
                  }
                  else
                  {
                      MessageBox.Show(" odd ");
                  }

        

        
        }

    }
}
