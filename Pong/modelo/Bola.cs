using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.modelo
{
    internal class Bola : Ponto
    {
        public Bola(int x, int y, int lAGURA, int aLTURA, int velocidadeX, int velocidadeY, float r, float g, float b) 
            : base(x, y, lAGURA, aLTURA, velocidadeX, velocidadeY, r, g, b)
        {
        }

        public void moverBola()
        {
            X = X + VELOCIDADE_X;
            Y = Y + VELOCIDADE_Y;
        }
        
        public  void inverterVelocidadeX()
        {
            VELOCIDADE_X = -VELOCIDADE_X;
        }

        public void inverterVelocidadeY()
        {
            VELOCIDADE_Y = -VELOCIDADE_Y;
        }
    }
}
