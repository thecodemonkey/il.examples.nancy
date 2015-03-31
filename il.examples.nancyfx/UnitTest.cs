using Nancy;
using Nancy.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace il.examples.nancyfx
{
    public class UnitTest
    {
        [Fact]
        public void Force_Hello_Request_Expect_Valid_String_Response() 
        {
            var browser = new Browser(new DefaultNancyBootstrapper());
            var response = browser.Get("/", (with) =>
            {
                with.HttpRequest();
            });

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Contains("Hallo Dortmund!", response.Body.AsString());
        }
    }
}
