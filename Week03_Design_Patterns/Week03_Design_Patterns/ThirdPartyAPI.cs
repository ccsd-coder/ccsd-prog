using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    class ThirdPartyAPI : IBridgeComponents
    {
        public void Send(String messageType)
        {
            Console.WriteLine("Sending " + messageType + " using Third party API.");
        }
    }
}
