using System;
using System.Collections.Generic;
using System.Text;
using Nancy;

namespace NancyRealWorld.Modules
{
    public class TagsModule : NancyModule
    {
        public TagsModule() : base("/tags")
        {
            Get("/", args => {
                throw new NotImplementedException();
            });
        }
    }
}
