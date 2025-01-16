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

        int speed = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if(moveUp == true && playerOne.Top > 0)
            {
                playerOne.Top -= speed;
            }

            if (moveDown == true && playerOne.Top < 250)
            {
                playerOne.Top += speed;
            }

            if (wUp == true && playerTwo.Top > 0)
            {
                playerTwo.Top -= speed;
            }

            if (sDown == true && playerTwo.Top < 250)
            {
                playerTwo.Top += speed;
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
