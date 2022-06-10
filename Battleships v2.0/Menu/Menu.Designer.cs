namespace Battleships_v2._0
{
    partial class Menu
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
            this.EditorButton = new System.Windows.Forms.Button();
            this.m_LeaderboardButton = new MaterialSkin.Controls.MaterialButton();
            this.m_ReplayButton = new MaterialSkin.Controls.MaterialButton();
            this.m_CurrentUser = new MaterialSkin.Controls.MaterialLabel();
            this.m_CurrentId = new MaterialSkin.Controls.MaterialLabel();
            this.m_BattleshipsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.m_HistoryButton = new MaterialSkin.Controls.MaterialButton();
            this.m_JoinGameButton = new MaterialSkin.Controls.MaterialButton();
            this.m_CreateGameButton = new MaterialSkin.Controls.MaterialButton();
            this.m_QuitButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // EditorButton
            // 
            this.EditorButton.Location = new System.Drawing.Point(12, 502);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.Size = new System.Drawing.Size(75, 23);
            this.EditorButton.TabIndex = 2;
            this.EditorButton.Text = "Editor";
            this.EditorButton.UseVisualStyleBackColor = true;
            this.EditorButton.Visible = false;
            this.EditorButton.Click += new System.EventHandler(this.EditorButton_Click);
            // 
            // m_LeaderboardButton
            // 
            this.m_LeaderboardButton.AutoSize = false;
            this.m_LeaderboardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_LeaderboardButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_LeaderboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_LeaderboardButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_LeaderboardButton.Depth = 0;
            this.m_LeaderboardButton.HighEmphasis = true;
            this.m_LeaderboardButton.Icon = null;
            this.m_LeaderboardButton.Location = new System.Drawing.Point(394, 182);
            this.m_LeaderboardButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_LeaderboardButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_LeaderboardButton.Name = "m_LeaderboardButton";
            this.m_LeaderboardButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_LeaderboardButton.Size = new System.Drawing.Size(128, 48);
            this.m_LeaderboardButton.TabIndex = 6;
            this.m_LeaderboardButton.Text = "Leaderboard";
            this.m_LeaderboardButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_LeaderboardButton.UseAccentColor = false;
            this.m_LeaderboardButton.UseVisualStyleBackColor = false;
            this.m_LeaderboardButton.Click += new System.EventHandler(this.m_LeaderboardButton_Click);
            // 
            // m_ReplayButton
            // 
            this.m_ReplayButton.AutoSize = false;
            this.m_ReplayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_ReplayButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_ReplayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_ReplayButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_ReplayButton.Depth = 0;
            this.m_ReplayButton.HighEmphasis = true;
            this.m_ReplayButton.Icon = null;
            this.m_ReplayButton.Location = new System.Drawing.Point(394, 302);
            this.m_ReplayButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_ReplayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_ReplayButton.Name = "m_ReplayButton";
            this.m_ReplayButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_ReplayButton.Size = new System.Drawing.Size(128, 48);
            this.m_ReplayButton.TabIndex = 7;
            this.m_ReplayButton.Text = "Replay";
            this.m_ReplayButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_ReplayButton.UseAccentColor = false;
            this.m_ReplayButton.UseVisualStyleBackColor = false;
            this.m_ReplayButton.Click += new System.EventHandler(this.m_ReplayButton_Click);
            // 
            // m_CurrentUser
            // 
            this.m_CurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_CurrentUser.AutoSize = true;
            this.m_CurrentUser.Depth = 0;
            this.m_CurrentUser.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_CurrentUser.Location = new System.Drawing.Point(9, 9);
            this.m_CurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_CurrentUser.Name = "m_CurrentUser";
            this.m_CurrentUser.Size = new System.Drawing.Size(27, 19);
            this.m_CurrentUser.TabIndex = 9;
            this.m_CurrentUser.Text = "text";
            this.m_CurrentUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_CurrentId
            // 
            this.m_CurrentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_CurrentId.AutoSize = true;
            this.m_CurrentId.Depth = 0;
            this.m_CurrentId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_CurrentId.Location = new System.Drawing.Point(9, 37);
            this.m_CurrentId.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_CurrentId.Name = "m_CurrentId";
            this.m_CurrentId.Size = new System.Drawing.Size(27, 19);
            this.m_CurrentId.TabIndex = 10;
            this.m_CurrentId.Text = "text";
            this.m_CurrentId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_BattleshipsLabel
            // 
            this.m_BattleshipsLabel.AutoSize = true;
            this.m_BattleshipsLabel.Depth = 0;
            this.m_BattleshipsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_BattleshipsLabel.Location = new System.Drawing.Point(442, 37);
            this.m_BattleshipsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_BattleshipsLabel.Name = "m_BattleshipsLabel";
            this.m_BattleshipsLabel.Size = new System.Drawing.Size(80, 19);
            this.m_BattleshipsLabel.TabIndex = 11;
            this.m_BattleshipsLabel.Text = "Battleships";
            // 
            // m_HistoryButton
            // 
            this.m_HistoryButton.AutoSize = false;
            this.m_HistoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_HistoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_HistoryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_HistoryButton.Depth = 0;
            this.m_HistoryButton.HighEmphasis = true;
            this.m_HistoryButton.Icon = null;
            this.m_HistoryButton.Location = new System.Drawing.Point(394, 242);
            this.m_HistoryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_HistoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_HistoryButton.Name = "m_HistoryButton";
            this.m_HistoryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_HistoryButton.Size = new System.Drawing.Size(128, 48);
            this.m_HistoryButton.TabIndex = 12;
            this.m_HistoryButton.Text = "History";
            this.m_HistoryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_HistoryButton.UseAccentColor = false;
            this.m_HistoryButton.UseVisualStyleBackColor = false;
            this.m_HistoryButton.Click += new System.EventHandler(this.m_HistoryButton_Click);
            // 
            // m_JoinGameButton
            // 
            this.m_JoinGameButton.AutoSize = false;
            this.m_JoinGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_JoinGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_JoinGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_JoinGameButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_JoinGameButton.Depth = 0;
            this.m_JoinGameButton.HighEmphasis = true;
            this.m_JoinGameButton.Icon = null;
            this.m_JoinGameButton.Location = new System.Drawing.Point(394, 122);
            this.m_JoinGameButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_JoinGameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_JoinGameButton.Name = "m_JoinGameButton";
            this.m_JoinGameButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_JoinGameButton.Size = new System.Drawing.Size(128, 48);
            this.m_JoinGameButton.TabIndex = 13;
            this.m_JoinGameButton.Text = "Join Game";
            this.m_JoinGameButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_JoinGameButton.UseAccentColor = false;
            this.m_JoinGameButton.UseVisualStyleBackColor = false;
            this.m_JoinGameButton.Click += new System.EventHandler(this.m_JoinGameButton_Click);
            // 
            // m_CreateGameButton
            // 
            this.m_CreateGameButton.AutoSize = false;
            this.m_CreateGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_CreateGameButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_CreateGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_CreateGameButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_CreateGameButton.Depth = 0;
            this.m_CreateGameButton.HighEmphasis = true;
            this.m_CreateGameButton.Icon = null;
            this.m_CreateGameButton.Location = new System.Drawing.Point(394, 62);
            this.m_CreateGameButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_CreateGameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_CreateGameButton.Name = "m_CreateGameButton";
            this.m_CreateGameButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_CreateGameButton.Size = new System.Drawing.Size(128, 48);
            this.m_CreateGameButton.TabIndex = 14;
            this.m_CreateGameButton.Text = "Create Game";
            this.m_CreateGameButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_CreateGameButton.UseAccentColor = false;
            this.m_CreateGameButton.UseVisualStyleBackColor = false;
            this.m_CreateGameButton.Click += new System.EventHandler(this.m_CreateGameButton_Click);
            // 
            // m_QuitButton
            // 
            this.m_QuitButton.AutoSize = false;
            this.m_QuitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_QuitButton.BackColor = System.Drawing.SystemColors.Control;
            this.m_QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_QuitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_QuitButton.Depth = 0;
            this.m_QuitButton.HighEmphasis = true;
            this.m_QuitButton.Icon = null;
            this.m_QuitButton.Location = new System.Drawing.Point(394, 362);
            this.m_QuitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_QuitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_QuitButton.Name = "m_QuitButton";
            this.m_QuitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_QuitButton.Size = new System.Drawing.Size(128, 48);
            this.m_QuitButton.TabIndex = 15;
            this.m_QuitButton.Text = "Quit";
            this.m_QuitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_QuitButton.UseAccentColor = false;
            this.m_QuitButton.UseVisualStyleBackColor = false;
            this.m_QuitButton.Click += new System.EventHandler(this.m_QuitButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.m_QuitButton);
            this.Controls.Add(this.m_CreateGameButton);
            this.Controls.Add(this.m_JoinGameButton);
            this.Controls.Add(this.m_HistoryButton);
            this.Controls.Add(this.m_BattleshipsLabel);
            this.Controls.Add(this.m_CurrentId);
            this.Controls.Add(this.m_CurrentUser);
            this.Controls.Add(this.m_ReplayButton);
            this.Controls.Add(this.m_LeaderboardButton);
            this.Controls.Add(this.EditorButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditorButton;
        private MaterialSkin.Controls.MaterialButton m_LeaderboardButton;
        private MaterialSkin.Controls.MaterialButton m_ReplayButton;
        private MaterialSkin.Controls.MaterialLabel m_CurrentUser;
        private MaterialSkin.Controls.MaterialLabel m_CurrentId;
        private MaterialSkin.Controls.MaterialLabel m_BattleshipsLabel;
        private MaterialSkin.Controls.MaterialButton m_HistoryButton;
        private MaterialSkin.Controls.MaterialButton m_JoinGameButton;
        private MaterialSkin.Controls.MaterialButton m_CreateGameButton;
        private MaterialSkin.Controls.MaterialButton m_QuitButton;
    }
}