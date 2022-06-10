namespace Battleships_v2._0
{
    partial class GameCreator
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
            this.m_GridSize = new MaterialSkin.Controls.MaterialComboBox();
            this.m_GameMode = new MaterialSkin.Controls.MaterialComboBox();
            this.m_StartButton = new MaterialSkin.Controls.MaterialButton();
            this.m_MenuButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // m_GridSize
            // 
            this.m_GridSize.AutoResize = false;
            this.m_GridSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_GridSize.Depth = 0;
            this.m_GridSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.m_GridSize.DropDownHeight = 174;
            this.m_GridSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_GridSize.DropDownWidth = 121;
            this.m_GridSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.m_GridSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_GridSize.FormattingEnabled = true;
            this.m_GridSize.Hint = "Grid Size";
            this.m_GridSize.IntegralHeight = false;
            this.m_GridSize.ItemHeight = 43;
            this.m_GridSize.Location = new System.Drawing.Point(328, 126);
            this.m_GridSize.MaxDropDownItems = 4;
            this.m_GridSize.MouseState = MaterialSkin.MouseState.OUT;
            this.m_GridSize.Name = "m_GridSize";
            this.m_GridSize.Size = new System.Drawing.Size(128, 49);
            this.m_GridSize.StartIndex = -1;
            this.m_GridSize.TabIndex = 0;
            this.m_GridSize.SelectedIndexChanged += new System.EventHandler(this.m_GridSize_SelectedIndexChanged);
            // 
            // m_GameMode
            // 
            this.m_GameMode.AutoResize = false;
            this.m_GameMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_GameMode.Depth = 0;
            this.m_GameMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.m_GameMode.DropDownHeight = 174;
            this.m_GameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_GameMode.DropDownWidth = 121;
            this.m_GameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.m_GameMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_GameMode.FormattingEnabled = true;
            this.m_GameMode.Hint = "Gamemode";
            this.m_GameMode.IntegralHeight = false;
            this.m_GameMode.ItemHeight = 43;
            this.m_GameMode.Location = new System.Drawing.Point(328, 181);
            this.m_GameMode.MaxDropDownItems = 4;
            this.m_GameMode.MouseState = MaterialSkin.MouseState.OUT;
            this.m_GameMode.Name = "m_GameMode";
            this.m_GameMode.Size = new System.Drawing.Size(128, 49);
            this.m_GameMode.StartIndex = 0;
            this.m_GameMode.TabIndex = 1;
            this.m_GameMode.SelectedIndexChanged += new System.EventHandler(this.m_GameMode_SelectedIndexChanged);
            // 
            // m_StartButton
            // 
            this.m_StartButton.AutoSize = false;
            this.m_StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_StartButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_StartButton.Depth = 0;
            this.m_StartButton.Enabled = false;
            this.m_StartButton.HighEmphasis = true;
            this.m_StartButton.Icon = null;
            this.m_StartButton.Location = new System.Drawing.Point(328, 239);
            this.m_StartButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_StartButton.Name = "m_StartButton";
            this.m_StartButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_StartButton.Size = new System.Drawing.Size(128, 48);
            this.m_StartButton.TabIndex = 2;
            this.m_StartButton.Text = "Start Game";
            this.m_StartButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_StartButton.UseAccentColor = false;
            this.m_StartButton.UseVisualStyleBackColor = true;
            this.m_StartButton.Click += new System.EventHandler(this.m_StartButton_Click);
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
            this.m_MenuButton.Location = new System.Drawing.Point(328, 299);
            this.m_MenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_MenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_MenuButton.Name = "m_MenuButton";
            this.m_MenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_MenuButton.Size = new System.Drawing.Size(128, 48);
            this.m_MenuButton.TabIndex = 12;
            this.m_MenuButton.Text = "Menu";
            this.m_MenuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_MenuButton.UseAccentColor = false;
            this.m_MenuButton.UseVisualStyleBackColor = true;
            this.m_MenuButton.Click += new System.EventHandler(this.m_MenuButton_Click);
            // 
            // GameCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_MenuButton);
            this.Controls.Add(this.m_StartButton);
            this.Controls.Add(this.m_GameMode);
            this.Controls.Add(this.m_GridSize);
            this.Name = "GameCreator";
            this.Text = "GameCreator";
            this.Load += new System.EventHandler(this.GameCreator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox m_GridSize;
        private MaterialSkin.Controls.MaterialComboBox m_GameMode;
        private MaterialSkin.Controls.MaterialButton m_StartButton;
        private MaterialSkin.Controls.MaterialButton m_MenuButton;
    }
}