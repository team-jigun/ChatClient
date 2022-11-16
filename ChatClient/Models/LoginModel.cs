using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Models
{
	public class LoginModel
	{
		public string Id {get; set; }
		public string Password {get; set; }

		public LoginModel(String id, String password)
		{
			Id = id;
			Password = password;
		}
	}
}
