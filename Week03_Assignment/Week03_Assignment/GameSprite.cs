using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Assignment
{
    public class GameSprite : Renderer
    {
        public override void Render()
        {
            m_api.Render();
        }
    }
}
