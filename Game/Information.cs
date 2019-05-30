using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Information : Form
    {
        mainForm mainFrm;
        public Information(mainForm frm)
        {
            InitializeComponent();
            mainFrm = frm;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            Location = new Point(180, 250);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mainFrm.PauseGame();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            mainFrm.ResetGame();
        }

        private void AutoToggle_CheckedChanged(object sender, EventArgs e)
        {
            //if (autoToggle.Checked)
            //{
            //    SoundPlayer sound = new SoundPlayer("AutopilotStart.wav");
            //    sound.Play();

            //} else
            //{
            //    SoundPlayer sound = new SoundPlayer("AutopilotEnd.wav");
            //    sound.Play();
            //}

            
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            mainFrm.ChangeSpeed(trackBar1.Value);
            lblCurrentLvl.Text = $"Current Level: {trackBar1.Value}";
        }

        public void UpdateLevel(int level)
        {
            trackBar1.Value = level;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            mainFrm.ChangeSpeed(trackBar1.Value);
            lblCurrentLvl.Text = $"Current Level: {trackBar1.Value}";
        }
    }
}
