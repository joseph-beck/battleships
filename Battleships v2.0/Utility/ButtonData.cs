#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0 
{
    class ButtonData 
    {
        public int x { get; set; }
        public int y { get; set; }
        public char type { get; set; }
        public ButtonData(int _x, int _y, char _type) 
        {
            x = _x;
            y = _y;
            type = _type;
        }
    }
}
