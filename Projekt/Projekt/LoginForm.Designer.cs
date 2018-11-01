namespace Projekt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_Textbox = new System.Windows.Forms.TextBox();
            this.Pass_Textbox = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // User_Textbox
            // 
            this.User_Textbox.Location = new System.Drawing.Point(112, 38);
            this.User_Textbox.Name = "User_Textbox";
            this.User_Textbox.Size = new System.Drawing.Size(100, 20);
            this.User_Textbox.TabIndex = 3;
            // 
            // Pass_Textbox
            // 
            this.Pass_Textbox.Location = new System.Drawing.Point(112, 102);
            this.Pass_Textbox.Name = "Pass_Textbox";
            this.Pass_Textbox.PasswordChar = '*';
            this.Pass_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Pass_Textbox.TabIndex = 4;
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.MidnightBlue;
            this.Login_Button.Location = new System.Drawing.Point(91, 161);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Login_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Pass_Textbox);
            this.Controls.Add(this.User_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_Textbox;
        private System.Windows.Forms.TextBox Pass_Textbox;
        private System.Windows.Forms.Button Login_Button;
    }
}

