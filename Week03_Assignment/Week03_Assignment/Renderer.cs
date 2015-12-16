using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Assignment
{
    public abstract class Renderer
    {
        public IRenderingAPI m_api;
        public abstract void Render();
    }
}
