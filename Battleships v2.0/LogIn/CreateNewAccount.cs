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
using System.Windows.Forms.VisualStyles;
#endregion

namespace Battleships_v2._0 
{
    public partial class CreateNewAccount : Form 
    {
        #region CLASS VARIABLES
        private Hashing hashing = new Hashing();
        private SQLite sqlite = new SQLite();
        private readonly string source = "..\\databases\\test-database";

        private string userId;
        #endregion

        #region FORM FUNCTIONS
        public CreateNewAccount() { InitializeComponent(); }
        private void CreateNewAccount_Load(object _sender, EventArgs _e) { }
        private void m_UsernameBox_TextChanged(object sender, EventArgs e) { EnableCreateButton(); }
        private void m_PasswordConfirm_TextChanged(object sender, EventArgs e) { EnableCreateButton(); }
        private void m_FirstNameBox_TextChanged(object sender, EventArgs e) { EnableCreateButton(); }
        private void m_LastNameBox_TextChanged(object sender, EventArgs e) { EnableCreateButton(); }
        private void m_PasswordBox_TextChanged(object sender, EventArgs e) { EnableCreateButton(); }
        private void m_CreateAccountButton_Click(object sender, EventArgs e) { CreateAccount(); }
        private void m_LogInButton_Click(object sender, EventArgs e) { ShowLogIn(); }
        #endregion

        #region CREATE ACCOUNT FUNCTIONS
        private void CreateAccount() 
        { // Creates the account
            if (m_PasswordBox.Text != m_PasswordConfirm.Text)
            { // If the passwords aren't the same the user must try again
                MessageBox.Show("Passwords do not match!");
                ResetTextBoxes();
                return;
            }

            string[] input = { m_UsernameBox.Text, m_FirstNameBox.Text, m_LastNameBox.Text, m_PasswordBox.Text };

            InsertIntoTable(input);
            MessageBox.Show($"Account Created! \n User ID: {userId}");
            ShowLogIn();
        }
        private void EnableCreateButton()
        { // Enables the create account button if the text boxes aren't empty
            // Prevents insertion of null data
            if (m_UsernameBox.Text != "" && m_FirstNameBox.Text != "" && m_LastNameBox.Text != "" &&
                m_PasswordBox.Text != "" && m_PasswordConfirm.Text != "" && m_PasswordBox.Text == m_PasswordConfirm.Text)
            {
                m_CreateAccountButton.Enabled = true;
            }
            else
            {
                m_CreateAccountButton.Enabled = false;
            }
        }
        private void InsertIntoTable(string[] _input) 
        { // Inserts the new user into the table of users
            string command = $"INSERT INTO users (user_id, username, first_name, last_name, password) " +
                             $"VALUES({GenerateUserId()}, '{_input[0]}', '{_input[1]}', '{_input[2]}','{hashing.MD5Hash(_input[3])}');";

            sqlite.WriteFromCommand(source, command);
        }
        private string GenerateUserId() 
        { // Generates a new user id
            string[] GetExistingIds() 
            { // Gets existing user ids 
                string command = "SELECT user_id FROM users;";
                string[] ids = sqlite.ReadTo1DArray(command, source, 0);
                return ids;
            }

            var rand = new Random();
            bool unique = false;
            string id = "";

            while (!unique) 
            { // Ensures that the username is unique, if it isn't continues looping till it is
                id = "";

                for (int i = 0; i < 5; i++) 
                {
                    id += rand.Next(0, 9).ToString();
                }
                if (!GetExistingIds().Contains(id)) unique = true;
            }

            userId = id;
            return id;
        }
        private void ResetTextBoxes()
        { // Resets the text boxes
            m_UsernameBox.Text = "";
            m_FirstNameBox.Text = "";
            m_LastNameBox.Text = "";
            m_PasswordBox.Text = "";
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
