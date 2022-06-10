#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

#endregion

namespace Battleships_v2._0 
{
    public partial class Leaderboard : Form 
    {
        #region CLASS VARIABLES
        private const string _WINSASC = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " +
                                         "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                                         "ORDER BY wins, username;";
        private const string _GAMESASC = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " +
                                         "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                                         "ORDER BY games_played, username;";
        private const string _ELOASC = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " +
                                         "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                                         "ORDER BY elo DESC, username;";
        private const string _WINSDESC = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " +
                                         "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                                         "ORDER BY wins DESC, username;";
        private const string _GAMESDESC = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " +
                                         "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                                         "ORDER BY games_played DESC, username;";
        private const string _ELODESC = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " +
                                         "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                                         "ORDER BY elo, username;";
        private readonly string source = Settings.SQLiteConnection;
        private SQLite sqlite = new SQLite();
        private ConsoleOutputs consoleOutputs = new ConsoleOutputs();
        private static string[] Filters =
        {
            "Wins",
            "Games Played",
            "Elo"
        };
        #endregion

        #region FORM FUNCTIONS
        public Leaderboard() { InitializeComponent(); }
        private void Leaderboard_Load(object _sender, EventArgs _e) { Init(); }
        private void SearchButton_Click(object _sender, EventArgs _e) { Search(); }
        private void SearchBar_TextChanged(object _sender, EventArgs _e) { SearchBarEmpty(); }
        private void FilterSelector_SelectedIndexChanged(object _sender, EventArgs _e) { FilterChanged(); }
        private void m_SearchButton_Click(object _sender, EventArgs _e) { Search(); }
        private void m_SearchBox_TextChanged(object _sender, EventArgs _e) { SearchBarEmpty(); }
        private void m_FilterBox_SelectedIndexChanged(object _sender, EventArgs _e) { FilterChanged(); }
        private void LeaderboardViewer_CellContentClick(object _sender, DataGridViewCellEventArgs _e) { }
        private void m_MenuButton_Click(object sender, EventArgs e) { ShowMenu(); }
        private void m_QuitButton_Click(object sender, EventArgs e) { Quit.Exit(); }
        #endregion

        #region LEADERBOARD FUNCTIONS
        private void Init()
        {
            for (int i = 0; i < Filters.Length; i++)
            {
                m_FilterBox.Items.Add(Filters[i]);
            }

            m_FilterBox.StartIndex = 0;
        }
        private void PopulateDatagrid(string[,] _input)
        { // Populates the datagrid view with a given input
            if (_input == null || _input.Length == 0)
            {
                return;
            }

            Console.WriteLine("TEST");

            // Defines values such as width and height of the grid view
            int height = _input.GetLength(0);
            int width = _input.GetLength(1) - 1;

            // Resets the grid view in case there is already data present
            LeaderboardViewer.Rows.Clear();
            LeaderboardViewer.ColumnCount = width;
            
            for (int i = 0; i < height; i++)
            { // Iterates through the given data and adds it to the grid view
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(LeaderboardViewer);

                for (int j = 0; j < width; j++)
                { // Constructs a row to be added
                    row.Cells[j].Value = _input[i, j];
                }
                LeaderboardViewer.Rows.Add(row);
            }

            // Adds the headers
            LeaderboardViewer.Columns[0].HeaderText = "Username";
            LeaderboardViewer.Columns[1].HeaderText = "Wins";
            LeaderboardViewer.Columns[2].HeaderText = "Losses";
            LeaderboardViewer.Columns[3].HeaderText = "Games Played";
            LeaderboardViewer.Columns[4].HeaderText = "Elo";

            LeaderboardViewer.ResetBindings();
            // Populate data grid with the array.
        }
        private void SearchBarEmpty()
        { // If the search bar is empty then it will be disabled so the user cannot search for null
            if (m_SearchBox.Text == "")
            {
                m_SearchButton.Enabled = false;
                return;
            }
            m_SearchButton.Enabled = true;
        }
        private void FilterChanged()
        { // Updates the grid view if a filter is changed
            int index = m_FilterBox.SelectedIndex;
            string filter = Filters[index];

            Console.WriteLine(filter);
            string[,] data = null;

            // A 2D array, data, is populated with the selected filter
            // The SQL commands are constants stored as class variables
            if (filter == "Wins")
            {
                data = sqlite.ReadTo2DArray(_WINSDESC, source);
            }
            else if (filter == "Games Played")
            {
                data = sqlite.ReadTo2DArray(_GAMESDESC, source);
            }
            else if (filter == "Elo")
            {
                 data = sqlite.ReadTo2DArray(_ELOASC, source);
            }

            //The grid view is then populated with the data
            consoleOutputs.Console2D(data);
            PopulateDatagrid(data);
        }

        private void Search()
        { // Allows the user to search for a desired user or user id
            string command = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " + 
                             "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                             $"WHERE username = '{m_SearchBox.Text}' " +
                             "ORDER BY games_played, username;";

            string[,] data = sqlite.ReadTo2DArray(command, source);
            PopulateDatagrid(data);

            if (data.Length == 0)
            { // If there is no data for the username is then tries to query the user id
                command = "SELECT users.username, stats.wins, stats.losses, stats.games_played, stats.elo, stats.user_id " +
                          "FROM stats INNER JOIN users ON stats.user_id = users.user_id " +
                          $"WHERE stats.user_id = {m_SearchBox.Text} " +
                          "ORDER BY games_played, username;";

                data = sqlite.ReadTo2DArray(command, source);
                PopulateDatagrid(data);
            }
            else if (data.Length == 0)
            {
                MessageBox.Show("User does not exist!");
            }

            consoleOutputs.Console2D(data);
            m_SearchBox.Text = "";
        }
        #endregion

        #region NAVIGATION
        private void ShowMenu()
        {
            var nextForm = new Menu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion
    }   
}
