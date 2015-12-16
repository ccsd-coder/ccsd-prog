using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Design_Patterns
{
    public partial class A
    {
        public void SetA(int a)
        {
            if ((a < 0) || (a > 255))
            {
                Console.WriteLine("Please refer to documentation for proper use of A::SetA()");
                return;
            }

            m_a = a;
        }
        public int GetA()
        {
            int ret_value = 0;
            if ((m_a < 0) || (m_a > 255))
            {
                Console.WriteLine("The returned value should NOT be out range");
                ret_value = 666;
            }
            else
            {
                ret_value = m_a;
            }
            return ret_value;
        }
    }
}
