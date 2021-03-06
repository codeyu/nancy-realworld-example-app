using System;
using System.Collections.Generic;
using System.Text;
using Nancy;
using Nancy.ModelBinding;
using NancyRealWorld.Models;

namespace NancyRealWorld.Modules
{
    public class UserModule : NancyModule
    {
        public UserModule() : base("/user")
        {
            
            Get("/", args => {
                throw new NotImplementedException();
            });
            Put("/", args => {
                var user = this.Bind<User>();
                throw new NotImplementedException();
            });
        }
    }
}