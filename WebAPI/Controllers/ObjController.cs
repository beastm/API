using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    public class ObjController : ApiController
    {
        private MyContext context = new MyContext();

        // GET: api/Object
        public IEnumerable<Obj> Get()
        {
            return this.context.Objs;
        }

        // GET: api/Object/5
        public Obj Get(int id)
        {
            return this.context.Objs.Find(id);
        }

        // POST: api/Object
        public void Post([FromBody]Obj obj)
        {
            this.context.Objs.Add(obj);
            this.context.SaveChanges();
        }

        // PUT: api/Obj/5
        public void Put(int id, [FromBody]Obj obj)
        {
            Obj current = this.context.Objs.Find(id);

            current.id = obj.id;
            current.path = obj.path;

            this.context.SaveChanges();
        }

        // DELETE: api/Object/5
        public void Delete(int id)
        {
            Obj obj = this.context.Objs.Find(id);

            this.context.Objs.Remove(obj);
            this.context.SaveChanges();
        }
    }
}
