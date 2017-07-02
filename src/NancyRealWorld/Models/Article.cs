using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Newtonsoft.Json;
namespace NancyRealWorld.Models
{
    public class Article
    {
        [JsonIgnore]
        public int ArticleId { get; set; }

        public string Slug { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Body { get; set; }

        public User Author { get; set; }

        public List<string> TagList { get; set; }

        public ImmutableList<Comment> Comments {get;set; }

        [JsonIgnore]
        public ImmutableList<Tag> ArticleTags { get; set; }

        [JsonIgnore]
        public ImmutableList<User> Favorited { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}