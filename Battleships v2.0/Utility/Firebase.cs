#region USING
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;
using Newtonsoft.Json;
#endregion

namespace Battleships_v2._0 
{
    class Firebase 
    {
        #region VARIABLE
        private readonly IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Settings.AuthSecret,
            BasePath = Settings.BasePath
        };
        private IFirebaseClient client;
        public bool isDirty { get; set; }
        public string recieved { get; private set; }
        public Packet packet { get; private set; }
        #endregion

        #region CONSTRUCTOR & MEM MANAGMENT
        public Firebase() { }
        public void Dispose()
        {
            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e);
            }
        }
        #endregion

        #region FIRESHARP
        public void FirebaseConnect()
        { // Connects to a Firebase client 
            try
            { // Tries connection
                client = new FirebaseClient(config);
                if (client != null)
                { 
                    Console.WriteLine("Connected");
                }
                else
                { // If connection is null then failed
                    Console.WriteLine("Connection failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e);
            }
        }
        public void FirebaseDisconnect()
        { // Attempts to disconnect from the firebase database
            try
            { // Sets client to null
                client = null;

                // Forces garbage collection on memory
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                Console.WriteLine("Disconnected");
            }
            finally
            { // Then disposes of this instance of the class
                // Forces garbage collection on memory
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                this.Dispose();
            }
        }
        public async void FirebaseCreate(string _direct, string _lobbyId, string a_lobbyId, Object _data) 
        { // Sending any object to the database
            if (_data == null)
            {
                return;
            }

            try
            {
                SetResponse response = await client.SetAsync($"{_direct}/{_lobbyId}/{a_lobbyId}", _data);
                var result = response.ResultAs<Object>();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating lobby, {0}", ex);
            }
        }
        public async void FirebaseSend(string _direct, string _lobbyId, string p_lobbyId, Object _data)
        { // Sends data to the database
            if (_data == null)
            {
                return;
            }

            try
            { // Tries to send a packet with the given object
                SetResponse response = await client.SetAsync($@"{_direct}/{_lobbyId}/{p_lobbyId}", _data);
                var result = response.ResultAs<Object>();
                //Console.WriteLine(result);
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Sending Packet, {0}", ex);
            }
        }
        public async void FirebaseSend(string _source, Object _data)
        { // Sends a packet to a desired source
            try
            {
                PushResponse push = await client.PushAsync($"{_source}", _data);
                var result = push.ResultAs<Object>();
                //Console.WriteLine(result);
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Sending Data to Database, {0}", ex);
            }
        }
        public async void FirebaseUpdate(string _direct, string _lobbyId, string p_lobbyId, Object _data)
        { // Updates given data in the database
            try
            {
                SetResponse response = await client.SetAsync($"{_direct}/{_lobbyId}/{p_lobbyId}", _data);
                var result = response.ResultAs<Object>();
                //Console.WriteLine(result);
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating {0}", ex);
            }
        }
        public async void FirebaseUpdate(string _source, Object _data)
        { // Sends an object to a database
            try
            { // Tries to send object to database
                SetResponse update = await client.SetAsync($"{_source}", _data);
                var result = update.ResultAs<Object>();
                //Console.WriteLine(result);
                Debug.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Updating Database, {0}", ex);
            }
        }
        public async Task<Object> FirebaseReceive(string _direct, string _lobbyId, string a_lobbyId)
        { // Task that returns data from the database as an object
            try
            {
                FirebaseResponse response = await client.GetAsync($"{_direct}/{_lobbyId}/{a_lobbyId}");
                var data = response.ResultAs<Object>();

                if (data != null)
                {
                    isDirty = true;
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error {0}", ex);
                return null;
            }
        }
        public async void FirebaseReceive(string _source)
        { // Retrieves data from database via a given source
            FirebaseResponse response = await client.GetAsync($"{_source}");
            Dictionary<string, string> data =
                JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Body.ToString());

            if (data == null)
            {
                return;
            }

            recieved = data.ElementAt(1).Value;
            isDirty = true;
        }
        public async void FirebaseReceivePacket(string _direct, string _lobbyId, string a_lobbyId)
        { // Receives a packet from the datbase
            try
            { // A response is set for a directory
                FirebaseResponse response = await client.GetAsync($@"{_direct}/{_lobbyId}/{a_lobbyId}");
                // Data is then deserialized
                Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Body.ToString());

                // A packet is made from the deserialized data
                packet = new Packet(
                    data.ElementAt(2).Value,                    
                    data.ElementAt(4).Value,                    
                    data.ElementAt(0).Value,                     
                    Convert.ToInt32(data.ElementAt(1).Value),   
                    Convert.ToBoolean(data.ElementAt(3).Value), 
                    data.ElementAt(6).Value,
                    data.ElementAt(5).Value
                );

                /* Data format
                    ID,
                    Name,
                    Game Data,
                    Grid Size,
                    Is Dirty,
                    State
                 */

                if (packet.IsDirty == true)
                {
                    isDirty = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Firebase Packet Reception {0}", ex);
            }
        }
        public async void FirebaseDelete(string _direct, string _lobbyId)
        {
            try
            {
                FirebaseResponse response = await client.DeleteAsync($"{_direct}/{_lobbyId}");
                var result = response.ResultAs<Object>();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting data, {0}", ex);
            }
        }
        #endregion
    }
}