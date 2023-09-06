using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pinPonGame
{
    public partial class gameForm : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;
        public gameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;


            racket.Top = playGround.Bottom - (playGround.Bottom / 10);

            gameOver_lbl.Left = (playGround.Width / 2) - (gameOver_lbl.Width / 2);
            gameOver_lbl.Top = (playGround.Height / 2) - (gameOver_lbl.Height / 2);
            gameOver_lbl.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;

            if(ball.Left <= playGround.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playGround.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playGround.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playGround.Bottom)
            {
                gameOver_lbl.Visible = true;
                timer1.Enabled = false;
            }
            if(ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                point_lbl.Text = points.ToString();

                Random r = new Random();
                playGround.BackColor = Color.FromArgb(r.Next(150, 255),r.Next(150, 255),r.Next(150, 255));


            }
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point_lbl.Text = "0";
                points = 0;
                timer1.Enabled = true;
                gameOver_lbl.Visible = false;
                playGround.BackColor = Color.White;
            }

        }
    }
}
