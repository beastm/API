using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class DataFromTo
    {
        public int id_dest { get; set; }
        public string FTP_config { get; set; }
        public string LD_path { get; set; }

        //obj
        public int id_obj { get; set; }
        public string path { get; set; }
    }
}