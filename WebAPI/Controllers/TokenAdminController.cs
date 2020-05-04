using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class TokenAdminController : ApiController
    {
        public IEnumerable<Admin_list> Get() 
        {
            using (MyContext context = new MyContext()) 
            {
                return context.Admins.ToList();
            }
        }
    }
}
