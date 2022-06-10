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
    public partial class Battleships : Game
    {

        public Battleships(int _gridSize) : base(_gridSize) { InitializeComponent(); }
        private void Battleships_Load(object _sender, EventArgs _e) { Run(); }
    }
}
