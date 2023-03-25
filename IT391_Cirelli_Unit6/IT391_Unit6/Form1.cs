using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT391_Unit6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Int32.Parse(textBox1.Text) < 5) | (Int32.Parse(textBox1.Text) > 18))
            {
                label2.Visible = true;
                label2.Text = "You entered an invalid age number!";
            }
            else
            {
                label2.Visible = true;
                label2.Text = "You entered age number of " + textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains('@'))
            {
                label3.Visible = true;
                label3.Text = "You entered " + textBox2.Text;
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Email requires an @ symbol";
            }
        }
    }
}
