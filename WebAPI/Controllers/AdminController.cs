﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AdminController : ApiController
    {
        private MyContext context = new MyContext();


        public IEnumerable<Admin_list> Get()
        {
            return this.context.Admins;
        }
     
        public Admin_list Get(int id)
        {
            return this.context.Admins.Find(id);
        }

        // POST: api/Admins
        public void Post([FromBody]Admin_list admin_List)
        {
            this.context.Admins.Add(admin_List);
            this.context.SaveChanges();
        }

        // PUT: api/Admin/5
        public void Put(int id, [FromBody]Admin_list admin)
        {
            Admin_list current = this.context.Admins.Find(id);

            current.id = admin.id;
            current.username = admin.username;
            current.login = admin.login;
            current.hashed_password = admin.hashed_password;
            current.gmail = admin.gmail;

            this.context.SaveChanges();
        }

        // DELETE: api/Admin/5
        public void Delete(int id)
        {
            Admin_list person = this.context.Admins.Find(id);

            this.context.Admins.Remove(person);
            this.context.SaveChanges();
        }
    }
}
