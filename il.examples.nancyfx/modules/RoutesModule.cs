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

            Post["/"] = _ => "post request!";

            Get["/{id}"] = _ => "id ist: " + _.id;
            
            Get["/123"] = _ => "feste ID!";

            Get["/{id:int}/const"] = _ => "numerische id ist: " + _.id;
        }
    }
}
