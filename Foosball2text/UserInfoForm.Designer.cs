﻿namespace Foosball2text
{
    partial class UserInfoForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.gamesPlayedLabel = new System.Windows.Forms.Label();
            this.gamesWonLabel = new System.Windows.Forms.Label();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.nameResultLabel = new System.Windows.Forms.Label();
            this.gamesPlayedResultLabel = new System.Windows.Forms.Label();
            this.gamesWonResultLabel = new System.Windows.Forms.Label();
            this.maxSpeedResultLabel = new System.Windows.Forms.Label();
            this.totalScoreResultLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(70, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // gamesPlayedLabel
            // 
            this.gamesPlayedLabel.AutoSize = true;
            this.gamesPlayedLabel.Location = new System.Drawing.Point(31, 71);
            this.gamesPlayedLabel.Name = "gamesPlayedLabel";
            this.gamesPlayedLabel.Size = new System.Drawing.Size(77, 13);
            this.gamesPlayedLabel.TabIndex = 1;
            this.gamesPlayedLabel.Text = "Games played:";
            // 
            // gamesWonLabel
            // 
            this.gamesWonLabel.AutoSize = true;
            this.gamesWonLabel.Location = new System.Drawing.Point(42, 94);
            this.gamesWonLabel.Name = "gamesWonLabel";
            this.gamesWonLabel.Size = new System.Drawing.Size(66, 13);
            this.gamesWonLabel.TabIndex = 2;
            this.gamesWonLabel.Text = "Games won:";
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.Location = new System.Drawing.Point(46, 118);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(62, 13);
            this.maxSpeedLabel.TabIndex = 3;
            this.maxSpeedLabel.Text = "Max speed:";
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.AutoSize = true;
            this.totalScoreLabel.Location = new System.Drawing.Point(45, 141);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(63, 13);
            this.totalScoreLabel.TabIndex = 4;
            this.totalScoreLabel.Text = "Total score:";
            // 
            // nameResultLabel
            // 
            this.nameResultLabel.AutoSize = true;
            this.nameResultLabel.Location = new System.Drawing.Point(114, 46);
            this.nameResultLabel.Name = "nameResultLabel";
            this.nameResultLabel.Size = new System.Drawing.Size(38, 13);
            this.nameResultLabel.TabIndex = 5;
            this.nameResultLabel.Text = "Name:";
            // 
            // gamesPlayedResultLabel
            // 
            this.gamesPlayedResultLabel.AutoSize = true;
            this.gamesPlayedResultLabel.Location = new System.Drawing.Point(114, 71);
            this.gamesPlayedResultLabel.Name = "gamesPlayedResultLabel";
            this.gamesPlayedResultLabel.Size = new System.Drawing.Size(77, 13);
            this.gamesPlayedResultLabel.TabIndex = 6;
            this.gamesPlayedResultLabel.Text = "Games played:";
            // 
            // gamesWonResultLabel
            // 
            this.gamesWonResultLabel.AutoSize = true;
            this.gamesWonResultLabel.Location = new System.Drawing.Point(114, 94);
            this.gamesWonResultLabel.Name = "gamesWonResultLabel";
            this.gamesWonResultLabel.Size = new System.Drawing.Size(66, 13);
            this.gamesWonResultLabel.TabIndex = 7;
            this.gamesWonResultLabel.Text = "Games won:";
            // 
            // maxSpeedResultLabel
            // 
            this.maxSpeedResultLabel.AutoSize = true;
            this.maxSpeedResultLabel.Location = new System.Drawing.Point(114, 118);
            this.maxSpeedResultLabel.Name = "maxSpeedResultLabel";
            this.maxSpeedResultLabel.Size = new System.Drawing.Size(62, 13);
            this.maxSpeedResultLabel.TabIndex = 8;
            this.maxSpeedResultLabel.Text = "Max speed:";
            // 
            // totalScoreResultLabel
            // 
            this.totalScoreResultLabel.AutoSize = true;
            this.totalScoreResultLabel.Location = new System.Drawing.Point(114, 141);
            this.totalScoreResultLabel.Name = "totalScoreResultLabel";
            this.totalScoreResultLabel.Size = new System.Drawing.Size(63, 13);
            this.totalScoreResultLabel.TabIndex = 9;
            this.totalScoreResultLabel.Text = "Total score:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.AcceptButton = this.button1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 11;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 179);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.maxSpeedLabel);
            this.Controls.Add(this.gamesWonLabel);
            this.Controls.Add(this.gamesPlayedLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.totalScoreResultLabel);
            this.Controls.Add(this.maxSpeedResultLabel);
            this.Controls.Add(this.gamesWonResultLabel);
            this.Controls.Add(this.gamesPlayedResultLabel);
            this.Controls.Add(this.nameResultLabel);
            this.Name = "UserInfoForm";
            this.Text = "User Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gamesPlayedLabel;
        private System.Windows.Forms.Label gamesWonLabel;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Label nameResultLabel;
        private System.Windows.Forms.Label gamesPlayedResultLabel;
        private System.Windows.Forms.Label gamesWonResultLabel;
        private System.Windows.Forms.Label maxSpeedResultLabel;
        private System.Windows.Forms.Label totalScoreResultLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}