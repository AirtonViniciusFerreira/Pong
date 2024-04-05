using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.modelo
{
    internal class Tamanho
    {
        private int _LAGURA;
        private int _ALTURA;

        public Tamanho(int lAGURA, int aLTURA)
        {
            LAGURA = lAGURA;
            ALTURA = aLTURA;
        }

        #region GET'S SET'S

        public int LAGURA { get => _LAGURA; set => _LAGURA = value; }
        public int ALTURA { get => _ALTURA; set => _ALTURA = value; }

        #endregion
    }
}
