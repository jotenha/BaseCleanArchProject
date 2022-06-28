namespace BaseCleanArchProject
{
    partial class User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestLabel = new System.Windows.Forms.Label();
            this.tB_userName = new System.Windows.Forms.TextBox();
            this.b_Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(12, 20);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(27, 15);
            this.TestLabel.TabIndex = 0;
            this.TestLabel.Text = "Test";
            // 
            // tB_userName
            // 
            this.tB_userName.Location = new System.Drawing.Point(56, 12);
            this.tB_userName.Name = "tB_userName";
            this.tB_userName.Size = new System.Drawing.Size(100, 23);
            this.tB_userName.TabIndex = 1;
            // 
            // b_Signup
            // 
            this.b_Signup.Location = new System.Drawing.Point(12, 41);
            this.b_Signup.Name = "b_Signup";
            this.b_Signup.Size = new System.Drawing.Size(144, 23);
            this.b_Signup.TabIndex = 2;
            this.b_Signup.Text = "Signup";
            this.b_Signup.UseVisualStyleBackColor = true;
            this.b_Signup.Click += new System.EventHandler(this.b_Signup_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Signup);
            this.Controls.Add(this.tB_userName);
            this.Controls.Add(this.TestLabel);
            this.Name = "User";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TestLabel;
        private TextBox tB_userName;
        private Button b_Signup;
    }
}