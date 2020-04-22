using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class DestinationController : ApiController
    {
        private MyContext context = new MyContext();

        // GET: api/Destination
        public IEnumerable<Destination> Get()
        {
            return this.context.Destinations;
        }

        // GET: api/Destination/5
        public Destination Get(int id)
        {
            return this.context.Destinations.Find(id);
        }

        // POST: api/Destination
        public void Post([FromBody]Destination destination)
        {
            this.context.Destinations.Add(destination);
            this.context.SaveChanges();
        }

        // PUT: api/Destination/5
        public void Put(int id, [FromBody]Destination destination)
        {
            Destination current = this.context.Destinations.Find(id);

            current.id = destination.id;
            current.FTP_config = destination.FTP_config;
            current.LD_path = destination.LD_path;

            this.context.SaveChanges();
        }

        // DELETE: api/Destination/5
        public void Delete(int id)
        {
            Destination destination = this.context.Destinations.Find(id);

            this.context.Destinations.Remove(destination);
            this.context.SaveChanges();
        }
    }
}
