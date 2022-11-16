﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    public class SignInModel
    {
        public string Id { get; set; }
        public string Password { get; set; }

        public SignInModel(string id, string password)
        {
            Id = id;
            Password = password;
        }
    }
}