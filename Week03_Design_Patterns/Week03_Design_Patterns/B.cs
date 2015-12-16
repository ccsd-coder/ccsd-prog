using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    public class B : A
    {
        protected int m_c;

        public B()
            : base()
        {
            m_c = 0;
        }

        public override void Debug()
        {
            Console.WriteLine("B - Calling Debug ");
        }
    }
}
