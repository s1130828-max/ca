using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //
            for (int i = 0; i < 12; i = i + 1)
            {
                for (int j = 0; j < 8; j = j + 1)
                {
                    txtMsg.Text += "■" ;
                }
                txtMsg.Text += Environment.NewLine;
            }
        }
    }
}
