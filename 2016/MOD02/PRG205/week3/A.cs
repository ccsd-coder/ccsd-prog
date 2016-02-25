using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class A
    {
        private int m_member01;
        private int m_member02;

        // Step 03 - Introducing why using a constructor
        // I want mt members 1 & 2 to be initialized with value 4
        // I need to create a constructor for that
        public A()
        {
            m_member01 = 4;
            m_member02 = 4;

        }
        public void Debug()
        {
            Console.WriteLine("member 01 = " + m_member01 );
            Console.WriteLine("member 02 = " + m_member02);
        }
    }
}
