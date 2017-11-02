namespace SQL_operations
{
    partial class ExceptionForm
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
            this.exceptionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExceptionText
            // 
            this.exceptionText.AutoSize = true;
            this.exceptionText.Location = new System.Drawing.Point(13, 13);
            this.exceptionText.Name = "ExceptionText";
            this.exceptionText.Size = new System.Drawing.Size(75, 13);
            this.exceptionText.TabIndex = 0;
            this.exceptionText.Text = "ExceptionText";
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 108);
            this.Controls.Add(this.exceptionText);
            this.Name = "ExceptionForm";
            this.Text = "ExceptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exceptionText;
    }
}