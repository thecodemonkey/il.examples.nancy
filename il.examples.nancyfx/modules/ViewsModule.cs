using il.examples.nancyfx.model;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.modules
{
    public class ViewsModule : NancyModule
    {
        public ViewsModule() : base("/views") 
        {
            var model = new User { EMail = "info@mail.de" };

            Get["/"] = _ => View["simple.html", model];

            Get["/mdown"] = _ => View["simple.md", model];

            Get["/razor"] = _ => View["simple.cshtml", model];
        }
    }
}
