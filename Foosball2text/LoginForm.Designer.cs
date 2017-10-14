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
            this.login2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.database1DataSet1 = new Foosball2text.Database1DataSet();
            this.userTableAdapter1 = new Foosball2text.Database1DataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(63, 59);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(143, 20);
            this.name1.TabIndex = 0;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(292, 59);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(143, 20);
            this.name2.TabIndex = 1;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(63, 125);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(143, 46);
            this.login1.TabIndex = 2;
            this.login1.Text = "Rinktis varda";
            this.login1.UseVisualStyleBackColor = true;
            this.login1.Click += new System.EventHandler(this.login1_Click);
            // 
            // login2
            // 
            this.login2.Location = new System.Drawing.Point(292, 125);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(143, 46);
            this.login2.TabIndex = 3;
            this.login2.Text = "Rinktis varda";
            this.login2.UseVisualStyleBackColor = true;
            this.login2.Click += new System.EventHandler(this.login2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login2);
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
        private System.Windows.Forms.Button login2;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet1;
        private Database1DataSetTableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.Label label2;
    }
}