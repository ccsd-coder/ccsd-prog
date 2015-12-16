using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class DerivedB : Base
    {
        public DerivedB() : base()
        {

        }

        public override void Debug()
        {
            Console.WriteLine("DerivedB - Debug");
        }
    }
}
