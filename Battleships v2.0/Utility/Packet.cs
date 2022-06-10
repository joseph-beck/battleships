#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0
{
    class Packet 
    { // Packet class used for sending data to the Firebase database (FBDB), this is also applicable for the recieving of data from the FBDB.
        public Packet(string _id, string _name, string _gameData, int _gridSize, bool _isDirty, string _state, string _shot)
        {
            Id = _id;
            Name = _name;
            GameData = _gameData;
            GridSize = _gridSize;
            IsDirty = _isDirty;
            State = _state;
            Shot = _shot;
        }
        public Packet()
        {
            
        }
        public string Id { get; set; }
        public string Name { get; set; }    
        public string GameData { get; set; }
        public int GridSize { get; set; }
        public bool IsDirty { get; set; }
        public string State { get; set; }
        public string Shot { get; set; }
    }
}
