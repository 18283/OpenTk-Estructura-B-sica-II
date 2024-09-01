using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Objeto
    {
        private float X;
        private float Y;
        private float Z;

        public Objeto(float cx, float cy, float cz)
        {
            X = cx;
            Y = cy;
            Z = cz;
        }

        public void T()
        {
            Parte arriba = new Parte(X,Y+0.1f,Z);
            arriba.CuboHorizontal();
            Parte abajo = new Parte(X,Y-0.2f,Z);
            abajo.Cubo();
        }
    }
}
