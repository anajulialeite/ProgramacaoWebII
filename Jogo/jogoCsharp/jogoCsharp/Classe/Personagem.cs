using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jogoCsharp;

namespace jogoCsharp.Classe
{
    class Personagem
    {
        public string Nome { get; private set; }
        public int Vida { get; protected set; }
        public int Ataque { get; protected set; }

        private static Random random = new Random(); // Objeto para gerar números aleatórios

        public Personagem(string nome, int vida, int ataque)
        {
            Nome = nome;
            Vida = vida;
            Ataque = ataque;
        }

        public void Atacar(Personagem alvo)
        {
            // Dano varia entre 80% e 120% do ataque base
            int danoVariavel = random.Next((int)(Ataque * 0.8), (int)(Ataque * 1.2) + 1);

            // Chance de crítico (20%) - Dano dobrado
            bool critico = random.Next(1, 101) <= 20;
            if (critico)
            {
                danoVariavel *= 2;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"PERIGO! {Nome} causou dano dobrado!");
                Console.ResetColor();
            }

            // Chance de esquiva (10%) - O ataque não acerta
            bool esquivou = random.Next(1, 101) <= 10;
            if (esquivou)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{alvo.Nome} esquivou do ataque!");
                Console.ResetColor();
                return;
            }

            // Aplica o dano ao alvo
            alvo.Vida -= danoVariavel;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} causando {danoVariavel} de dano!");

            // Garante que a vida não fique negativa
            if (alvo.Vida < 0) alvo.Vida = 0;
        }
    }
}

