using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    public class C : A
    {
        protected int m_d;

        public C()
            : base()
        {
            m_d = 0;
        }

        public override void Debug()
        {
            Console.WriteLine("C - Calling Debug ");
        }
    }
}
