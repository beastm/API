using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class KlientController : ApiController
    {
        private MyContext context = new MyContext();

        // GET: api/Job/5
        public IEnumerable<Klient> Get()
        {
            return this.context.Klients;
        }

        // GET: api/Job/5
        public Klient Get(int id)
        {
            return this.context.Klients.Find(id);
        }

        // POST: api/Job/5
        public void Post([FromBody]Klient klient)
        {
            this.context.Klients.Add(klient);
            this.context.SaveChanges();
        }

        // PUT: api/Job/5
        public void Put(int id, [FromBody]Klient klient)
        {
            Klient current = this.context.Klients.Find(id);

            current.id = klient.id;
            current.info = klient.info;
            current.ip = klient.ip;
            current.mac_adr = klient.mac_adr;
            current.name = klient.name;
            current.state = klient.state;

            this.context.SaveChanges();
        }

        // DELETE: api/Job/5
        public void Delete(int id)
        {
            Klient klient = this.context.Klients.Find(id);

            this.context.Klients.Remove(klient);
            this.context.SaveChanges();
        }
    }
}
