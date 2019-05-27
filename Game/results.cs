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
    public partial class Results : Form
    {
        public Results(int playPoints, int compPoints)
        {
            InitializeComponent();

            lblCompPoints.Text = $"Computer Points: {compPoints}";
            lblPlayPoints.Text = $"Player Points: {playPoints}";

            if(compPoints > playPoints)
            {
                lblResult.BackColor = Color.Red;
                lblResult.Text = "You Lost";
            }
            else if(playPoints > compPoints)
            {
                lblResult.BackColor = Color.LightGreen;
                lblResult.Text = "You Won!";
            } else if(playPoints == compPoints)
            {
                lblResult.BackColor = Color.Blue;
                lblResult.Text = "Draw";
            }
        }
    }
}
