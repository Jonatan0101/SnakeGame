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
        string playerDirection = "right";
        int speed = 5;
        int playerSpeed = 7;
        int dirCh = 0;
        bool pause = false;
        bool hasStarted = false;
        int points = 0;
        int playerPoints = 0;
        int clockUp = 0;
        int timeLeft = 60;

        Random r = new Random();

        int currentX;
        int currentY;

        int currentPlayerPosX;
        int currentPlayerPosY;

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
            //data.Show();

            playerBox.Location = new Point(r.Next(10, Size.Width), r.Next(10, Size.Height));
            pictureBox1.Location = new Point(r.Next(10, Size.Width), r.Next(10, Size.Height));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void ChangeSpeed(int value)
        {
            speed = value;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pause && e.KeyCode != Keys.Escape)
                return;
            
            switch (e.KeyCode)
            {
                case Keys.Down:
                    playerDirection = "down";
                    break;
                case Keys.Up:
                    playerDirection = "up";
                    break;
                case Keys.Right:
                    playerDirection = "right";
                    break;
                case Keys.Left:
                    playerDirection = "left";
                    break;

                case Keys.Escape:
                    PauseGame();
                    break;
            }
            dirCh++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (info.autoToggle.Checked)
                Control();
            

            pauseMsg.Visible = false;

            GetPositions();

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
            switch (playerDirection)
            {
                case "up":
                    playerBox.Location = new Point(currentPlayerPosX, currentPlayerPosY - playerSpeed);
                    break;
                case "down":
                    playerBox.Location = new Point(currentPlayerPosX, currentPlayerPosY + playerSpeed);

                    break;
                case "right":
                    playerBox.Location = new Point(currentPlayerPosX + playerSpeed, currentPlayerPosY);
                    break;
                case "left":
                    playerBox.Location = new Point(currentPlayerPosX - playerSpeed, currentPlayerPosY);
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

            // Flyttar spelaren om man åker utanför
            if (playerBox.Location.X > Size.Width)
                ChangePictureLocation(playerBox, 0, currentPlayerPosY);
            if (playerBox.Location.Y > Size.Height)
                ChangePictureLocation(playerBox, currentPlayerPosX, 0);
            if (playerBox.Location.X < 0)
                ChangePictureLocation(playerBox, Size.Width, currentPlayerPosY);
            if (playerBox.Location.Y < 0)
                ChangePictureLocation(playerBox, currentPlayerPosX, Size.Height);



            // Om cirkeln tas byter den plats
            if (pictureBox1.Bounds.IntersectsWith(circle.Bounds))
            {
                ChangeCirclePosition();
                points++;
            }
            if (playerBox.Bounds.IntersectsWith(circle.Bounds))
            {
                ChangeCirclePosition();
                playerPoints++;
            }
                
        }

        void Control()
        {
            GetPositions();

            int diffNormX = Math.Abs(currentX - circlePosX);
            int diffEdgX = Math.Abs(Width - currentX + circlePosX);

            int diffNormY = Math.Abs(currentY - circlePosX);
            int diffEdgY = Math.Abs(Height - currentY + circlePosX);

            data.txtDisplay.AppendText($"\ndiffNormX{diffNormX}-----diffEdgeX{diffEdgX} /// diffNormY{diffNormY}-----diffEdgeY{diffEdgY}");

            if (currentX < circlePosX)
            {
                if (diffNormX < diffEdgX)
                    direction = "right";
                else
                    direction = "left";
            }
            if (currentX > circlePosX)
            {
                if (diffNormX < diffEdgX)
                    direction = "left";
                else
                    direction = "right";
            }
            if(circlePosX -speed < currentX && circlePosX +speed > currentX)
            {
                if(currentY < circlePosY)
                    direction = "down";

                if(currentY > circlePosY)
                {
                    if (diffNormY < diffEdgY)
                        direction = "up";
                    else
                        direction = "down";
                }
            }
        }

        // Ej klar
        void AltControl()
        {
            int diffNormX = Math.Abs(currentX - circlePosX);
            int diffEdgX = Math.Abs(Width - currentX + circlePosX);

            int diffNormY = Math.Abs(currentY - circlePosX);
            int diffEdgY = Math.Abs(Height - currentY + circlePosX);



            

            
        }

        void GetPositions()
        {
            currentX = pictureBox1.Location.X;
            currentY = pictureBox1.Location.Y;

            circlePosX = circle.Location.X;
            circlePosY = circle.Location.Y;

            currentPlayerPosX = playerBox.Location.X;
            currentPlayerPosY = playerBox.Location.Y;
        }

        void ChangePictureLocation(PictureBox p, int x, int y)
        {
            p.Location = new Point(x, y);
        }

        

        void ChangeCirclePosition()
        {
            info.infoPoints.Text = $"Computer Points: {points}";
            info.lblPlayerPoints.Text = $"Player Points: {playerPoints}";
            
            circle.Location = new Point(r.Next(1, Size.Width -20), r.Next(1, Size.Height-100));

            data.txtDisplay.AppendText($"\n/////////NEW POSITION////////");
        }

        private void SpeedSelect_Scroll(object sender, EventArgs e)
        {
            
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
            clock.Enabled = !pause;
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
            timeLeft--;
            if (timeLeft == 0)
            {
                PauseGame();
                Results result = new Results(playerPoints, points);
                result.Show();
            }

            info.infoTimeLeft.Text = $"Time Left: {timeLeft}";
            //info.infoPpS.Text = $"Points / Second: {Math.Round(points / (double)(clockUp), 2)}";
        }

        
    }
}
