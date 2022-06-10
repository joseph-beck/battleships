namespace Battleships_v2._0
{
    partial class ResetPassword
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
            this.m_ConfirmButton = new MaterialSkin.Controls.MaterialButton();
            this.m_LogInButton = new MaterialSkin.Controls.MaterialButton();
            this.m_UserIdBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_UsernameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_PasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_ConfirmPasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // m_ConfirmButton
            // 
            this.m_ConfirmButton.AutoSize = false;
            this.m_ConfirmButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_ConfirmButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_ConfirmButton.Depth = 0;
            this.m_ConfirmButton.Enabled = false;
            this.m_ConfirmButton.HighEmphasis = true;
            this.m_ConfirmButton.Icon = null;
            this.m_ConfirmButton.Location = new System.Drawing.Point(12, 127);
            this.m_ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_ConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_ConfirmButton.Name = "m_ConfirmButton";
            this.m_ConfirmButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_ConfirmButton.Size = new System.Drawing.Size(128, 48);
            this.m_ConfirmButton.TabIndex = 5;
            this.m_ConfirmButton.Text = "Confirm";
            this.m_ConfirmButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_ConfirmButton.UseAccentColor = false;
            this.m_ConfirmButton.UseVisualStyleBackColor = true;
            this.m_ConfirmButton.Click += new System.EventHandler(this.m_ConfirmButton_Click);
            // 
            // m_LogInButton
            // 
            this.m_LogInButton.AutoSize = false;
            this.m_LogInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_LogInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_LogInButton.Depth = 0;
            this.m_LogInButton.HighEmphasis = true;
            this.m_LogInButton.Icon = null;
            this.m_LogInButton.Location = new System.Drawing.Point(146, 127);
            this.m_LogInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_LogInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_LogInButton.Name = "m_LogInButton";
            this.m_LogInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_LogInButton.Size = new System.Drawing.Size(128, 48);
            this.m_LogInButton.TabIndex = 6;
            this.m_LogInButton.Text = "Log In";
            this.m_LogInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_LogInButton.UseAccentColor = false;
            this.m_LogInButton.UseVisualStyleBackColor = true;
            this.m_LogInButton.Click += new System.EventHandler(this.m_LogInButton_Click);
            // 
            // m_UserIdBox
            // 
            this.m_UserIdBox.AnimateReadOnly = false;
            this.m_UserIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_UserIdBox.Depth = 0;
            this.m_UserIdBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_UserIdBox.Hint = "User ID";
            this.m_UserIdBox.LeadingIcon = null;
            this.m_UserIdBox.Location = new System.Drawing.Point(12, 12);
            this.m_UserIdBox.MaxLength = 50;
            this.m_UserIdBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_UserIdBox.Multiline = false;
            this.m_UserIdBox.Name = "m_UserIdBox";
            this.m_UserIdBox.Size = new System.Drawing.Size(128, 50);
            this.m_UserIdBox.TabIndex = 1;
            this.m_UserIdBox.Text = "";
            this.m_UserIdBox.TrailingIcon = null;
            this.m_UserIdBox.TextChanged += new System.EventHandler(this.m_UserIdBox_TextChanged);
            // 
            // m_UsernameBox
            // 
            this.m_UsernameBox.AnimateReadOnly = false;
            this.m_UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_UsernameBox.Depth = 0;
            this.m_UsernameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_UsernameBox.Hint = "Username";
            this.m_UsernameBox.LeadingIcon = null;
            this.m_UsernameBox.Location = new System.Drawing.Point(146, 11);
            this.m_UsernameBox.MaxLength = 50;
            this.m_UsernameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_UsernameBox.Multiline = false;
            this.m_UsernameBox.Name = "m_UsernameBox";
            this.m_UsernameBox.Size = new System.Drawing.Size(128, 50);
            this.m_UsernameBox.TabIndex = 2;
            this.m_UsernameBox.Text = "";
            this.m_UsernameBox.TrailingIcon = null;
            this.m_UsernameBox.TextChanged += new System.EventHandler(this.m_UsernameBox_TextChanged);
            // 
            // m_PasswordBox
            // 
            this.m_PasswordBox.AnimateReadOnly = false;
            this.m_PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PasswordBox.Depth = 0;
            this.m_PasswordBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_PasswordBox.Hint = "Password";
            this.m_PasswordBox.LeadingIcon = null;
            this.m_PasswordBox.Location = new System.Drawing.Point(12, 68);
            this.m_PasswordBox.MaxLength = 50;
            this.m_PasswordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_PasswordBox.Multiline = false;
            this.m_PasswordBox.Name = "m_PasswordBox";
            this.m_PasswordBox.Password = true;
            this.m_PasswordBox.Size = new System.Drawing.Size(128, 50);
            this.m_PasswordBox.TabIndex = 3;
            this.m_PasswordBox.Text = "";
            this.m_PasswordBox.TrailingIcon = null;
            this.m_PasswordBox.TextChanged += new System.EventHandler(this.m_PasswordBox_TextChanged);
            // 
            // m_ConfirmPasswordBox
            // 
            this.m_ConfirmPasswordBox.AnimateReadOnly = false;
            this.m_ConfirmPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_ConfirmPasswordBox.Depth = 0;
            this.m_ConfirmPasswordBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_ConfirmPasswordBox.Hint = "Confirm";
            this.m_ConfirmPasswordBox.LeadingIcon = null;
            this.m_ConfirmPasswordBox.Location = new System.Drawing.Point(146, 68);
            this.m_ConfirmPasswordBox.MaxLength = 50;
            this.m_ConfirmPasswordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_ConfirmPasswordBox.Multiline = false;
            this.m_ConfirmPasswordBox.Name = "m_ConfirmPasswordBox";
            this.m_ConfirmPasswordBox.Password = true;
            this.m_ConfirmPasswordBox.Size = new System.Drawing.Size(128, 50);
            this.m_ConfirmPasswordBox.TabIndex = 4;
            this.m_ConfirmPasswordBox.Text = "";
            this.m_ConfirmPasswordBox.TrailingIcon = null;
            this.m_ConfirmPasswordBox.TextChanged += new System.EventHandler(this.m_ConfirmPasswordBox_TextChanged);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 189);
            this.Controls.Add(this.m_ConfirmPasswordBox);
            this.Controls.Add(this.m_PasswordBox);
            this.Controls.Add(this.m_UsernameBox);
            this.Controls.Add(this.m_UserIdBox);
            this.Controls.Add(this.m_LogInButton);
            this.Controls.Add(this.m_ConfirmButton);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton m_ConfirmButton;
        private MaterialSkin.Controls.MaterialButton m_LogInButton;
        private MaterialSkin.Controls.MaterialTextBox m_UserIdBox;
        private MaterialSkin.Controls.MaterialTextBox m_UsernameBox;
        private MaterialSkin.Controls.MaterialTextBox m_PasswordBox;
        private MaterialSkin.Controls.MaterialTextBox m_ConfirmPasswordBox;
    }
}