using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            Personagem person1 = new Personagem("Lula");
            Personagem Person2 = new Personagem("Bolsonaro");

            Console.Clear();

            do
            {
                if (person1.getVida() > 0 && Person2.getVida() > 0)
                {
                    person1.Combate(Person2.getAtaque());
                    Person2.Combate(person1.getAtaque());
                }
                else if (person1.getVida() <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Person2.getNome() + " Ganhou!");
                    Console.ForegroundColor = ConsoleColor.White;
                    gameOver = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(person1.getNome() + " Ganhou!");
                    Console.ForegroundColor = ConsoleColor.White;
                    gameOver = true;
                }

            } while (!gameOver);

            Console.ReadLine();
        }
    }

}

