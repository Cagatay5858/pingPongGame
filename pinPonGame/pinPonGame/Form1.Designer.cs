namespace pinPonGame
{
    partial class gameForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playGround = new System.Windows.Forms.Panel();
            this.point_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.gameOver_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.Controls.Add(this.gameOver_lbl);
            this.playGround.Controls.Add(this.point_lbl);
            this.playGround.Controls.Add(this.score_lbl);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.racket);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(800, 450);
            this.playGround.TabIndex = 0;
            // 
            // point_lbl
            // 
            this.point_lbl.AutoSize = true;
            this.point_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.point_lbl.Location = new System.Drawing.Point(93, 23);
            this.point_lbl.Name = "point_lbl";
            this.point_lbl.Size = new System.Drawing.Size(24, 25);
            this.point_lbl.TabIndex = 3;
            this.point_lbl.Text = "0";
            this.point_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.point_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_lbl.Location = new System.Drawing.Point(13, 23);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(86, 25);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score : ";
            this.score_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(151, 223);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(256, 332);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // gameOver_lbl
            // 
            this.gameOver_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOver_lbl.Location = new System.Drawing.Point(240, 73);
            this.gameOver_lbl.Name = "gameOver_lbl";
            this.gameOver_lbl.Size = new System.Drawing.Size(305, 180);
            this.gameOver_lbl.TabIndex = 4;
            this.gameOver_lbl.Text = "Game Over !\r\n\r\nF1 - Restart Game\r\n\r\nEsc - Exit";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playGround);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Label point_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label gameOver_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

