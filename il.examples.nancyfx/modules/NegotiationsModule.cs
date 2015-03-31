using CsvHelper;
using il.examples.nancyfx.model;
using Nancy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.modules
{
    public class NegotiationsModule : NancyModule
    {
        public NegotiationsModule() : base("/negotiations") 
        {
            Get["/"] = _ =>
            {
                var model = new List<User> {
                    new User { EMail = "info@mail.de", Password = "123pwd" },
                    new User { EMail = "info2@mail2.de", Password = "123pwd" }
                };
                
                return Negotiate.WithModel(model)
                                .WithHeader("X-Custom", "SomeValue")
                                .WithView("hallo");
            };
        }
    }
}
