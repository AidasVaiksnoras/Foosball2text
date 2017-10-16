namespace Foosball2text
{
    partial class LoginForm
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
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.login1 = new System.Windows.Forms.Button();
            this.database1DataSet1 = new Foosball2text.Database1DataSet();
            this.userTableAdapter1 = new Foosball2text.Database1DataSetTableAdapters.UserTableAdapter();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(30, 59);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(199, 20);
            this.name1.TabIndex = 0;
            this.name1.Text = "Kairės pusės komandos pavadinimas";
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(292, 59);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(199, 20);
            this.name2.TabIndex = 1;
            this.name2.Text = "Dešinės pusės komandos pavadinimas";
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(166, 141);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(166, 46);
            this.login1.TabIndex = 2;
            this.login1.Text = "Rinktis varda";
            this.login1.UseVisualStyleBackColor = true;
            this.login1.Click += new System.EventHandler(this.login1_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(237, 101);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 3;
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 269);
            this.Controls.Add(this.label);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Button login1;
        private Database1DataSet database1DataSet1;
        private Database1DataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.Label label;
    }
}