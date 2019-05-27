namespace Game
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedSelect = new System.Windows.Forms.TrackBar();
            this.pauseMsg = new System.Windows.Forms.Label();
            this.circle = new System.Windows.Forms.PictureBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.playerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 198);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // speedSelect
            // 
            this.speedSelect.Location = new System.Drawing.Point(-75, -81);
            this.speedSelect.Margin = new System.Windows.Forms.Padding(2);
            this.speedSelect.Name = "speedSelect";
            this.speedSelect.Size = new System.Drawing.Size(78, 45);
            this.speedSelect.TabIndex = 1;
            this.speedSelect.Value = 10;
            this.speedSelect.Scroll += new System.EventHandler(this.SpeedSelect_Scroll);
            // 
            // pauseMsg
            // 
            this.pauseMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pauseMsg.AutoSize = true;
            this.pauseMsg.BackColor = System.Drawing.Color.Transparent;
            this.pauseMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseMsg.Location = new System.Drawing.Point(134, 24);
            this.pauseMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pauseMsg.Name = "pauseMsg";
            this.pauseMsg.Size = new System.Drawing.Size(434, 55);
            this.pauseMsg.TabIndex = 3;
            this.pauseMsg.Text = "GAME IS PAUSED";
            this.pauseMsg.Visible = false;
            // 
            // circle
            // 
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.InitialImage = ((System.Drawing.Image)(resources.GetObject("circle.InitialImage")));
            this.circle.Location = new System.Drawing.Point(11, 265);
            this.circle.Margin = new System.Windows.Forms.Padding(2);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(32, 37);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circle.TabIndex = 4;
            this.circle.TabStop = false;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(127, 88);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(345, 51);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // playerBox
            // 
            this.playerBox.Image = ((System.Drawing.Image)(resources.GetObject("playerBox.Image")));
            this.playerBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("playerBox.InitialImage")));
            this.playerBox.Location = new System.Drawing.Point(280, 170);
            this.playerBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(26, 28);
            this.playerBox.TabIndex = 8;
            this.playerBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.pauseMsg);
            this.Controls.Add(this.speedSelect);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(75004, 812507);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar speedSelect;
        private System.Windows.Forms.Label pauseMsg;
        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox playerBox;
    }
}

