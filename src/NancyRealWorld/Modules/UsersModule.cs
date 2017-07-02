using System;
using System.Collections.Generic;
using System.Text;
using Nancy;
using Nancy.ModelBinding;
using NancyRealWorld.Models;

namespace NancyRealWorld.Modules
{
    public class UsersModule : NancyModule
    {
        public UsersModule(): base("/users")
        {
            Post("/login", args => {
                var user = this.Bind<User>();
                throw new NotImplementedException();
            });

            //Register
            Post("/", args => {
                var user = this.Bind<User>();
                throw new NotImplementedException();
            });
        }
    }
}