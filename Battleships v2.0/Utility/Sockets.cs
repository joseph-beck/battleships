#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
#endregion

namespace Battleships_v2._0 
{
    class Sockets 
    {
        public static Socket Connect(string _server, int _port) 
        {
            Socket socket = null;
            IPHostEntry hostEntry = null;

            hostEntry = Dns.GetHostEntry(_server);

            foreach (IPAddress address in hostEntry.AddressList) {
                IPEndPoint endPoint = new IPEndPoint(address, _port);
                Socket tempSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                tempSocket.Connect(endPoint);

                if (tempSocket.Connected) 
                {
                    socket = tempSocket;
                    break;
                }
            }
            return socket;
        }
        public void Disconnect(Socket _server) 
        {
            try 
            {
                _server.Shutdown(SocketShutdown.Both);
            }
            finally 
            {
                _server.Close();
            }
        }
        public int Send(Socket _server, String _data) 
        {
            byte[] data = Encoding.UTF8.GetBytes(_data);
            byte[] bytes = new byte[256];

            try 
            {
                int byteCount = _server.Send(data, 0, data.Length, SocketFlags.None);
                Console.WriteLine("Sent {0} bytes.", byteCount);
            }
            catch (SocketException e) 
            {
                Console.WriteLine("{0} Error code: {1}", e.Message, e.ErrorCode);
                return (e.ErrorCode);
            }
            return 0;
        }
        public string Receive(Socket _server) 
        {
            byte[] bytes = new byte[256];

            try 
            {
                int byteCount = _server.Receive(bytes, 0, bytes.Length, SocketFlags.None);
                if (byteCount > 0)
                {
                    Console.WriteLine($"{Encoding.UTF8.GetString(bytes, 0, byteCount)} WAS RECEIVED");
                    return Encoding.UTF8.GetString(bytes, 0, byteCount);
                }
            }
            catch (SocketException e) 
            {
                Console.WriteLine("{0} Error code: {1}", e.Message, e.ErrorCode);
                return (e.ErrorCode).ToString();
            }
            return "0";
        }
    }
}
