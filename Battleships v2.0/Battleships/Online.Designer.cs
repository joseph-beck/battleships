namespace Battleships_v2._0
{
    partial class Online
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
            this.FirebaseTick = new System.Windows.Forms.Timer(this.components);
            this.m_LobbyIdLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // FirebaseTick
            // 
            this.FirebaseTick.Interval = 200;
            this.FirebaseTick.Tick += new System.EventHandler(this.FirebaseTick_Tick);
            // 
            // m_LobbyIdLabel
            // 
            this.m_LobbyIdLabel.AutoSize = true;
            this.m_LobbyIdLabel.Depth = 0;
            this.m_LobbyIdLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_LobbyIdLabel.Location = new System.Drawing.Point(115, 503);
            this.m_LobbyIdLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_LobbyIdLabel.Name = "m_LobbyIdLabel";
            this.m_LobbyIdLabel.Size = new System.Drawing.Size(68, 19);
            this.m_LobbyIdLabel.TabIndex = 9;
            this.m_LobbyIdLabel.Text = "Lobby ID:";
            // 
            // Online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.m_LobbyIdLabel);
            this.Name = "Online";
            this.Text = "Battleships";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Online_FormClosing);
            this.Load += new System.EventHandler(this.Online_Load);
            this.Controls.SetChildIndex(this.m_ResetButton, 0);
            this.Controls.SetChildIndex(this.m_MenuButton, 0);
            this.Controls.SetChildIndex(this.m_LobbyIdLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer FirebaseTick;
        private MaterialSkin.Controls.MaterialLabel m_LobbyIdLabel;
    }
}