using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships_v2._0
{
    public partial class GameJoiner : Form
    {
        #region CLASS VARIABLES
        private Firebase firebase = new Firebase();
        
        private string lobbyId;
        private string e_lobbyId;

        private Packet packet;

        private int tries = 0;
        #endregion

        #region FORM FUNCTIONS
        public GameJoiner() { InitializeComponent(); }
        private void GameJoiner_Load(object _sender, EventArgs _e) { Init(); }
        private void m_LobbyIdBox_TextChanged(object _sender, EventArgs _e) { BoxEmpty(); }
        private void m_MenuButton_Click(object _sender, EventArgs _e) { ShowMenu(); }
        private void m_JoinButton_Click(object _sender, EventArgs _e) { JoinGame(); }
        private void m_ConfirmButton_Click(object _sender, EventArgs _e) { Confirm(); }
        #endregion

        #region JOINER FUNCTIONS
        private void Init()
        { // Connects to the database 
            firebase.FirebaseConnect();
        }
        private void BoxEmpty()
        { // If the box is empty then a game cant be joined
            if (m_LobbyIdBox.Text == "")
            {
                m_JoinButton.Enabled = false;
                m_ConfirmButton.Enabled = false;
                return;
            }

            m_ConfirmButton.Enabled = true;
        }
        private void Disconnect()
        { // Disconects from firebase database
            firebase.FirebaseDisconnect();
            firebase.Dispose();
        }
        private void Confirm()
        { // Confirm button functionality
            JoinGame();
            m_JoinButton.Enabled = true;
            m_ConfirmButton.Enabled = false;
            m_LobbyIdBox.ReadOnly = true;
        }
        private void Reset()
        { // Resets the whole form
            m_LobbyIdBox.ReadOnly = false;
            m_LobbyIdBox.Text = "";
            m_JoinButton.Enabled = false;
            m_ConfirmButton.Enabled = false;
        }
        private int GetGridSize()
        { // Gets the grid size from a given lobby id
            firebase.FirebaseReceivePacket("lobbies", lobbyId, e_lobbyId);
            packet = firebase.packet;

            // If the packet is not null then it tries to get the grid size
            if (packet != null)
            {
                return packet.GridSize;
            }

            return -1;
        }
        private void JoinGame()
        { // Tries to join a game
            lobbyId = m_LobbyIdBox.Text;
            e_lobbyId = $"0_{m_LobbyIdBox.Text}";

            int f_GridSize = GetGridSize();


            if (f_GridSize == -1)
            {
                Console.WriteLine(tries);
                if (tries == 1)
                {
                    MessageBox.Show("No Game Found!");
                    Reset();
                    tries = 0;
                    return;
                }
                tries++;
                return;
            }

            // If the grid size is not -1 then it not invalid and allows the user to connect
            // The client is then constructed and started and this is disposed
            Disconnect();

            var nextForm = new Online(f_GridSize, false, lobbyId);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion

        #region NAVIGATION
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

        
    }
}
