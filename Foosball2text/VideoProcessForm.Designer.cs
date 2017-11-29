namespace Foosball2text
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.TeamB_score = new System.Windows.Forms.Label();
            this.TeamA_score = new System.Windows.Forms.Label();
            this.TeamB_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TeamA_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.OmniSpeedPerMs_label = new System.Windows.Forms.Label();
            this.OmniSpeedPerMs_value = new System.Windows.Forms.Label();
            this.LabelUpdates = new System.Windows.Forms.Label();
            this.ValueUpdates = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_TeamOnLeftMaxValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_TeamOnRightMaxValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.Expand_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // _ylabel
            // 
            this._ylabel.AutoSize = true;
            this._ylabel.Location = new System.Drawing.Point(172, 9);
            this._ylabel.Name = "_ylabel";
            this._ylabel.Size = new System.Drawing.Size(46, 13);
            this._ylabel.TabIndex = 5;
            this._ylabel.Text = "000.000";
            // 
            // _xlabel
            // 
            this._xlabel.AutoSize = true;
            this._xlabel.Location = new System.Drawing.Point(104, 9);
            this._xlabel.Name = "_xlabel";
            this._xlabel.Size = new System.Drawing.Size(46, 13);
            this._xlabel.TabIndex = 6;
            this._xlabel.Text = "000.000";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ballOnSideOfFieldValue
            // 
            this.ballOnSideOfFieldValue.AutoSize = true;
            this.ballOnSideOfFieldValue.Location = new System.Drawing.Point(107, 22);
            this.ballOnSideOfFieldValue.Name = "ballOnSideOfFieldValue";
            this.ballOnSideOfFieldValue.Size = new System.Drawing.Size(25, 13);
            this.ballOnSideOfFieldValue.TabIndex = 30;
            this.ballOnSideOfFieldValue.Text = "Null";
            // 
            // sideOfFieldLabel
            // 
            this.sideOfFieldLabel.AutoSize = true;
            this.sideOfFieldLabel.Location = new System.Drawing.Point(3, 22);
            this.sideOfFieldLabel.Name = "sideOfFieldLabel";
            this.sideOfFieldLabel.Size = new System.Drawing.Size(98, 13);
            this.sideOfFieldLabel.TabIndex = 29;
            this.sideOfFieldLabel.Text = "Ball on side of field:";
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Location = new System.Drawing.Point(86, 35);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(25, 13);
            this.SpeedValue.TabIndex = 28;
            this.SpeedValue.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ball speed/ms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ball coordinates:";
            // 
            // TeamB_score
            // 
            this.TeamB_score.AutoSize = true;
            this.TeamB_score.Location = new System.Drawing.Point(553, 27);
            this.TeamB_score.Name = "TeamB_score";
            this.TeamB_score.Size = new System.Drawing.Size(13, 13);
            this.TeamB_score.TabIndex = 35;
            this.TeamB_score.Tag = "score";
            this.TeamB_score.Text = "0";
            // 
            // TeamA_score
            // 
            this.TeamA_score.AutoSize = true;
            this.TeamA_score.Location = new System.Drawing.Point(435, 27);
            this.TeamA_score.Name = "TeamA_score";
            this.TeamA_score.Size = new System.Drawing.Size(13, 13);
            this.TeamA_score.TabIndex = 34;
            this.TeamA_score.Tag = "score";
            this.TeamA_score.Text = "0";
            // 
            // TeamB_label
            // 
            this.TeamB_label.AutoSize = true;
            this.TeamB_label.Location = new System.Drawing.Point(553, 14);
            this.TeamB_label.Name = "TeamB_label";
            this.TeamB_label.Size = new System.Drawing.Size(44, 13);
            this.TeamB_label.TabIndex = 33;
            this.TeamB_label.Text = "Team B";
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
            // TeamA_label
            // 
            this.TeamA_label.AutoSize = true;
            this.TeamA_label.Location = new System.Drawing.Point(435, 14);
            this.TeamA_label.Name = "TeamA_label";
            this.TeamA_label.Size = new System.Drawing.Size(44, 13);
            this.TeamA_label.TabIndex = 31;
            this.TeamA_label.Text = "Team A";
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
            this.restartButton.Location = new System.Drawing.Point(12, 240);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(363, 27);
            this.restartButton.TabIndex = 40;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // OmniSpeedPerMs_label
            // 
            this.OmniSpeedPerMs_label.AutoSize = true;
            this.OmniSpeedPerMs_label.Location = new System.Drawing.Point(3, 48);
            this.OmniSpeedPerMs_label.Name = "OmniSpeedPerMs_label";
            this.OmniSpeedPerMs_label.Size = new System.Drawing.Size(83, 13);
            this.OmniSpeedPerMs_label.TabIndex = 41;
            this.OmniSpeedPerMs_label.Text = "OmniSpeed/ms:";
            // 
            // OmniSpeedPerMs_value
            // 
            this.OmniSpeedPerMs_value.AutoSize = true;
            this.OmniSpeedPerMs_value.Location = new System.Drawing.Point(92, 48);
            this.OmniSpeedPerMs_value.Name = "OmniSpeedPerMs_value";
            this.OmniSpeedPerMs_value.Size = new System.Drawing.Size(25, 13);
            this.OmniSpeedPerMs_value.TabIndex = 42;
            this.OmniSpeedPerMs_value.Text = "Null";
            // 
            // LabelUpdates
            // 
            this.LabelUpdates.AutoSize = true;
            this.LabelUpdates.Location = new System.Drawing.Point(3, 61);
            this.LabelUpdates.Name = "LabelUpdates";
            this.LabelUpdates.Size = new System.Drawing.Size(134, 13);
            this.LabelUpdates.TabIndex = 43;
            this.LabelUpdates.Text = "SecondsBetweenUpdates:";
            // 
            // ValueUpdates
            // 
            this.ValueUpdates.AutoSize = true;
            this.ValueUpdates.Location = new System.Drawing.Point(140, 61);
            this.ValueUpdates.Name = "ValueUpdates";
            this.ValueUpdates.Size = new System.Drawing.Size(25, 13);
            this.ValueUpdates.TabIndex = 44;
            this.ValueUpdates.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "TeamOnLeft:";
            // 
            // label_TeamOnLeftMaxValue
            // 
            this.label_TeamOnLeftMaxValue.AutoSize = true;
            this.label_TeamOnLeftMaxValue.Location = new System.Drawing.Point(78, 87);
            this.label_TeamOnLeftMaxValue.Name = "label_TeamOnLeftMaxValue";
            this.label_TeamOnLeftMaxValue.Size = new System.Drawing.Size(46, 13);
            this.label_TeamOnLeftMaxValue.TabIndex = 48;
            this.label_TeamOnLeftMaxValue.Text = "0.00000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "TeamOnRight:";
            // 
            // label_TeamOnRightMaxValue
            // 
            this.label_TeamOnRightMaxValue.AutoSize = true;
            this.label_TeamOnRightMaxValue.Location = new System.Drawing.Point(212, 87);
            this.label_TeamOnRightMaxValue.Name = "label_TeamOnRightMaxValue";
            this.label_TeamOnRightMaxValue.Size = new System.Drawing.Size(46, 13);
            this.label_TeamOnRightMaxValue.TabIndex = 50;
            this.label_TeamOnRightMaxValue.Text = "0.00000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(3, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Max Ball Speeds:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(687, 205);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 52;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Expand_button
            // 
            this.Expand_button.Location = new System.Drawing.Point(4, 6);
            this.Expand_button.Name = "Expand_button";
            this.Expand_button.Size = new System.Drawing.Size(146, 27);
            this.Expand_button.TabIndex = 0;
            this.Expand_button.Text = "Show additional data\r\n";
            this.Expand_button.UseVisualStyleBackColor = true;
            this.Expand_button.Click += new System.EventHandler(this.Expand_button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(381, 234);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Expand_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label_TeamOnRightMaxValue);
            this.splitContainer1.Panel2.Controls.Add(this._ylabel);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this._xlabel);
            this.splitContainer1.Panel2.Controls.Add(this.label_TeamOnLeftMaxValue);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.SpeedValue);
            this.splitContainer1.Panel2.Controls.Add(this.ValueUpdates);
            this.splitContainer1.Panel2.Controls.Add(this.sideOfFieldLabel);
            this.splitContainer1.Panel2.Controls.Add(this.LabelUpdates);
            this.splitContainer1.Panel2.Controls.Add(this.ballOnSideOfFieldValue);
            this.splitContainer1.Panel2.Controls.Add(this.OmniSpeedPerMs_value);
            this.splitContainer1.Panel2.Controls.Add(this.OmniSpeedPerMs_label);
            this.splitContainer1.Size = new System.Drawing.Size(300, 150);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 53;
            // 
            // VideoProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 274);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.EndGameButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TeamB_score);
            this.Controls.Add(this.TeamA_score);
            this.Controls.Add(this.TeamB_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeamA_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VideoProcessForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoProcessForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Label TeamB_score;
        private System.Windows.Forms.Label TeamA_score;
        private System.Windows.Forms.Label TeamB_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TeamA_label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button EndGameButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label OmniSpeedPerMs_label;
        private System.Windows.Forms.Label OmniSpeedPerMs_value;
        private System.Windows.Forms.Label LabelUpdates;
        private System.Windows.Forms.Label ValueUpdates;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_TeamOnLeftMaxValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_TeamOnRightMaxValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button Expand_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

