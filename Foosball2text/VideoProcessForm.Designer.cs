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
            this.TeamB = new System.Windows.Forms.Label();
            this.TeamA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(468, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // _ylabel
            // 
            this._ylabel.AutoSize = true;
            this._ylabel.Location = new System.Drawing.Point(550, 234);
            this._ylabel.Name = "_ylabel";
            this._ylabel.Size = new System.Drawing.Size(46, 13);
            this._ylabel.TabIndex = 5;
            this._ylabel.Text = "000.000";
            // 
            // _xlabel
            // 
            this._xlabel.AutoSize = true;
            this._xlabel.Location = new System.Drawing.Point(482, 234);
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
            this.ballOnSideOfFieldValue.Location = new System.Drawing.Point(485, 247);
            this.ballOnSideOfFieldValue.Name = "ballOnSideOfFieldValue";
            this.ballOnSideOfFieldValue.Size = new System.Drawing.Size(25, 13);
            this.ballOnSideOfFieldValue.TabIndex = 30;
            this.ballOnSideOfFieldValue.Text = "Null";
            // 
            // sideOfFieldLabel
            // 
            this.sideOfFieldLabel.AutoSize = true;
            this.sideOfFieldLabel.Location = new System.Drawing.Point(381, 247);
            this.sideOfFieldLabel.Name = "sideOfFieldLabel";
            this.sideOfFieldLabel.Size = new System.Drawing.Size(98, 13);
            this.sideOfFieldLabel.TabIndex = 29;
            this.sideOfFieldLabel.Text = "Ball on side of field:";
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Location = new System.Drawing.Point(464, 260);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(25, 13);
            this.SpeedValue.TabIndex = 28;
            this.SpeedValue.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ball speed/ms:";
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
            this.OmniSpeedPerMs_label.Location = new System.Drawing.Point(381, 273);
            this.OmniSpeedPerMs_label.Name = "OmniSpeedPerMs_label";
            this.OmniSpeedPerMs_label.Size = new System.Drawing.Size(83, 13);
            this.OmniSpeedPerMs_label.TabIndex = 41;
            this.OmniSpeedPerMs_label.Text = "OmniSpeed/ms:";
            // 
            // OmniSpeedPerMs_value
            // 
            this.OmniSpeedPerMs_value.AutoSize = true;
            this.OmniSpeedPerMs_value.Location = new System.Drawing.Point(470, 273);
            this.OmniSpeedPerMs_value.Name = "OmniSpeedPerMs_value";
            this.OmniSpeedPerMs_value.Size = new System.Drawing.Size(25, 13);
            this.OmniSpeedPerMs_value.TabIndex = 42;
            this.OmniSpeedPerMs_value.Text = "Null";
            // 
            // LabelUpdates
            // 
            this.LabelUpdates.AutoSize = true;
            this.LabelUpdates.Location = new System.Drawing.Point(381, 286);
            this.LabelUpdates.Name = "LabelUpdates";
            this.LabelUpdates.Size = new System.Drawing.Size(134, 13);
            this.LabelUpdates.TabIndex = 43;
            this.LabelUpdates.Text = "SecondsBetweenUpdates:";
            // 
            // ValueUpdates
            // 
            this.ValueUpdates.AutoSize = true;
            this.ValueUpdates.Location = new System.Drawing.Point(518, 286);
            this.ValueUpdates.Name = "ValueUpdates";
            this.ValueUpdates.Size = new System.Drawing.Size(25, 13);
            this.ValueUpdates.TabIndex = 44;
            this.ValueUpdates.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "TeamOnLeft:";
            // 
            // label_TeamOnLeftMaxValue
            // 
            this.label_TeamOnLeftMaxValue.AutoSize = true;
            this.label_TeamOnLeftMaxValue.Location = new System.Drawing.Point(456, 312);
            this.label_TeamOnLeftMaxValue.Name = "label_TeamOnLeftMaxValue";
            this.label_TeamOnLeftMaxValue.Size = new System.Drawing.Size(46, 13);
            this.label_TeamOnLeftMaxValue.TabIndex = 48;
            this.label_TeamOnLeftMaxValue.Text = "0.00000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "TeamOnRight:";
            // 
            // label_TeamOnRightMaxValue
            // 
            this.label_TeamOnRightMaxValue.AutoSize = true;
            this.label_TeamOnRightMaxValue.Location = new System.Drawing.Point(590, 312);
            this.label_TeamOnRightMaxValue.Name = "label_TeamOnRightMaxValue";
            this.label_TeamOnRightMaxValue.Size = new System.Drawing.Size(46, 13);
            this.label_TeamOnRightMaxValue.TabIndex = 50;
            this.label_TeamOnRightMaxValue.Text = "0.00000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(381, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Max Ball Speeds:";
            // 
            // VideoProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 350);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_TeamOnRightMaxValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_TeamOnLeftMaxValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValueUpdates);
            this.Controls.Add(this.LabelUpdates);
            this.Controls.Add(this.OmniSpeedPerMs_value);
            this.Controls.Add(this.OmniSpeedPerMs_label);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.EndGameButton);
            this.Controls.Add(this.listBox1);
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "VideoProcessForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label TeamB;
        private System.Windows.Forms.Label TeamA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
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
    }
}

