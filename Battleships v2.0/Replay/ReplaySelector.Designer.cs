namespace Battleships_v2._0
{
    partial class ReplaySelector
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
            this.SelectorListView = new System.Windows.Forms.ListView();
            this.m_MenuButton = new MaterialSkin.Controls.MaterialButton();
            this.m_OpenButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // SelectorListView
            // 
            this.SelectorListView.HideSelection = false;
            this.SelectorListView.Location = new System.Drawing.Point(12, 12);
            this.SelectorListView.Name = "SelectorListView";
            this.SelectorListView.Size = new System.Drawing.Size(776, 349);
            this.SelectorListView.TabIndex = 0;
            this.SelectorListView.UseCompatibleStateImageBehavior = false;
            this.SelectorListView.SelectedIndexChanged += new System.EventHandler(this.SelectorListView_SelectedIndexChanged);
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
            this.m_MenuButton.Location = new System.Drawing.Point(13, 387);
            this.m_MenuButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_MenuButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_MenuButton.Name = "m_MenuButton";
            this.m_MenuButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_MenuButton.Size = new System.Drawing.Size(128, 48);
            this.m_MenuButton.TabIndex = 10;
            this.m_MenuButton.Text = "Menu";
            this.m_MenuButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_MenuButton.UseAccentColor = false;
            this.m_MenuButton.UseVisualStyleBackColor = true;
            this.m_MenuButton.Click += new System.EventHandler(this.m_MenuButton_Click);
            // 
            // m_OpenButton
            // 
            this.m_OpenButton.AutoSize = false;
            this.m_OpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_OpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_OpenButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_OpenButton.Depth = 0;
            this.m_OpenButton.HighEmphasis = true;
            this.m_OpenButton.Icon = null;
            this.m_OpenButton.Location = new System.Drawing.Point(659, 387);
            this.m_OpenButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_OpenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_OpenButton.Name = "m_OpenButton";
            this.m_OpenButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_OpenButton.Size = new System.Drawing.Size(128, 48);
            this.m_OpenButton.TabIndex = 11;
            this.m_OpenButton.Text = "Open";
            this.m_OpenButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_OpenButton.UseAccentColor = false;
            this.m_OpenButton.UseVisualStyleBackColor = true;
            this.m_OpenButton.Click += new System.EventHandler(this.m_OpenButton_Click);
            // 
            // ReplaySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_OpenButton);
            this.Controls.Add(this.m_MenuButton);
            this.Controls.Add(this.SelectorListView);
            this.Name = "ReplaySelector";
            this.Text = "ReplaySelector";
            this.Load += new System.EventHandler(this.ReplaySelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView SelectorListView;
        private MaterialSkin.Controls.MaterialButton m_MenuButton;
        private MaterialSkin.Controls.MaterialButton m_OpenButton;
    }
}