#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0 
{
    static class CurrentUser 
    {
        static CurrentUser() 
        {
             
        }
        public static void Init(string _userid, string _username, string _firstname, string _lastname) 
        {
            UserId = _userid;
            Username = _username;
            FirstName = _firstname;
            LastName = _lastname;
        }
        public static string UserId { get; private set; }
        public static string Username { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }
    }
}
