#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Battleships_v2._0
{
    public partial class History : Form
    {
        #region CLASS VARIABLES
        private readonly string source = Settings.SQLiteConnection;
        private readonly ConsoleOutputs consoleOutputs = new ConsoleOutputs();
        private SQLite sqlite = new SQLite();
        #endregion

        #region FORM FUNCTIOSN
        public History() { InitializeComponent(); }
        private void History_Load(object _sender, EventArgs _e) { Init(); }
        private void SearchBar_TextChanged(object _sender, EventArgs _e) { SearchBarChange(); }
        private void SearchButton_Click(object _sender, EventArgs _e) { Search(); }
        private void MyHistoryButton_Click(object _sender, EventArgs _e) { GetMyHistory(); }
        private void m_SearchBox_TextChanged(object _sender, EventArgs _e) { SearchBarChange(); }
        private void m_SearchButton_Click(object _sender, EventArgs _e) { Search(); }
        private void m_MyHistoryButton_Click(object _sender, EventArgs _e) { GetMyHistory(); }
        private void m_MenuButton_Click(object sender, EventArgs e) { ShowMenu(); }
        private void m_QuitButton_Click(object _sender, EventArgs _e) { Quit.Exit(); }
        #endregion

        #region HISTORY FUNCTIONS
        private void Init()
        {

        }
        private void PopulateDataGrid(string[,] _input)
        { // Populates the grid view with a given input
            if (_input == null || _input.Length == 0)
            {
                MessageBox.Show("User does not exist!");
                return;
            }

            // Determines the dimensions of the grid view
            int height = _input.GetLength(0);
            int width = _input.GetLength(1) ;

            // Resets the grid view of all previous data
            HistoryViewer.Rows.Clear();
            HistoryViewer.ColumnCount = width;

            for (int i = 0; i < height; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(HistoryViewer);

                for (int j = 0; j < width; j++)
                { // Creates a row from input data to be added to the grid view
                    row.Cells[j].Value = _input[i, j];
                }
                HistoryViewer.Rows.Add(row);

                if (i % 2 != 0 && i + 1 != height) 
                { // This creates a blank row between each game
                    // This helps to provide greater visual clarity
                    DataGridViewRow blank = new DataGridViewRow();
                    blank.CreateCells(HistoryViewer);

                    for (int k = 0; k < width; k++)
                    {
                        blank.Cells[k].Value = "";
                    }
                    HistoryViewer.Rows.Add(blank);
                }
            }

            // Sets the headers of the grid view
            HistoryViewer.Columns[0].HeaderText = "Username";
            HistoryViewer.Columns[1].HeaderText = "Score";
            HistoryViewer.Columns[2].HeaderText = "Shots";
            HistoryViewer.Columns[3].HeaderText = "Hits";
            HistoryViewer.Columns[4].HeaderText = "Misses";

            HistoryViewer.ResetBindings();
        }
        private string[,] FormatHistory(string[,] _input)
        { // Formats the 2D array so that
            // It is interpretable by the populator
            int height = _input.GetLength(0) * 2;
            int width = 5;

            string[,] data = new string[height, width];

            for (int i = 0; i < _input.GetLength(0); i++)
            {
                data[2 * i, 0] = _input[i, 1];      // User 1 name
                data[2 * i, 1] = _input[i, 3];      // User 1 score
                data[2 * i, 2] = _input[i, 5];      // User 1 shots
                data[2 * i, 3] = _input[i, 7];      // User 1 hits
                data[2 * i, 4] = _input[i, 9];      // User 1 misses

                data[2 * i + 1, 0] = _input[i, 2];  // User 2 name
                data[2 * i + 1, 1] = _input[i, 4];  // User 2 score
                data[2 * i + 1, 2] = _input[i, 6];  // User 2 shots
                data[2 * i + 1, 3] = _input[i, 8];  // User 2 hits
                data[2 * i + 1, 4] = _input[i, 10]; // User 2 misses
            }

            return data;
        }
        private string[,] GetHistoryData(string _userId)
        { // SQL query that returns data based on a search
            string command = "SELECT game_result.* " +
                             "FROM game_result " +
                             "LEFT JOIN history on game_result.game_result_id = history.game_result_id " +
                             $"WHERE user_id = {_userId};";

            // Uses SQLite functionality to return to a 2D array
            string[,] data = sqlite.ReadTo2DArray(command, source);

            return data;
        }
        private void GetMyHistory()
        { // Returns the history of the currently logged in user
            if (CurrentUser.UserId == null)
            {
                MessageBox.Show("No user currently logged in!");
                m_MyHistoryButton.Enabled = false;
                return;
            }

            string[,] data = GetHistoryData(CurrentUser.UserId);
            consoleOutputs.Console2D(data);

            string[,] finalised = FormatHistory(data);
            consoleOutputs.Console2D(finalised);

            PopulateDataGrid(finalised);
        }
        private void Search()
        { // Returns the data of the searched for user
            string[,] data = GetHistoryData(m_SearchBox.Text);
            consoleOutputs.Console2D(data);

            string[,] finalised = FormatHistory(data);
            consoleOutputs.Console2D(finalised);

            PopulateDataGrid(finalised);
            m_SearchBox.Text = "";
        }
        private void SearchBarChange()
        { // Disables the search bar if null
            if (m_SearchBox.Text != "")
            {
                m_SearchButton.Enabled = true;
                return;
            }
            m_SearchButton.Enabled = false;
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