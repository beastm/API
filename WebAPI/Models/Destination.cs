using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Destination
    {
        public int id { get; set; }
        public string FTP_config { get; set; }
        public string LD_path { get; set; }
    }
}