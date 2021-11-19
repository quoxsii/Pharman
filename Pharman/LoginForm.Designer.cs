
namespace Pharman
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.loginTextBox.Location = new System.Drawing.Point(30, 157);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(206, 29);
            this.loginTextBox.TabIndex = 52;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginButton.Location = new System.Drawing.Point(30, 274);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(206, 41);
            this.loginButton.TabIndex = 50;
            this.loginButton.Text = "ВОЙТИ";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(26, 193);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 21);
            this.passwordLabel.TabIndex = 61;
            this.passwordLabel.Text = "Пароль";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.passwordTextBox.Location = new System.Drawing.Point(30, 217);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(206, 29);
            this.passwordTextBox.TabIndex = 60;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Pharman.Properties.Resources.Logo;
            this.logoPictureBox.Location = new System.Drawing.Point(30, 9);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(206, 104);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 63;
            this.logoPictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.loginLabel.Location = new System.Drawing.Point(26, 133);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(56, 21);
            this.loginLabel.TabIndex = 64;
            this.loginLabel.Text = "Логин";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(266, 345);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharman";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label loginLabel;
    }
}