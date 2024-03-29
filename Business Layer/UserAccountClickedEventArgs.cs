using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project.Business_Layer
{
    public class UserAccountClickedEventArgs : EventArgs
    {
        public string Username { get; }
        public string Password { get; }

        public UserAccountClickedEventArgs(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public UserAccountClickedEventArgs(string username)
        {
            Username = username;
        }
    }
}
