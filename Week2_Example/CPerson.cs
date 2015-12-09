using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Framework
{
    public partial class CPerson
    {
        protected string m_FirstName {get; set;}
        protected string m_LastName { get; set; }

        public CPerson()
        {
            m_FirstName = "";
            m_LastName = "";
        }

        public CPerson( string FirstName, string LastName)
        {
            m_FirstName = FirstName;
            m_LastName = LastName;
        }

        public override string ToString()
        {
            return "(" + m_FirstName + "," + m_LastName + ")";
        }
    }
}
