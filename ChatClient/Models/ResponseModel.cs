using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Models
{
    public class ResponseModel<T>
    {

        public  string code { get; set;}


        public  string message { get; set;}

        public T? options { get; set; }
    }
}
