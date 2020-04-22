using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Report
    {
        public int id { get; set; }
        public int id_client { get; set; }
        public string popis { get; set; }
        public string Template_Name { get; set; }
        public string Backup_Report { get; set; }
    }
}