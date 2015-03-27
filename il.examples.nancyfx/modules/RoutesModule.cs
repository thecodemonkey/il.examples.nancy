using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx.modules
{
    public class RoutesModule : NancyModule
    {
        public RoutesModule() : base("/routes") 
        {
            Get["/"] = _ => 200;
        }
    }
}
