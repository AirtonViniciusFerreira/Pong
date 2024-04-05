using OpenTK;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pong
{
    internal class Program : GameWindow
    {
        private modelo.Bola bola;
        private modelo.Jogador jogador1;
        private modelo.Jogador jogador2;
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            acaoBola();
            acaoJogador1();
            acaoJogador2();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            classe.ClsOpenGl.Desenhar(LARGURA_TELA, ALTURA_TELA);

            classe.ClsOpenGl.DesenharRetangulo(bola);
            classe.ClsOpenGl.DesenharRetangulo(jogador1);
            classe.ClsOpenGl.DesenharRetangulo(jogador2);

            SwapBuffers();
        }

        static void Main()
        {
            Program program = new Program();
            
            program.bola = new modelo.Bola(0, 0, 20, 20, 3, 3, 1.0f, 1.0f, 0.0f);
            
            program.jogador1 = 
                new modelo.Jogador(
                    program.MARGEM_ESQUERDA + program.bola.LAGURA / 2,
                    0, 
                    program.bola.LAGURA,
                    program.bola.ALTURA * 3,
                    3, 
                    3,
                    1.0f,
                    0.0f,
                    0.0f
                );
            
            program.jogador2 = 
                new modelo.Jogador(
                    program.MARGEM_DIREITA - program.bola.LAGURA / 2,
                    0, 
                    program.bola.LAGURA,
                    program.bola.ALTURA * 3,
                    3,
                    3,
                    0.0f,
                    0.0f,
                    1.0f
                );

            program.Run();
        }

        public void acaoBola()
        {
            bola.moverBola();

            if (bola.MARGEM_DIREITA > jogador2.MARGEM_ESQUERDA &&
                bola.MARGEM_BAIXO < jogador2.MARGEM_CIMA &&
                bola.MARGEM_CIMA > jogador2.MARGEM_BAIXO)
            {
                bola.inverterVelocidadeX();
            }

            if (bola.MARGEM_ESQUERDA < jogador1.MARGEM_DIREITA &&
                bola.MARGEM_BAIXO < jogador1.MARGEM_CIMA &&
                bola.MARGEM_CIMA > jogador1.MARGEM_BAIXO)
            {
                bola.inverterVelocidadeX();
            }

            if (bola.MARGEM_CIMA > MARGEM_CIMA)
            {
                bola.inverterVelocidadeY();
            }

            if (bola.MARGEM_BAIXO < MARGEM_BAIXO)
            {
                bola.inverterVelocidadeY();
            }

            if (bola.X < MARGEM_ESQUERDA || bola.X > MARGEM_DIREITA)
            {
                bola.X = 0;
                bola.Y = 0;
            }
        }

        public void acaoJogador1()
        {
            if (Keyboard.GetState().IsKeyDown(Key.W) &&
                (jogador1.MARGEM_CIMA + 5) < MARGEM_CIMA)
            {
                jogador1.Y += 5;
            }

            if (Keyboard.GetState().IsKeyDown(Key.S) &&
                (jogador1.MARGEM_BAIXO - 5) > MARGEM_BAIXO)
            {
                jogador1.Y -= 5;
            }
        }

        public void acaoJogador2()
        {
            if (Keyboard.GetState().IsKeyDown(Key.Up)
                && (jogador2.MARGEM_CIMA + 5) < MARGEM_CIMA)
            {
                jogador2.Y += 5;
            }

            if (Keyboard.GetState().IsKeyDown(Key.Down) &&
                (jogador2.MARGEM_BAIXO - 5) > MARGEM_BAIXO)
            {
                jogador2.Y -= 5;
            }
        }

        #region GET'S SET'S

        public int LARGURA_TELA 
        { 
            get 
            {
                jogador1.X = MARGEM_ESQUERDA + bola.LAGURA / 2;
                jogador2.X = MARGEM_DIREITA - bola.LAGURA / 2;
                return ClientSize.Width;
            }
        }

        public int ALTURA_TELA 
        { 
            get => ClientSize.Height; 
        }

        public int MARGEM_DIREITA
        {
            get => (ClientSize.Width / 2);
        }

        public int MARGEM_ESQUERDA
        {
            get => -(ClientSize.Width / 2);
        }

        public int MARGEM_CIMA
        {
            get => (ClientSize.Height / 2);
        }

        public int MARGEM_BAIXO
        {
            get => -(ClientSize.Height / 2);
        }

        #endregion
    }
}
