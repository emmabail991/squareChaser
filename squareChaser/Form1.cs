using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace squareChaser
{


    public partial class Form1 : Form
    {

        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            countDown = true;
        }

        //rnadgen intagers
        int randNumY;
        int randNumX;

        //shape staring locations and size
        Rectangle player1 = new Rectangle(130, 30, 20, 20);
        Rectangle player2 = new Rectangle(450, 350, 20, 20);
        Rectangle pointBall = new Rectangle(460, 30, 10, 10);
        Rectangle speedBall = new Rectangle(130, 360, 10, 10);
        Rectangle boarder = new Rectangle(125, 25, 350, 350);
        Rectangle reverse = new Rectangle(125,23,10, 10);

        //player score and speed intagers
        int player1Score = 0;
        int player2Score = 0;
        int player1Speed = 4;
        int player2Speed = 4;

        //movment j
        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftDown = false;
        bool rightDown = false;
        bool countDown = false;


        //color brushes for graphics
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush darkBlueBrush = new SolidBrush(Color.DarkBlue);
        Pen whitePen = new Pen(Color.White, 5);
        Pen yellowPen = new Pen(Color.Yellow, 2);
        


        //enables and disables movment keys
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }

        }

        //enables and disables movment keys
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            //starting coundown
            if (countDown == true)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources._123CountDown);

                winLabel.Visible = true;

                winLabel.Text = "3";
                Thread.Sleep(1000);
                Refresh();

                winLabel.Text = "2";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                winLabel.Text = "1";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                winLabel.Text = "GO!!!";
                player.Play();
                Thread.Sleep(1000);
                Refresh();

                winLabel.Visible = false;
                countDown = false;
                player.Play();
                Thread.Sleep(1000);
                Refresh();
            }

            //move player 1
            if (wDown == true && player1.Y > 30)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < 350)
            {
                player1.Y += player1Speed;
            }
            if (aDown == true && player1.X > 130)
            {
                player1.X -= player1Speed;
            }
            if (dDown == true && player1.X < 450)
            {
                player1.X += player1Speed;
            }

            // move player 2
            if (upArrowDown == true && player2.Y > 30)
            {
                player2.Y -= player2Speed;
            }
            if (downArrowDown == true && player2.Y < 350)
            {
                player2.Y += player2Speed;
            }
            if (leftDown == true && player2.X > 130)
            {
                player2.X -= player2Speed;
            }
            if (rightDown == true && player2.X < 450)
            {
                player2.X += player2Speed;
            }

            //ball collition with player
            if (player1.IntersectsWith(pointBall))
            {
                //play speed ball sound 
                SoundPlayer player = new SoundPlayer(Properties.Resources.pointSound);
                player.Play();

                //new randome spot for pointball
                randNumX = randGen.Next(125, 445);
                randNumY = randGen.Next(35, 345);
                pointBall.Y = randNumY;
                pointBall.X = randNumX;

                //adds point to score and displayes 
                player1Score++;
                player1ScoreLable.Text = $"{player1Score}";
            }
            else if (player2.IntersectsWith(pointBall))
            {
                //play speed ball sound 
                SoundPlayer player = new SoundPlayer(Properties.Resources.pointSound);
                player.Play();

                //new randome spot for pointball
                randNumX = randGen.Next(125, 445);
                randNumY = randGen.Next(35, 345);
                pointBall.Y = randNumY;
                pointBall.X = randNumX;

                //adds point to score and displayes 
                player2Score++;
                player2ScoreLabel.Text = $"{player2Score}";
            }

            if (player1.IntersectsWith(speedBall))
            {
                //play speed ball sound 
                SoundPlayer player = new SoundPlayer(Properties.Resources.speedSound);
                player.Play();

                //new randome spot for speedball
                randNumX = randGen.Next(125, 445);
                randNumY = randGen.Next(35, 345);
                speedBall.Y = randNumY;
                speedBall.X = randNumX;

                //ups player speed
                player1Speed++;
            }
            else if (player2.IntersectsWith(speedBall))
            {
                //play speed ball sound 
                SoundPlayer player = new SoundPlayer(Properties.Resources.speedSound);
                player.Play();

                //new randome spot for speedball
                randNumX = randGen.Next(125, 445);
                randNumY = randGen.Next(35, 345);
                speedBall.Y = randNumY;
                speedBall.X = randNumX;

                //ups player speed
                player1Speed++;
            }
           
            //check for game over and play win sound
            if (player1Score == 6)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.winSound);
                player.Play();

                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
            }
            else if (player2Score == 6)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.winSound);
                player.Play();

                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
            }
            Refresh();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            //shape and border graphics
            e.Graphics.FillEllipse(darkBlueBrush, player1);
            e.Graphics.FillEllipse(blueBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, pointBall);
            e.Graphics.DrawRectangle(whitePen, boarder);
            e.Graphics.DrawEllipse(yellowPen, speedBall);
            
        }


    }
}



