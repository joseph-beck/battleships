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
#endregion

namespace Battleships_v2._0
{
    public partial class ServerEditor : Game
    {
        #region CLASS VARIABLES
        private readonly Firebase firebase = new Firebase();
        private readonly SQLite sqlite = new SQLite();

        private static string source = Settings.SQLiteConnection;
        private static string userId = "12345"; //CurrentUser.UserId;
        private static string userName = "Jeff"; //CurrentUser.Username;

        private static string lobbyId;
        private static string p_LobbyId;
        private static string e_LobbyId;

        private static int gridSize;

        private static bool host;
        private static bool debug = true;
        private static string port;
        private static string gamemode = "Battleships";

        private bool l_joined = false;
        private bool l_placed = false;
        private bool l_shooting = false;
        private bool l_shotTaken = false;
        private bool l_waiting = true;

        private int l_shots;
        private int l_hits;

        private string state = "joined";
        private string turn = "0";
        private string shot = "null";

        private Packet p_packet;
        private Packet e_packet;
        #endregion

        #region CONSTRUCTORS
        public ServerEditor(int _gridSize) : base(_gridSize)
        {
            InitializeComponent();

            gridSize = _gridSize;
        }
        public ServerEditor(int _gridSize, bool _host) : base(_gridSize)
        {
            InitializeComponent();

            host = _host;
            gridSize = _gridSize;
            state = "joined";
        }
        public ServerEditor(int f_gridSize, bool _host, string _port) : base(f_gridSize)
        {
            InitializeComponent();

            host = _host;
            port = _port;
            gridSize = f_gridSize;
            state = "joined";
        }
        #endregion

        #region FORM FUNCTIONS
        private void ServerEditor_Load(object _sender, EventArgs _e) { Init(); }
        private void ServerEditor_FormClosing(object _sender, FormClosingEventArgs _e) { Exit(); }
        private void QuitButton_Click(object _sender, EventArgs _e) { Exit(); }
        private void LobbyIdLabel_Click(object _sender, EventArgs _e) { }
        private void Tick_Tick(object _sender, EventArgs _e) { FirebaseEvent(); }
        protected override void m_MenuButton_Click(object _sender, EventArgs _e) { ShowMenu(); }
        #endregion

        #region NETWORK FUNCTIONS
        private void Init()
        {
            Run();
            firebase.FirebaseConnect();
            EnableDisable(playerGrid, false);

            if (host)
            {
                Create();
            }
            else if (!host)
            {
                Join();
            }
            Tick.Enabled = true;
        }
        private void FirebaseEvent()
        {
            
            Console.WriteLine("receiving enemy packet"); 
            firebase.FirebaseReceivePacket("lobbies", lobbyId, e_LobbyId);

            if (!firebase.isDirty)
            { // Guard clause no other values are checked if the data is unchanged
                return;
            }

            e_packet = firebase.packet;
            Interpret(e_packet.GameData, enemyGrid);
            
            p_SendGridData(playerGrid);

            if (placed && !l_placed)
            {
                state = "placed";
            }
            if (!l_joined && state == "joined" && e_packet.State == "joined")
            {
                Debug.WriteLineIf(!l_joined, l_joined);
                EnableDisable(playerGrid, true);
                l_joined = true;
                state = "placing";
                Console.WriteLine("All joined");
            }
            if (!l_placed && state == "placed" && e_packet.State == "placed")
            {
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
                l_shooting = true;
                Console.WriteLine("All placed");
            }

            if (state == "attacking" || state == "defending")
            {
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

            if (e_packet.State == "won")
            {
                state = "lost";

                Over();
                
                MessageBox.Show("Game over, lost");
            }
            else if (state == "won")
            {
                Over();

                MessageBox.Show("Game over, won!");
            }

            void Over()
            {
                shot = "null";
                p_SendGridData(playerGrid);
                GameWon();

                if (p_LobbyId[0] == '0')
                {
                    firebase.FirebaseDelete("lobbies", lobbyId);
                }

                Ticker.Enabled = false;
                Tick.Enabled = false;
            }
        }
        private void Create()
        {
            int CreateId()
            {
                var rand = new Random();

                return rand.Next(0, 99999);
            }
            lobbyId = CreateId().ToString();

            p_packet = new Packet(userId, userName, "null", gridSize, true, "joined", shot);
            e_packet = new Packet("null", "null", "null", gridSize, false, "waiting", shot);

            p_LobbyId = $"0_{lobbyId}";
            e_LobbyId = $"1_{lobbyId}";

            //Turn turn = new Turn(userId);

            firebase.FirebaseCreate("lobbies",lobbyId, p_LobbyId, p_packet);
            firebase.FirebaseSend("lobbies", lobbyId, p_LobbyId, p_packet);
            firebase.FirebaseCreate("lobbies", lobbyId, e_LobbyId, e_packet);
            firebase.FirebaseSend("lobbies", lobbyId, e_LobbyId, e_packet);
            //firebase.FirebaseCreate("lobbies", lobbyId, turn);

            LobbyIdLabel.Text = $"Lobby ID: {lobbyId}";

            Console.WriteLine("Created");
        }
        private void Send()
        {
            Packet packet = new Packet(userId, userName, "null", gridSize, false, "placing", shot);

            firebase.FirebaseSend("lobbies", lobbyId, p_LobbyId, packet);
        }
        private void Join()
        {
            Packet packet = new Packet(userId, userName, "null", gridSize, true, "joined", shot);

            lobbyId = port;
            p_LobbyId = $"1_{lobbyId}";
            e_LobbyId = $"0_{lobbyId}";

            firebase.FirebaseSend("lobbies", lobbyId, p_LobbyId, packet);
            LobbyIdLabel.Text = $"Lobby ID: {lobbyId}";
        }
        private void Exit()
        { // Closes out of the application entirely
            FirebaseClose();
            Quit.Exit();
        }
        private void FirebaseClose()
        { // Stops the ticking and sends a left message to the database
            Tick.Enabled = false;
            Ticker.Enabled = false;

            Packet packet = new Packet
                (
                userId, 
                userName, 
                "null", 
                10, 
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
        private void p_SendGridData(Button[,] _grid)
        { // Sends any updates to the clients data
            string data = CreateGridString(_grid);

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

            /*
             *  Packet constructor
             *  User Id
             *  Username
             *  Game data
             *  Grid size
             *  is dirty?
             *  User state
             */

            firebase.FirebaseUpdate("lobbies", lobbyId, p_LobbyId, packet);
        }
        private void e_SendGridData(Button[,] _grid)
        { // Sends any updates that the client has made on the enemy grid
            string data = CreateGridString(_grid);

            Packet packet = new Packet(
                e_packet.Id,
                e_packet.Name,
                data,
                gridSize,
                true,
                e_packet.State,
                e_packet.Shot
            );

            /*
             *  Packet constructor
             *  User Id
             *  Username
             *  Game data
             *  Grid size
             *  is dirty?
             *  User state
             */

            firebase.FirebaseUpdate("lobbies", lobbyId, e_LobbyId, packet);
        }
        #endregion

        #region GAME FUNCTIONS
        protected override void Event()
        {
            currentGridStringP = CreateGridString(playerGrid);
            currentGridStringE = CreateGridString(enemyGrid);

            Debug.WriteLine(currentGridStringP);
            Debug.WriteLine(currentGridStringE);

            void WriteAndAdd()
            {
                playersTurns.Add(currentGridStringP);
                enemiesTurns.Add(currentGridStringE);
            }

            void WriteToList()
            {
                playersTurns.Add(currentGridStringP);
                enemiesTurns.Add(currentGridStringE);
            }

            void GameStart()
            {
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

            if (IsChanged() && shooting == true)
            { // If the board has changed then the updated grid string is added to a list
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
        {
            playersTurns.Add(currentGridStringP);
            enemiesTurns.Add(currentGridStringE);

            EnableDisable(playerGrid, false);
            EnableDisable(enemyGrid, false);

            WriteResultToFile();
            PostGameResult();
        }
        protected override void ShootTile(object _sender, EventArgs _e)
        {
            Button button = (Button)_sender;
            ButtonData buttonData = (ButtonData)button.Tag;
            char type = buttonData.type;

            if (type == 'e')
            {
                type = 'm';

                l_shots++;

                //button.BackColor = Color.LightSlateGray;
            }
            else if (type == 's')
            {
                type = 'h';

                l_hits++;
                l_shots++;

                //button.BackColor = Color.MediumVioletRed;
            }
            buttonData.type = type;
            
            shot = $"{buttonData.x}, {buttonData.y}";
            l_shotTaken = true;
        }
        private void ShotUpdate(string _shot, Button[,] _grid)
        {
            if (_shot == "null")
            {
                return;
            }

            string[] shot = _shot.Split(',');
            int x = Convert.ToInt32(shot[0]);
            int y = Convert.ToInt32(shot[1]);

            ButtonData buttonData = (ButtonData)_grid[x, y].Tag;

            if (buttonData.type == 'e')
            {
                buttonData.type = 'm';
            }
            else if (buttonData.type == 's')
            {
                buttonData.type = 'h';
            }

            _grid[x, y].Tag = buttonData;
            UpdateGrid(_grid, debug);
        }
        #endregion

        #region DATABASE

        private void PostGameResult()
        {
            int GenerateId()
            {
                bool unique = false;
                var rand = new Random();
                int id = 0;

                while (!unique)
                {
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
            {
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
                             $"VALUES ({resultsId}, '{nameOne}', '{nameTwo}', {scoreOne}, {scoreTwo}, {shotsOne}, {shotsTwo}, {hitsOne}, {hitsTwo}, {missesOne}, {missesTwo}, '{gamemode}');";

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