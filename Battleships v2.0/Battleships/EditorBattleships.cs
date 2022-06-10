#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
#endregion

namespace Battleships_v2._0 
{
    public partial class EditorBattleships : Form 
    {
        #region CLASS VARIABLES
        private readonly Button[,] playerGrid = new Button[gridSize, gridSize];
        private readonly Button[,] enemyGrid = new Button[gridSize, gridSize];
        private string gridString = "";
        private static int gridSize = 10;

        private readonly IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Settings.AuthSecret,
            BasePath = Settings.BasePath
        };
        private IFirebaseClient client;
        private string received;
        private bool isDirty;
        #endregion

        #region FORM FUNCTIONS
        public EditorBattleships() { InitializeComponent(); }
        private void EditorBattleships_Load(object _sender, EventArgs e) { Init(); }
        private void Connect_Click(object _sender, EventArgs _e) { Connection(); }
        private void TestButton_Click(object _sender, EventArgs _e) { /*firebase.FirebaseSend();*/ }
        private void RecieveButton_Click(object _sender, EventArgs _e) { FirebaseReceive(); }
        private void UpdateButton_Click(object _sender, EventArgs _e) { Updates(); }
        private void MenuButton_Click(object _sender, EventArgs _e) { ShowMenu(); }
        private void DisconnectButton_Click(object _sender, EventArgs _e) { Disconnect(); }
        private void Ticker_Tick(object _sender, EventArgs _e) { Tick(); }
        #endregion

        #region FIREBASE FUNCTIONS
        private void FirebaseConnect()
        { // Connects to a Firebase client 
            try
            { // Tries connection
                client = new FirebaseClient(config);
                if (client != null)
                {
                    Console.WriteLine("Connected");
                }
                else
                { // If connection is null then failed
                    Console.WriteLine("Connection failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e);
            }
        }
        private void FirebaseDisconnect()
        { // Attempts to disconnect from the firebase database
            try
            { // Sets client to null
                client = null;

                // Forces garbage collection on memory
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                Console.WriteLine("Disconnected");
            }
            finally
            { // Then disposes of this instance of the class
                // Forces garbage collection on memory
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                this.Dispose();
            }
        }
        private async void FirebaseReceive()
        { // Hard coded test function
            FirebaseResponse response = await client.GetAsync(@"game/12345");
            Dictionary<string, string> data =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Body.ToString());

            received = data.ElementAt(1).Value;
            isDirty = true;
        }
        private async void FirebaseUpdate(string _id, string _data, string _source)
        { // Sends a basic data packet via a given source, to update
            var send = new Data
            {
                Id = _id,
                GameData = _data
            };

            SetResponse update = await client.SetAsync($"{_source}", send);
            Data result = update.ResultAs<Data>();

            //Console.WriteLine(result.Id);
        }
        #endregion

        #region GAME FUNCTIONS
        private void Init() 
        { // Initializes the form
            isDirty = false;
            CreateGrid(playerGrid, PlayerPanel);
            CreateGrid(enemyGrid, EnemyPanel);
            SetClickPlace(playerGrid);
            EnableDisable(enemyGrid, false);
        }
        private void Connection() 
        { // Connects to firebase database
            FirebaseConnect();
            Ticker.Enabled = true;
        }  
        private void Disconnect()
        { // Disconnects from firebase database
            Ticker.Enabled = false;
            FirebaseDisconnect();
        }
        private void Updates() 
        { // Updates the grid
            InterpretGridString(enemyGrid, gridString, true);
        }
        private void Tick() 
        { // Runs every tick and this manages the receiving of data and serialization
            // As well as this it also sends the users data

            FirebaseReceive();

            if (isDirty) 
            { // If new data has been received then the enemy grid can be updated
                Console.WriteLine("Updating");
                InterpretGridString(enemyGrid, received, true);
                isDirty = false;
            }
            if (CreateGridString(playerGrid) != "") 
            { // If the players grid is not null then it can be send to the server
                Console.WriteLine("Sending");
                FirebaseUpdate("54321", CreateGridString(playerGrid), @"game/54321/-MxGhDjN0uvvhcKTU5r3");
            }
        }
        private void CreateGrid(Button[,] _grid, Control _panel) 
        { // Creates the grids in panels
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
        private string CreateGridString(Button[,] _grid) 
        { // Serializes a string based on the given grid
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
        private void InterpretGridString(Button[,] _grid, string _data, bool _showShips) 
        { // Deserializes a string and updates a grid
            string[] gridSplit = _data.Split('|');
            int k = 0;

            for (int i = 0; i < gridSize; i++) 
            { // Goes through entire grid
                for (int j = 0; j < gridSize; j++) 
                { // Gets the button data for that index of the array
                    ButtonData buttonData = (ButtonData)_grid[j, i].Tag;
                    buttonData.type = Convert.ToChar((gridSplit[k]));
                    k++;

                    switch (buttonData.type) 
                    { // Based on the button type changes colour and ag
                        case 'e':
                            _grid[j, i].BackColor = Color.FromArgb(255, 0, 120, 255);
                            break;
                        case 's':
                            if (_showShips)
                            {
                                _grid[j, i].BackColor = Color.Silver;
                            }
                            break;
                        case 'm':
                            _grid[j, i].BackColor = Color.LightSlateGray;
                            break;
                        case 'h':
                            _grid[j, i].BackColor = Color.MediumVioletRed;
                            break;
                    }
                }
            }
        }
        private void EnableDisable(Button[,] _grid, bool _enabled)
        { // Enables or disables a grid
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    _grid[j, i].Enabled = _enabled;
                }
            }
        }
        private void ShipPlaceTile(object _sender, EventArgs _e) 
        { // Makes it so the tile can have a ship placed on it
            Button button = (Button)_sender;
            ButtonData buttonData = (ButtonData)button.Tag;
            char type = buttonData.type;

            if (type == 'e') 
            {
                type = 's';
                //shipsPlaced++;
                button.BackColor = Color.Silver;
            }
            buttonData.type = type;
        }
        private void SetClickPlace(Button[,] _grid) 
        { // Sets a grid click type to place
            for (int i = 0; i < gridSize; i++) 
            {
                for (int j = 0; j < gridSize; j++) 
                {
                    _grid[j, i].Click += new EventHandler(ShipPlaceTile);
                }
            }
        }
        private void DelClickPlace(Button[,] _grid) 
        { // Removes a grids click type of place
            for (int i = 0; i < gridSize; i++) 
            {
                for (int j = 0; j < gridSize; j++) 
                {
                    _grid[j, i].Click -= new EventHandler(ShipPlaceTile);
                }
            }
        }
        #endregion

        #region NAVIGATION FUNCTIONS
        private void ShowMenu()
        {
            Disconnect();

            var nextForm = new Menu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = await client.DeleteAsync($"lobbies/2142");
                var result = response.ResultAs<Object>();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting data, {0}", ex);
            }
        }
    }
    internal class Data
    { // temp class will later be replaced by packet
        public string Id { get; set; }
        public string GameData { get; set; }
    }
}