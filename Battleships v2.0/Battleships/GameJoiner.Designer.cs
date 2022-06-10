namespace Battleships_v2._0
{
    partial class GameJoiner
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
            this.m_LobbyIdBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_JoinButton = new MaterialSkin.Controls.MaterialButton();
            this.m_MenuButton = new MaterialSkin.Controls.MaterialButton();
            this.m_ConfirmButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // m_LobbyIdBox
            // 
            this.m_LobbyIdBox.AnimateReadOnly = false;
            this.m_LobbyIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_LobbyIdBox.Depth = 0;
            this.m_LobbyIdBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_LobbyIdBox.LeadingIcon = null;
            this.m_LobbyIdBox.Location = new System.Drawing.Point(328, 129);
            this.m_LobbyIdBox.MaxLength = 50;
            this.m_LobbyIdBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_LobbyIdBox.Multiline = false;
            this.m_LobbyIdBox.Name = "m_LobbyIdBox";
            this.m_LobbyIdBox.Size = new System.Drawing.Size(128, 50);
            this.m_LobbyIdBox.TabIndex = 0;
            this.m_LobbyIdBox.Text = "";
            this.m_LobbyIdBox.TrailingIcon = null;
            this.m_LobbyIdBox.TextChanged += new System.EventHandler(this.m_LobbyIdBox_TextChanged);
            // 
            // m_JoinButton
            // 
            this.m_JoinButton.AutoSize = false;
            this.m_JoinButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_JoinButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_JoinButton.Depth = 0;
            this.m_JoinButton.Enabled = false;
            this.m_JoinButton.HighEmphasis = true;
            this.m_JoinButton.Icon = null;
            this.m_JoinButton.Location = new System.Drawing.Point(328, 248);
            this.m_JoinButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_JoinButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_JoinButton.Name = "m_JoinButton";
            this.m_JoinButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_JoinButton.Size = new System.Drawing.Size(128, 48);
            this.m_JoinButton.TabIndex = 1;
            this.m_JoinButton.Text = "Join Game";
            this.m_JoinButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_JoinButton.UseAccentColor = false;
            this.m_JoinButton.UseVisualStyleBackColor = true;
            this.m_JoinButton.Click += new System.EventHandler(this.m_JoinButton_Click);
            // 
            // m_MenuButton
            // 
            this.m_MenuButton.AutoSize = false;
            this.m_MenuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_MenuButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_MenuButton.Depth = 0;
            this.m_MenuButton.HighEmphasis = true;
            this.m_MenuButton.Icon = null;
            this.m_MenuButton.Location = new System.Drawing.Point(328, 308);
            this.m_MenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_MenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_MenuButton.Name = "m_MenuButton";
            this.m_MenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_MenuButton.Size = new System.Drawing.Size(128, 48);
            this.m_MenuButton.TabIndex = 11;
            this.m_MenuButton.Text = "Menu";
            this.m_MenuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_MenuButton.UseAccentColor = false;
            this.m_MenuButton.UseVisualStyleBackColor = true;
            this.m_MenuButton.Click += new System.EventHandler(this.m_MenuButton_Click);
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
            this.m_ConfirmButton.Location = new System.Drawing.Point(328, 188);
            this.m_ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_ConfirmButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_ConfirmButton.Name = "m_ConfirmButton";
            this.m_ConfirmButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_ConfirmButton.Size = new System.Drawing.Size(128, 48);
            this.m_ConfirmButton.TabIndex = 13;
            this.m_ConfirmButton.Text = "Confirm";
            this.m_ConfirmButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_ConfirmButton.UseAccentColor = false;
            this.m_ConfirmButton.UseVisualStyleBackColor = true;
            this.m_ConfirmButton.Click += new System.EventHandler(this.m_ConfirmButton_Click);
            // 
            // GameJoiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_ConfirmButton);
            this.Controls.Add(this.m_MenuButton);
            this.Controls.Add(this.m_JoinButton);
            this.Controls.Add(this.m_LobbyIdBox);
            this.Name = "GameJoiner";
            this.Text = "GameJoiner";
            this.Load += new System.EventHandler(this.GameJoiner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox m_LobbyIdBox;
        private MaterialSkin.Controls.MaterialButton m_JoinButton;
        private MaterialSkin.Controls.MaterialButton m_MenuButton;
        private MaterialSkin.Controls.MaterialButton m_ConfirmButton;
    }
}