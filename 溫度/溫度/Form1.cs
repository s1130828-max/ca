using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace 溫度
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 防呆驗證：嘗試將輸入文字轉換為 double 數字
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                // 公式：F = C * 9 / 5 + 32
                double fahrenheit = celsius * 9.0 / 5.0 + 32;

                // 顯示結果，並四捨五入至小數點後兩位
                textBox2.Text = $"華氏 {fahrenheit:F2} °F";
            }
            else
            {
                MessageBox.Show("請輸入有效的溫度數字！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 防呆驗證：嘗試將輸入文字轉換為 double 數字
            if (double.TryParse(textBox1.Text, out double fahrenheit))
            {
                // 公式：C = (F - 32) * 5 / 9
                double celsius = (fahrenheit - 32) * 5.0 / 9.0;

                // 顯示結果，並四捨五入至小數點後兩位
                textBox2.Text = $"攝氏 {celsius:F2} °C";
            }
            else
            {
                MessageBox.Show("請輸入有效的溫度數字！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
