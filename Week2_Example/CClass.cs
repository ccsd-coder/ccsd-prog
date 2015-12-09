using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Framework
{
    public partial class CClass
    {
        protected string m_FullName {get; set;}
        protected UInt32 m_courseID { get; set; }
        protected bool m_isDirectedStudy { get; set; }

        public CClass()
        {
            m_FullName = "";
            m_courseID = 1;
            m_isDirectedStudy = false;
        }

        public CClass(string FullName, UInt32 courseID, bool isDirectedStudy)
        {
            m_FullName = FullName;
            m_courseID = courseID;
            m_isDirectedStudy = isDirectedStudy;
        }

        ~CClass()
        {
        }

        public override string ToString()
        {
            string s = "<Content>";
            s += "FullName: \"" + m_FullName + "\" ";
            s += "CourseID: \"" + m_courseID + "\" ";
            s += "IsDirectedStudy: \"" + Utils.CUType.toString(m_isDirectedStudy) + "\" ";
            s += "</Content>";
            return s;
        }
    }
}
