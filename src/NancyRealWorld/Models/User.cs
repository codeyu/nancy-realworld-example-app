using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Newtonsoft.Json;
namespace NancyRealWorld.Models
{
    public class User
    {
        [JsonIgnore]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Bio { get; set; }

        public string Image { get; set; }

        [JsonIgnore]
        public ImmutableList<Article> ArticleFavorites { get; set; }

        [JsonIgnore]
        public ImmutableList<User> Following { get; set; }

        [JsonIgnore]
        public ImmutableList<User> Followers { get; set; }

        [JsonIgnore]
        public byte[] Hash { get; set; }

        [JsonIgnore]
        public byte[] Salt { get; set; }
    }
    
}
