namespace WindowsFormsApplication
{
    partial class helloWorldApplicationForm
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
            this.txtBoxToDisplayMessage = new System.Windows.Forms.TextBox();
            this.clickMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxToDisplayMessage
            // 
            this.txtBoxToDisplayMessage.Location = new System.Drawing.Point(80, 116);
            this.txtBoxToDisplayMessage.Name = "txtBoxToDisplayMessage";
            this.txtBoxToDisplayMessage.Size = new System.Drawing.Size(167, 22);
            this.txtBoxToDisplayMessage.TabIndex = 0;
            // 
            // clickMeButton
            // 
            this.clickMeButton.Location = new System.Drawing.Point(268, 116);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(75, 23);
            this.clickMeButton.TabIndex = 1;
            this.clickMeButton.Text = "Click Me";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // helloWorldApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 350);
            this.Controls.Add(this.clickMeButton);
            this.Controls.Add(this.txtBoxToDisplayMessage);
            this.Name = "helloWorldApplicationForm";
            this.Text = "Hello World Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxToDisplayMessage;
        private System.Windows.Forms.Button clickMeButton;
    }
}

