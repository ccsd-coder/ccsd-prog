using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week03_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSprite gs = new GameSprite();
            gs.m_api = new Renderer_OpenGL();

            gs.Render();

            gs.m_api = new Renderer_DirectX();

            gs.Render();
        }
    }
}
