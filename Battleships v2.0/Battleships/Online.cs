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

namespace Battleships_v2._0
{
    public partial class Online : Game
    {
        #region CLASS VARIABLES

        private readonly Firebase firebase = new Firebase();
        private readonly SQLite sqlite = new SQLite();

        private static string source = Settings.SQLiteConnection;
        private static string userId = CurrentUser.UserId; 
        private static string userName = CurrentUser.Username; 

        private static string lobbyId;
        private static string p_LobbyId;
        private static string e_LobbyId;

        private static int gridSize;

        private static bool host;
        private static bool debug = false;
        private static string port;
        private static string gamemode = "Battleships";

        private bool l_joined = false;
        private bool l_placed = false;
        private bool l_shotTaken = false;
        private bool l_waiting = true;

        private int l_shots;
        private int l_hits;

        private string state = "joined";
        private string shot = "null";

        private Packet p_packet;
        private Packet e_packet;

        #endregion

        #region CONSTRUCTORS
        public Online(int _gridSize) : base(_gridSize)
        {
            InitializeComponent();

            gridSize = _gridSize;
        }

        public Online(int _gridSize, bool _host) : base(_gridSize)
        {
            InitializeComponent();

            host = _host;
            gridSize = _gridSize;
            state = "joined";
        }

        public Online(int f_gridSize, bool _host, string _port) : base(f_gridSize)
        {
            InitializeComponent();

            host = _host;
            port = _port;
            gridSize = f_gridSize;
            state = "joined";
        }
        #endregion

        #region FORM FUNCTIONS
        private void Online_Load(object _sender, EventArgs _e) { Init(); }
        private void Online_FormClosing(object _sender, FormClosingEventArgs _e) { Exit(); }
        private void FirebaseTick_Tick(object _sender, EventArgs _e) { FirebaseEvent(); }
        #endregion

        #region NETWORK FUNCTIONS
        private void Init()
        { // Initialization
            Run();
            // Connects to database
            firebase.FirebaseConnect();

            if (host)
            { // If they are the host a lobby is created
                CreateLobby();
            }
            else if (!host)
            { // If they are not the host they join the game
                JoinLobby();
            }

            // Tickers are then enabled
            EnableDisable(playerGrid, false);
            FirebaseTick.Enabled = true;
        }
        private void FirebaseEvent()
        { // Firebase event handles the sending and receiving of data each tick
            void Send()
            { // Local data is sent to the database
                p_SendData(playerGrid);
            }
            bool IsDirty()
            { // Packet is received from the database
                Console.WriteLine("receiving enemy packet");
                firebase.FirebaseReceivePacket("lobbies", lobbyId, e_LobbyId);

                if (!firebase.isDirty)
                { // Guard clause no other values are checked if the data is unchanged
                    return false;
                }

                // Sets received data to local packet, and data is interpreted 
                e_packet = firebase.packet;
                Interpret(e_packet.GameData, enemyGrid);

                return true;
            }
            void Receive()
            {
                firebase.FirebaseReceivePacket("lobbies", lobbyId, e_LobbyId);

                // Sets received data to local packet, and data is interpreted 
                e_packet = firebase.packet;
                Interpret(e_packet.GameData, enemyGrid);
            }
            void Joined()
            { // When everyone has joined 
                if (!l_joined && state == "joined" && e_packet.State == "joined")
                { // If everyone has joined the state is changed to joined and players begin placing ships
                    Debug.WriteLineIf(!l_joined, l_joined);
                    EnableDisable(playerGrid, true);
                    l_joined = true;
                    state = "placing";
                    Console.WriteLine("All joined");
                }
            }
            void Placed()
            { // When both players have all ships placed
                if (placed && !l_placed)
                { // If all ships have been placed the state is changed, and grid can no longer be reset
                    state = "placed";
                    m_ResetButton.Enabled = false;
                }

                if (!l_placed && state == "placed" && e_packet.State == "placed")
                { // When all the ships are placed the players begin shooting, this sets up the state of each player
                    Console.WriteLine("switching, {0}", p_LobbyId[0]);
                    if (p_LobbyId[0] == '0')
                    {
                        state = "attacking";
                    }
                    else if (p_LobbyId[0] == '1')
                    {
                        state = "defending";
                        EnableDisable(enemyGrid, false);
                    }

                    EnableDisable(playerGrid, false);
                    l_placed = true;
                }
            }
            void Firing()
            { // When the users are firing at one another
                if (state == "attacking" || state == "defending")
                { // Updates the grid if the game is in the attacking phase
                    ShotUpdate(e_packet.Shot, playerGrid);
                }

                if (state == "defending" && l_waiting)
                {
                    shot = "null";
                    if (e_packet.Shot != "null")
                    {
                        state = "attacking";
                    }
                }

                if (l_shotTaken && state == "attacking")
                {
                    state = "defending";
                    l_waiting = true;
                    l_shotTaken = false;
                }

                if (l_hits == shipsToPlace)
                {
                    state = "won";
                    Console.WriteLine("Game won!");
                }
            }
            void Over()
            { // When the game is over variables are assigned once more and then ticks are ended
                shot = "null";
                p_SendData(playerGrid);
                GameWon();

                if (p_LobbyId[0] == '0')
                {
                    firebase.FirebaseDelete("lobbies", lobbyId);
                }

                Ticker.Enabled = false;
                FirebaseTick.Enabled = false;
            }
            void Won()
            { // When the game has been one
                if (e_packet.State == "won")
                { // When the enemy has won the user has lost
                    state = "lost";

                    Over();

                    MessageBox.Show("Game over, lost");
                }
                else if (state == "won")
                { // When you have won the game ends
                    Over();

                    MessageBox.Show("Game over, won!");
                }
            }

            if (!IsDirty())
            { // If the receive function returns false then the packet is null
                // To prevent actions on null data this guard clause returns
                return;
            }

            Receive();
            Send();
            Joined();
            Placed();
            Firing();
            Won();
        }
        private void CreateLobby()
        { // This creates the lobby id
            int CreateId()
            {
                var rand = new Random();

                return rand.Next(0, 99999);
            }
            void Create()
            {
                lobbyId = CreateId().ToString();

                // Creates instances of packet for each user
                p_packet = new Packet(userId, userName, "null", gridSize, true, "joined", shot);
                e_packet = new Packet("null", "null", "null", gridSize, false, "waiting", shot);

                // Assigns paths to each players data
                p_LobbyId = $"0_{lobbyId}";
                e_LobbyId = $"1_{lobbyId}";

                // Initializes the lobby of the game
                firebase.FirebaseCreate("lobbies", lobbyId, p_LobbyId, p_packet);
                firebase.FirebaseSend("lobbies", lobbyId, p_LobbyId, p_packet);
                firebase.FirebaseCreate("lobbies", lobbyId, e_LobbyId, e_packet);
                firebase.FirebaseSend("lobbies", lobbyId, e_LobbyId, e_packet);

                m_LobbyIdLabel.Text = $"Lobby ID: {lobbyId}";

                Console.WriteLine("Created");
            }

            Create();
        }
        private void JoinLobby()
        { // Joins a lobby with a given lobby id 
            Packet packet = new Packet(userId, userName, "null", gridSize, true, "joined", shot);

            lobbyId = port;
            p_LobbyId = $"1_{lobbyId}";
            e_LobbyId = $"0_{lobbyId}";

            firebase.FirebaseSend("lobbies", lobbyId, p_LobbyId, packet);
            m_LobbyIdLabel.Text = $"Lobby ID: {lobbyId}";
        }
        private void Exit()
        { // Closes out of the application entirely
            FirebaseClose();
            Quit.Exit();
        }
        private void FirebaseClose()
        { // Stops the ticking and sends a left message to the database
            FirebaseTick.Enabled = false;
            Ticker.Enabled = false;

            Packet packet = new Packet
                (
                userId,
                userName,
                "null",
                gridSize,
                false,
                "left",
                shot
            );

            // Disconnects from the Firebase database
            firebase.FirebaseSend("lobbies", lobbyId, p_LobbyId, packet);
            firebase.FirebaseDisconnect();
        }
        private void Interpret(string _data, Button[,] _grid)
        { // Interprets the received data from the server

            Console.WriteLine(_data);

            if (_data == null || _data == "null")
            {
                return;
            }

            InterpretGridString(_grid, _data);
            UpdateGrid(_grid, debug);
        }
        private void p_SendData(Button[,] _grid)
        { // Sends any updates to the clients data
            string data = CreateGridString(_grid);

            /*
             *  Packet constructor
             *  User Id
             *  Username
             *  Game data
             *  Grid size
             *  is dirty?
             *  User state
             */

            Packet packet = new Packet
            (
                userId,
                userName,
                data,
                gridSize,
                true,
                state,
                shot
            );

            firebase.FirebaseUpdate("lobbies", lobbyId, p_LobbyId, packet);
        }
        #endregion

        #region GAME FUNCTIONS
        protected override void Event()
        { // Local event for the online class
            currentGridStringP = CreateGridString(playerGrid);
            currentGridStringE = CreateGridString(enemyGrid);

            Debug.WriteLine(currentGridStringP);
            Debug.WriteLine(currentGridStringE);

            void WriteToList()
            { // Adds a new turn to list
                playersTurns.Add(currentGridStringP);
                enemiesTurns.Add(currentGridStringE);
            }
            void GameStart()
            { // Starts game
                DelClickPlace(playerGrid);
                EnableDisable(playerGrid, false);

                SetClickShoot(enemyGrid);
                EnableDisable(enemyGrid, true);
            }

            if (shipsPlaced == shipsToPlace && placed == false)
            { // Initial ship placing stage, when over sets next phase in motion
                GameStart();

                placed = true;
                state = "placed";
                shooting = true;
            }

            if ((shipsToPlace == playerHits || shipsToPlace == enemyHits) && over == false)
            { // Checks if game has been won
                over = true;

                //WriteToList();
            }

            if (IsChanged())
            { // If the board has changed then the updated grid string is added to a list
                Console.WriteLine("WRITING");
                WriteToList();
            }
            if (state == "attacking")
            {
                EnableDisable(enemyGrid, true);

            }
            else if (state == "defending")
            {
                EnableDisable(enemyGrid, false);
            }
        }
        protected override void GameWon()
        { // When the game is won game results are posted and tickers are ended
            playersTurns.Add(currentGridStringP);
            enemiesTurns.Add(currentGridStringE);

            EnableDisable(playerGrid, false);
            EnableDisable(enemyGrid, false);

            WriteResultToFile();
            PostGameResult();
        }
        protected override void ShootTile(object _sender, EventArgs _e)
        { // The shoot tile functionality needed a minor overhaul
            // To be compatible with the database some local functions such as shots and hits were introduced
            Button button = (Button)_sender;
            ButtonData buttonData = (ButtonData)button.Tag;
            char type = buttonData.type;

            if (type == 'e')
            {
                type = 'm';

                l_shots++;
            }
            else if (type == 's')
            {
                type = 'h';

                l_hits++;
                l_shots++;
            }
            buttonData.type = type;

            // The shot variable was also introduced so a client could interpret what part of their grid was shot
            shot = $"{buttonData.x}, {buttonData.y}";
            l_shotTaken = true;
        }
        private void ShotUpdate(string _shot, Button[,] _grid)
        { // Updates when a play has been shot
            if (_shot == "null")
            { // Guard clause in case shot has no data
                return;
            }

            // Updates the players view of the other grid to what was hit
            // The shot is first deserialized
            string[] shot = _shot.Split(',');
            int x = Convert.ToInt32(shot[0]);
            int y = Convert.ToInt32(shot[1]);

            ButtonData buttonData = (ButtonData)_grid[x, y].Tag;

            // Checks what has been hit
            if (buttonData.type == 'e')
            {
                buttonData.type = 'm';
            }
            else if (buttonData.type == 's')
            {
                buttonData.type = 'h';
            }

            // Updates the tag and then the grid
            _grid[x, y].Tag = buttonData;
            UpdateGrid(_grid, debug);
        }
        #endregion

        #region DATABASE
        private void PostGameResult()
        { // Posts a game result
            int GenerateId()
            { // Generates a unique id for the game result
                bool unique = false;
                var rand = new Random();
                int id = 0;

                while (!unique)
                { // While it is not unique it keeps checking and randomly generating a new id
                    id = rand.Next(10000, 99999);
                    string sqlCommand = $"SELECT * FROM game_result WHERE game_result_id = {id};";
                    string[,] ids = sqlite.ReadTo2DArray(sqlCommand, source);

                    if (ids == null || ids.GetLength(0) == 0)
                    {
                        unique = true;
                    }
                }
                return id;
            }
            int[] GetData(Button[,] _grid)
            { // Gets the data for the history, from a given grid
                int[] data = new int[3];

                /*
                 *  misses
                 *  hits
                 *  shots
                 */

                for (int i = 0; i < gridSize; i++)
                {
                    for (int j = 0; j < gridSize; j++)
                    {
                        ButtonData buttonData = (ButtonData)_grid[j, i].Tag;

                        if (buttonData.type == 'm')
                        {
                            data[0]++;
                            data[2]++;
                        }
                        else if (buttonData.type == 'h')
                        {
                            data[1]++;
                            data[2]++;
                        }
                    }
                }

                return data;
            }

            // Assigns variables that will be placed within the database via a command
            int resultsId = GenerateId();
            int[] results = GetData(enemyGrid);

            string nameOne = userName;
            string nameTwo = e_packet.Name;

            int shotsOne = l_shots;
            int shotsTwo = results[2];

            int hitsOne = l_hits;
            int hitsTwo = results[1];

            int missesOne = l_shots - l_hits;
            int missesTwo = results[0];

            int scoreOne = hitsOne + shotsOne + missesTwo;
            int scoreTwo = hitsTwo + shotsTwo + missesOne;

            string command = "INSERT INTO game_result " +
                             $"VALUES ({resultsId}, '{nameOne}', '{nameTwo}', {scoreOne}, {scoreTwo}, {shotsOne}, {shotsTwo}," +
                             $" {hitsOne}, {hitsTwo}, {missesOne}, {missesTwo}, '{gamemode}');";

            sqlite.WriteFromCommand(source, command);

            command = "INSERT INTO history " +
                      $"VALUES ({resultsId}, {userId});";

            sqlite.WriteFromCommand(source, command);
        }
        #endregion

        #region NAVIGATION
        protected override void ShowMenu()
        {
            FirebaseClose();

            var nextForm = new Menu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion
    }
}
