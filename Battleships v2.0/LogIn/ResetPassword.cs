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

namespace Battleships_v2._0
{
    public partial class ResetPassword : Form
    {
        #region CLASS VARIABLES
        private readonly SQLite sqlite = new SQLite();
        private readonly string source = Settings.SQLiteConnection;
        private readonly Hashing hashing = new Hashing();
        #endregion
        
        #region FORM FUNCTIONS
        public ResetPassword() { InitializeComponent(); }
        private void ResetPassword_Load(object _sender, EventArgs _e) { Init(); }
        private void m_ConfirmButton_Click(object sender, EventArgs e) { PasswordReset(); }
        private void m_ConfirmPasswordBox_TextChanged(object sender, EventArgs e) { EnableConfirmButton(); }
        private void m_PasswordBox_TextChanged(object sender, EventArgs e) { EnableConfirmButton(); }
        private void m_UsernameBox_TextChanged(object sender, EventArgs e) { EnableConfirmButton(); }
        private void m_UserIdBox_TextChanged(object sender, EventArgs e) { EnableConfirmButton(); }
        private void m_LogInButton_Click(object sender, EventArgs e) { ShowLogIn(); }
        #endregion

        #region PASSWORD RESET FUNCTIONS
        private void Init() { }
        private void PasswordReset()
        { // Resets the password
            // The new password is hashed
            string newPassword = hashing.MD5Hash(m_PasswordBox.Text);
            string command = $"UPDATE users SET password = '{newPassword}' WHERE user_id = {m_UserIdBox.Text};";

            if (m_UsernameBox.Text == GetUsername(m_UserIdBox.Text))
            {
                if (m_PasswordBox.Text == m_ConfirmPasswordBox.Text)
                { // If the username, id and the passwords match the new hashed password is replaced in the database
                    sqlite.WriteFromCommand(source, command);
                    Console.WriteLine(command);
                    MessageBox.Show("Success");
                }
            }
            // Shows log in form
            ShowLogIn();
        }
        private string GetUsername(string _userId)
        { // Gets the username with a given user id
            string command = $"SELECT username FROM users WHERE user_id = {_userId};";
            string username = sqlite.ReadToString(command, source);

            return username;
        }
        private void EnableConfirmButton()
        { // Enables the enter button if all of the boxes are not null
            if (m_UserIdBox.Text != "" && m_UsernameBox.Text != "" && m_PasswordBox.Text != "" &&
                m_ConfirmPasswordBox.Text != "" && m_PasswordBox.Text == m_ConfirmPasswordBox.Text)
            {
                m_ConfirmButton.Enabled = true;
            }
            else
            {
                m_ConfirmButton.Enabled = false;
            }
        }
        #endregion

        #region NAVIGATION
        private void ShowLogIn()
        {
            LogIn nextForm = new LogIn();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion
    }
}
