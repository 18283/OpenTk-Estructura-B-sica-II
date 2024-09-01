using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace ConsoleApp1
{
    internal class Poligono
    {
        private float X;
        private float Y;
        private float Z;

        public Poligono(float cx, float cy, float cz)
        {
            CentroPoligono(cx,cy,cz);
        }

        public void CentroPoligono(float x1, float y1, float z1)
        {
            X = x1;
            Y = y1;
            Z = z1;
        }

        
        //Rectagulos
        public void Rectangulo()
        {
            GL.Rotate(0.1, 0.0f, 1.0f, 0.1f);
            GL.Color4(Color4.CadetBlue);
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(X-0.1f, Y+0.2f, Z);
            GL.Vertex3(X+0.1f, Y+0.2f, Z);
            GL.Vertex3(X+0.1f, Y-0.2f, Z);
            GL.Vertex3(X-0.1f, Y-0.2f, Z);

            GL.End();
        }

        public void RectanguloEnZ()
        {
            GL.Rotate(0.1, 0.0f, 1.0f, 0.1f);
            GL.Color4(Color4.CadetBlue);
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(X, Y + 0.2f, Z - 0.1f);
            GL.Vertex3(X, Y + 0.2f, Z + 0.1f);
            GL.Vertex3(X, Y - 0.2f, Z + 0.1f);
            GL.Vertex3(X, Y - 0.2f, Z - 0.1f);

            GL.End();
        }

        public void RectanguloHorizontal()
        {
            GL.Rotate(0.1, 0.0f, 1.0f, 0.1f);
            GL.Color4(Color4.CadetBlue);
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(X-0.3f, Y+0.1f, Z);
            GL.Vertex3(X + 0.3f, Y + 0.1f, Z);
            GL.Vertex3(X + 0.3f, Y - 0.1f, Z);
            GL.Vertex3(X - 0.3f, Y - 0.1f, Z);

            GL.End();
        }

        public void RectanguloHorizontalEnZ()
        {
            GL.Rotate(0.1, 0.0f, 1.0f, 0.1f);
            GL.Color4(Color4.CadetBlue);
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(X - 0.3f, Y, Z+0.1f);
            GL.Vertex3(X + 0.3f, Y, Z+0.1f);
            GL.Vertex3(X + 0.3f, Y, Z-0.1f);
            GL.Vertex3(X - 0.3f, Y, Z-0.1f);

            GL.End();
        }

        //Cuadrados
        public void CuadradoHorizontalEnZ()
        {
            GL.Rotate(0.1, 0.0f, 1.0f, 0.1f);
            GL.Color4(Color4.CadetBlue);
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(X - 0.1f, Y, Z + 0.1f);
            GL.Vertex3(X + 0.1f, Y, Z + 0.1f);
            GL.Vertex3(X + 0.1f, Y, Z - 0.1f);
            GL.Vertex3(X - 0.1f, Y, Z - 0.1f);

            GL.End();
        }

        public void CuadradoEnZ()
        {
            GL.Rotate(0.1, 0.0f, 1.0f, 0.1f);
            GL.Color4(Color4.CadetBlue);
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(X, Y+0.1f, Z - 0.1f);
            GL.Vertex3(X, Y + 0.1f, Z + 0.1f);
            GL.Vertex3(X, Y-0.1f, Z + 0.1f);
            GL.Vertex3(X, Y - 0.1f, Z - 0.1f);

            GL.End();
        }
    }
}
