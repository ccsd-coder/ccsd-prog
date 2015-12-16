using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    public class SendEmail : SendData
    {
        public override void Send( String s )
        {
            // Use the bridge to send the email
            _iBridgeComponents.Send( s );
        }
    }
}
