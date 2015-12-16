using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SendData _sendData = new SendEmail();
            _sendData._iBridgeComponents = new WebService();
            _sendData.Send();
            _sendData._iBridgeComponents = new ThirdPartyAPI();
            _sendData.Send();


            SendData _sendData2 = new SendSMS();
            _sendData2._iBridgeComponents = new WebService();
            _sendData2.Send();
            _sendData2._iBridgeComponents = new ThirdPartyAPI();
            _sendData2.Send();
        }
    }
}
