using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class mainForm : Form
    {
        string direction = "down";
        int speed = 10;
        int dirCh = 0;
        bool pause = false;
        bool hasStarted = false;
        int points = 0;
        int clockUp = 0;
        int timeLeft = 60;

        int currentX;
        int currentY;

        int circlePosX;
        int circlePosY;

        Information info;
        DisplayData data;
        public mainForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            info = new Information(this);
            data = new DisplayData(this);
            info.Show();
            data.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pause && e.KeyCode != Keys.Escape)
                return;
            
            switch (e.KeyCode)
            {
                case Keys.Down:
                    direction = "down";
                    break;
                case Keys.Up:
                    direction = "up";
                    break;
                case Keys.Right:
                    direction = "right";
                    break;
                case Keys.Left:
                    direction = "left";
                    break;

                case Keys.Escape:
                    PauseGame();
                    break;
            }
            dirCh++;
            info.infoDirCh.Text = $"Direction Changes: {dirCh}";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Control();

            pauseMsg.Visible = false;

            currentX = pictureBox1.Location.X;
            currentY = pictureBox1.Location.Y;

            // Tar in direction variablen och flyttar den åt hållet det är
            switch (direction)
            {
                case "up":
                    pictureBox1.Location = new Point(currentX, currentY - speed);
                    break;
                case "down":
                    pictureBox1.Location = new Point(currentX, currentY + speed);
                    
                    break;
                case "right":
                    pictureBox1.Location = new Point(currentX + speed, currentY);
                    break;
                case "left":
                    pictureBox1.Location = new Point(currentX - speed, currentY);
                    break;
            }

            // Flyttar bild om den åker utanför formen
            if (pictureBox1.Location.X > Size.Width)
                ChangePictureLocation(pictureBox1, 0, currentY);
            if (pictureBox1.Location.Y > Size.Height)
                ChangePictureLocation(pictureBox1, currentX, 0);
            if (pictureBox1.Location.X < 0)
                ChangePictureLocation(pictureBox1, Size.Width, currentY);
            if (pictureBox1.Location.Y < 0)
                ChangePictureLocation(pictureBox1, currentX, Size.Height);
            if (pictureBox1.Bounds.IntersectsWith(circle.Bounds))
                ChangeCirclePosition();
        }

        void Control()
        {
            currentX = pictureBox1.Location.X;
            currentY = pictureBox1.Location.Y;

            circlePosX = circle.Location.X;
            circlePosY = circle.Location.Y;

            if (currentX < circlePosX)
            {
                direction = "right";
            }
            if (currentX > circlePosX)
            {
                direction = "left";
            }
            if(circlePosX -10 < currentX && circlePosX +10 > currentX)
            {
                if(currentY < circlePosY)
                {
                    direction = "down";
                }
                if(currentY > circlePosY)
                {
                    direction = "up";
                }
            }
        }

        // Kalkylerar avståndet i pixlar mellan bild och cirkel
        double DistCalc()
        {
            currentX = pictureBox1.Location.X;
            currentY = pictureBox1.Location.Y;

            circlePosX = circle.Location.X;
            circlePosY = circle.Location.Y;

            // Returnerar avståndet som räknas ut med hjälp av avståndsformeln
            return Math.Sqrt(Math.Pow(circlePosX - currentX, 2) + Math.Pow(circlePosY - currentY, 2));
        }

        void ChangePictureLocation(PictureBox p, int x, int y)
        {
            p.Location = new Point(x, y);
        }

        void ChangeCirclePosition()
        {
            points++;
            info.infoPoints.Text = $"Points: {points}";
            
            Random r = new Random();
            circle.Location = new Point(r.Next(1, Size.Width -20), r.Next(1, Size.Height-100));

            data.txtDisplay.Text = $"{data.txtDisplay.Text}\n{DistCalc()} ----- ({currentX}, {currentY}) ({circlePosX},{circlePosY})";
        }

        private void SpeedSelect_Scroll(object sender, EventArgs e)
        {
            //speed = speedSelect.Value;
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        public void PauseGame()
        {
            if (!hasStarted)
                return;
            pause = !pause;
            pauseMsg.Visible = pause;

            timer1.Enabled = !pause;
        }
        public void ResetGame()
        {
            timeLeft = 60;
            points = 0;
            pictureBox1.Location = new Point(330, 200);
            timer1.Enabled = false;
            startBtn.Visible = true;
            pauseMsg.Visible = false;
            ChangeCirclePosition();
        }

        private void LblPoints_Click(object sender, EventArgs e){ }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            hasStarted = true;
            timer1.Enabled = true;
            clock.Enabled = true;
            startBtn.Visible = false;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            if (pause)
                return;

            clockUp++;
            //timeLeft--;
            info.infoTimeLeft.Text = $"Time Left: {timeLeft}";
            info.infoPpS.Text = $"Points / Second: {Math.Round((double)points / (double)(clockUp), 2)}";
        }
    }
}
