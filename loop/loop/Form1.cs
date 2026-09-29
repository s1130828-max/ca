using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int num = 1;

            //
            for (int i = 1; i < 10; i=i+1)
            {
                txtMsg.Text += num + "Hello" + Environment.NewLine;   
            }

        }
    }
}
