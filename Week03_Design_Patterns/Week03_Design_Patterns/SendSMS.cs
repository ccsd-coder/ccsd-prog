﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    public class SendSMS : SendData
    {
        public override void Send( String s )
        {
            _iBridgeComponents.Send( s );
        }
    }
}
