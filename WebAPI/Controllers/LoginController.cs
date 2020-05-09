using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.PowerBI.Security;
using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.IdentityModel.Claims;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using System.Web.UI.WebControls;
using Ubiety.Dns.Core;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class LoginController : ApiController
    {

        MyContext MyContext = new MyContext();

        public IHttpActionResult UserLogin(Key key)
        {
            if (key.hash_password_user ==  MyContext.Admins.First(admin => admin.username == key.username).hashed_password) 
            {
                string token = TokenManager.GenerateToken(key.username);
                
                MyContext.Tokens.Add(new Token
                {
                    hash = token,
                    username = key.username                   
                 });

                MyContext.SaveChanges();
                return Ok(token);   
            }            
            return Unauthorized(); 
        }

        public void Delete(int id)
        {
            Token t = this.MyContext.Tokens.Find(id);

            this.MyContext.Tokens.Remove(t);
            this.MyContext.SaveChanges();
        } 
    }
}
