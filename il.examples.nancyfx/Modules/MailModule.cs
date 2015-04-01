using il.examples.nancyfx.model;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.Modules
{
    public class MailModule : NancyModule
    {
        public MailModule() 
        {
            Post["/registration"] = _ =>
            {
                var model = this.Bind<User>();

                return View["registration", model];
            };
        }
    }
}
