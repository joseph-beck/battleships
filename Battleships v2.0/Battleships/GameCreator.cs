using System;
using System.Collections.Generic;
using System.ComponentModel;
#region USING
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Battleships_v2._0
{
    public partial class GameCreator : Form
    {
        #region CLASS VARIABLES
        private readonly int[] gridSizes =
        {
            5, 6, 7, 8 ,9 ,10 ,11, 12, 13, 14, 15
        };
        private readonly string[] gamemodes =
        {
            "Battleships", "Scatterships"
        };
        #endregion

        #region FORM FUNCTIONS
        public GameCreator() { InitializeComponent(); }
        private void GameCreator_Load(object _sender, EventArgs _e) { Init(); }
        private void m_StartButton_Click(object _sender, EventArgs _e) { CreateGame(); }
        private void m_GameMode_SelectedIndexChanged(object _sender, EventArgs _e) { }
        private void m_GridSize_SelectedIndexChanged(object _sender, EventArgs _e) { FilterEmpty(); }
        private void m_MenuButton_Click(object _sender, EventArgs _e) { ShowMenu(); }
        #endregion

        #region CREATOR FUNCTIONS
        private void Init()
        { // Initializes the form, sets the combo box variables
            for (int i = 0; i < gridSizes.Length; i++)
            {
                m_GridSize.Items.Add(gridSizes[i]);
            }

            for (int i = 0; i < gamemodes.Length; i++)
            {
                m_GameMode.Items.Add(gamemodes[i]);
            }
        }
        private void CreateGame()
        { // Creates a game based on the given grid size
            int gridSize = gridSizes[m_GridSize.SelectedIndex];

            var nextForm = new Online(gridSize, true);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void FilterEmpty()
        {
            if (m_GridSize.SelectedIndex == -1)
            {
                m_StartButton.Enabled = false;
            }
            else
            {
                m_StartButton.Enabled = true;
            }
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
