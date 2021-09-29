using GameTop.Interface;
namespace GameTop
{
    public class JogoFoda 
    {

        private readonly iJogador _JogadorA; 
        private readonly iJogador _JogadorB;
        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;
        }        

        public  void IniciarJogo()
        {
            System.Console.Write(_JogadorA.Passe());
            System.Console.Write(_JogadorA.Chuta());
            System.Console.Write(_JogadorA.Corre());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.Write(_JogadorB.Passe());
            System.Console.Write(_JogadorB.Chuta());
            System.Console.Write(_JogadorB.Corre()); 
        }

    }
}