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
            String msg = "<STRING>";

            SendData _sendData2 = new SendSMS();
            _sendData2._iBridgeComponents = new WebService();
            _sendData2.Send( msg );
            _sendData2._iBridgeComponents = new ThirdPartyAPI();
            _sendData2.Send( msg );

            A a = new A();

            a.SetA(3);

            B b = new B();

            //b.m_c

            C c = new C();

            a.Debug();
            b.Debug();
            c.Debug();

        }
    }
}
