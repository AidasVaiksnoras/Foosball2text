﻿namespace Foosball2text
{
    partial class VideoProcessForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._ylabel = new System.Windows.Forms.Label();
            this._xlabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ballOnSideOfFieldValue = new System.Windows.Forms.Label();
            this.sideOfFieldLabel = new System.Windows.Forms.Label();
            this.SpeedValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TeamB = new System.Windows.Forms.Label();
            this.TeamA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LatestLog = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 234);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(363, 228);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // _ylabel
            // 
            this._ylabel.AutoSize = true;
            this._ylabel.Location = new System.Drawing.Point(527, 234);
            this._ylabel.Name = "_ylabel";
            this._ylabel.Size = new System.Drawing.Size(13, 13);
            this._ylabel.TabIndex = 5;
            this._ylabel.Text = "0";
            // 
            // _xlabel
            // 
            this._xlabel.AutoSize = true;
            this._xlabel.Location = new System.Drawing.Point(482, 234);
            this._xlabel.Name = "_xlabel";
            this._xlabel.Size = new System.Drawing.Size(13, 13);
            this._xlabel.TabIndex = 6;
            this._xlabel.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ballOnSideOfFieldValue
            // 
            this.ballOnSideOfFieldValue.AutoSize = true;
            this.ballOnSideOfFieldValue.Location = new System.Drawing.Point(485, 260);
            this.ballOnSideOfFieldValue.Name = "ballOnSideOfFieldValue";
            this.ballOnSideOfFieldValue.Size = new System.Drawing.Size(25, 13);
            this.ballOnSideOfFieldValue.TabIndex = 30;
            this.ballOnSideOfFieldValue.Text = "Null";
            // 
            // sideOfFieldLabel
            // 
            this.sideOfFieldLabel.AutoSize = true;
            this.sideOfFieldLabel.Location = new System.Drawing.Point(381, 260);
            this.sideOfFieldLabel.Name = "sideOfFieldLabel";
            this.sideOfFieldLabel.Size = new System.Drawing.Size(98, 13);
            this.sideOfFieldLabel.TabIndex = 29;
            this.sideOfFieldLabel.Text = "Ball on side of field:";
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Location = new System.Drawing.Point(469, 247);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(25, 13);
            this.SpeedValue.TabIndex = 28;
            this.SpeedValue.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ball speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ball coordinates:";
            // 
            // TeamB
            // 
            this.TeamB.AutoSize = true;
            this.TeamB.Location = new System.Drawing.Point(545, 27);
            this.TeamB.Name = "TeamB";
            this.TeamB.Size = new System.Drawing.Size(13, 13);
            this.TeamB.TabIndex = 35;
            this.TeamB.Tag = "score";
            this.TeamB.Text = "0";
            // 
            // TeamA
            // 
            this.TeamA.AutoSize = true;
            this.TeamA.Location = new System.Drawing.Point(431, 27);
            this.TeamA.Name = "TeamA";
            this.TeamA.Size = new System.Drawing.Size(13, 13);
            this.TeamA.TabIndex = 34;
            this.TeamA.Tag = "score";
            this.TeamA.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Team B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(381, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Team A";
            // 
            // LatestLog
            // 
            this.LatestLog.AutoSize = true;
            this.LatestLog.Location = new System.Drawing.Point(450, 284);
            this.LatestLog.Name = "LatestLog";
            this.LatestLog.Size = new System.Drawing.Size(33, 13);
            this.LatestLog.TabIndex = 37;
            this.LatestLog.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Latest Log: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(384, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 186);
            this.listBox1.TabIndex = 38;
            // 
            // EndGameButton
            // 
            this.EndGameButton.AutoSize = true;
            this.EndGameButton.Location = new System.Drawing.Point(687, 42);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(67, 23);
            this.EndGameButton.TabIndex = 39;
            this.EndGameButton.TabStop = false;
            this.EndGameButton.Text = "End Game\r\n";
            this.EndGameButton.UseVisualStyleBackColor = true;
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(386, 310);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(130, 27);
            this.restartButton.TabIndex = 40;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // VideoProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.EndGameButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LatestLog);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TeamB);
            this.Controls.Add(this.TeamA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ballOnSideOfFieldValue);
            this.Controls.Add(this.sideOfFieldLabel);
            this.Controls.Add(this.SpeedValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._xlabel);
            this.Controls.Add(this._ylabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VideoProcessForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _ylabel;
        private System.Windows.Forms.Label _xlabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ballOnSideOfFieldValue;
        private System.Windows.Forms.Label sideOfFieldLabel;
        private System.Windows.Forms.Label SpeedValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TeamB;
        private System.Windows.Forms.Label TeamA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LatestLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button EndGameButton;
        private System.Windows.Forms.Button restartButton;
    }
}
