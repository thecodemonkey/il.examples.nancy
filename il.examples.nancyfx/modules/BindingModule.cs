using il.examples.nancyfx.model;
using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.modules
{
    public class BindingModule : NancyModule
    {
        public BindingModule() : base("/binding") 
        {
            Post["/"] = _ =>
            {
                User user = this.Bind();

                return String.Format("email: {0}, pwd: {1}", user.EMail, user.Password);
            };     
        }
    }
}
