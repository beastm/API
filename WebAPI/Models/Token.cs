using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Token
    {
        public int id { get; set; }
        public string username { get; set; }        
        public string hash { get; set; }
    }
}