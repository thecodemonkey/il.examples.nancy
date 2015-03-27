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

        }
    }
}
