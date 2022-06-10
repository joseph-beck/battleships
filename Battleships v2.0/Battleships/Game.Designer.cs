namespace Battleships_v2._0
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.EnemyPanel = new System.Windows.Forms.Panel();
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.m_ResetButton = new MaterialSkin.Controls.MaterialButton();
            this.m_MenuButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // EnemyPanel
            // 
            this.EnemyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyPanel.AutoSize = true;
            this.EnemyPanel.Location = new System.Drawing.Point(796, 12);
            this.EnemyPanel.Name = "EnemyPanel";
            this.EnemyPanel.Size = new System.Drawing.Size(200, 100);
            this.EnemyPanel.TabIndex = 5;
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.AutoSize = true;
            this.PlayerPanel.Location = new System.Drawing.Point(12, 12);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(210, 110);
            this.PlayerPanel.TabIndex = 4;
            // 
            // Ticker
            // 
            this.Ticker.Enabled = true;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // m_ResetButton
            // 
            this.m_ResetButton.AutoSize = false;
            this.m_ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_ResetButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_ResetButton.Depth = 0;
            this.m_ResetButton.HighEmphasis = true;
            this.m_ResetButton.Icon = null;
            this.m_ResetButton.Location = new System.Drawing.Point(13, 474);
            this.m_ResetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_ResetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_ResetButton.Name = "m_ResetButton";
            this.m_ResetButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_ResetButton.Size = new System.Drawing.Size(72, 48);
            this.m_ResetButton.TabIndex = 7;
            this.m_ResetButton.Text = "Reset";
            this.m_ResetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_ResetButton.UseAccentColor = false;
            this.m_ResetButton.UseVisualStyleBackColor = true;
            this.m_ResetButton.Click += new System.EventHandler(this.m_ResetButton_Click);
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
            this.m_MenuButton.Location = new System.Drawing.Point(923, 474);
            this.m_MenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_MenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_MenuButton.Name = "m_MenuButton";
            this.m_MenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_MenuButton.Size = new System.Drawing.Size(72, 48);
            this.m_MenuButton.TabIndex = 8;
            this.m_MenuButton.Text = "Menu";
            this.m_MenuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_MenuButton.UseAccentColor = false;
            this.m_MenuButton.UseVisualStyleBackColor = true;
            this.m_MenuButton.Click += new System.EventHandler(this.m_MenuButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.m_MenuButton);
            this.Controls.Add(this.m_ResetButton);
            this.Controls.Add(this.EnemyPanel);
            this.Controls.Add(this.PlayerPanel);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel EnemyPanel;
        private System.Windows.Forms.Panel PlayerPanel;
        protected MaterialSkin.Controls.MaterialButton m_MenuButton;
        protected System.Windows.Forms.Timer Ticker;
        protected MaterialSkin.Controls.MaterialButton m_ResetButton;
    }
}