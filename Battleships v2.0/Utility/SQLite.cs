#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Threading;
using System.Windows.Forms;
#endregion

namespace Battleships_v2._0 
{
    class SQLite 
    {
        public static SQLiteConnection Connect(string _source) 
        { // Connects to an SQLite Database of specified location
            SQLiteConnection sqliteConn = new SQLiteConnection($"Data Source={_source}");

            try 
            { // Tries to open the connection
                sqliteConn.Open();
            }
            catch (Exception ex) 
            { // If it fails then an exception occurs the error code is printed
                Console.WriteLine("Connection error {0}", ex.Message);
            }
            return sqliteConn;
        }
        public void Disconnect(string _source)
        { // Disconnects from SQLite Database
            try
            {
                SQLiteConnection connection = Connect(_source);
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }
        }
        public int WriteFromString(string _source, string _input, string _command) 
        { // Writes fromm a given command and input
            try
            { // Connects to database
                SQLiteConnection connection = Connect(_source);

                // The command is created
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;
                command.ExecuteNonQuery();

                // The reader then checks the amount of records affected as a result of that command
                SQLiteDataReader reader = command.ExecuteReader();
                int rowsAffected = reader.RecordsAffected;

                // All connections are then closed
                reader.Close();
                connection.Close();

                return rowsAffected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }

            return -1;
        }
        public void WriteFromString(string _source, string _input, string _command, string _s) 
        { // Writes fromm a given command and input
            try
            {
                // Connects to the database
                SQLiteConnection connection = Connect(_source);

                // User given command is executed
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }
        }
        public int WriteFromCommand(string _source, string _command, string _s) 
        { // Writes from a given command
            try
            { // Connects to the database
                SQLiteConnection connection = Connect(_source);

                // User given command is executed
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;
                command.ExecuteNonQuery();

                // Amount of affected lines is calculated
                SQLiteDataReader reader = command.ExecuteReader();
                int rowsAffected = reader.RecordsAffected;

                // Connections to the database are closed
                reader.Close();
                connection.Close();

                // Amount of affected rows is returned
                return rowsAffected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }

            return -1;
        }
        public void WriteFromCommand(string _source, string _command) 
        { // Writes from a given command
            try
            { // Connects to the database
                SQLiteConnection connection = Connect(_source);

                // User given command is executed
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;
                command.ExecuteNonQuery();

                // Connection then closed once finished
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }
        }

        public void WriteFromArray(string _command, string _source, string[] input)
        { // NULL

        }
        public List<string[]> ReadToListOfArray(string _command, string _source) 
        { // Reads a given command to a list of arrays
            try
            { // Connects to the database
                SQLiteConnection connection = Connect(_source);

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;

                SQLiteDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    string[] reading = new string[reader.FieldCount];

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        reading[i] = reader.GetValue(i).ToString();
                    }

                    data.Add(reading);
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }
            return null;
        }
        public string[,] ReadTo2DArray( string _command, string _source) 
        { // Reads a given command into a 2D array
            try
            {
                SQLiteConnection connection = Connect(_source);
                // Connection to database is opened

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;
                SQLiteDataReader reader = command.ExecuteReader();

                int rows = 0;
                while (reader.Read())
                {
                    rows++;
                }

                reader.Close();

                reader = command.ExecuteReader();
                string[,] data = new string[rows, reader.FieldCount];
                int j = 0;

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data[j, i] = reader.GetValue(i).ToString();
                    }
                    j++;
                }

                reader.Close();
                connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error encountered reading to 2D array, {0}", ex);
            }
            return null;
        }
        public string[] ReadTo1DArray(string _command, string _source, int _index) 
        { // For queries that will have a single row
            try
            { // Connection to database is opened
                SQLiteConnection connection = Connect(_source);

                // Command is created
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;
                SQLiteDataReader reader = command.ExecuteReader();

                // Bounds of the array is calculated
                int rows = 0;
                while (reader.Read())
                {
                    rows++;
                }

                // Reader then closed
                reader.Close();

                // Variables initialized 
                string[] data = new string[rows];
                int i = 0;

                // Data is then read into the data array from the database
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data[i] = reader.GetValue(_index).ToString();
                    i++;
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }

            return null;
        }
        public string[] ReadTo1DArray(string _command, string _source) 
        { // For queries that will have a single row
            try
            {
                // Connection to database is opened
                SQLiteConnection connection = Connect(_source);

                // Command is created and reader is initialized
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;
                SQLiteDataReader reader = command.ExecuteReader();

                // Size of the array is calculated
                int rows = 0;
                while (reader.Read())
                {
                    rows++;
                }
                reader.Close();

                // Data is initialized 
                string[] data = new string[rows];
                int i = 0;

                // Command is executed
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data[i] = reader.GetValue(0).ToString();
                    i++;
                }
                reader.Close();

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }

            return null;
        }
        public List<string> ReadToList(string _command, string _source) 
        { // Writes a given command to a list
            try
            {
                // Data variables are initialized
                List<string> data = new List<string>();
                int i = 0;

                // Connection is opened
                SQLiteConnection connection = Connect(_source);

                // The command is then created
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;

                // Command is executed and data is added to the list
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(reader.GetValue(i).ToString());
                    ;
                    Console.WriteLine(data[i]);
                    i++;
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }
            return null;
        }
        public string ReadToString(string _command, string _source) 
        { // Writes a given command to a string - often expect a single value only
            try
            { // Connection is opened
                SQLiteConnection connection = Connect(_source);

                // Command is created
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;

                // Reader is started with the command
                SQLiteDataReader reader = command.ExecuteReader();
                string data = "";

                while (reader.Read())
                {
                    data = reader.GetValue(0).ToString();
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }

            return null;
        }
        public int GetFieldCount(string _command, string _source) 
        { // Returns the field count of a given command
            try
            { // Connection is opened
                SQLiteConnection connection = Connect(_source);

                // Command is constructed
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = _command;

                // Command is executed and the the field count is calculated
                SQLiteDataReader reader = command.ExecuteReader();

                int fields = reader.FieldCount;
                reader.Close();

                // The field count is then returned
                return fields;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Disconnection error {0}", ex.Message);
            }
            return -1;
        }
    }
}
