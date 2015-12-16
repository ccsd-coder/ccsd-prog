using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    public partial class A
    {
        protected int m_a;
        protected int m_b;
        List<int> m_l;
        // Constructor
        public A()
        {
            m_a = 0;
            m_b = 0;
            m_l = new List<int>(5);
        }

        public virtual void Debug()
        {
            Console.WriteLine("A - Calling Debug ");
        }




        // Destructor
        ~A()
        {
            m_l.Clear();
        }
    }

}
