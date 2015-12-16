using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    // Abstract Bridge Component
    public interface IBridgeComponents
    {
        void Send(String messageType);
    }
}
