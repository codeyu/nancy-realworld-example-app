using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Nancy;
using Nancy.ModelBinding;
using NancyRealWorld.Models;

namespace NancyRealWorld.Modules
{
    
    public class ArticlesModule : NancyModule
    {
        public static List<Article> lst = new List<Article>();
        public ArticlesModule() : base("/articles")
        {
            Get("/", args => {
                var authorName = Request.Query.@author;
                var tag = Request.Query.@tag;
                var favorited = Request.Query.@favorited;
                throw new NotImplementedException();
            });
            Get("/{slug:string}", args => {
                throw new NotImplementedException();
            });

            Get("/feed", args => {
                throw new NotImplementedException();
            });

            Post("/", args => {
                var article = this.Bind<Article>();
                throw new NotImplementedException();
            });

            Delete("/{slug:string}", args => {
                throw new NotImplementedException();
            });

            Put("/{slug:string}", args => {
                var article = this.Bind<Article>();
                throw new NotImplementedException();
            });

            Post("/{slug:string}/favorite", args => {
                throw new NotImplementedException();
            });

            Delete("/{slug:string}/favorite", args => {
                throw new NotImplementedException();
            });
        }

        public List<Article> GetArticles(string filterValue = null)
        {
            throw new NotImplementedException();
        }
    }
}