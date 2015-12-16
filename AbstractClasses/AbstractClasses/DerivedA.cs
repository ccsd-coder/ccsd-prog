using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class DerivedA : Base
    {
        public DerivedA() : base()
        {

        }

        public override void Debug()
        {
            Console.WriteLine("DerivedA - Debug");
        }
    }
}
