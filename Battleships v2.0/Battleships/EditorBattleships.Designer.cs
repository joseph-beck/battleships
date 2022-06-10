namespace Battleships_v2._0
{
    partial class EditorBattleships
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
            this.PlayerPanel = new System.Windows.Forms.Panel();
            this.Connect = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.RecieveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.EnemyPanel = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.AutoSize = true;
            this.PlayerPanel.Location = new System.Drawing.Point(12, 12);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(220, 120);
            this.PlayerPanel.TabIndex = 1;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(713, 415);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(632, 415);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // RecieveButton
            // 
            this.RecieveButton.Location = new System.Drawing.Point(551, 415);
            this.RecieveButton.Name = "RecieveButton";
            this.RecieveButton.Size = new System.Drawing.Size(75, 23);
            this.RecieveButton.TabIndex = 4;
            this.RecieveButton.Text = "Recieve";
            this.RecieveButton.UseVisualStyleBackColor = true;
            this.RecieveButton.Click += new System.EventHandler(this.RecieveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(470, 415);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Ticker
            // 
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // EnemyPanel
            // 
            this.EnemyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnemyPanel.AutoSize = true;
            this.EnemyPanel.Location = new System.Drawing.Point(578, 12);
            this.EnemyPanel.Name = "EnemyPanel";
            this.EnemyPanel.Size = new System.Drawing.Size(210, 110);
            this.EnemyPanel.TabIndex = 2;
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(93, 415);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 6;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(12, 415);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 7;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(389, 415);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditorBattleships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.EnemyPanel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RecieveButton);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.PlayerPanel);
            this.Name = "EditorBattleships";
            this.Text = "EditorBattleships";
            this.Load += new System.EventHandler(this.EditorBattleships_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PlayerPanel;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button RecieveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Timer Ticker;
        private System.Windows.Forms.Panel EnemyPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}