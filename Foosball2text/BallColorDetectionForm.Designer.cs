namespace Foosball2text
{
    partial class BallColorDetectionForm
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
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._pauseButton = new System.Windows.Forms.Button();
            this._continueButton = new System.Windows.Forms.Button();
            this._restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please pause video when ball appears and press on ball to detect color";
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(33, 34);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(360, 200);
            this._pictureBox.TabIndex = 1;
            this._pictureBox.TabStop = false;
            this._pictureBox.Click += new System.EventHandler(this.OnPictureBoxClick);
            // 
            // _pauseButton
            // 
            this._pauseButton.Location = new System.Drawing.Point(33, 249);
            this._pauseButton.Name = "_pauseButton";
            this._pauseButton.Size = new System.Drawing.Size(100, 25);
            this._pauseButton.TabIndex = 2;
            this._pauseButton.Text = "Pause";
            this._pauseButton.UseVisualStyleBackColor = true;
            this._pauseButton.Click += new System.EventHandler(this.OnPauseButtonClick);
            // 
            // _continueButton
            // 
            this._continueButton.Location = new System.Drawing.Point(164, 249);
            this._continueButton.Name = "_continueButton";
            this._continueButton.Size = new System.Drawing.Size(100, 25);
            this._continueButton.TabIndex = 3;
            this._continueButton.Text = "Continue";
            this._continueButton.UseVisualStyleBackColor = true;
            this._continueButton.Click += new System.EventHandler(this.OnContinueButtonClick);
            // 
            // _restartButton
            // 
            this._restartButton.Location = new System.Drawing.Point(293, 249);
            this._restartButton.Name = "_restartButton";
            this._restartButton.Size = new System.Drawing.Size(100, 25);
            this._restartButton.TabIndex = 4;
            this._restartButton.Text = "Restart";
            this._restartButton.UseVisualStyleBackColor = true;
            this._restartButton.Click += new System.EventHandler(this.OnRestartButtonClick);
            // 
            // BallColorDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 292);
            this.Controls.Add(this._restartButton);
            this.Controls.Add(this._continueButton);
            this.Controls.Add(this._pauseButton);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this.label1);
            this.Name = "BallColorDetectionForm";
            this.Text = "BallColorDetectionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Button _pauseButton;
        private System.Windows.Forms.Button _continueButton;
        private System.Windows.Forms.Button _restartButton;
    }
}