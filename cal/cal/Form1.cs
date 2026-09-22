using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "×";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "－";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "＋";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "÷";
        }
    }
}
