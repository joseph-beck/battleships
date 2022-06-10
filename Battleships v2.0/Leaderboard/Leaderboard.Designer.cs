namespace Battleships_v2._0
{
    partial class Leaderboard
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
            this.LeaderboardViewer = new System.Windows.Forms.DataGridView();
            this.m_SearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.m_FilterBox = new MaterialSkin.Controls.MaterialComboBox();
            this.m_QuitButton = new MaterialSkin.Controls.MaterialButton();
            this.m_MenuButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaderboardViewer
            // 
            this.LeaderboardViewer.AllowUserToAddRows = false;
            this.LeaderboardViewer.AllowUserToDeleteRows = false;
            this.LeaderboardViewer.AllowUserToResizeColumns = false;
            this.LeaderboardViewer.AllowUserToResizeRows = false;
            this.LeaderboardViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LeaderboardViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LeaderboardViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeaderboardViewer.Enabled = false;
            this.LeaderboardViewer.Location = new System.Drawing.Point(12, 70);
            this.LeaderboardViewer.MultiSelect = false;
            this.LeaderboardViewer.Name = "LeaderboardViewer";
            this.LeaderboardViewer.ReadOnly = true;
            this.LeaderboardViewer.RowHeadersWidth = 10;
            this.LeaderboardViewer.RowTemplate.Height = 24;
            this.LeaderboardViewer.RowTemplate.ReadOnly = true;
            this.LeaderboardViewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LeaderboardViewer.Size = new System.Drawing.Size(984, 455);
            this.LeaderboardViewer.TabIndex = 0;
            this.LeaderboardViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LeaderboardViewer_CellContentClick);
            // 
            // m_SearchBox
            // 
            this.m_SearchBox.AnimateReadOnly = false;
            this.m_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_SearchBox.Depth = 0;
            this.m_SearchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_SearchBox.Hint = "Enter Username";
            this.m_SearchBox.LeadingIcon = null;
            this.m_SearchBox.Location = new System.Drawing.Point(368, 12);
            this.m_SearchBox.MaxLength = 50;
            this.m_SearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_SearchBox.Multiline = false;
            this.m_SearchBox.Name = "m_SearchBox";
            this.m_SearchBox.Size = new System.Drawing.Size(147, 50);
            this.m_SearchBox.TabIndex = 5;
            this.m_SearchBox.Text = "";
            this.m_SearchBox.TrailingIcon = null;
            this.m_SearchBox.TextChanged += new System.EventHandler(this.m_SearchBox_TextChanged);
            // 
            // m_SearchButton
            // 
            this.m_SearchButton.AutoSize = false;
            this.m_SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_SearchButton.Depth = 0;
            this.m_SearchButton.Enabled = false;
            this.m_SearchButton.HighEmphasis = true;
            this.m_SearchButton.Icon = null;
            this.m_SearchButton.Location = new System.Drawing.Point(233, 13);
            this.m_SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_SearchButton.Name = "m_SearchButton";
            this.m_SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_SearchButton.Size = new System.Drawing.Size(128, 48);
            this.m_SearchButton.TabIndex = 6;
            this.m_SearchButton.Text = "Search";
            this.m_SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_SearchButton.UseAccentColor = false;
            this.m_SearchButton.UseVisualStyleBackColor = true;
            this.m_SearchButton.Click += new System.EventHandler(this.m_SearchButton_Click);
            // 
            // m_FilterBox
            // 
            this.m_FilterBox.AutoResize = false;
            this.m_FilterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_FilterBox.Depth = 0;
            this.m_FilterBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.m_FilterBox.DropDownHeight = 174;
            this.m_FilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_FilterBox.DropDownWidth = 121;
            this.m_FilterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.m_FilterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_FilterBox.FormattingEnabled = true;
            this.m_FilterBox.IntegralHeight = false;
            this.m_FilterBox.ItemHeight = 43;
            this.m_FilterBox.Location = new System.Drawing.Point(12, 13);
            this.m_FilterBox.MaxDropDownItems = 4;
            this.m_FilterBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_FilterBox.Name = "m_FilterBox";
            this.m_FilterBox.Size = new System.Drawing.Size(156, 49);
            this.m_FilterBox.StartIndex = 0;
            this.m_FilterBox.TabIndex = 7;
            this.m_FilterBox.SelectedIndexChanged += new System.EventHandler(this.m_FilterBox_SelectedIndexChanged);
            // 
            // m_QuitButton
            // 
            this.m_QuitButton.AutoSize = false;
            this.m_QuitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_QuitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_QuitButton.Depth = 0;
            this.m_QuitButton.HighEmphasis = true;
            this.m_QuitButton.Icon = null;
            this.m_QuitButton.Location = new System.Drawing.Point(867, 13);
            this.m_QuitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_QuitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_QuitButton.Name = "m_QuitButton";
            this.m_QuitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_QuitButton.Size = new System.Drawing.Size(128, 48);
            this.m_QuitButton.TabIndex = 8;
            this.m_QuitButton.Text = "Quit";
            this.m_QuitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_QuitButton.UseAccentColor = false;
            this.m_QuitButton.UseVisualStyleBackColor = true;
            this.m_QuitButton.Click += new System.EventHandler(this.m_QuitButton_Click);
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
            this.m_MenuButton.Location = new System.Drawing.Point(731, 13);
            this.m_MenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_MenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_MenuButton.Name = "m_MenuButton";
            this.m_MenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_MenuButton.Size = new System.Drawing.Size(128, 48);
            this.m_MenuButton.TabIndex = 9;
            this.m_MenuButton.Text = "Menu";
            this.m_MenuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_MenuButton.UseAccentColor = false;
            this.m_MenuButton.UseVisualStyleBackColor = true;
            this.m_MenuButton.Click += new System.EventHandler(this.m_MenuButton_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.m_MenuButton);
            this.Controls.Add(this.m_QuitButton);
            this.Controls.Add(this.m_FilterBox);
            this.Controls.Add(this.m_SearchButton);
            this.Controls.Add(this.m_SearchBox);
            this.Controls.Add(this.LeaderboardViewer);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LeaderboardViewer;
        private MaterialSkin.Controls.MaterialTextBox m_SearchBox;
        private MaterialSkin.Controls.MaterialButton m_SearchButton;
        private MaterialSkin.Controls.MaterialComboBox m_FilterBox;
        private MaterialSkin.Controls.MaterialButton m_QuitButton;
        private MaterialSkin.Controls.MaterialButton m_MenuButton;
    }
}