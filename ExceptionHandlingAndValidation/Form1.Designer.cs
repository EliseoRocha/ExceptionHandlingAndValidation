namespace ExceptionHandlingAndValidation
{
    partial class Form1
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
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.ValidateAgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(182, 98);
            this.AgeTextBox.MaxLength = 3;
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 0;
            // 
            // ValidateAgeButton
            // 
            this.ValidateAgeButton.Location = new System.Drawing.Point(182, 158);
            this.ValidateAgeButton.Name = "ValidateAgeButton";
            this.ValidateAgeButton.Size = new System.Drawing.Size(100, 31);
            this.ValidateAgeButton.TabIndex = 1;
            this.ValidateAgeButton.Text = "Validate Age";
            this.ValidateAgeButton.UseVisualStyleBackColor = true;
            this.ValidateAgeButton.Click += new System.EventHandler(this.ValidateAgeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 316);
            this.Controls.Add(this.ValidateAgeButton);
            this.Controls.Add(this.AgeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Button ValidateAgeButton;
    }
}

