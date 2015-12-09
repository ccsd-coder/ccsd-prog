using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Framework
{
    public partial class CMod
    {
        protected string m_modName;
        protected List<CClass> m_Classes;

        public CMod()
        {
            m_modName = "";
            m_Classes = new List<CClass>();
            m_Classes.Clear();
        }

        public CMod(string modName)
        {
            m_modName = modName;
            m_Classes = new List<CClass>();
            m_Classes.Clear();
        }

        ~CMod()
        {
            m_Classes.Clear();
        }

        public void AddClass(CClass c)
        {
            m_Classes.Add(c);
            return;
        }

        public void Debug()
        {
            int n = m_Classes.Count();
            Console.WriteLine("Number of Classes for Current Mod: " + n);
            for (int i = 0; i < n; i++)
            {
                string s = m_Classes[i].ToString();
                Console.WriteLine(s);
            }
            return;
        }
    }
}
