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
    public partial class Replay : Form 
    {
        #region CONSTRUCTOR
        public Replay(string _fileName)
        {
            fileName = _fileName;
            fromFile = fileHandler.Get2DArrayFromFile($"{Settings.ReplayPath}\\{fileName}", "%");
            playerGridData = new string[fromFile.GetLength(1)];
            enemyGridData = new string[fromFile.GetLength(1)];
            totalTurns = playerGridData.Length - 1;
            gridSize = 10;
            playerGrid = new Button[gridSize, gridSize];
            enemyGrid = new Button[gridSize, gridSize];

            InitializeComponent();
        }
        #endregion

        #region CLASS VARIABLES
        private static FileHandling fileHandler = new FileHandling();
        private static ConsoleOutputs consoleOutputs = new ConsoleOutputs();
        private static string[,] fromFile;
        private static string[] playerGridData;
        private static string[] enemyGridData;
        private readonly Button[,] playerGrid;
        private readonly Button[,] enemyGrid;
        private static int gridSize;
        private static string fileName;
        private readonly int totalTurns;
        private int index = 0;
        #endregion

        #region FORM FUNCTIONS
        private void Replay_Load(object _sender, EventArgs _e) { Init(); }
        private void NextButton_Click(object _sender, EventArgs _e) { OnNextButton(); }
        private void PreviousButton_Click(object _sender, EventArgs _e) { OnPreviousButton(); }
        private void SelectorButton_Click(object _sender, EventArgs _e) { ShowSelector(); }
        private void m_MenuButton_Click(object _sender, EventArgs _e) { ShowMenu(); }
        private void m_BackButton_Click(object _sender, EventArgs _e) { OnPreviousButton(); }
        private void m_NextButton_Click(object _sender, EventArgs _e) { OnNextButton(); }
        private void m_SelectorButton_Click(object _sender, EventArgs _e) { ShowSelector(); }
        #endregion

        #region REPLAY FUNCTIONS
        private void Init() 
        {
            PopulateFromFile();
            CreateGrid(playerGrid, PlayerPanel);
            CreateGrid(enemyGrid, EnemyPanel);
            EnableDisable(playerGrid, false);
            EnableDisable(enemyGrid, false);
            InterpretGridString(playerGrid, playerGridData, index);
            InterpretGridString(enemyGrid, enemyGridData, index);
            IndexCheck(index);
        }
        private void OnNextButton() 
        { // When the user presses the next button the index is shifted showing the next frame
            index++;

            InterpretGridString(playerGrid, playerGridData, index);
            InterpretGridString(enemyGrid, enemyGridData, index);
            IndexCheck(index);
        }
        private void OnPreviousButton() 
        { // When the user presses the previous button the index is shifted showing the previous frame
            index--;

            InterpretGridString(playerGrid, playerGridData, index);
            InterpretGridString(enemyGrid, enemyGridData, index);
            IndexCheck(index);
        }

        private void CreateGrid(Button[,] _grid, Panel _panel) 
        {
            int x = 0, y = 0;
            _panel.Controls.Clear();

            for (int i = 0; i < gridSize; i++) {
                for (int j = 0; j < gridSize; j++) {
                    _grid[i, j] = new Button();

                    _grid[i, j].Tag = new ButtonData(i, j, 'e');
                    _grid[i, j].Width = 32;
                    _grid[i, j].Height = 32;
                    _grid[i, j].Left = x;
                    _grid[i, j].Top = y;
                    _grid[i, j].BackColor = Color.FromArgb(255, 0, 120, 255);
                    _grid[i, j].FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                    _grid[i, j].TabStop = false;
                    _grid[i, j].FlatStyle = FlatStyle.Flat;
                    _grid[i, j].FlatAppearance.BorderSize = 0;

                    _panel.Controls.Add(_grid[i, j]);
                    x += _grid[i, j].Width;
                }
                y += 32;
                x = 0;
            }
        }
        private void PopulateFromFile() 
        { // This function uses file handling to retrieve data from a file
            // It is looped through until the entirety of the file is read
            for (int i = 0; i < fromFile.GetLength(0); i++) 
            {
                for (int j = 0; j < fromFile.GetLength(1); j++) 
                {
                    if (i == 0) 
                    { // The initial section of the file shows user data so it is populated from here
                        playerGridData[j] = fromFile[i, j];
                    }
                    else 
                    { // Then the enemy data is populated
                        enemyGridData[j] = fromFile[i, j];
                    }
                }
            }
        }
        private void IndexCheck(int _index)
        {
            m_NextButton.Enabled = _index != totalTurns;

            m_BackButton.Enabled = _index != 0;
        }
        private void InterpretGridString(Button[,] _grid, string[] _data, int _index) 
        { // This function takes a grid string and changes values of the current grids on screen accordingly
            string[] gridSplit = _data[_index].Split('|');
            int k = 0;

            for (int i = 0; i < gridSize; i++) 
            {
                for (int j = 0; j < gridSize; j++) 
                { // Getting the button data for each tile so that it can be updated
                    ButtonData buttonData = (ButtonData)_grid[i, j].Tag;
                    buttonData.type = Convert.ToChar((gridSplit[k]));
                    k++;

                    switch (buttonData.type) 
                    { // Changing the colour of tiles based on the type of tile it is
                        case 'e':
                            _grid[i, j].BackColor = Color.FromArgb(255, 0, 120, 255);
                            break;
                        case 's':
                            _grid[i, j].BackColor = Color.Silver;
                            break;
                        case 'm':
                            _grid[i, j].BackColor = Color.LightSlateGray;
                            break;
                        case 'h':
                            _grid[i, j].BackColor = Color.MediumVioletRed;
                            break;
                    }
                }
            }
        }
        private void EnableDisable(Button[,] _grid, bool _enabled) 
        {
            for (int i = 0; i < gridSize; i++) 
            {
                for (int j = 0; j < gridSize; j++) 
                {
                    _grid[i, j].Enabled = _enabled;
                }
            }
        }
        #endregion

        #region NAVIGATION
        private void ShowSelector()
        {
            var nextForm = new ReplaySelector();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
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