using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoCsharp.Classe
{
    class Jogador : Personagem
    {
        public int Experiencia { get; private set; }
        public int Nivel { get; private set; }

        public Jogador(string nome, int vida, int ataque) : base(nome, vida, ataque)
        {
            Experiencia = 0;
            Nivel = 1;
        }

        public void GanharExperiencia(int quantidade)
        {
            Experiencia += quantidade;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Nome} ganhou {quantidade} de experiência!");
            Console.ResetColor();

            // Se a experiência for suficiente, sobe de nível
            if (Experiencia >= 100)
            {
                SubirNivel();
            }
        }

        private void SubirNivel()
        {
            Nivel++;
            Experiencia = 0;
            Vida = 100; // Recupera vida ao subir de nível
            Ataque += 5; // Aumenta o ataque

            Console.WriteLine($"⭐ {Nome} subiu para o nível {Nivel}! Vida restaurada e ataque aumentado!");
        }
    }
}
