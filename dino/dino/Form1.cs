using dino.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dino
{
    public partial class Form1 : Form
    {
        private Image[] walkFrames = new Image[2];
        private int currentFrame = 0;
        private bool isJumping = false;
        private int jumpSpeed = 0;
        private int force = 12;
        private int groundY;

        public Form1()
        {
            InitializeComponent();
            InitializeAnimation();
            groundY = pictureBox1.Top;

            // 確保表單能優先攔截按鍵事件
            this.KeyPreview = true;
        }

        private void InitializeAnimation()
        {
            try
            {
                walkFrames[0] = Resources.DinoRun1;
                walkFrames[1] = Resources.DinoRun2;
                pictureBox1.Image = walkFrames[0];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("圖片載入失敗，請檢查路徑！錯誤訊息: " + ex.Message);
            }
        }

        int time = 0;
        int speed = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time.ToString();

            // 1. 障礙物與背景循環移動
            if (pictureBox2.Right < 0) pictureBox2.Left = 1080;
            if (pictureBox3.Right < 0) pictureBox3.Left = 1080;
            if (cactu1.Right < 0) cactu1.Left = 1080;

            pictureBox2.Left -= speed;
            pictureBox3.Left -= speed;
            cactu1.Left -= speed;

            // 2. 跳躍物理運算
            if (isJumping)
            {
                pictureBox1.Top += jumpSpeed;
                jumpSpeed += 10;

                if (pictureBox1.Top >= groundY)
                {
                    pictureBox1.Top = groundY;
                    isJumping = false;
                }
            }

            // 3. 碰撞檢測 (放在 isJumping 外部，確保走路與跳躍狀態都會判斷)
            if (pictureBox1.Bounds.IntersectsWith(cactu1.Bounds))
            {
                GameOver();
            }
        }

        // 使用 KeyPress 監聽空白鍵
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                // 若遊戲尚未開始，啟動計時器
                if (!timer1.Enabled)
                {
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    timer2.Interval = 200;
                }

                // 若不在跳躍中，觸發起跳
                if (!isJumping)
                {
                    isJumping = true;
                    jumpSpeed = -60;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isJumping)
            {
                currentFrame = (currentFrame == 0) ? 1 : 0;
                pictureBox1.Image = walkFrames[currentFrame];
            }
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            MessageBox.Show("遊戲結束!");
        }
    }
}