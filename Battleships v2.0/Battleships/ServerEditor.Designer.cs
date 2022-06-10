namespace Battleships_v2._0
{
    partial class ServerEditor
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
            this.LobbyIdLabel = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LobbyIdLabel
            // 
            this.LobbyIdLabel.AutoSize = true;
            this.LobbyIdLabel.Location = new System.Drawing.Point(348, 502);
            this.LobbyIdLabel.Name = "LobbyIdLabel";
            this.LobbyIdLabel.Size = new System.Drawing.Size(53, 13);
            this.LobbyIdLabel.TabIndex = 9;
            this.LobbyIdLabel.Text = "Lobby ID:";
            this.LobbyIdLabel.Click += new System.EventHandler(this.LobbyIdLabel_Click);
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // ServerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.LobbyIdLabel);
            this.Name = "ServerEditor";
            this.Text = "ServerEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerEditor_FormClosing);
            this.Load += new System.EventHandler(this.ServerEditor_Load);
            this.Controls.SetChildIndex(this.LobbyIdLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LobbyIdLabel;
        private System.Windows.Forms.Timer Tick;
        protected new MaterialSkin.Controls.MaterialButton m_MenuButton;
    }
}