using System;
using System.Collections.Generic;
using System.Text;
using Nancy;

namespace NancyRealWorld
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello World, it's Nancy on .NET Core");
        }
    }
}
