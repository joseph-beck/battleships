#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Battleships_v2._0 {
    public partial class Menu : Form {
        #region FORM FUNCTIONS
        public Menu() { InitializeComponent(); }
        private void Menu_Load(object _sender, EventArgs _e) { Init();}
        private void EditorButton_Click(object _sender, EventArgs _e) { ShowEditorBattleships(); }
        private void m_LeaderboardButton_Click(object _sender, EventArgs _e) { ShowLeaderboard(); }
        private void m_HistoryButton_Click(object _sender, EventArgs _e) { ShowHistory(); }
        private void m_ReplayButton_Click(object _sender, EventArgs _e) { ShowReplay(); }
        private void m_CreateGameButton_Click(object _sender, EventArgs _e) { ShowCreator(); }
        private void m_JoinGameButton_Click(object _sender, EventArgs _e) { ShowJoiner(); }
        private void m_QuitButton_Click(object sender, EventArgs e) { Quit.Exit(); }
        #endregion

        #region MENU FUNCTIONS
        private void Init()
        {
            m_CurrentUser.Text = CurrentUser.Username;
            m_CurrentId.Text = CurrentUser.UserId;
        }
        #endregion

        #region NAVIGATION
        /*private void ShowBattleships()
        {
            var nextForm = new Battleships();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }*/
        private void ShowEditorBattleships()
        {
            var nextForm = new EditorBattleships();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void ShowReplay()
        {
            var nextForm = new ReplaySelector();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void ShowLeaderboard()
        {
            var nextForm = new Leaderboard();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void ShowHistory()
        {
            var nextForm = new History();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void ShowCreator()
        {
            var nextForm = new GameCreator();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void ShowJoiner()
        {
            var nextForm = new GameJoiner();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion
    }
}
