using il.examples.nancyfx.model;    
using Nancy;                        
using System;                       
using System.Collections.Generic;   
using System.Linq;                  
using System.Text;                  
using System.Threading.Tasks;       

namespace il.examples.nancyfx.modules
{
    public class HelloModule : NancyModule
    {
        public HelloModule() 
        {
            Get["/"] = _ => "Hallo Dortmund! hmm nee, ich meine L&uuml;nen, ahhrrr wie auch immer...";

            Get["/hallo"] = _ => View["hallo.html"];

            Get["/user"] = _ => new User {  EMail = "user@mail.de" };

            Get["/async", true] = async (x, ct) =>
            {
                await Task.Delay(1000);
                return 200;
            };
        }
    }
}
