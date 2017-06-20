using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace NancyRealWorld.Models
{
    public class Comment
    {
        [JsonProperty("id")]
        public int CommentId { get; set; }

        public string Body { get; set; }

        public User Author { get; set; }

        [JsonIgnore]
        public Article Article { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}