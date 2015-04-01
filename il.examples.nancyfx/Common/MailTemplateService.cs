using il.examples.nancyfx.model;
using il.examples.nancyfx.Modules;
using Nancy;
using Nancy.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.Common
{
    public class MailTemplateService
    {
        public static string GetEMailTemplate<TModel>(TModel model, string templatename)
        {
            var browser = new Browser(with =>
            {
                with.Module<MailModule>();
            });

            var response = browser.Post("/" + templatename, (with) =>
            {
                with.HttpRequest();
                with.JsonBody(model);
            });

            return response.Body.AsString();
        }
    }
}
