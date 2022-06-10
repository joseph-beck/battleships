#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 

namespace Battleships_v2._0 
{
    class Ship 
    {
        public string type { get; }
        public int size { get; }
        public string name { get; }
        public Ship(string _type, int _size, string _name)
        {
            type = _type;
            size = _size;
            name = _name;
        }
    }
}
