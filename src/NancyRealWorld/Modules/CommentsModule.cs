using System;
using System.Collections.Generic;
using System.Text;
using Nancy;
using Nancy.ModelBinding;
using NancyRealWorld.Models;

namespace NancyRealWorld.Modules
{
    public class CommentsModule : NancyModule
    {
        public CommentsModule() : base("/articles")
        {
            Get("/{slug:string}/comments", args => {
                var slug = args.slug;
                throw new NotImplementedException();
            });

            Post("/{slug:string}",args => {
                var slug = args.slug;
                var comment = this.Bind<Comment>();
                throw new NotImplementedException();
            });

            Delete("/{slug:string}/comments/{id:int}", args => {
                var slug = args.slug;
                var comment = args.id;
                throw new NotImplementedException();
            });
        }
    }
}