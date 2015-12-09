using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Framework
{
    public class CStudent : CPerson
    {
        private UInt32 m_id { get; set; }

        public CStudent() : base()
        {
        }

        public CStudent(string FirstName, string LastName, UInt32 id)
            : base(FirstName, LastName )
        {
            m_id = id;
        }
    }
}
