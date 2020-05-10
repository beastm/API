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
                   join obj in context.Objs on x.id equals obj.id_template
                   select new Get()
                   {
                       Template_name = x.Template_name,
                       Backup_type = x.Backup_type,
                       Cronos_config = x.Cronos_config,
                       Save_format = x.Cronos_config,
                       Date_s = x.Date_s,
                       Date_e = x.Date_e,
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
                    join obj in context.Objs on x.id equals obj.id_template
                    where x.id == id
                    select new Get()
                    {
                        Template_name = x.Template_name,
                        Backup_type = x.Backup_type,
                        Cronos_config = x.Cronos_config,
                        Save_format = x.Cronos_config,
                        Date_s = x.Date_s,
                        Date_e = x.Date_e,
                        path = obj.path,
                        B_Limit = x.B_Limit,
                        id_client = job.id_client,
                        id_report = job.id_report,
                        id_template = job.id_template
                    }).ToList()[0];
        }


        [HttpGet]
        public IEnumerable<DataFromTo> GetData()
        {
            return from x in context.Templates
                   join Destination in context.Destinations on x.id equals Destination.id_template
                   join obj in context.Objs on x.id equals obj.id_template
                   select new DataFromTo()
                   {
                       id_dest = Destination.id,
                       id_obj = obj.id,
                       FTP_config = Destination.FTP_config,
                       LD_path = Destination.LD_path,
                       path = obj.path
                   };
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
