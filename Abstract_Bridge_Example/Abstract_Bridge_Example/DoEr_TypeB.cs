using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bridge_Example
{
    public class DoEr_TypeB : IInterface
    {
        public void DoSomething()
        {
            Console.WriteLine("B Doing Something");
        }
    }
}
