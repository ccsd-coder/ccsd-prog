using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM_Framework
{
    public partial class CClass
    {
        public static void Test()
        {
            string testName = "CClass - Test";
            string underLine = Utils.CUText.CreateHyphenString(testName);
            Console.WriteLine(testName );
            Console.WriteLine(underLine);

            CClass c1 = new CClass( ".NET Programming I", 205, false );

            string classString = c1.ToString();

            Console.WriteLine(classString);
        }
    }
}
