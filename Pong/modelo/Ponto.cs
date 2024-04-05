using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.modelo
{
    internal class Ponto : Tamanho
    {
        private int _X;
        private int _Y;
        private int _VELOCIDADE_X;
        private int _VELOCIDADE_Y;
        private float _R;
        private float _G;
        private float _B;

        public Ponto(int x, int y, int lAGURA, int aLTURA, int velocidadeX, int velocidadeY, float r, float g, float b) 
            : base(lAGURA, aLTURA)
        {
            X = x;
            Y = y;
            VELOCIDADE_X = velocidadeX;
            VELOCIDADE_Y = velocidadeY;
            R = r;
            G = g;
            B = b;
        }

        #region GET'S SET'S

        public int MARGEM_DIREITA
        {
            get => (X + LAGURA / 2);
        }

        public int MARGEM_ESQUERDA
        {
            get => (X - LAGURA / 2);
        }

        public int MARGEM_CIMA
        {
            get => (Y + ALTURA / 2);
        }

        public int MARGEM_BAIXO
        {
            get => (Y - ALTURA / 2);
        }

        public int X { get => _X; set => _X = value; }
        public int Y { get => _Y; set => _Y = value; }
        public int VELOCIDADE_X { get => _VELOCIDADE_X; set => _VELOCIDADE_X = value; }
        public int VELOCIDADE_Y { get => _VELOCIDADE_Y; set => _VELOCIDADE_Y = value; }
        public float R { get => _R; set => _R = value; }
        public float G { get => _G; set => _G = value; }
        public float B { get => _B; set => _B = value; }

        #endregion
    }
}
