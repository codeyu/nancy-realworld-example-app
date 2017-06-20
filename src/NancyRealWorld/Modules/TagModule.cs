using System;
using System.Collections.Generic;
using System.Text;
using Nancy;

namespace NancyRealWorld.Modules
{
    public class TagModule : NancyModule
    {
        public TagModule()
        {
            Get("/tags", args => "TODO...");
        }
    }
}
