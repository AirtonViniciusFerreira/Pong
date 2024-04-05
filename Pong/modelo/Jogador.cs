using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.modelo
{
    internal class Jogador : Ponto
    {
        public Jogador(int x, int y, int lAGURA, int aLTURA, int velocidadeX, int velocidadeY, float r, float g, float b) 
            : base(x, y, lAGURA, aLTURA, velocidadeX, velocidadeY, r, g, b)
        {
        }
    }
}
