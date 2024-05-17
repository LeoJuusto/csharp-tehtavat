using System.Security.Cryptography.X509Certificates;

namespace robotti
{
    internal class Program
    {
        public int X = 0;
        public int Y = 0;
        public bool OnKäynnissä;
        public int RobottiKäsky = 0;
        public int vaihto = 0;
        static void Main(string[] args)
        {
           Program p = new Program();
            p.Suorita();
        }

        public void Suorita()
        {
            while (true)
            {
                Console.WriteLine("mitä komentoja robotille käynnistä sammuta ylös alas oikea vasen");
                string valinto = Console.ReadLine();

                if (valinto == "käynnistä")
                {
                    OnKäynnissä = true;
                    vaihto += 1;
                }
                if (valinto == "sammuta")
                {
                    OnKäynnissä = false;
                    vaihto += 1;
                }
                if (valinto == "ylös" & OnKäynnissä == true)
                {
                    Y += 1;
                    vaihto += 1;
                }
                if (valinto == "alas" & OnKäynnissä == true)
                {
                    Y -= 1;
                    vaihto += 1;
                }
                if (valinto == "oikea" & OnKäynnissä == true)
                {
                    X += 1;
                    vaihto += 1;
                }
                if (valinto == "vasen" & OnKäynnissä == true)
                {
                    X -= 1;
                    vaihto += 1;
                }
                Console.WriteLine($"robotti; {X} {Y} {OnKäynnissä}");
                if (vaihto == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("laita joku niistä");
                }
            }
        }
    }
}