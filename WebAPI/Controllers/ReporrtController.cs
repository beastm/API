using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    public class ReportController : ApiController
    {
        private MyContext context = new MyContext();


        public IEnumerable<Report> Get()
        {
            return this.context.Reports;
        }


        public Report Get(int id)
        {
            return this.context.Reports.Find(id);
        }

        // POST: api/Report
        public void Post([FromBody]Report report)
        {
            this.context.Reports.Add(report);
            this.context.SaveChanges();
        }

        public void Put(int id, [FromBody]Report report)
        {
            Report current = this.context.Reports.Find(id);

            current.id = report.id;
            current.id_client = report.id_client;
            current.popis = report.popis;
            current.Template_Name = report.Template_Name;
            current.Backup_Report = report.Backup_Report;

            this.context.SaveChanges();
        }

        // DELETE: api/Report/5
        public void Delete(int id)
        {
            Report report = this.context.Reports.Find(id);

            this.context.Reports.Remove(report);
            this.context.SaveChanges();
        }
    }
}
