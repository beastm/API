using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class GetController : ApiController
    {

        private MyContext context = new MyContext();


        // GET: api/Get
        public IEnumerable<Get> Get()
        {
            return from x in context.Templates
                   join job in context.Jobs on x.id equals job.id_template
                   join obj in context.Objs on x.Obj_id equals obj.id
                   select new Get()
                   {
                       Template_name = x.Template_name,
                       Backup_type = x.Backup_type,
                       Cronos_config = x.Cronos_config,
                       Save_format = x.Cronos_config,
                       Destination_id = x.Destination_id,
                       Date_s = x.Date_s,
                       Date_e = x.Date_e,
                       path = obj.path,
                       B_Limit = x.B_Limit,
                       id_client = job.id_client,
                       id_report = job.id_report,
                       id_template = job.id_template                       
                   };

                   

        }

        // GET: api/Get/5
        public Get Get(int id)
        {
            return (from x in context.Templates

                    join job in context.Jobs on x.id equals job.id_template
                    join obj in context.Objs on x.Obj_id equals obj.id
                    where x.id == id
                    select new Get()
                    {
                        Template_name = x.Template_name,
                        Backup_type = x.Backup_type,
                        Cronos_config = x.Cronos_config,
                        Save_format = x.Cronos_config,
                        Destination_id = x.Destination_id,
                        Date_s = x.Date_s,
                        Date_e = x.Date_e,
                        path = obj.path,
                        B_Limit = x.B_Limit,
                        id_client = job.id_client,
                        id_report = job.id_report,
                        id_template = job.id_template
                    }).ToList()[0];
        }

     
        // POST: api/Get
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Get/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Get/5
        public void Delete(int id)
        {
        }
    }
}
