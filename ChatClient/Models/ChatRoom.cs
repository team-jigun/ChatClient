using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Models
{
    public class ChatRoom
    {
        private int _id;
        private string _name;
        public int Id { get => _id; }
        public string Name { get => _name; }
        
        public ChatRoom(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
