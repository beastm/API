using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Get
    {
        //Template
        public string Template_name { get; set; }
        public string Backup_type { get; set; }
        public string Cronos_config { get; set; }
        public string Save_format { get; set; }
        public int Destination_id { get; set; }
        public DateTime Date_s { get; set; }
        public DateTime Date_e { get; set; }      
        public string path { get; set; }
        public int B_Limit { get; set; }


        //Job
        public int id_client { get; set; }
        public int id_report { get; set; }
        public int id_template { get; set; }

    }
}