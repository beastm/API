using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class TemplateController : ApiController
    {
        private MyContext context = new MyContext();

        // GET: api/Template
        public IEnumerable<Template> Get()
        {
            return this.context.Templates;
        }

        // GET: api/Template/5
        public Template Get(int id)
        {
            return this.context.Templates.Find(id);
        }

        // POST: api/Template
        public void Post([FromBody]Template template)
        {
            this.context.Templates.Add(template);
            this.context.SaveChanges();
        }

        // PUT: api/Template/5
        public void Put(int id, [FromBody]Template template)
        {
            Template current = this.context.Templates.Find(id);

            current.id = template.id;
            current.Template_name = template.Template_name;
            current.Backup_type = template.Backup_type;
            current.Cronos_config = template.Cronos_config;
            current.Save_format = template.Save_format;
            current.Date_s = template.Date_s;
            current.Date_e = template.Date_e;
            current.B_Limit = template.B_Limit;

            this.context.SaveChanges();
        }

        // DELETE: api/Template/5
        public void Delete(int id)
        {
            Template template = this.context.Templates.Find(id);

            this.context.Templates.Remove(template);
            this.context.SaveChanges();
        }
    }
}
