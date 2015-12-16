using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bridge_Example
{
    public abstract class DoEr
    {
        public IInterface m_interface;
        public abstract void DoSomething();
    }
}
