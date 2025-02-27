using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoCsharp.Classe
{
    class Batalha
    {
        private Jogador jogador;
        private Inimigo inimigo;

        public Batalha(Jogador jogador, Inimigo inimigo)
        {
            this.jogador = jogador;
            this.inimigo = inimigo;
        }

        public void Iniciar()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Batalha iniciada entre {jogador.Nome} e {inimigo.Nome}!");
            Console.ResetColor();

            while (jogador.Vida > 0 && inimigo.Vida > 0)
            {
                // Turno do jogador
                jogador.Atacar(inimigo);

                // Verifica se o inimigo foi derrotado
                if (inimigo.Vida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{jogador.Nome} venceu a batalha!");
                    Console.ResetColor();
                    jogador.GanharExperiencia(50);
                    return;
                }

                // Turno do inimigo
                inimigo.Atacar(jogador);

                // Verifica se o jogador foi derrotado
                if (jogador.Vida <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($" X( {jogador.Nome} MORREU! Fim de jogo.");
                    Console.ResetColor();
                    return;
                }
            }
        }
    }
}
