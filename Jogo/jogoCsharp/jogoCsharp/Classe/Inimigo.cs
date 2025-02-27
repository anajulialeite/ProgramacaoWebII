using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoCsharp.Classe
{
    class Inimigo : Personagem
    {
        public string Dificuldade { get; private set; }

        public Inimigo(string nome, string dificuldade) : base(nome, 0, 0) 
        {
            Dificuldade = dificuldade;
            AjustarDificuldade();
        }

        private void AjustarDificuldade()
        {
            switch (Dificuldade.ToLower())
            {
                case "fácil":
                    Vida = 50;
                    Ataque = 10;
                    break;
                case "médio":
                    Vida = 80;
                    Ataque = 15;
                    break;
                case "difícil":
                    Vida = 120;
                    Ataque = 20;
                    break;
                default:
                    Vida = 80;
                    Ataque = 15;
                    Console.WriteLine("Dificuldade desconhecida! Definindo como 'Médio'.");
                    break;
            }
        }
    }
}
