using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ChatClient.Models
{
    public class ChatMessage
    {
        private string _username;
        private string _message;
        private bool _currentUser;

        public string Username { get => _username; }
        public string Message { get => _message; }

        public HorizontalAlignment MessageAlignment { get => _currentUser ? HorizontalAlignment.Right : HorizontalAlignment.Left; }

        public ChatMessage(string username, string message, bool currentUser)
        {
            _username = username;
            _message = message;
            _currentUser = currentUser;
        }
    }
}
