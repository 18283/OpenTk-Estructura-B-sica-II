using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parte
    {
        private float X;
        private float Y;
        private float Z;

        public Parte(float cx, float cy, float cz)
        {
            X = cx;
            Y = cy; 
            Z = cz;
        }

        public void Cubo()
        {
            Poligono r1 = new Poligono(X, Y, Z - 0.1f);
            r1.Rectangulo();
            Poligono r2 = new Poligono(X, Y, Z + 0.1f);
            r2.Rectangulo();
            Poligono r3 = new Poligono(X - 0.1f, Y, Z);
            r3.RectanguloEnZ();
            Poligono r4 = new Poligono(X + 0.1f, Y, Z);
            r4.RectanguloEnZ();
            Poligono c1 = new Poligono(X, Y + 0.2f, Z);
            c1.CuadradoHorizontalEnZ();
            Poligono c2 = new Poligono(X, Y - 0.2f, Z);
            c2.CuadradoHorizontalEnZ();
        }

        public void CuboHorizontal()
        {
            Poligono r1 = new Poligono(X,Y,Z-0.1f);
            r1.RectanguloHorizontal();
            Poligono r2 = new Poligono(X, Y, Z + 0.1f);
            r2.RectanguloHorizontal();
            Poligono r3 = new Poligono(X, Y + 0.1f, Z);
            r3.RectanguloHorizontalEnZ();
            Poligono r4 = new Poligono(X, Y - 0.1f, Z);
            r4.RectanguloHorizontalEnZ();
            Poligono c1 = new Poligono(X-0.3f, Y, Z);
            c1.CuadradoEnZ();
            Poligono c2 = new Poligono(X + 0.3f, Y, Z);
            c2.CuadradoEnZ();
        }
    }
}
