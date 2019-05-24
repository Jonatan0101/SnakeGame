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
            this.SuspendLayout();
            // 
            // infoPoints
            // 
            this.infoPoints.AutoSize = true;
            this.infoPoints.Font = new System.Drawing.Font("Minion Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPoints.Location = new System.Drawing.Point(12, 9);
            this.infoPoints.Name = "infoPoints";
            this.infoPoints.Size = new System.Drawing.Size(134, 45);
            this.infoPoints.TabIndex = 0;
            this.infoPoints.Text = "Points: 0";
            // 
            // infoTimeLeft
            // 
            this.infoTimeLeft.AutoSize = true;
            this.infoTimeLeft.Font = new System.Drawing.Font("Minion Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTimeLeft.Location = new System.Drawing.Point(12, 54);
            this.infoTimeLeft.Name = "infoTimeLeft";
            this.infoTimeLeft.Size = new System.Drawing.Size(194, 45);
            this.infoTimeLeft.TabIndex = 1;
            this.infoTimeLeft.Text = "Time Left: 60";
            this.infoTimeLeft.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Minion Pro", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Minion Pro", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(20, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(337, 72);
            this.btnReset.TabIndex = 3;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // infoDirCh
            // 
            this.infoDirCh.AutoSize = true;
            this.infoDirCh.Font = new System.Drawing.Font("Minion Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoDirCh.Location = new System.Drawing.Point(12, 99);
            this.infoDirCh.Name = "infoDirCh";
            this.infoDirCh.Size = new System.Drawing.Size(298, 45);
            this.infoDirCh.TabIndex = 4;
            this.infoDirCh.Text = "Direction Changes: 0";
            // 
            // infoPpS
            // 
            this.infoPpS.AutoSize = true;
            this.infoPpS.Font = new System.Drawing.Font("Minion Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoPpS.Location = new System.Drawing.Point(12, 144);
            this.infoPpS.Name = "infoPpS";
            this.infoPpS.Size = new System.Drawing.Size(255, 45);
            this.infoPpS.TabIndex = 5;
            this.infoPpS.Text = "Points / Second: 0";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 453);
            this.Controls.Add(this.infoPpS);
            this.Controls.Add(this.infoDirCh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoTimeLeft);
            this.Controls.Add(this.infoPoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Information";
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
    }
}