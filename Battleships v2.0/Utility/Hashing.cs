#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
#endregion

namespace Battleships_v2._0 
{
    class Hashing 
    {
        public string SHA256Hash(string _input) 
        { // Takes input and returns SHA256 hashed string
            using (SHA256 sha256 = SHA256.Create()) 
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(_input));
                // New string builder for the result
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) 
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                // Returns the final string builder value
                return builder.ToString();
            }
        }
        public string MD5Hash(string _input) 
        { // Takes input and returns MD5 hashed string
            using (MD5 md5 = MD5.Create()) 
            {
                byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(_input));
                // New string builder for the result
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) 
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                // Returns the final string builder value
                return builder.ToString();
            }
        }
    }
}
