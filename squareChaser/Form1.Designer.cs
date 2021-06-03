
namespace squareChaser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player1ScoreLable = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player1Color = new System.Windows.Forms.Label();
            this.player2Color = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1ScoreLable
            // 
            this.player1ScoreLable.BackColor = System.Drawing.Color.Transparent;
            this.player1ScoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLable.ForeColor = System.Drawing.Color.White;
            this.player1ScoreLable.Location = new System.Drawing.Point(-1, 0);
            this.player1ScoreLable.Name = "player1ScoreLable";
            this.player1ScoreLable.Size = new System.Drawing.Size(42, 23);
            this.player1ScoreLable.TabIndex = 0;
            this.player1ScoreLable.Text = "0";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.player2ScoreLabel.Location = new System.Drawing.Point(581, 0);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(17, 23);
            this.player2ScoreLabel.TabIndex = 1;
            this.player2ScoreLabel.Text = "0";
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(202, 124);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(199, 78);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "0";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player1Color
            // 
            this.player1Color.AutoSize = true;
            this.player1Color.BackColor = System.Drawing.Color.DodgerBlue;
            this.player1Color.Location = new System.Drawing.Point(578, 23);
            this.player1Color.Name = "player1Color";
            this.player1Color.Size = new System.Drawing.Size(10, 13);
            this.player1Color.TabIndex = 4;
            this.player1Color.Text = " ";
            // 
            // player2Color
            // 
            this.player2Color.AutoSize = true;
            this.player2Color.BackColor = System.Drawing.Color.DarkBlue;
            this.player2Color.Location = new System.Drawing.Point(12, 23);
            this.player2Color.Name = "player2Color";
            this.player2Color.Size = new System.Drawing.Size(10, 13);
            this.player2Color.TabIndex = 5;
            this.player2Color.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.player2Color);
            this.Controls.Add(this.player1Color);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Squaare Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1ScoreLable;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player1Color;
        private System.Windows.Forms.Label player2Color;
    }
}

