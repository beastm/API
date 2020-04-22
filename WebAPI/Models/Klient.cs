using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Klient
    {

        public int id { get; set; }
        public string info { get; set; }
        public string  ip { get; set; }
        public string mac_adr { get; set; }
        public string name { get; set; }
    }
}