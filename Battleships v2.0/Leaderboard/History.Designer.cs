namespace Battleships_v2._0
{
    partial class History
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
            this.m_SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.m_SearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.m_MyHistoryButton = new MaterialSkin.Controls.MaterialButton();
            this.m_QuitButton = new MaterialSkin.Controls.MaterialButton();
            this.HistoryViewer = new System.Windows.Forms.DataGridView();
            this.m_MenuButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryViewer)).BeginInit();
            this.SuspendLayout();
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
            this.m_SearchButton.Location = new System.Drawing.Point(478, 15);
            this.m_SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_SearchButton.Name = "m_SearchButton";
            this.m_SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_SearchButton.Size = new System.Drawing.Size(128, 48);
            this.m_SearchButton.TabIndex = 10;
            this.m_SearchButton.Text = "Search";
            this.m_SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_SearchButton.UseAccentColor = false;
            this.m_SearchButton.UseVisualStyleBackColor = true;
            this.m_SearchButton.Click += new System.EventHandler(this.m_SearchButton_Click);
            // 
            // m_SearchBox
            // 
            this.m_SearchBox.AnimateReadOnly = false;
            this.m_SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_SearchBox.Depth = 0;
            this.m_SearchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_SearchBox.Hint = "Enter ID";
            this.m_SearchBox.LeadingIcon = null;
            this.m_SearchBox.Location = new System.Drawing.Point(343, 13);
            this.m_SearchBox.MaxLength = 50;
            this.m_SearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_SearchBox.Multiline = false;
            this.m_SearchBox.Name = "m_SearchBox";
            this.m_SearchBox.Size = new System.Drawing.Size(128, 50);
            this.m_SearchBox.TabIndex = 9;
            this.m_SearchBox.Text = "";
            this.m_SearchBox.TrailingIcon = null;
            this.m_SearchBox.TextChanged += new System.EventHandler(this.m_SearchBox_TextChanged);
            // 
            // m_MyHistoryButton
            // 
            this.m_MyHistoryButton.AutoSize = false;
            this.m_MyHistoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_MyHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_MyHistoryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_MyHistoryButton.Depth = 0;
            this.m_MyHistoryButton.HighEmphasis = true;
            this.m_MyHistoryButton.Icon = null;
            this.m_MyHistoryButton.Location = new System.Drawing.Point(13, 15);
            this.m_MyHistoryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_MyHistoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_MyHistoryButton.Name = "m_MyHistoryButton";
            this.m_MyHistoryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_MyHistoryButton.Size = new System.Drawing.Size(128, 48);
            this.m_MyHistoryButton.TabIndex = 11;
            this.m_MyHistoryButton.Text = "My History";
            this.m_MyHistoryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_MyHistoryButton.UseAccentColor = false;
            this.m_MyHistoryButton.UseVisualStyleBackColor = true;
            this.m_MyHistoryButton.Click += new System.EventHandler(this.m_MyHistoryButton_Click);
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
            this.m_QuitButton.Location = new System.Drawing.Point(869, 13);
            this.m_QuitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_QuitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_QuitButton.Name = "m_QuitButton";
            this.m_QuitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_QuitButton.Size = new System.Drawing.Size(128, 48);
            this.m_QuitButton.TabIndex = 12;
            this.m_QuitButton.Text = "Quit";
            this.m_QuitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_QuitButton.UseAccentColor = false;
            this.m_QuitButton.UseVisualStyleBackColor = true;
            this.m_QuitButton.Click += new System.EventHandler(this.m_QuitButton_Click);
            // 
            // HistoryViewer
            // 
            this.HistoryViewer.AllowUserToAddRows = false;
            this.HistoryViewer.AllowUserToDeleteRows = false;
            this.HistoryViewer.AllowUserToResizeColumns = false;
            this.HistoryViewer.AllowUserToResizeRows = false;
            this.HistoryViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HistoryViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HistoryViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryViewer.Enabled = false;
            this.HistoryViewer.Location = new System.Drawing.Point(12, 72);
            this.HistoryViewer.MultiSelect = false;
            this.HistoryViewer.Name = "HistoryViewer";
            this.HistoryViewer.ReadOnly = true;
            this.HistoryViewer.RowHeadersWidth = 10;
            this.HistoryViewer.RowTemplate.Height = 24;
            this.HistoryViewer.RowTemplate.ReadOnly = true;
            this.HistoryViewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HistoryViewer.Size = new System.Drawing.Size(984, 455);
            this.HistoryViewer.TabIndex = 13;
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
            this.m_MenuButton.Location = new System.Drawing.Point(733, 13);
            this.m_MenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_MenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_MenuButton.Name = "m_MenuButton";
            this.m_MenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_MenuButton.Size = new System.Drawing.Size(128, 48);
            this.m_MenuButton.TabIndex = 14;
            this.m_MenuButton.Text = "Menu";
            this.m_MenuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_MenuButton.UseAccentColor = false;
            this.m_MenuButton.UseVisualStyleBackColor = true;
            this.m_MenuButton.Click += new System.EventHandler(this.m_MenuButton_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.m_MenuButton);
            this.Controls.Add(this.HistoryViewer);
            this.Controls.Add(this.m_QuitButton);
            this.Controls.Add(this.m_MyHistoryButton);
            this.Controls.Add(this.m_SearchButton);
            this.Controls.Add(this.m_SearchBox);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton m_SearchButton;
        private MaterialSkin.Controls.MaterialTextBox m_SearchBox;
        private MaterialSkin.Controls.MaterialButton m_MyHistoryButton;
        private MaterialSkin.Controls.MaterialButton m_QuitButton;
        private System.Windows.Forms.DataGridView HistoryViewer;
        private MaterialSkin.Controls.MaterialButton m_MenuButton;
    }
}