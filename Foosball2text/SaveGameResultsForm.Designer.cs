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
            this.label_goalsB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_goalsA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_maxSpeedA = new System.Windows.Forms.Label();
            this.label_maxSpeedB = new System.Windows.Forms.Label();
            this.button_saveData = new System.Windows.Forms.Button();
            this.label_gameTimeValue = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Controls.Add(this.label_goalsB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_goalsA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_maxSpeedA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_maxSpeedB, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 99);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label_goalsB
            // 
            this.label_goalsB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_goalsB.AutoSize = true;
            this.label_goalsB.Location = new System.Drawing.Point(249, 18);
            this.label_goalsB.Name = "label_goalsB";
            this.label_goalsB.Size = new System.Drawing.Size(23, 13);
            this.label_goalsB.TabIndex = 6;
            this.label_goalsB.Text = "null";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Goals";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_goalsA
            // 
            this.label_goalsA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_goalsA.AutoSize = true;
            this.label_goalsA.Location = new System.Drawing.Point(140, 18);
            this.label_goalsA.Name = "label_goalsA";
            this.label_goalsA.Size = new System.Drawing.Size(23, 13);
            this.label_goalsA.TabIndex = 5;
            this.label_goalsA.Text = "null";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max speed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_maxSpeedA
            // 
            this.label_maxSpeedA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_maxSpeedA.AutoSize = true;
            this.label_maxSpeedA.Location = new System.Drawing.Point(140, 67);
            this.label_maxSpeedA.Name = "label_maxSpeedA";
            this.label_maxSpeedA.Size = new System.Drawing.Size(23, 13);
            this.label_maxSpeedA.TabIndex = 13;
            this.label_maxSpeedA.Text = "null";
            // 
            // label_maxSpeedB
            // 
            this.label_maxSpeedB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_maxSpeedB.AutoSize = true;
            this.label_maxSpeedB.Location = new System.Drawing.Point(249, 67);
            this.label_maxSpeedB.Name = "label_maxSpeedB";
            this.label_maxSpeedB.Size = new System.Drawing.Size(23, 13);
            this.label_maxSpeedB.TabIndex = 14;
            this.label_maxSpeedB.Text = "null";
            // 
            // button_saveData
            // 
            this.button_saveData.Location = new System.Drawing.Point(12, 187);
            this.button_saveData.Name = "button_saveData";
            this.button_saveData.Size = new System.Drawing.Size(314, 48);
            this.button_saveData.TabIndex = 7;
            this.button_saveData.Text = "Confirm and Save game data";
            this.button_saveData.UseVisualStyleBackColor = true;
            this.button_saveData.Click += new System.EventHandler(this.button_saveData_Click);
            // 
            // label_gameTimeValue
            // 
            this.label_gameTimeValue.AutoSize = true;
            this.label_gameTimeValue.Location = new System.Drawing.Point(12, 163);
            this.label_gameTimeValue.Name = "label_gameTimeValue";
            this.label_gameTimeValue.Size = new System.Drawing.Size(97, 13);
            this.label_gameTimeValue.TabIndex = 8;
            this.label_gameTimeValue.Text = "Game length 00:00";
            // 
            // SaveGameResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 247);
            this.Controls.Add(this.label_gameTimeValue);
            this.Controls.Add(this.button_saveData);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_goalsA;
        private System.Windows.Forms.Label label_maxSpeedB;
        private System.Windows.Forms.Label label_maxSpeedA;
        private System.Windows.Forms.Label label_goalsB;
        private System.Windows.Forms.Button button_saveData;
        private System.Windows.Forms.Label label_gameTimeValue;
    }
}