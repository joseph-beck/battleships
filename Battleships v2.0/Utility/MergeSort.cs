#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0
{
    class MergeSort
    {
        #region INT ARRAY
        public void Merge(int[] _array, int _left, int _mid, int _right)
        {
            // Sets up two regions of the array, this is how they are later split
            // n1 shows the left hand side of the array with n2 showing the right
            int n1 = _mid - _left + 1;
            int n2 = _right - _mid;

            int[] Left = new int[n1];
            int[] Right = new int[n2];

            int i, j;

            // These two loops populate the split arrays with the required data from the inputted array
            for (i = 0; i < n1; i++)
            {
                Left[i] = _array[i + _left];
            }
            for (j = 0; j < n2; j++)
            {
                Right[j] = _array[_mid + j + 1];
            }

            i = j = 0;
            int count = _left;


            // Comparisons are then on whether the values inside need to be shifted or not
            while (i < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    _array[count] = Left[i];
                    i++;
                }
                else
                {
                    _array[count] = Right[j];
                    j++;
                }
                count++;
            }

            // This then reconstructs the two halves of the array 
            while (i < n1)
            {
                _array[count] = Left[i];
                i++;
                count++;
            }
            while (j < n2)
            {
                _array[count] = Right[j];
                j++;
                count++;
            }
        }
        public void Sort(int[] _array, int _left, int _right)
        { // This sets up the sorting of the array getting sizes for the different parts of the array so that they can be split
            if (_left < _right)
            {
                int mid = _left + (_right - _left) / 2;

                // The Sort function is recursive, it continues splitting the array(s) further.
                Sort(_array, _left, mid);
                Sort(_array, mid + 1, _right);

                Merge(_array, _left, mid, _right);
                Print(_array);
            }
        }
        public void PrintAsync(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Thread.Sleep(200);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        public void Print(int[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }

            Console.WriteLine("");
        }
        public int[] Run(int[] _array)
        { // Run initializes the sort and then returns it once it has been complete
            Sort(_array, 0, _array.Length - 1);

            return _array;
        }
        #endregion

        #region STRING ARRAY
        /*public void Merge(string[] _array, int _left, int _mid, int _right)
        {
            int n1 = _mid - _left + 1;
            int n2 = _right - _mid;

            string[] Left = new string[n1];
            string[] Right = new string[n2];

            int i, j;

            for (i = 0; i < n1; i++)
            {
                Left[i] = _array[i + _left];
            }
            for (j = 0; j < n2; j++)
            {
                Right[j] = _array[_mid + j + 1];
            }

            i = j = 0;
            int count = _left;

            while (i < n1 && j < n2)
            {
                if (Left[i]. <= Right[j])
                {
                    _array[count] = Left[i];
                    i++;
                }
                else
                {
                    _array[count] = Right[j];
                    j++;
                }
                count++;
            }

            while (i < n1)
            {
                _array[count] = Left[i];
                i++;
                count++;
            }
            while (j < n2)
            {
                _array[count] = Right[j];
                j++;
                count++;
            }
        }
        public void Sort(string[] _array, int _left, int _right)
        {
            if (_left < _right)
            {
                int mid = _left + (_right - _left) / 2;

                Sort(_array, _left, mid);
                Sort(_array, mid + 1, _right);

                Merge(_array, _left, mid, _right);
                Print(_array);
            }
        }
        public async void PrintAsync(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Thread.Sleep(200);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        public void Print(string[] _array)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }

            Console.WriteLine("");
        }
        public int[] Run(string[] _array)
        {
            Sort(_array, 0, _array.Length - 1);

            return _array;
        }*/
        #endregion
    }
}