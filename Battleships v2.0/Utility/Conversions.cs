#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0.Utility
{
    class Conversions
    {
        public string[] ListToArray(List<string> _input)
        {
            string[] data = new string[_input.Count];

            for (int i = 0; i < _input.Count; i++)
            {
                data[i] = _input[i];
            }
            return data;
        }
        public int[] ListToArray(List<int> _input)
        {
            int[] data = new int[_input.Count];

            for (int i = 0; i < _input.Count; i++)
            {
                data[i] = _input[i];
            }
            return data;
        }
    }
}
