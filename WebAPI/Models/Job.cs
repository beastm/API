using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Job
    {
        public int id { get; set; }
        public int id_client { get; set; }
        public int id_report { get; set; }
        public int id_template { get; set; }
    }
}