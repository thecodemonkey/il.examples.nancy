using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace il.examples.nancyfx
{
    public class Programm
    {
        public static void Main(string[] args) 
        {
            var config = new HostConfiguration();
            config.UrlReservations.CreateAutomatically = true;

            using (var host = new NancyHost(config, new Uri("http://localhost:1234")))
            {
                host.Start();

                Console.WriteLine("Hallo ich bin Nancy, und ich horche am Port 1234.");
                Console.ReadLine();
            }
        }
    }
}
