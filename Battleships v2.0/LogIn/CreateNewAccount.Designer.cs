namespace Battleships_v2._0
{
    partial class CreateNewAccount
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
            this.m_LogInButton = new MaterialSkin.Controls.MaterialButton();
            this.m_CreateAccountButton = new MaterialSkin.Controls.MaterialButton();
            this.m_PasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_LastNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_FirstNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_UsernameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_PasswordConfirm = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // m_LogInButton
            // 
            this.m_LogInButton.AutoSize = false;
            this.m_LogInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_LogInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_LogInButton.Depth = 0;
            this.m_LogInButton.HighEmphasis = true;
            this.m_LogInButton.Icon = null;
            this.m_LogInButton.Location = new System.Drawing.Point(222, 127);
            this.m_LogInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_LogInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_LogInButton.Name = "m_LogInButton";
            this.m_LogInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_LogInButton.Size = new System.Drawing.Size(128, 48);
            this.m_LogInButton.TabIndex = 7;
            this.m_LogInButton.Text = "Log In";
            this.m_LogInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_LogInButton.UseAccentColor = false;
            this.m_LogInButton.UseVisualStyleBackColor = true;
            this.m_LogInButton.Click += new System.EventHandler(this.m_LogInButton_Click);
            // 
            // m_CreateAccountButton
            // 
            this.m_CreateAccountButton.AutoSize = false;
            this.m_CreateAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_CreateAccountButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_CreateAccountButton.Depth = 0;
            this.m_CreateAccountButton.Enabled = false;
            this.m_CreateAccountButton.HighEmphasis = true;
            this.m_CreateAccountButton.Icon = null;
            this.m_CreateAccountButton.Location = new System.Drawing.Point(86, 127);
            this.m_CreateAccountButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_CreateAccountButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_CreateAccountButton.Name = "m_CreateAccountButton";
            this.m_CreateAccountButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_CreateAccountButton.Size = new System.Drawing.Size(128, 48);
            this.m_CreateAccountButton.TabIndex = 6;
            this.m_CreateAccountButton.Text = "Create Account";
            this.m_CreateAccountButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_CreateAccountButton.UseAccentColor = false;
            this.m_CreateAccountButton.UseVisualStyleBackColor = true;
            this.m_CreateAccountButton.Click += new System.EventHandler(this.m_CreateAccountButton_Click);
            // 
            // m_PasswordBox
            // 
            this.m_PasswordBox.AnimateReadOnly = false;
            this.m_PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PasswordBox.Depth = 0;
            this.m_PasswordBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_PasswordBox.Hint = "Password";
            this.m_PasswordBox.LeadingIcon = null;
            this.m_PasswordBox.Location = new System.Drawing.Point(111, 68);
            this.m_PasswordBox.MaxLength = 50;
            this.m_PasswordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_PasswordBox.Multiline = false;
            this.m_PasswordBox.Name = "m_PasswordBox";
            this.m_PasswordBox.Password = true;
            this.m_PasswordBox.Size = new System.Drawing.Size(128, 50);
            this.m_PasswordBox.TabIndex = 4;
            this.m_PasswordBox.Text = "";
            this.m_PasswordBox.TrailingIcon = null;
            this.m_PasswordBox.TextChanged += new System.EventHandler(this.m_PasswordBox_TextChanged);
            // 
            // m_LastNameBox
            // 
            this.m_LastNameBox.AnimateReadOnly = false;
            this.m_LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_LastNameBox.Depth = 0;
            this.m_LastNameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_LastNameBox.Hint = "Last Name";
            this.m_LastNameBox.LeadingIcon = null;
            this.m_LastNameBox.Location = new System.Drawing.Point(280, 12);
            this.m_LastNameBox.MaxLength = 50;
            this.m_LastNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_LastNameBox.Multiline = false;
            this.m_LastNameBox.Name = "m_LastNameBox";
            this.m_LastNameBox.Size = new System.Drawing.Size(128, 50);
            this.m_LastNameBox.TabIndex = 3;
            this.m_LastNameBox.Text = "";
            this.m_LastNameBox.TrailingIcon = null;
            this.m_LastNameBox.TextChanged += new System.EventHandler(this.m_LastNameBox_TextChanged);
            // 
            // m_FirstNameBox
            // 
            this.m_FirstNameBox.AnimateReadOnly = false;
            this.m_FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_FirstNameBox.Depth = 0;
            this.m_FirstNameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_FirstNameBox.Hint = "First Name";
            this.m_FirstNameBox.LeadingIcon = null;
            this.m_FirstNameBox.Location = new System.Drawing.Point(146, 12);
            this.m_FirstNameBox.MaxLength = 50;
            this.m_FirstNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_FirstNameBox.Multiline = false;
            this.m_FirstNameBox.Name = "m_FirstNameBox";
            this.m_FirstNameBox.Size = new System.Drawing.Size(128, 50);
            this.m_FirstNameBox.TabIndex = 2;
            this.m_FirstNameBox.Text = "";
            this.m_FirstNameBox.TrailingIcon = null;
            this.m_FirstNameBox.TextChanged += new System.EventHandler(this.m_FirstNameBox_TextChanged);
            // 
            // m_UsernameBox
            // 
            this.m_UsernameBox.AnimateReadOnly = false;
            this.m_UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_UsernameBox.Depth = 0;
            this.m_UsernameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_UsernameBox.Hint = "Username";
            this.m_UsernameBox.LeadingIcon = null;
            this.m_UsernameBox.Location = new System.Drawing.Point(12, 12);
            this.m_UsernameBox.MaxLength = 50;
            this.m_UsernameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_UsernameBox.Multiline = false;
            this.m_UsernameBox.Name = "m_UsernameBox";
            this.m_UsernameBox.Size = new System.Drawing.Size(128, 50);
            this.m_UsernameBox.TabIndex = 1;
            this.m_UsernameBox.Text = "";
            this.m_UsernameBox.TrailingIcon = null;
            this.m_UsernameBox.TextChanged += new System.EventHandler(this.m_UsernameBox_TextChanged);
            // 
            // m_PasswordConfirm
            // 
            this.m_PasswordConfirm.AnimateReadOnly = false;
            this.m_PasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_PasswordConfirm.Depth = 0;
            this.m_PasswordConfirm.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_PasswordConfirm.Hint = "Confirm";
            this.m_PasswordConfirm.LeadingIcon = null;
            this.m_PasswordConfirm.Location = new System.Drawing.Point(245, 67);
            this.m_PasswordConfirm.MaxLength = 50;
            this.m_PasswordConfirm.MouseState = MaterialSkin.MouseState.OUT;
            this.m_PasswordConfirm.Multiline = false;
            this.m_PasswordConfirm.Name = "m_PasswordConfirm";
            this.m_PasswordConfirm.Password = true;
            this.m_PasswordConfirm.Size = new System.Drawing.Size(128, 50);
            this.m_PasswordConfirm.TabIndex = 5;
            this.m_PasswordConfirm.Text = "";
            this.m_PasswordConfirm.TrailingIcon = null;
            this.m_PasswordConfirm.TextChanged += new System.EventHandler(this.m_PasswordConfirm_TextChanged);
            // 
            // CreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 193);
            this.Controls.Add(this.m_PasswordConfirm);
            this.Controls.Add(this.m_UsernameBox);
            this.Controls.Add(this.m_FirstNameBox);
            this.Controls.Add(this.m_LastNameBox);
            this.Controls.Add(this.m_PasswordBox);
            this.Controls.Add(this.m_CreateAccountButton);
            this.Controls.Add(this.m_LogInButton);
            this.Name = "CreateNewAccount";
            this.Text = "CreateNewAccount";
            this.Load += new System.EventHandler(this.CreateNewAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton m_LogInButton;
        private MaterialSkin.Controls.MaterialButton m_CreateAccountButton;
        private MaterialSkin.Controls.MaterialTextBox m_PasswordBox;
        private MaterialSkin.Controls.MaterialTextBox m_LastNameBox;
        private MaterialSkin.Controls.MaterialTextBox m_FirstNameBox;
        private MaterialSkin.Controls.MaterialTextBox m_UsernameBox;
        private MaterialSkin.Controls.MaterialTextBox m_PasswordConfirm;
    }
}