using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatClient.Models
{
    public class AccessTokenModel
    {
        //[JsonPropertyName("token")]
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
