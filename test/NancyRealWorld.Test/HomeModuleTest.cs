using Nancy;
using Xunit;
using Nancy.Testing;
namespace NancyRealWorld.Test
{
    public class HomeModuleTest
    {
        [Fact]
        public void TestHomeRoot()
        {
            //Arrange
            var bootstrapper = new ConfigurableBootstrapper(with =>
            {
                with.Module<HomeModule>();
            });
            var browser = new Browser(bootstrapper);

            //act
            var response = browser.Get("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.Result.StatusCode);
        }
    }
}
