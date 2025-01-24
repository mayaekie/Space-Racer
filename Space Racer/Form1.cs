using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Racer
{
    public partial class Form1 : Form
    {
        //global variables
        bool moveUp, moveDown, wUp, sDown;

        int speed = 8;
        int playerOneScore;
        int playerTwoScore;

        Image rocket = Properties.Resources.Iconoir_Team_Iconoir_Rocket_512;

        Rectangle player1 = new Rectangle(100, 250, 50,50);
        Rectangle player2 = new Rectangle(205, 250, 50, 50);

        //Ball variables
        int ballSize = 10;
        //int ballSpeed = 8;
        int groundHeight = 50;

        List<Rectangle> balls = new List<Rectangle>();
        List<int> ballSpeeds = new List<int>();

        SolidBrush greenBrush = new SolidBrush(Color.Green);

        Random randGen = new Random();
        int randValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //move rockets
            if (moveUp == true && player1.Y > 0)
            {
                player1.Y -= speed;
            }

            if (moveDown == true && player1.Y < 250)
            {
                player1.Y += speed;
            }

            if (wUp == true && player2.Y > 0)
            {
                player2.Y -= speed;
            }

            if (sDown == true && player2.Y < 250)
            {
                player2.Y += speed;
            }

            if (player1.Y < 10)
            {
                playerOneScore += 1;
                player1.Y = 250;
                
            }

            if(player2.Y < 10)
            {
                playerTwoScore += 1;
                player2.Y = 250;
            }

            if (playerOneScore == 3)
            {
               gameTimer.Stop();
            }

            if (playerTwoScore == 3)
            {
                gameTimer.Stop();
            }

            randValue = randGen.Next(1, 100);

            if (randValue <  25)
            {
                int Y = randGen.Next(0, this.Height);
                Rectangle newBall = new Rectangle(0, Y, ballSize, ballSize);
                balls.Add(newBall);
            }

            //else if (randValue < 11)
            //{
            //    int Y = randGen.Next(0, this.Height);
            //    Rectangle newBall = new Rectangle(0, Y, ballSize, ballSize);
            //    balls.Add(newBall);
            //}
            //else if (randValue < 17)
            //{
            //    int Y = randGen.Next(0, this.Height);
            //    Rectangle newBall = new Rectangle(0, Y, ballSize, ballSize);
            //    balls.Add(newBall);
            //}


            for (int i = 0; i < balls.Count; i++)
            {
                int x = balls[i].X + 10;
                balls[i] = new Rectangle(x, balls[i].Y, ballSize, ballSize);
            }

            for (int i = 0; i < balls.Count; i++)
            {
                ///didnt have time to finish the code for collisions
                ///DNF
                if (player1.IntersectsWith(balls[i]))
                {
                    
                }
            }
                    Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p1Score.Text = playerOneScore + "";
            p2Score.Text = playerTwoScore + "";
            e.Graphics.DrawImage(rocket, player1);
            e.Graphics.DrawImage(rocket, player2);

            for (int i = 0; i < balls.Count; i++)
            {
                e.Graphics.FillEllipse(greenBrush, balls[i]);
                
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }

            if (e.KeyCode == Keys.W)
            {
                wUp = true;
            }

            if (e.KeyCode == Keys.S)
            {
                sDown = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }

            if (e.KeyCode == Keys.W)
            {
                wUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                sDown = false;
            }
        }
    }
}
