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
using System.Configuration;
#endregion

namespace Battleships_v2._0 {
    public partial class LogIn : Form {
        #region CLASS VARIABLES
        private Hashing hasing = new Hashing();
        private SQLite sqlite = new SQLite();
        private readonly string source = Settings.SQLiteConnection;
        //private readonly string source = "..\\databases\\test-database";
        #endregion

        #region FORM FUCNTIONS
        public LogIn() { InitializeComponent(); }
        private void LogIn_Load(object _sender, EventArgs _e) { }
        private void m_PasswordBox_TextChanged(object sender, EventArgs e) { EnableEnterButton(); }
        private void m_UserIdBox_TextChanged(object sender, EventArgs e) { EnableEnterButton(); }
        private void m_UsernameBox_TextChanged(object sender, EventArgs e) { EnableEnterButton(); }
        private void m_CreateAccount_Click(object sender, EventArgs e) { ShowCreateNewAccount(); }
        private void m_ResetPassword_Click(object sender, EventArgs e) { ShowPasswordReset(); }
        private void m_EnterButton_Click(object sender, EventArgs e) { TryLogIn(); }
        #endregion

        #region LOG IN FUNCTIONS
        private void TryLogIn() 
        { // Tries to log the user in
            // Commands to get individual variables for both password and username
            string password = sqlite.ReadToString($"SELECT password FROM users WHERE user_id = {m_UserIdBox.Text};", source);
            string username = sqlite.ReadToString($"SELECT username FROM users WHERE user_id = {m_UserIdBox.Text};", source);

            if (username != m_UsernameBox.Text)
            { // Incorrect username occurrence
                MessageBox.Show("Username and ID do not match!");
                return;
            }

            if (hasing.MD5Hash(m_PasswordBox.Text) == password) 
            { // When password is correct the current user is initiated
                MessageBox.Show("Success");

                string[,] userData = sqlite.ReadTo2DArray($"SELECT * FROM users WHERE username = '{m_UsernameBox.Text}';", source);
                CurrentUser.Init(userData[0, 0], userData[0, 1], userData[0, 2], userData[0, 3]);

                ShowMenu();
            }
            else 
            { // Otherwise incorrect password
                MessageBox.Show("Failure - try again");
                Reset();
            }
        }
        private void EnableEnterButton()
        { // Checks whether the boxes have any data in to enable the enter button
            if (m_UserIdBox.Text != "" && m_UsernameBox.Text != "" && m_PasswordBox.Text != "")
            {
                m_EnterButton.Enabled = true;
            }
            else
            {
                m_EnterButton.Enabled = false;
            }
        }
        private void Reset()
        {
            m_UserIdBox.Text = "";
            m_UsernameBox.Text = "";
            m_PasswordBox.Text = "";
        }
        #endregion

        #region NAVIGATION
        private void ShowPasswordReset()
        {
            ResetPassword nextForm = new ResetPassword();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void ShowCreateNewAccount()
        {
            CreateNewAccount nextForm = new CreateNewAccount();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void ShowMenu()
        {
            Menu nextForm = new Menu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion
    }
}
