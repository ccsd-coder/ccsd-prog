using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM_Framework
{
    public partial class CPerson
    {
        public static void Test()
        {
            CPerson p1 = new CPerson( "Julien", "Esposito" );
            CPerson p2 = new CPerson( "Jerry", "Ward" );

            string s1 = p1.m_FirstName;

            Console.WriteLine("1st Student First Name = " + s1);
        }
    }
}
