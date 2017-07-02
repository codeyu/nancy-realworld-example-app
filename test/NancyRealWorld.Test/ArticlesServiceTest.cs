using System;
using System.Collections.Generic;
using System.Text;
using NancyRealWorld.Infrastructure;
using NancyRealWorld.Models;
using NancyRealWorld.Services;
using Xunit;

namespace NancyRealWorld.Test
{
    public class ArticlesServiceTest
    {
        private readonly ArticlesService _service;
        public ArticlesServiceTest()
        {
            _service = new ArticlesService();
        }
        [Fact]
        public void TestAddArticle()
        {
            var article = new Article
            {
                Title = "A Test",
                Body = "1,2,4,343,3,4,drwerdf3,,4234,%^#$%2",
                Description = "",
                TagList = new List<string> {"test", "number"},
                Author = new User()
                {
                  UserName  = "test"
                },
                Slug = "A Test".GenerateSlug(),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            var result = _service.AddArticle(article);
            Assert.True(result>0);
        }
    }
}
