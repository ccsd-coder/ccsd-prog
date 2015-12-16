using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    // Abstract logic class with reference to the Bridge
    public abstract class SendData
    {
        // Reference of the Bridge
        public IBridgeComponents _iBridgeComponents;

        public abstract void Send( String s );
    }
}
