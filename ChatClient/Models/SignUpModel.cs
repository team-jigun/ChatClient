using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public class SignUpModel
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public SignUpModel(string id, string password, string name)
        {
            Id = id;
            Password = password;
            Name = name;
        }
    }
}
