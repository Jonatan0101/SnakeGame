namespace Game
{
    partial class Results
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayPoints = new System.Windows.Forms.Label();
            this.lblCompPoints = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Finished";
            // 
            // lblPlayPoints
            // 
            this.lblPlayPoints.AutoSize = true;
            this.lblPlayPoints.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayPoints.Location = new System.Drawing.Point(68, 269);
            this.lblPlayPoints.Name = "lblPlayPoints";
            this.lblPlayPoints.Size = new System.Drawing.Size(208, 27);
            this.lblPlayPoints.TabIndex = 1;
            this.lblPlayPoints.Text = "Your Points: 0";
            // 
            // lblCompPoints
            // 
            this.lblCompPoints.AutoSize = true;
            this.lblCompPoints.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompPoints.Location = new System.Drawing.Point(12, 242);
            this.lblCompPoints.Name = "lblCompPoints";
            this.lblCompPoints.Size = new System.Drawing.Size(264, 27);
            this.lblCompPoints.TabIndex = 2;
            this.lblCompPoints.Text = "Computer Points: 0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(67, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(264, 37);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Game Finished";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 305);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCompPoints);
            this.Controls.Add(this.lblPlayPoints);
            this.Controls.Add(this.label1);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayPoints;
        private System.Windows.Forms.Label lblCompPoints;
        private System.Windows.Forms.Label lblResult;
    }
}