namespace MASH
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.careerLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Jokerman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.titleLabel.Location = new System.Drawing.Point(500, 64);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(492, 144);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "M.A.S.H.";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.startButton.Location = new System.Drawing.Point(495, 302);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(255, 83);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "EXPLORE THE MAGIC";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.startButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // careerLabel1
            // 
            this.careerLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.careerLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.careerLabel1.Location = new System.Drawing.Point(22, 18);
            this.careerLabel1.Name = "careerLabel1";
            this.careerLabel1.Size = new System.Drawing.Size(92, 45);
            this.careerLabel1.TabIndex = 2;
            this.careerLabel1.Text = "Career";
            this.careerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(554, 471);
            this.Controls.Add(this.careerLabel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Mash Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label careerLabel1;
    }
}

