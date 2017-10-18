namespace Foosball2text
{
    partial class LeaderboardForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gamesWonTab = new System.Windows.Forms.TabPage();
            this.gamesWonList = new System.Windows.Forms.ListBox();
            this.totalScoreTab = new System.Windows.Forms.TabPage();
            this.totalScoreList = new System.Windows.Forms.ListBox();
            this.maxSpeedTab = new System.Windows.Forms.TabPage();
            this.maxSpeedList = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gamesPlayedList = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.gamesWonTab.SuspendLayout();
            this.totalScoreTab.SuspendLayout();
            this.maxSpeedTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gamesWonTab);
            this.tabControl1.Controls.Add(this.totalScoreTab);
            this.tabControl1.Controls.Add(this.maxSpeedTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(290, 273);
            this.tabControl1.TabIndex = 0;
            // 
            // gamesWonTab
            // 
            this.gamesWonTab.Controls.Add(this.gamesWonList);
            this.gamesWonTab.Location = new System.Drawing.Point(4, 22);
            this.gamesWonTab.Name = "gamesWonTab";
            this.gamesWonTab.Padding = new System.Windows.Forms.Padding(3);
            this.gamesWonTab.Size = new System.Drawing.Size(282, 247);
            this.gamesWonTab.TabIndex = 0;
            this.gamesWonTab.Text = "Laimėti žaidimai";
            this.gamesWonTab.UseVisualStyleBackColor = true;
            // 
            // gamesWonList
            // 
            this.gamesWonList.FormattingEnabled = true;
            this.gamesWonList.Location = new System.Drawing.Point(6, 16);
            this.gamesWonList.Name = "gamesWonList";
            this.gamesWonList.Size = new System.Drawing.Size(270, 225);
            this.gamesWonList.TabIndex = 0;
            this.gamesWonList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.GamesWonList_Format);
            // 
            // totalScoreTab
            // 
            this.totalScoreTab.Controls.Add(this.totalScoreList);
            this.totalScoreTab.Location = new System.Drawing.Point(4, 22);
            this.totalScoreTab.Name = "totalScoreTab";
            this.totalScoreTab.Padding = new System.Windows.Forms.Padding(3);
            this.totalScoreTab.Size = new System.Drawing.Size(282, 247);
            this.totalScoreTab.TabIndex = 1;
            this.totalScoreTab.Text = "Taškai";
            this.totalScoreTab.UseVisualStyleBackColor = true;
            // 
            // totalScoreList
            // 
            this.totalScoreList.FormattingEnabled = true;
            this.totalScoreList.Location = new System.Drawing.Point(2, 0);
            this.totalScoreList.Name = "totalScoreList";
            this.totalScoreList.Size = new System.Drawing.Size(279, 238);
            this.totalScoreList.TabIndex = 0;
            this.totalScoreList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.TotalScoreList_Format);
            // 
            // maxSpeedTab
            // 
            this.maxSpeedTab.Controls.Add(this.maxSpeedList);
            this.maxSpeedTab.Location = new System.Drawing.Point(4, 22);
            this.maxSpeedTab.Name = "maxSpeedTab";
            this.maxSpeedTab.Size = new System.Drawing.Size(282, 247);
            this.maxSpeedTab.TabIndex = 2;
            this.maxSpeedTab.Text = "Greitis";
            this.maxSpeedTab.UseVisualStyleBackColor = true;
            // 
            // maxSpeedList
            // 
            this.maxSpeedList.FormattingEnabled = true;
            this.maxSpeedList.Location = new System.Drawing.Point(2, 1);
            this.maxSpeedList.Name = "maxSpeedList";
            this.maxSpeedList.Size = new System.Drawing.Size(279, 238);
            this.maxSpeedList.TabIndex = 0;
            this.maxSpeedList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.MaxSpeedList_Format);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gamesPlayedList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(282, 247);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "sužaista žaidimų";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gamesPlayedList
            // 
            this.gamesPlayedList.FormattingEnabled = true;
            this.gamesPlayedList.Location = new System.Drawing.Point(1, 2);
            this.gamesPlayedList.Name = "gamesPlayedList";
            this.gamesPlayedList.Size = new System.Drawing.Size(280, 238);
            this.gamesPlayedList.TabIndex = 0;
            this.gamesPlayedList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.GamesPlayedList_Format);
            // 
            // LeaderboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 297);
            this.Controls.Add(this.tabControl1);
            this.Name = "LeaderboardForm";
            this.Text = "LeaderboardForm";
            this.tabControl1.ResumeLayout(false);
            this.gamesWonTab.ResumeLayout(false);
            this.totalScoreTab.ResumeLayout(false);
            this.maxSpeedTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gamesWonTab;
        private System.Windows.Forms.ListBox gamesWonList;
        private System.Windows.Forms.TabPage totalScoreTab;
        private System.Windows.Forms.TabPage maxSpeedTab;
        private System.Windows.Forms.ListBox totalScoreList;
        private System.Windows.Forms.ListBox maxSpeedList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox gamesPlayedList;
    }
}