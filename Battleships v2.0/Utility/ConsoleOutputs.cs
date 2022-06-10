#region USING
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0 
{
    class ConsoleOutputs 
    {
        #region CONSOLE
        public void Console2D(string[,] _array) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _array.GetLength(0); i++) 
            {
                for (var j = 0; j < _array.GetLength(1); j++) 
                {
                    Console.WriteLine($"{_array[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("ENDING");
        }
        public void Console2D(int[,] _array) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _array.GetLength(0); i++)
            {
                for (var j = 0; j < _array.GetLength(1); j++) 
                {
                    Console.WriteLine($"{_array[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("ENDING");
        }
        public void Console2D(string[,] _array, int _inner, int _outer) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _inner; i++) 
            {
                for (var j = 0; j < _outer; j++) 
                {
                    Console.WriteLine($"{_array[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("ENDING");
        }
        public void Console2D(int[,] _array, int _inner, int _outer) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _inner; i++) 
            {
                for (var j = 0; j < _outer; j++) 
                {
                    Console.WriteLine($"{_array[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("ENDING");
        }
        public void Console1D(string[] _array) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _array.Length; i++) 
            {
                Console.WriteLine($"{_array[i]}");
            }
            Console.WriteLine("ENDING");
        }
        public void Console1D(int[] _array) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _array.Length; i++) 
            {
                Console.WriteLine($"{_array[i]}");
            }
            Console.WriteLine("ENDING");
        }
        public void Console1D(string[] _array, int _length) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _length; i++) 
            {
                Console.WriteLine($"{_array[i]}");
            }
            Console.WriteLine("ENDING");
        }
        public void Console1D(int[] _array, int _length) 
        {
            if (_array == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _length; i++) 
            {
                Console.WriteLine($"{_array[i]}");
            }
            Console.WriteLine("ENDING");
        }
        public void List1D(List<string> _list, int _length)
        {
            if (_list == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _length; i++)
            {
                Console.WriteLine($"{_list[i]}");
            }
            Console.WriteLine("ENDING");
        }
        public void List1D(List<int> _list, int _length)
        {
            if (_list == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _length; i++)
            {
                Console.WriteLine($"{_list[i]}");
            }
            Console.WriteLine("ENDING");
        }
        public void List1D(List<string> _list)
        {
            if (_list == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _list.Count; i++)
            {
                Console.WriteLine($"{_list[i]}");
            }
            Console.WriteLine("ENDING");
        }
        public void List1D(List<int> _list)
        {
            if (_list == null)
            {
                return;
            }

            Console.WriteLine("OUTPUTTING");
            for (var i = 0; i < _list.Count; i++)
            {
                Console.WriteLine($"{_list[i]}");
            }
            Console.WriteLine("ENDING");
        }
        #endregion

        #region DEBUG
        public void Debug2D(string[,] _array) {
            for (int i = 0; i < _array.GetLength(0); i++) {
                for (int j = 0; j < _array.GetLength(1); j++) {
                    Debug.WriteLine($"{_array[i, j]} ");
                }
                Debug.WriteLine("");
            }
        }
        public void Debug2D(int[,] _array) {
            for (int i = 0; i < _array.GetLength(0); i++) {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Debug.WriteLine($"{_array[i, j]} ");
                }
                Debug.WriteLine("");
            }
        }
        public void Debug1D(string[] _array) {
            for (int i = 0; i < _array.Length; i++) {
                Debug.WriteLine($"{_array[i]}");
            }
        }
        public void Debug1D(int[] _array) {
            for (int i = 0; i < _array.Length; i++) {
                Debug.WriteLine($"{_array[i]}");
            }
        }
        #endregion
    }
}
