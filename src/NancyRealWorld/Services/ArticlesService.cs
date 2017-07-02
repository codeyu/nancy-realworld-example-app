using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;
using NancyRealWorld.Models;

namespace NancyRealWorld.Services
{
    public class ArticlesService
    {
        public int AddArticle(Article article)
        {
            // Open database (or create if doesn't exist)
            var connStr = string.IsNullOrEmpty(Startup.ConnectionString) ? "RealWorld.db" : Startup.ConnectionString;
            using (var db = new LiteDatabase(connStr))
            {
                // Get articles collection
                var col = db.GetCollection<Article>("articles");

                // Map Author property to "users" collections 
                BsonMapper.Global.Entity<Article>()
                    .DbRef(x => x.Author, "users");

                // Create unique index in Slug field
                col.EnsureIndex(x => x.Slug, true);

                // Insert new article document (Id will be auto-incremented)
                var result = col.Insert(article);
                return result.AsInt32;
            }
        }
    }
}
