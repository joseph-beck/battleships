#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Battleships_v2._0
{
    public partial class Game : Form
    {
        #region CLASS VARIABLES
        private readonly FileHandling fileHandling = new FileHandling();
        private readonly ConsoleOutputs consoleOutputs = new ConsoleOutputs();

        private static int gridSize;
        private int[,] origin = new int[1, 2];
        protected int playerHits;
        protected int enemyHits;
        protected int shipsPlaced;
        protected int shipsToPlace;
        protected int shotsLeft = 1;
        private int tick;
        private int partsPlaced;
        private int index = 0;
        private int[] nose = new int[2];
        private int[] tail = new int[2];

        protected readonly Button[,] playerGrid;
        protected readonly Button[,] enemyGrid;

        protected List<string> playersTurns = new List<string>();
        protected List<string> enemiesTurns = new List<string>();

        protected bool placed;
        protected bool over;
        protected bool shooting;
        protected bool isDirty;

        private string turn = "player-1";
        private string orientation = "unknown";
        protected string currentGridStringP;
        private string previousGridStringP;
        protected string currentGridStringE;
        private string previousGridStringE;

        private readonly Ship[] ships =
        {
            new Ship("MS", 1, "Minesweeper"),
            new Ship("PB", 1, "Patrol Boat"),
            new Ship("CV", 2, "Corvette"),
            new Ship("DR", 2, "Destroyer"),
            new Ship("FG", 3, "Frigate"),
            new Ship("SM", 3, "Submarine"),
            new Ship("BS", 4, "Battleship"),
            new Ship("CS", 4, "Cruiser"),
            new Ship("HC", 5, "Heavy Cruiser"),
            new Ship("AC", 5, "Aircraft Carrier"),
            new Ship("DN", 6, "Dreadnought"),
            new Ship("WS", 7, "Warship")
        };
        private readonly int[,] bounds =
        {
            {0, 0},                 // Top Left
            {gridSize , 0},         // Top Right
            {0, gridSize},          // Bottom Left
            {gridSize, gridSize}    // Bottom Right
        };
        #endregion

        #region FORM FUNCTIONS
        public Game(int _gridSize)
        {
            InitializeComponent();

            gridSize = _gridSize;

            playerGrid = new Button[gridSize, gridSize];
            enemyGrid = new Button[gridSize, gridSize];
        }

        public Game()
        {
            InitializeComponent();

            gridSize = 10;

            playerGrid = new Button[gridSize, gridSize];
            enemyGrid = new Button[gridSize, gridSize];
        }
        private void Game_Load(object _sender, EventArgs _e) { /*Init();*/ }
        protected virtual void Ticker_Tick(object _sender, EventArgs _e) { Event(); }
        private void ResetButton_Click(object _sender, EventArgs _e) { Reset(playerGrid); }
        private void m_ResetButton_Click(object _sender, EventArgs _e) { Reset(playerGrid); }
        protected virtual void m_MenuButton_Click(object sender, EventArgs e) { ShowMenu(); }
        #endregion

        #region GAME FUNCTIONS
        protected void Run()
        { // Runs a game on call
            // All of these functions initialize the board
            shotsLeft = 1;
            shipsToPlace = CalculateShipsToPlace();
            Console.WriteLine(shipsToPlace);

            CreateGrid(playerGrid, PlayerPanel);
            CreateGrid(enemyGrid, EnemyPanel);
            EnableDisable(enemyGrid, false);
            PopulateGridRandom(enemyGrid, shipsToPlace);

            previousGridStringP = CreateGridString(playerGrid);
            currentGridStringP = CreateGridString(playerGrid);
            previousGridStringE = CreateGridString(enemyGrid);
            currentGridStringE = CreateGridString(enemyGrid);
            placed = over = false;

            SetShowPlacement(playerGrid);
        }
        protected virtual void Event()
        { // A series of checks every tick to check the status of the game

            currentGridStringP = CreateGridString(playerGrid);
            currentGridStringE = CreateGridString(enemyGrid);
            tick++;
            Debug.WriteLine(tick);

            void WriteToList()
            { // Writes any updates to a list
                // This is later used to make a replay file
                playersTurns.Add(currentGridStringP);
                enemiesTurns.Add(currentGridStringE);
            }
            void GameStart()
            { // Starts the game once a given condition is met
                DelClickPlace(playerGrid);
                EnableDisable(playerGrid, false);

                SetClickShoot(enemyGrid);
                EnableDisable(enemyGrid, true);
            }

            if (shipsPlaced == shipsToPlace && placed == false)
            { // Initial ship placing stage, when over sets next phase in motion
                GameStart();

                placed = true;
                m_ResetButton.Enabled = false;
                shooting = true;
            }
            if ((shipsToPlace == playerHits || shipsToPlace == enemyHits) && over == false)
            { // Checks if game has been won
                over = true;

                WriteToList();
                GameWon();
            }
            if (IsChanged() && shooting == true)
            { // If the board has changed then the updated grid string is added to a list
                WriteToList();
            }
        }
        private void CreateGrid(Button[,] _grid, Panel _panel)
        { // Creates a grid of specified size, places them within a specified panel and formats
            int x = 0, y = 0;
            _panel.Controls.Clear();

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    _grid[j, i] = new Button();

                    _grid[j, i].Tag = new ButtonData(j, i, 'e');
                    _grid[j, i].Width = 32;
                    _grid[j, i].Height = 32;
                    _grid[j, i].Left = x;
                    _grid[j, i].Top = y;
                    _grid[j, i].BackColor = Color.FromArgb(255, 0, 120, 255);
                    _grid[j, i].FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                    _grid[j, i].TabStop = false;
                    _grid[j, i].FlatStyle = FlatStyle.Flat;
                    _grid[j, i].FlatAppearance.BorderSize = 0;

                    _panel.Controls.Add(_grid[j, i]);
                    x += _grid[j, i].Width;
                }
                y += 32;
                x = 0;
            }
        }
        private static void PopulateGridRandom(Button[,] _grid, int _toPlace)
        { // Randomly populates a given grid with ships
            var rand = new Random();

            while (_toPlace > 0)
            {
                int x = rand.Next(1, gridSize);
                int y = rand.Next(1, gridSize);

                ButtonData buttonData = (ButtonData)_grid[x, y].Tag;
                char type = buttonData.type;

                if (type == 'e')
                {
                    type = 's';
                    _toPlace--;
                }
                buttonData.type = type;
            }
        }
        protected void UpdateGrid(Button[,] _grid, bool _debug)
        { // Updates a given grid to show the most up to date view
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    ButtonData buttonData = (ButtonData)_grid[j, i].Tag;

                    switch (buttonData.type)
                    {
                        case 'e':
                            _grid[j, i].BackColor = Color.FromArgb(255, 0, 120, 255);
                            break;
                        case 's':
                            if (_debug)
                            {
                                _grid[j, i].BackColor = Color.Silver;
                            }
                            break;
                        case 'h':
                            _grid[j, i].BackColor = Color.MediumVioletRed;
                            break;
                        case 'm':
                            _grid[j, i].BackColor = Color.LightSlateGray;
                            break;
                    }
                }
            }
        }
        
        protected void InterpretGridString(Button[,] _grid, string _string)
        { // Deserializes a given string into a grid
            string[] gridSplit = _string.Split('|');
            int k = 0;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    ButtonData buttonData = (ButtonData)_grid[j, i].Tag;
                    buttonData.type = Convert.ToChar((gridSplit[k]));
                    k++;
                }
            }
        }
        protected string CreateGridString(Button[,] _grid)
        { // Serializes a given grid into a string
            string output = "";

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    ButtonData buttonData = (ButtonData)_grid[j, i].Tag;
                    output += $"{buttonData.type}|";
                }
            }
            return output;
        }
        protected virtual void GameWon()
        {
            EnableDisable(playerGrid, false);
            EnableDisable(enemyGrid, false);

            WriteResultToFile();

            MessageBox.Show(@"Game over!");
        }
        protected void WriteResultToFile()
        {
            string GenId()
            {
                var rand = new Random();
                string temp = "";

                for (int i = 0; i < 5; i++)
                {
                    temp += rand.Next(0, 9);
                }
                return temp;
            }
            List<string> GetFiles()
            {
                List<string> files = new List<string>();
                foreach (string item in Directory.GetFiles(Settings.ReplayPath))
                {
                    FileInfo fileInfo = new FileInfo(item);
                    files.Add(fileInfo.Name);
                }

                return files;
            }
            bool IsUnque(string _id)
            {
                List<string> files = GetFiles();

                if (files.Contains(_id))
                {
                    return false;
                }
                return true;
            }

            string gameId = GenId();

            while (true)
            {
                if (IsUnque(gameId))
                {
                    break;
                }
                gameId = GenId();
            }

            fileHandling.CreateNewFile(gameId, $"..\\replays\\");
            fileHandling.Write2ListsToFile(playersTurns, enemiesTurns, "%", $"..\\{Settings.ReplayPath}\\{gameId}.txt");
            Console.WriteLine(@"DATA WRITTEN");
        }
        private void SwitchTurn()
        { // Switches the turn when a move occurs to the next user
            Console.WriteLine(@"SWITCHING");
            if (shotsLeft == 0 && turn == "player-1")
            {
                shotsLeft = 1;
                turn = "computer-1";

                EnableDisable(enemyGrid, false);
                ComputerShoot(playerGrid);
            }
            else if (shotsLeft == 0 && turn == "computer-1")
            {
                shotsLeft = 1;
                turn = "player-1";

                EnableDisable(enemyGrid, true);
            }
        }
        private async void ComputerShoot(Button[,] _grid)
        {
            await Task.Delay(1000);
            var rand = new Random();
            bool isShooting = true;

            while (isShooting)
            {
                int x = rand.Next(1, gridSize);
                int y = rand.Next(1, gridSize);

                ButtonData buttonData = (ButtonData)_grid[x, y].Tag;

                switch (buttonData.type)
                {
                    case 's':
                        buttonData.type = 'h';
                        _grid[x, y].BackColor = Color.MediumVioletRed;
                        enemyHits++;
                        break;
                    case 'e':
                        buttonData.type = 'm';
                        shotsLeft--;
                        isShooting = false;
                        _grid[x, y].BackColor = Color.LightSlateGray;
                        break;
                    default:
                        shotsLeft--;
                        isShooting = false;
                        break;
                }
            }
            SwitchTurn();
        }
        private void EnableDisable(Button[,] _grid, bool _enabled, char type)
        { // Enables or disables the entirety of a given grid based on the bool value _enabled
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    ButtonData data = (ButtonData)_grid[i, j].Tag;
                    if (data.type == type)
                    {
                        _grid[i, j].Enabled = _enabled;
                    }
                    else
                    {
                        _grid[i, j].Enabled = !_enabled;
                    }
                }
            }
        }
        protected void EnableDisable(Button[,] _grid, bool _enabled)
        { // Enables or disables the entirety of a given grid based on the bool value _enabled
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {

                    _grid[i, j].Enabled = _enabled;
                }
            }
        }
        private void EnableDisable(Button[,] _grid, bool _enabled, int _x, int _y)
        { // Enables or a disables a specific button based on its grid location
            _grid[_x, _y].Enabled = _enabled;
        }

        protected bool IsChanged()
        { // Checks for a change on the board
            if (currentGridStringP != previousGridStringP)
            {
                Console.WriteLine(@"CHANGE OCCURRED");
                previousGridStringP = currentGridStringP;
                previousGridStringE = currentGridStringE;
                return true;
            }
            return false;
        }
        private void Reset(Button[,] _grid)
        {
            if (placed == false)
            {
                index = 0;
                shipsPlaced = 0;

                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        _grid[j, i].Tag = new ButtonData(j, i, 'e');
                        _grid[j, i].BackColor = Color.FromArgb(255, 0, 120, 255);
                    }
                }
                UpdateGrid(_grid, false);
            }
            else
            {
                m_ResetButton.Enabled = false;
            }
            EnableDisable(playerGrid, true);
        }
        private int CalculateShipsToPlace()
        {
            int maxIndex = GetMaxIndex();
            int a_ships = 0;

            for (int i = 0; i < maxIndex; i++)
            {
                a_ships += ships[i].size;
            }

            return a_ships;
        }
        private int GetMaxIndex()
        {
            int index = 0;

            switch (gridSize)
            {
                case 5:
                    index = 5;
                    break;
                case 6:
                    index = 6;
                    break;
                case 7:
                    index = 7;
                    break;
                case 8:
                case 9:
                    index = 8;
                    break;
                case 10:
                    index = 9;
                    break;
                case 11:
                case 12:
                    index = 10;
                    break;
                case 13:
                case 14:
                    index = 11;
                    break;
                case 15:
                    index = 12;
                    break;
            }
            return index;
        }
        private void ShowPlacementOptions(object _sender, EventArgs _e)
        {   // Ship can only be placed horizontally or vertically in a straight line, there is no exception to this rule
            // All buttons except those that fall under this catergory must be disabled

            /*    1 2 3 4 5 6 7 8 9
             *  1   y  
             *  2 x . x x x x x x 
             *  3   y  
             *  4   y
             *  5   y 
             *  6   y
             *  7
             *  8
             *  9  
             */

            // Gets the button data of the sender
            Button button = (Button)_sender;
            ButtonData buttonData = (ButtonData)button.Tag;
            char type = buttonData.type;

            // A 2D integer array that will be populated by the surrounding tiles of a ship
            int[,] surrounding;
            

            void SetOrigin()
            { // This function sets the origin of them users placement
                origin[0, 0] = buttonData.x; // x coord of origin
                origin[0, 1] = buttonData.y; // y coord of origin
            }
            bool InBounds(int _x, int _y)
            { // This checks whether the x and y coordinates are within the bounds of the grid
                int[,] current =
                {
                    {_x, _y}
                };

                
                if (current[0, 0] == -1 || current[0, 0] == gridSize)
                {
                    return false;
                }
                if (current[0, 1] == -1 || current[0, 1] == gridSize)
                {
                    return false;
                }
                return true;
                // A boolean value is returned depending on whether its within bounds
            }
            void EnableDisableSpecifics(int[,] _avoids, Button[,] _grid, bool _enabled)
            { // This allows the user to enable or disable specific buttons on a given grid
                EnableDisable(_grid, false);
                for (int i = 0; i < _avoids.GetLength(0); i++)
                {

                    if (InBounds(_avoids[i, 0], _avoids[i, 1]))
                    { // If its in bounds then it can be toggled
                        ButtonData data = (ButtonData)_grid[_avoids[i, 0], _avoids[i, 1]].Tag;
                        if (data.type == 'e')
                        { // If the button is an empty tile it can have a ship placed on it
                            _grid[_avoids[i, 0], _avoids[i, 1]].Enabled = _enabled;
                        }
                        else
                        { // Otherwise the button is not enabled
                            _grid[_avoids[i, 0], _avoids[i, 1]].Enabled = !_enabled;
                        }
                    }
                }
            }
            void DetermineOrientation()
            { // This determines the orientation of the ship
                if (nose[1] == tail[1])
                { // If ys are equal then ship is horizontal
                    orientation = "horizontal";
                }
                else
                { // If xs are equal then ship is vertical
                    orientation = "vertical";
                }
            }
            int[,] GetSurrounding()
            { // Gets the origin of the ship and then makes an array of all surrounding tiles
                SetOrigin();

                int[,] array = new int[4, 2];

                array[0, 0] = origin[0, 0] + 1;
                array[0, 1] = origin[0, 1];

                array[1, 0] = origin[0, 0] - 1;
                array[1, 1] = origin[0, 1];

                array[2, 0] = origin[0, 0];
                array[2, 1] = origin[0, 1] + 1;

                array[3, 0] = origin[0, 0];
                array[3, 1] = origin[0, 1] - 1;

                return array;
            }
            void Place()
            { // The main placement algorithm
                if (partsPlaced == 0)
                { // If first piece is being placed all tiles around the first piece can have a ship on it
                    surrounding = GetSurrounding();
                    EnableDisable(playerGrid, false, 'e');
                    EnableDisableSpecifics(surrounding, playerGrid, true);
                    ShipPlaceTile(_sender, _e);

                    nose[0] = buttonData.x;
                    nose[1] = buttonData.y;
                    // The front pointer is also initialized here
                }
                else if (partsPlaced >= 1)
                { // When the parts are greater then the rear pointer needs to be assigned
                    if (partsPlaced == 1)
                    {
                        tail[0] = buttonData.x;
                        tail[1] = buttonData.y;
                        DetermineOrientation();
                    }

                    if (partsPlaced > 1)
                    { // When another tile is placed it must be determined whether it was placed to the front or rear pointer,
                        // If placed near the rear pointer then the rear pointer must be moved, same for the front pointer
                        if ((orientation == "horizontal" && nose[0] > tail[0] && tail[0] < buttonData.x) ||
                            (orientation == "vertical" && nose[1] > tail[1] && tail[1] < buttonData.y))
                        {
                            nose[0] = buttonData.x;
                            nose[1] = buttonData.y;
                        }
                        else
                        {
                            tail[0] = buttonData.x;
                            tail[1] = buttonData.y;
                        } // The pointers are then assigned via this calculation
                    }

                    // The whole grid is then disabled
                    EnableDisable(playerGrid, false, 'e');

                    switch (orientation)
                    { // Depending on the orientation the surrounding tiles change
                        case "horizontal":
                            surrounding = new int[2, 2];

                            if (nose[0] < tail[0])
                            { 
                                surrounding[0, 0] = nose[0] - 1;
                                surrounding[0, 1] = nose[1];

                                surrounding[1, 0] = tail[0] + 1;
                                surrounding[1, 1] = tail[1];
                            }
                            else
                            {
                                surrounding[0, 0] = nose[0] + 1;
                                surrounding[0, 1] = nose[1];

                                surrounding[1, 0] = tail[0] - 1;
                                surrounding[1, 1] = tail[1];

                            }

                            // Specific buttons are then toggled on and off depending on the orientation
                            EnableDisableSpecifics(surrounding, playerGrid, true);
                            break;
                        case "vertical":
                            surrounding = new int[2, 2];

                            if (nose[1] > tail[1])
                            {
                                surrounding[0, 0] = nose[0];
                                surrounding[0, 1] = nose[1] + 1;

                                surrounding[1, 0] = tail[0];
                                surrounding[1, 1] = tail[1] - 1;
                            }
                            else
                            {
                                surrounding[0, 0] = nose[0];
                                surrounding[0, 1] = nose[1] - 1;

                                surrounding[1, 0] = tail[0];
                                surrounding[1, 1] = tail[1] + 1;
                            }

                            // Specific buttons are then toggled on and off depending on the orientation
                            EnableDisableSpecifics(surrounding, playerGrid, true);
                            break;
                    }
                }
                
                // Ship place tile is the placement handler for placing ships
                ShipPlaceTile(_sender, _e);
                // Parts placed is increased everytime a part is placed  
                partsPlaced++;
                // Max size is the max size of the ship being placed
                int maxSize = ships[index].size;

                if (partsPlaced == maxSize)
                { // If all parts have been placed the index of the array increases
                    // This moves onto the next ship
                    EnableDisable(playerGrid, true, 'e');
                    partsPlaced = 0;
                    index++;
                }
            }
            
            Place();
        }
        private void ShipPlaceTile(object _sender, EventArgs _e)
        { // An event handler for buttons that places a ship tile
            Button button = (Button)_sender;
            ButtonData buttonData = (ButtonData)button.Tag;
            char type = buttonData.type;

            if (type == 'e')
            {
                type = 's';
                shipsPlaced++;
                button.BackColor = Color.Silver;
            }
            buttonData.type = type;
        }
        protected virtual void ShootTile(object _sender, EventArgs _e)
        { // An event handler for buttons that allows the tile to be shot at
            Button button = (Button)_sender;
            ButtonData buttonData = (ButtonData)button.Tag;
            char type = buttonData.type;

            if (type == 'e')
            {
                type = 'm';
                shotsLeft--;
                button.BackColor = Color.LightSlateGray;
            }
            else if (type == 's')
            {
                type = 'h';
                playerHits++;
                button.BackColor = Color.MediumVioletRed;
            }
            buttonData.type = type;
            Console.WriteLine("shot");
            SwitchTurn();
        }
        private void SetShowPlacement(Button[,] _grid)
        { // Adds Showplacement properties
            for (var i = 0; i < gridSize; i++)
            {
                for (var j = 0; j < gridSize; j++)
                {
                    _grid[i, j].Click += ShowPlacementOptions;
                }
            }
        }
        private void DelShowPlacement(Button[,] _grid)
        { // Removes ShowPlacement properties 
            for (var i = 0; i < gridSize; i++)
            {
                for (var j = 0; j < gridSize; j++)
                {
                    _grid[i, j].Click -= ShowPlacementOptions;
                }
            }
        }
        private void SetClickPlace(Button[,] _grid)
        { // Allows a grid to have place properties
            for (var i = 0; i < gridSize; i++)
            {
                for (var j = 0; j < gridSize; j++)
                {
                    _grid[i, j].Click += ShipPlaceTile;
                }
            }
        }
        protected void DelClickPlace(Button[,] _grid)
        { // Removes a given grids placement properties
            for (var i = 0; i < gridSize; i++)
            {
                for (var j = 0; j < gridSize; j++)
                {
                    _grid[i, j].Click -= ShipPlaceTile;
                }
            }
        }
        protected void SetClickShoot(Button[,] _grid)
        { // Allows a grid to have shoot properties
            for (var i = 0; i < gridSize; i++)
            {
                for (var j = 0; j < gridSize; j++)
                {
                    _grid[i, j].Click += ShootTile;
                }
            }
        }
        private void DelClickShoot(Button[,] _grid)
        { // Removes a given grids shoot properties
            for (var i = 0; i < gridSize; i++)
            {
                for (var j = 0; j < gridSize; j++)
                {
                    _grid[i, j].Click -= ShootTile;
                }
            }
        }
        #endregion

        #region NAVIGATION
        protected virtual void ShowMenu()
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