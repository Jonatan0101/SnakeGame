namespace Game
{
    partial class Information
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
            this.infoPoints = new System.Windows.Forms.Label();
            this.infoTimeLeft = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.infoDirCh = new System.Windows.Forms.Label();
            this.infoPpS = new System.Windows.Forms.Label();
            this.autoToggle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // infoPoints
            // 
            this.infoPoints.AutoSize = true;
            this.infoPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPoints.Location = new System.Drawing.Point(9, 7);
            this.infoPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoPoints.Name = "infoPoints";
            this.infoPoints.Size = new System.Drawing.Size(120, 31);
            this.infoPoints.TabIndex = 0;
            this.infoPoints.Text = "Points: 0";
            // 
            // infoTimeLeft
            // 
            this.infoTimeLeft.AutoSize = true;
            this.infoTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTimeLeft.Location = new System.Drawing.Point(9, 44);
            this.infoTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoTimeLeft.Name = "infoTimeLeft";
            this.infoTimeLeft.Size = new System.Drawing.Size(172, 31);
            this.infoTimeLeft.TabIndex = 1;
            this.infoTimeLeft.Text = "Time Left: 60";
            this.infoTimeLeft.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(15, 236);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(253, 58);
            this.btnReset.TabIndex = 3;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // infoDirCh
            // 
            this.infoDirCh.AutoSize = true;
            this.infoDirCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDirCh.Location = new System.Drawing.Point(9, 80);
            this.infoDirCh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoDirCh.Name = "infoDirCh";
            this.infoDirCh.Size = new System.Drawing.Size(268, 31);
            this.infoDirCh.TabIndex = 4;
            this.infoDirCh.Text = "Direction Changes: 0";
            // 
            // infoPpS
            // 
            this.infoPpS.AutoSize = true;
            this.infoPpS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPpS.Location = new System.Drawing.Point(9, 117);
            this.infoPpS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoPpS.Name = "infoPpS";
            this.infoPpS.Size = new System.Drawing.Size(234, 31);
            this.infoPpS.TabIndex = 5;
            this.infoPpS.Text = "Points / Second: 0";
            // 
            // autoToggle
            // 
            this.autoToggle.AutoSize = true;
            this.autoToggle.Checked = true;
            this.autoToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoToggle.Location = new System.Drawing.Point(19, 178);
            this.autoToggle.Name = "autoToggle";
            this.autoToggle.Size = new System.Drawing.Size(224, 33);
            this.autoToggle.TabIndex = 6;
            this.autoToggle.Text = "Enable Autopilot";
            this.autoToggle.UseVisualStyleBackColor = true;
            this.autoToggle.CheckedChanged += new System.EventHandler(this.AutoToggle_CheckedChanged);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 368);
            this.Controls.Add(this.autoToggle);
            this.Controls.Add(this.infoPpS);
            this.Controls.Add(this.infoDirCh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoTimeLeft);
            this.Controls.Add(this.infoPoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Information";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time Left: 60";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Label infoPoints;
        public System.Windows.Forms.Label infoTimeLeft;
        public System.Windows.Forms.Label infoDirCh;
        public System.Windows.Forms.Label infoPpS;
        public System.Windows.Forms.CheckBox autoToggle;
    }
}