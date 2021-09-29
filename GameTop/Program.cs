using System;
using GameTop.Lib;

namespace GameTop
{
            class Program
        {
            static void Main(string[] args)
            {
                var jogo = new JogoFoda(
                    new Jogador1("Adeilson"),
                    new Jogador2("José")
                );
                
                jogo.IniciarJogo();
            }
        }

}
