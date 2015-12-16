using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            DerivedA a = new DerivedA();
            DerivedB bd = new DerivedB();

            b.Debug();
            a.Debug();
            bd.Debug();
        }
    }
}
