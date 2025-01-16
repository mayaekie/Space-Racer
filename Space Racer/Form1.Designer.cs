namespace Space_Racer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerOne = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.playerTwo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // playerOne
            // 
            this.playerOne.Image = ((System.Drawing.Image)(resources.GetObject("playerOne.Image")));
            this.playerOne.Location = new System.Drawing.Point(141, 311);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(50, 50);
            this.playerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerOne.TabIndex = 0;
            this.playerOne.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // playerTwo
            // 
            this.playerTwo.Image = ((System.Drawing.Image)(resources.GetObject("playerTwo.Image")));
            this.playerTwo.Location = new System.Drawing.Point(289, 311);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(50, 50);
            this.playerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerTwo.TabIndex = 1;
            this.playerTwo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 373);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Name = "Form1";
            this.Text = "Space Race";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerOne;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox playerTwo;
    }
}

