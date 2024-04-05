using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace Pong.classe
{
    internal class ClsOpenGl
    {
        public static void Desenhar(int iWidth, int iHeight)
        {

            GL.Viewport(0, 0, iWidth, iHeight);

            Matrix4 mProjection = Matrix4.CreateOrthographic(iWidth, iHeight, 0.0f, 1.0f);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref mProjection);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            
        }

        internal static void DesenharRetangulo(int iX, int iY, int iLargura, int iAltura)
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2((-0.5f * iLargura + iX), (-0.5f * iAltura + iY));
            GL.Vertex2((0.5f * iLargura + iX), (-0.5f * iAltura + iY));
            GL.Vertex2((0.5f * iLargura + iX), (0.5f * iAltura + iY));
            GL.Vertex2((-0.5f * iLargura + iX),(0.5f * iAltura + iY));
            GL.End();

        }

        internal static void DesenharRetangulo(modelo.Ponto ponto)
        {
            GL.Color3(ponto.R, ponto.G, ponto.B);

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2((-0.5f * ponto.LAGURA + ponto.X), (-0.5f * ponto.ALTURA + ponto.Y));
            GL.Vertex2((0.5f * ponto.LAGURA + ponto.X), (-0.5f * ponto.ALTURA + ponto.Y));
            GL.Vertex2((0.5f * ponto.LAGURA + ponto.X), (0.5f * ponto.ALTURA + ponto.Y));
            GL.Vertex2((-0.5f * ponto.LAGURA + ponto.X), (0.5f * ponto.ALTURA + ponto.Y));
            GL.End();

        }
    }
}
