using System;
using System.Collections.Generic;
using System.Text;
using Nancy;
using Nancy.ModelBinding;
using NancyRealWorld.Models;

namespace NancyRealWorld.Modules
{
    public class ProfilesModule : NancyModule
    {
        public ProfilesModule(): base("/profiles")
        {
            Post("/{user:string}/follow", args => {
                var user = this.Bind<User>();
                throw new NotImplementedException();
            });
            
            Delete("/{user:string}/follow", args => {
                var user = this.Bind<User>();
                throw new NotImplementedException();
            });

            Get("/{user:string}", args => {
                var user = this.Bind<User>();
                throw new NotImplementedException();
            });
        }
    }
}