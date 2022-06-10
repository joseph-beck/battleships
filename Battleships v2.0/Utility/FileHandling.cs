#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
#endregion

namespace Battleships_v2._0 
{
    class FileHandling 
    {
        private static ConsoleOutputs consoleOutputs = new ConsoleOutputs();
        public void CreateNewFile(string _name, string _source) 
        { // This function creates a new file with a specified name at a specified source
            try
            {
                StreamWriter streamWriter = File.CreateText($"{_source}\\{_name}.txt");
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Creating File, {0}", ex);
            }
        }
        public string GetStringFromFile(string _source)
        { // This function returns a string from a file
            try
            {
                string data = File.ReadAllText(_source);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Reading to String, {0}", ex);
            }

            return null;
        }
        public string[] Get1DArrayFromFile(string _source) 
        { // This function returns a 1D array from a file
            try
            {
                string[] data = File.ReadAllLines(_source);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Reading to 1D Array, {0}", ex);
            }
            return null;
        }
        public string[,] Get2DArrayFromFile(string _source, string _seperator)
        { // This function returns a 2D array from a file
            try
            { // The writer first writes to 1D array
                string[] tempData = File.ReadAllLines(_source);
                int count = 1;

                // The array is then searched through to find a separator which is given by the user
                // If the separator is found the count is increased
                for (int i = 0; i < tempData.Length; i++)
                {
                    if (tempData[i] == _seperator) count++;
                }

                // Some calculations are made to find out the dimensions of the 2D array
                // This is based on the amount of seperators
                int size = (tempData.Length - count + 1) / count;
                string[,] data = new string[count, size];
                int index = 0;

                // The tempData is then iterated through one more time to produce a new 2D array
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (tempData[index] == _seperator) index++;

                        data[i, j] = tempData[index];
                        index++;
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Reading to 2D Array, {0}", ex);
            }
            return null;
        }
        public void WriteArrayToFile(string[] _input, string _source)
        { // This function writes a 1D array to a file
            try
            {
                StreamWriter streamWriter = new StreamWriter(_source);

                // The given input array is then iterated through
                // For each value in the array a new line is written in the given file
                for (int i = 0; i < _input.Length; i++)
                {
                    streamWriter.WriteLine(_input[i]);
                }

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Writing to File, {0}", ex);
            }
        }
        public void Write2DArrayToFile(string[,] _input, string _source) 
        { // TBC
            try
            {
                StreamWriter streamWriter = new StreamWriter(_source);

                for (int i = 0; i < _input.Length; i++)
                {
                    streamWriter.WriteLine(_input[i, 0]);
                }

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured Writing to File, {0}", ex);
            }
        }
        public void WriteListToFile(List<string> _input, string _source)
        { // This function writes a list array to a file
            try
            {
                StreamWriter streamWriter = new StreamWriter(_source);

                // The given input list is then iterated through
                // For each value in the list a new line is written in the given file
                for (int i = 0; i < _input.Count; i++)
                {
                    streamWriter.WriteLine(_input[i]);
                }

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Writing to File, {0}", ex);
            }
        }
        public void Write2ListsToFile(List<string> _inputOne,List<string> _inputTwo, string _seperator, string _source) 
        { // This function writes 2 lists to a file
            try
            {
                StreamWriter streamWriter = new StreamWriter(_source);

                // The first given input list is then iterated through
                // For each value in the first list a new line is written in the given file
                for (int i = 0; i < _inputOne.Count; i++)
                {
                    streamWriter.WriteLine(_inputOne[i]);
                }

                // The same then occurs for the second list
                streamWriter.WriteLine(_seperator);
                for (int i = 0; i < _inputTwo.Count; i++)
                {
                    streamWriter.WriteLine(_inputTwo[i]);
                }

                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Writing Multiple Lists to File, {0}", ex);
            }
        }
        public void WriteStringToFile(string _input, string _source) 
        { // This function writes a single string to a file
            try
            {
                StreamWriter streamWriter = new StreamWriter(_source);
                streamWriter.WriteLine(_input);
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Writing to File, {0}", ex);
            }
        }
        public void WriteArrayToNewFile(string[] _input, string _name, string _source)
        { // This function creates a new file and writes an array to it
            try
            {
                StreamWriter streamWriter = File.CreateText($"{_source}\\{_name}.txt");
                streamWriter.Close();
                WriteArrayToFile(_input, ($"{_source}\\{_name}.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Writing to File, {0}", ex);
            }
        }
        public void WriteStringToNewFile(string _input, string _name, string _source) 
        { // This functions creates a new file and writes a string to it
            try
            {
                StreamWriter streamWriter = File.CreateText($"{_source}\\{_name}.txt");
                streamWriter.Close();
                WriteStringToFile(_input, ($"{_source}\\{_name}.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred Writing to File, {0}", ex);
            }
        }
    }
}
