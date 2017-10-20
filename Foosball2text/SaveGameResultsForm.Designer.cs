namespace Foosball2text
{
    partial class SaveGameResultsForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label_leftTeamName = new System.Windows.Forms.Label();
            this.label_rightTeamName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_maxSpeedB = new System.Windows.Forms.Label();
            this.label_maxSpeedA = new System.Windows.Forms.Label();
            this.label_newRankB = new System.Windows.Forms.Label();
            this.label_newRankA = new System.Windows.Forms.Label();
            this.abel_rankChangeB = new System.Windows.Forms.Label();
            this.label_rankChangeA = new System.Windows.Forms.Label();
            this.label_oldRankingB = new System.Windows.Forms.Label();
            this.label_oldRankingA = new System.Windows.Forms.Label();
            this.label_goalsB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_goalsA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_gameTimeValue = new System.Windows.Forms.Label();
            this.button_saveData = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HeaderLabel.Location = new System.Drawing.Point(72, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(198, 16);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Game ended null team won!";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_leftTeamName
            // 
            this.label_leftTeamName.AutoSize = true;
            this.label_leftTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_leftTeamName.Location = new System.Drawing.Point(140, 39);
            this.label_leftTeamName.Name = "label_leftTeamName";
            this.label_leftTeamName.Size = new System.Drawing.Size(49, 15);
            this.label_leftTeamName.TabIndex = 1;
            this.label_leftTeamName.Text = "Team A";
            this.label_leftTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rightTeamName
            // 
            this.label_rightTeamName.AutoSize = true;
            this.label_rightTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_rightTeamName.Location = new System.Drawing.Point(248, 39);
            this.label_rightTeamName.Name = "label_rightTeamName";
            this.label_rightTeamName.Size = new System.Drawing.Size(50, 15);
            this.label_rightTeamName.TabIndex = 2;
            this.label_rightTeamName.Text = "Team B";
            this.label_rightTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.88995F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.11005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Controls.Add(this.label_maxSpeedB, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_maxSpeedA, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_newRankB, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_newRankA, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.abel_rankChangeB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_rankChangeA, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_oldRankingB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_oldRankingA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_goalsB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_goalsA, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 147);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label_maxSpeedB
            // 
            this.label_maxSpeedB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_maxSpeedB.AutoSize = true;
            this.label_maxSpeedB.Location = new System.Drawing.Point(250, 125);
            this.label_maxSpeedB.Name = "label_maxSpeedB";
            this.label_maxSpeedB.Size = new System.Drawing.Size(23, 13);
            this.label_maxSpeedB.TabIndex = 14;
            this.label_maxSpeedB.Text = "null";
            // 
            // label_maxSpeedA
            // 
            this.label_maxSpeedA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_maxSpeedA.AutoSize = true;
            this.label_maxSpeedA.Location = new System.Drawing.Point(142, 125);
            this.label_maxSpeedA.Name = "label_maxSpeedA";
            this.label_maxSpeedA.Size = new System.Drawing.Size(23, 13);
            this.label_maxSpeedA.TabIndex = 13;
            this.label_maxSpeedA.Text = "null";
            // 
            // label_newRankB
            // 
            this.label_newRankB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_newRankB.AutoSize = true;
            this.label_newRankB.Location = new System.Drawing.Point(250, 95);
            this.label_newRankB.Name = "label_newRankB";
            this.label_newRankB.Size = new System.Drawing.Size(23, 13);
            this.label_newRankB.TabIndex = 12;
            this.label_newRankB.Text = "null";
            // 
            // label_newRankA
            // 
            this.label_newRankA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_newRankA.AutoSize = true;
            this.label_newRankA.Location = new System.Drawing.Point(142, 95);
            this.label_newRankA.Name = "label_newRankA";
            this.label_newRankA.Size = new System.Drawing.Size(23, 13);
            this.label_newRankA.TabIndex = 11;
            this.label_newRankA.Text = "null";
            // 
            // abel_rankChangeB
            // 
            this.abel_rankChangeB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.abel_rankChangeB.AutoSize = true;
            this.abel_rankChangeB.Location = new System.Drawing.Point(250, 66);
            this.abel_rankChangeB.Name = "abel_rankChangeB";
            this.abel_rankChangeB.Size = new System.Drawing.Size(23, 13);
            this.abel_rankChangeB.TabIndex = 10;
            this.abel_rankChangeB.Text = "null";
            // 
            // label_rankChangeA
            // 
            this.label_rankChangeA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_rankChangeA.AutoSize = true;
            this.label_rankChangeA.Location = new System.Drawing.Point(142, 66);
            this.label_rankChangeA.Name = "label_rankChangeA";
            this.label_rankChangeA.Size = new System.Drawing.Size(23, 13);
            this.label_rankChangeA.TabIndex = 9;
            this.label_rankChangeA.Text = "null";
            // 
            // label_oldRankingB
            // 
            this.label_oldRankingB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_oldRankingB.AutoSize = true;
            this.label_oldRankingB.Location = new System.Drawing.Point(250, 37);
            this.label_oldRankingB.Name = "label_oldRankingB";
            this.label_oldRankingB.Size = new System.Drawing.Size(23, 13);
            this.label_oldRankingB.TabIndex = 8;
            this.label_oldRankingB.Text = "null";
            // 
            // label_oldRankingA
            // 
            this.label_oldRankingA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_oldRankingA.AutoSize = true;
            this.label_oldRankingA.Location = new System.Drawing.Point(142, 37);
            this.label_oldRankingA.Name = "label_oldRankingA";
            this.label_oldRankingA.Size = new System.Drawing.Size(23, 13);
            this.label_oldRankingA.TabIndex = 7;
            this.label_oldRankingA.Text = "null";
            // 
            // label_goalsB
            // 
            this.label_goalsB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_goalsB.AutoSize = true;
            this.label_goalsB.Location = new System.Drawing.Point(250, 8);
            this.label_goalsB.Name = "label_goalsB";
            this.label_goalsB.Size = new System.Drawing.Size(23, 13);
            this.label_goalsB.TabIndex = 6;
            this.label_goalsB.Text = "null";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goals";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old ranking";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ranking Score change";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New ranking";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_goalsA
            // 
            this.label_goalsA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_goalsA.AutoSize = true;
            this.label_goalsA.Location = new System.Drawing.Point(142, 8);
            this.label_goalsA.Name = "label_goalsA";
            this.label_goalsA.Size = new System.Drawing.Size(23, 13);
            this.label_goalsA.TabIndex = 5;
            this.label_goalsA.Text = "null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_gameTimeValue
            // 
            this.label_gameTimeValue.AutoSize = true;
            this.label_gameTimeValue.Location = new System.Drawing.Point(81, 207);
            this.label_gameTimeValue.Name = "label_gameTimeValue";
            this.label_gameTimeValue.Size = new System.Drawing.Size(34, 13);
            this.label_gameTimeValue.TabIndex = 6;
            this.label_gameTimeValue.Text = "00:00";
            this.label_gameTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_saveData
            // 
            this.button_saveData.Location = new System.Drawing.Point(123, 231);
            this.button_saveData.Name = "button_saveData";
            this.button_saveData.Size = new System.Drawing.Size(93, 48);
            this.button_saveData.TabIndex = 7;
            this.button_saveData.Text = "Confirm and Save game data";
            this.button_saveData.UseVisualStyleBackColor = true;
            this.button_saveData.Click += new System.EventHandler(this.button_saveData_Click);
            // 
            // SaveGameResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 291);
            this.Controls.Add(this.button_saveData);
            this.Controls.Add(this.label_gameTimeValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_rightTeamName);
            this.Controls.Add(this.label_leftTeamName);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "SaveGameResultsForm";
            this.Text = "SaveGameResultsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label_leftTeamName;
        private System.Windows.Forms.Label label_rightTeamName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_goalsA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_gameTimeValue;
        private System.Windows.Forms.Label label_maxSpeedB;
        private System.Windows.Forms.Label label_maxSpeedA;
        private System.Windows.Forms.Label label_newRankB;
        private System.Windows.Forms.Label label_newRankA;
        private System.Windows.Forms.Label abel_rankChangeB;
        private System.Windows.Forms.Label label_rankChangeA;
        private System.Windows.Forms.Label label_oldRankingB;
        private System.Windows.Forms.Label label_oldRankingA;
        private System.Windows.Forms.Label label_goalsB;
        private System.Windows.Forms.Button button_saveData;
    }
}