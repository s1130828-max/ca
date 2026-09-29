using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 數字計算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans = 0;
            for (int i = 1; i <= 10; i = i + 1)
            {
                ans = ans + i;
            }
            txtMsg.Text = ans.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;

            // 從 11 開始遞減，每次減 2，直到大於等於 1
            for (int i = 11; i >= 1; i -= 2)
            {
                sum += i;
                Console.Write(i);
                if (i > 1)
                {
                    Console.Write(" + ");
                }
                txtMsg.Text = sum.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = 0;

            // 從 0.5 開始，每次加 0.5，直到 10.0 為止
            for (double i = 0.5; i <= 10.0; i += 0.5)
            {
                sum += i;
                Console.Write($"{i:0.0}"); // 格式化輸出保留一位小數

                if (i < 10.0)
                {
                    Console.Write(" + ");
                }
                txtMsg.Text = sum.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
