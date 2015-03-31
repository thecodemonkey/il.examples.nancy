using il.examples.nancyfx.Common;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.Modules
{
    public class DIModule : NancyModule
    {
        public DIModule(IUserRepository users) 
        {
            Get["/users"] = _ => users.LoadAll();
        }
    }
}
