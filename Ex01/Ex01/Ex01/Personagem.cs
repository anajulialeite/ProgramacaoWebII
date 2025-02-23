using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Personagem
    {
        private string nome;

        private int vida;

        private int ataque;

        private int defesa;

        public Personagem(string nome)
        {
            this.nome = nome;
            this.vida = 100;
            this.ataque = 50;
            this.defesa = 30;
            Console.WriteLine("Personagem: " + nome + ", criado com sucesso!");
        }

        //Regras de combate
        public string getNome()
        {
            return nome;
        }

        public int getVida()
        {
            return vida;
        }

        public int getAtaque()
        {
            return ataque;
        }

        public int getDefesa()
        {
            return defesa;
        }

        public void Combate(int dano)
        {
            Random danoVariavel = new Random();
            int ataqueFinal = this.defesa - danoVariavel.Next(0, dano);

            if (ataqueFinal > 0)
            {
                vida -= ataqueFinal;
                if (VerificarVida())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(nome + ", leva dano de: " + ataqueFinal);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("vida: " + vida);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(nome + " Bloqueou o ataque");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }

        }

        public bool VerificarVida()
        {
            if(vida <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(nome + ". Se Lascou! :(");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            return true;
        }

    }

}

