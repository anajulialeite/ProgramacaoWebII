using jogoCsharp.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jogoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Bem vindo ao jogo de luta!");
            Console.ResetColor();

            // Criando o jogador
            Jogador heroi = new Jogador("Hulk", 100, 20);

            // Criando o inimigo
            Inimigo monstro = new Inimigo("Loki", "Médio");

            // Iniciando a batalha
            Batalha batalha = new Batalha(heroi, monstro);
            batalha.Iniciar();
        }
    }
}
