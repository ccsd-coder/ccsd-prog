using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bridge_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassThatDoes itdoes = new ClassThatDoes();
            itdoes.m_interface = new DoEr_TypeA();
            itdoes.DoSomething();

            itdoes.m_interface = new DoEr_TypeB();
            itdoes.DoSomething();
        }
    }
}
