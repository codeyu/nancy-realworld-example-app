using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace NancyRealWorld.Models
{
    public class Tag
    {
        [JsonIgnore]
        public long Id {get;set;}

        public string Name {get;set;}
    }
}