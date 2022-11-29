using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Models
{
    internal class SignupModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }    

        public SignupModel(string id, string password, string name)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
