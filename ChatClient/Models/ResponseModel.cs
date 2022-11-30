using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Models
{
    public class ResponseModel<T>
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public T? Options { get; set; }
    }
}
