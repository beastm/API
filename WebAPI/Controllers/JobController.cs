using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class JobController : ApiController
    {
        private MyContext context = new MyContext();

        // GET: api/Job/5
        public IEnumerable<Job> Get()
        {
            return this.context.Jobs;
        }

        // GET: api/Job/5
        public Job Get(int id)
        {
            return this.context.Jobs.Find(id);
        }

        // POST: api/Job/5
        public void Post([FromBody]Destination destination)
        {
            this.context.Destinations.Add(destination);
            this.context.SaveChanges();
        }

        // PUT: api/Job/5
        public void Put(int id, [FromBody]Job job)
        {
            Job current = this.context.Jobs.Find(id);

            current.id = job.id;
            current.id_client = job.id_client;
            current.id_report = job.id_report;
            current.id_template = job.id_template;

            this.context.SaveChanges();
        }

        // DELETE: api/Job/5
        public void Delete(int id)
        {
            Job job = this.context.Jobs.Find(id);

            this.context.Jobs.Remove(job);
            this.context.SaveChanges();
        }
    }
}
