namespace Battleships_v2._0
{
    partial class LogIn
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
            this.m_EnterButton = new MaterialSkin.Controls.MaterialButton();
            this.m_ResetPassword = new MaterialSkin.Controls.MaterialButton();
            this.m_CreateAccount = new MaterialSkin.Controls.MaterialButton();
            this.m_UsernameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_UserIdBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_PasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // m_EnterButton
            // 
            this.m_EnterButton.AutoSize = false;
            this.m_EnterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_EnterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_EnterButton.Depth = 0;
            this.m_EnterButton.Enabled = false;
            this.m_EnterButton.HighEmphasis = true;
            this.m_EnterButton.Icon = null;
            this.m_EnterButton.Location = new System.Drawing.Point(12, 71);
            this.m_EnterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_EnterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_EnterButton.Name = "m_EnterButton";
            this.m_EnterButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_EnterButton.Size = new System.Drawing.Size(128, 48);
            this.m_EnterButton.TabIndex = 4;
            this.m_EnterButton.Text = "Enter";
            this.m_EnterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_EnterButton.UseAccentColor = false;
            this.m_EnterButton.UseVisualStyleBackColor = true;
            this.m_EnterButton.Click += new System.EventHandler(this.m_EnterButton_Click);
            // 
            // m_ResetPassword
            // 
            this.m_ResetPassword.AutoSize = false;
            this.m_ResetPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_ResetPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_ResetPassword.Depth = 0;
            this.m_ResetPassword.HighEmphasis = true;
            this.m_ResetPassword.Icon = null;
            this.m_ResetPassword.Location = new System.Drawing.Point(146, 71);
            this.m_ResetPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_ResetPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_ResetPassword.Name = "m_ResetPassword";
            this.m_ResetPassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_ResetPassword.Size = new System.Drawing.Size(128, 48);
            this.m_ResetPassword.TabIndex = 5;
            this.m_ResetPassword.Text = "Reset Password";
            this.m_ResetPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_ResetPassword.UseAccentColor = false;
            this.m_ResetPassword.UseVisualStyleBackColor = true;
            this.m_ResetPassword.Click += new System.EventHandler(this.m_ResetPassword_Click);
            // 
            // m_CreateAccount
            // 
            this.m_CreateAccount.AutoSize = false;
            this.m_CreateAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_CreateAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_CreateAccount.Depth = 0;
            this.m_CreateAccount.HighEmphasis = true;
            this.m_CreateAccount.Icon = null;
            this.m_CreateAccount.Location = new System.Drawing.Point(282, 71);
            this.m_CreateAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_CreateAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_CreateAccount.Name = "m_CreateAccount";
            this.m_CreateAccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_CreateAccount.Size = new System.Drawing.Size(128, 48);
            this.m_CreateAccount.TabIndex = 6;
            this.m_CreateAccount.Text = "Create Account";
            this.m_CreateAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_CreateAccount.UseAccentColor = false;
            this.m_CreateAccount.UseVisualStyleBackColor = true;
            this.m_CreateAccount.Click += new System.EventHandler(this.m_CreateAccount_Click);
            // 
            // m_UsernameBox
            // 
            this.m_UsernameBox.AnimateReadOnly = false;
            this.m_UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_UsernameBox.Depth = 0;
            this.m_UsernameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_UsernameBox.Hint = "Username";
            this.m_UsernameBox.LeadingIcon = null;
            this.m_UsernameBox.Location = new System.Drawing.Point(146, 12);
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
            // m_PasswordBox
            // 
            this.m_PasswordBox.AnimateReadOnly = false;
            this.m_PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PasswordBox.Depth = 0;
            this.m_PasswordBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_PasswordBox.Hint = "Password";
            this.m_PasswordBox.LeadingIcon = null;
            this.m_PasswordBox.Location = new System.Drawing.Point(280, 12);
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
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 130);
            this.Controls.Add(this.m_PasswordBox);
            this.Controls.Add(this.m_UserIdBox);
            this.Controls.Add(this.m_UsernameBox);
            this.Controls.Add(this.m_CreateAccount);
            this.Controls.Add(this.m_ResetPassword);
            this.Controls.Add(this.m_EnterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton m_EnterButton;
        private MaterialSkin.Controls.MaterialButton m_ResetPassword;
        private MaterialSkin.Controls.MaterialButton m_CreateAccount;
        private MaterialSkin.Controls.MaterialTextBox m_UsernameBox;
        private MaterialSkin.Controls.MaterialTextBox m_UserIdBox;
        private MaterialSkin.Controls.MaterialTextBox m_PasswordBox;
    }
}