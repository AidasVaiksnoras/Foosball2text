namespace Foosball2text
{
    partial class VideoLoggerForm
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
            this.LeftGoalButton = new System.Windows.Forms.Button();
            this.RightGoalButton = new System.Windows.Forms.Button();
            this.BallDisappearedButton = new System.Windows.Forms.Button();
            this.BallPassedButton = new System.Windows.Forms.Button();
            this.HasDisappearedButton = new System.Windows.Forms.Button();
            this.PassedToText = new System.Windows.Forms.TextBox();
            this.DisappearedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LatestLog = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Coordinates = new System.Windows.Forms.Label();
            this.SpeedValue = new System.Windows.Forms.Label();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TeamA = new System.Windows.Forms.Label();
            this.TeamB = new System.Windows.Forms.Label();
            this.sideOfFieldLabel = new System.Windows.Forms.Label();
            this.ballOnSideOfFieldValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftGoalButton
            // 
            this.LeftGoalButton.Location = new System.Drawing.Point(315, 124);
            this.LeftGoalButton.Name = "LeftGoalButton";
            this.LeftGoalButton.Size = new System.Drawing.Size(150, 23);
            this.LeftGoalButton.TabIndex = 0;
            this.LeftGoalButton.Text = "Left Goal Test";
            this.LeftGoalButton.UseVisualStyleBackColor = true;
            this.LeftGoalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RightGoalButton
            // 
            this.RightGoalButton.Location = new System.Drawing.Point(471, 124);
            this.RightGoalButton.Name = "RightGoalButton";
            this.RightGoalButton.Size = new System.Drawing.Size(145, 23);
            this.RightGoalButton.TabIndex = 1;
            this.RightGoalButton.Text = "Right Goal Test";
            this.RightGoalButton.UseVisualStyleBackColor = true;
            this.RightGoalButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // BallDisappearedButton
            // 
            this.BallDisappearedButton.Location = new System.Drawing.Point(315, 153);
            this.BallDisappearedButton.Name = "BallDisappearedButton";
            this.BallDisappearedButton.Size = new System.Drawing.Size(150, 23);
            this.BallDisappearedButton.TabIndex = 2;
            this.BallDisappearedButton.Text = "Ball Disappeared Test";
            this.BallDisappearedButton.UseVisualStyleBackColor = true;
            this.BallDisappearedButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // BallPassedButton
            // 
            this.BallPassedButton.Location = new System.Drawing.Point(315, 182);
            this.BallPassedButton.Name = "BallPassedButton";
            this.BallPassedButton.Size = new System.Drawing.Size(150, 23);
            this.BallPassedButton.TabIndex = 3;
            this.BallPassedButton.Text = "Ball Passed to";
            this.BallPassedButton.UseVisualStyleBackColor = true;
            this.BallPassedButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // HasDisappearedButton
            // 
            this.HasDisappearedButton.Location = new System.Drawing.Point(471, 211);
            this.HasDisappearedButton.Name = "HasDisappearedButton";
            this.HasDisappearedButton.Size = new System.Drawing.Size(145, 23);
            this.HasDisappearedButton.TabIndex = 6;
            this.HasDisappearedButton.Text = "has Disappeared";
            this.HasDisappearedButton.UseVisualStyleBackColor = true;
            this.HasDisappearedButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // PassedToText
            // 
            this.PassedToText.Location = new System.Drawing.Point(471, 184);
            this.PassedToText.Name = "PassedToText";
            this.PassedToText.Size = new System.Drawing.Size(145, 20);
            this.PassedToText.TabIndex = 7;
            // 
            // DisappearedText
            // 
            this.DisappearedText.Location = new System.Drawing.Point(315, 213);
            this.DisappearedText.Name = "DisappearedText";
            this.DisappearedText.Size = new System.Drawing.Size(150, 20);
            this.DisappearedText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Latest Log: ";
            // 
            // LatestLog
            // 
            this.LatestLog.AutoSize = true;
            this.LatestLog.Location = new System.Drawing.Point(82, 102);
            this.LatestLog.Name = "LatestLog";
            this.LatestLog.Size = new System.Drawing.Size(33, 13);
            this.LatestLog.TabIndex = 11;
            this.LatestLog.Text = "None";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 186);
            this.listBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ball coordinates:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ball speed:";
            // 
            // Coordinates
            // 
            this.Coordinates.AutoSize = true;
            this.Coordinates.Location = new System.Drawing.Point(100, 9);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(25, 13);
            this.Coordinates.TabIndex = 15;
            this.Coordinates.Text = "Null";
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Location = new System.Drawing.Point(100, 22);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(25, 13);
            this.SpeedValue.TabIndex = 16;
            this.SpeedValue.Text = "Null";
            // 
            // EndGameButton
            // 
            this.EndGameButton.Location = new System.Drawing.Point(471, 153);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(145, 23);
            this.EndGameButton.TabIndex = 17;
            this.EndGameButton.Text = "End of Game\r\n";
            this.EndGameButton.UseVisualStyleBackColor = true;
            this.EndGameButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Team A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Team B";
            // 
            // TeamA
            // 
            this.TeamA.AutoSize = true;
            this.TeamA.Location = new System.Drawing.Point(62, 72);
            this.TeamA.Name = "TeamA";
            this.TeamA.Size = new System.Drawing.Size(13, 13);
            this.TeamA.TabIndex = 21;
            this.TeamA.Tag = "score";
            this.TeamA.Text = "0";
            // 
            // TeamB
            // 
            this.TeamB.AutoSize = true;
            this.TeamB.Location = new System.Drawing.Point(176, 72);
            this.TeamB.Name = "TeamB";
            this.TeamB.Size = new System.Drawing.Size(13, 13);
            this.TeamB.TabIndex = 22;
            this.TeamB.Tag = "score";
            this.TeamB.Text = "0";
            // 
            // sideOfFieldLabel
            // 
            this.sideOfFieldLabel.AutoSize = true;
            this.sideOfFieldLabel.Location = new System.Drawing.Point(12, 35);
            this.sideOfFieldLabel.Name = "sideOfFieldLabel";
            this.sideOfFieldLabel.Size = new System.Drawing.Size(98, 13);
            this.sideOfFieldLabel.TabIndex = 23;
            this.sideOfFieldLabel.Text = "Ball on side of field:";
            // 
            // ballOnSideOfFieldValue
            // 
            this.ballOnSideOfFieldValue.AutoSize = true;
            this.ballOnSideOfFieldValue.Location = new System.Drawing.Point(116, 35);
            this.ballOnSideOfFieldValue.Name = "ballOnSideOfFieldValue";
            this.ballOnSideOfFieldValue.Size = new System.Drawing.Size(25, 13);
            this.ballOnSideOfFieldValue.TabIndex = 24;
            this.ballOnSideOfFieldValue.Text = "Null";
            // 
            // VideoLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 324);
            this.Controls.Add(this.ballOnSideOfFieldValue);
            this.Controls.Add(this.sideOfFieldLabel);
            this.Controls.Add(this.TeamB);
            this.Controls.Add(this.TeamA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndGameButton);
            this.Controls.Add(this.SpeedValue);
            this.Controls.Add(this.Coordinates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LatestLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisappearedText);
            this.Controls.Add(this.PassedToText);
            this.Controls.Add(this.HasDisappearedButton);
            this.Controls.Add(this.BallPassedButton);
            this.Controls.Add(this.BallDisappearedButton);
            this.Controls.Add(this.RightGoalButton);
            this.Controls.Add(this.LeftGoalButton);
            this.Name = "VideoLoggerForm";
            this.Text = "VideoLogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeftGoalButton;
        private System.Windows.Forms.Button RightGoalButton;
        private System.Windows.Forms.Button BallDisappearedButton;
        private System.Windows.Forms.Button BallPassedButton;
        private System.Windows.Forms.Button HasDisappearedButton;
        private System.Windows.Forms.TextBox PassedToText;
        private System.Windows.Forms.TextBox DisappearedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LatestLog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Coordinates;
        private System.Windows.Forms.Label SpeedValue;
        private System.Windows.Forms.Button EndGameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TeamA;
        private System.Windows.Forms.Label TeamB;
        private System.Windows.Forms.Label sideOfFieldLabel;
        private System.Windows.Forms.Label ballOnSideOfFieldValue;
    }
}