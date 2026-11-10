using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問卷調查
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}
        private void groupBox3_Enter(object sender, EventArgs e){}
        private void radioButton2_CheckedChanged(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void ClearSelection(GroupBox gb)
        {foreach (Control c in gb.Controls){if (c is RadioButton rdo) rdo.Checked = false;if (c is CheckBox chk) chk.Checked = false;if (c is TextBox txt) txt.Clear();}}
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {groupBox3.Enabled = !radioButton6.Checked;if (radioButton6.Checked){ClearSelection(groupBox3);}}
        private void button1_Click(object sender, EventArgs e)
        {
            string ageResult = "";
            if (radioButton1.Checked) ageResult = "6歲以下";
            else if (radioButton2.Checked) ageResult = "6~10歲";
            else if (radioButton3.Checked) ageResult = "10~14歲";
            else if (radioButton4.Checked) ageResult = "14~18歲";
            else if (radioButton5.Checked) ageResult = "18歲以上";
            else { MessageBox.Show("請選擇年齡層！"); return; }
            if (radioButton5.Checked)
            { MessageBox.Show($"問卷結果：\n年齡層：{ageResult}\n(因大於18歲，不符合本問卷調查對象)", "調查結果");return;}
            string timeResult = "";
            if (radioButton6.Checked) timeResult = "不使用";
            else if (radioButton7.Checked) timeResult = "2小時以內";
            else if (radioButton8.Checked) timeResult = "2~4小時";
            else if (radioButton9.Checked) timeResult = "4~6小時";
            else if (radioButton10.Checked) timeResult = "6小時以上";
            else { MessageBox.Show("請選擇使用時數！"); return; }
            if (radioButton6.Checked)
            { MessageBox.Show($"問卷結果：\n年齡層：{ageResult}\n使用時數：{timeResult}\n主要活動：無", "調查結果");return;}
            List<string> activities = new List<string>();
            if (checkBox1.Checked) activities.Add("社群軟體");
            if (checkBox2.Checked) activities.Add("線上遊戲");
            if (checkBox3.Checked) activities.Add("課業需求");
            if (checkBox4.Checked) activities.Add("線上影音");
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            { activities.Add($"其它({textBox1.Text.Trim()})");}
            string actResult = activities.Count > 0 ? string.Join(", ", activities) : "未勾選任何活動";
            string finalReport = $"【問卷調查結果】\n" +
                                 $"1. 年齡層：{ageResult}\n" +
                                 $"2. 網路使用時數：{timeResult}\n" +
                                 $"3. 主要活動：{actResult}";
            MessageBox.Show(finalReport, "調查結果", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {bool isOver18 = radioButton5.Checked;groupBox2.Enabled = !isOver18;groupBox3.Enabled = !isOver18;if (isOver18){ClearSelection(groupBox2);ClearSelection(groupBox3);}}
    }
}
