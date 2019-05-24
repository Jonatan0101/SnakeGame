namespace Game
{
    partial class DisplayData
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
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(433, 447);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "";
            this.txtDisplay.TextChanged += new System.EventHandler(this.TxtDisplay_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "clear box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "DisplayData";
            this.Text = "DisplayData";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Button button1;
    }
}