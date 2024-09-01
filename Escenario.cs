using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Escenario
    {
        private float X;
        private float Y;
        private float Z;

        public Escenario(float cx, float cy, float cz)
        {
            X = cx;
            Y = cy;
            Z = cz;
        }

        public void Escenario1()
        {
            Objeto LetraT=new Objeto(X+0.3f, Y+0.5f, Z+0.1f);
            LetraT.T();
        }
    }

}
