namespace Tessa_Biava_Exercise5
{
    partial class ApproximateForm
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
            this.enterLabel = new System.Windows.Forms.Label();
            this.numberTermsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.termsLabel = new System.Windows.Forms.Label();
            this.approximationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Location = new System.Drawing.Point(41, 31);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(113, 13);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter number of terms:";
            // 
            // numberTermsTextBox
            // 
            this.numberTermsTextBox.Location = new System.Drawing.Point(160, 28);
            this.numberTermsTextBox.Name = "numberTermsTextBox";
            this.numberTermsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTermsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateButton.Location = new System.Drawing.Point(106, 92);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(65, 55);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(0, 13);
            this.termsLabel.TabIndex = 3;
            this.termsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // approximationLabel
            // 
            this.approximationLabel.AutoSize = true;
            this.approximationLabel.Location = new System.Drawing.Point(66, 72);
            this.approximationLabel.Name = "approximationLabel";
            this.approximationLabel.Size = new System.Drawing.Size(0, 13);
            this.approximationLabel.TabIndex = 4;
            this.approximationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApproximateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 135);
            this.Controls.Add(this.approximationLabel);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberTermsTextBox);
            this.Controls.Add(this.enterLabel);
            this.Name = "ApproximateForm";
            this.Text = "Approximate Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox numberTermsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.Label approximationLabel;
    }
}

