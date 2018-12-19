using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.Remoting.Messaging;
using System.IO;

namespace Leer_Api
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string url = "https://api.cambio.today/v1/full/USD/json?key=1524|fp01KD82DW3~_PAnGj2a0EqG~QJ1qq4Z";
            var json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);
            
            foreach (var i in m)
            {
                
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
