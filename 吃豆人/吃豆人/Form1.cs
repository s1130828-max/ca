using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 吃豆人
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool goup,godown,goleft,goright = false;
        int pacmanspeed = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup)
            {
                pacman.Top -= 8;
                pacman.Image = Properties.Resources.pacmanup;
            }
            if (godown)
            {
                pacman.Top += 8;
                pacman.Image = Properties.Resources.pacmandown;
            }
            if (goleft)
            {
                pacman.Left -= 8;
                pacman.Image = Properties.Resources.pacmanleft;
            }
            if (goright)
            {
                pacman.Left += 8;
                pacman.Image = Properties.Resources.pacman;
            }

            if (pacman.Bounds.IntersectsWith(panel1.Bounds))
            {
                goup = godown = false;
            }
            if (pacman.Bounds.IntersectsWith(panel2.Bounds))
            {
                goup = godown = false;
            }
            if (pacman.Bounds.IntersectsWith(panel4.Bounds))
            {
                goup = godown = false;
            }
            if (pacman.Bounds.IntersectsWith(panel5.Bounds))
            {
                goup = godown = false;
            }
            if (pacman.Bounds.IntersectsWith(panel1.Bounds))
            {
                goleft = goright = false;
            }
            if (pacman.Bounds.IntersectsWith(panel2.Bounds))
            {
                goleft = goright = false;
            }
            if (pacman.Bounds.IntersectsWith(panel4.Bounds))
            {
                goleft = goright = false;
            }
            if (pacman.Bounds.IntersectsWith(panel5.Bounds))
            {
                goleft = goright = false;
            }
                if (pacman.Bounds.IntersectsWith(pictureBox17.Bounds))
            {
                pictureBox17.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox3.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox4.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox5.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox6.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                pictureBox7.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                pictureBox9.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                pictureBox11.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                pictureBox13.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                pictureBox8.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                pictureBox15.Visible = false;
            }
            if (pacman.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                pictureBox16.Visible = false;
            }

            if (pacman.Top < -50)
            {
                pacman.Top = 490;
            }
            if (pacman.Left < -50)
            {
                pacman.Left = 820;
            }
            if (pacman.Top > 490 )
            {
                pacman.Top = -50;
            }
            if (pacman.Left > 820)
            {
                pacman.Left = -50;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goup = false;
                godown = false;
                goleft = true;
                goright = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                godown = false;
                goup = false;
                goleft = false;
                goright = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                godown = false;
                goleft = false;
                goright = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                goup = false;
                goleft = false;
                goright = false;
            }
        }
    }
}
