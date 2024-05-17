namespace seikkailijanreppu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tilavuus = 0;
            double paino = 0;
            double tavaraa = 0;
            

            while (true)
            {
                if (tavaraa >= 10) {

                    Console.WriteLine($"täynnä");
                    break;
                
                }
                if (paino >= 30)
                {
                    Console.WriteLine($"täynnä");
                    break;

                }
                if (tilavuus >= 20)
                {
                    Console.WriteLine($"täynnä");
                    break;

                }
                Console.WriteLine($"repussa on tällä hetkellä {tavaraa}/10 tavaraa {paino}/30 painoa {tilavuus}/20 tilavuus");
                Console.WriteLine($"mitä haluut lisätä");
                Console.WriteLine($"nuoli");
                Console.WriteLine($"jousi");
                Console.WriteLine($"köysi");
                Console.WriteLine($"vettä");
                Console.WriteLine($"ruokaa");
                Console.WriteLine($"miekka");
                string valinto = Console.ReadLine();
                if (valinto == "nuoli")
                {
                    tavaraa += 1;
                    paino += 0.1;
                    tilavuus += 0.05;
                }
                if (valinto == "jousi")
                {
                    tavaraa += 1;
                    paino += 0.1;
                    tilavuus += 0.05;
                }
                if (valinto == "köysi")
                {
                    tavaraa += 1;
                    paino += 2;
                    tilavuus += 2;
                }
                if (valinto == "vesi")
                {
                    tavaraa += 1;
                    paino += 1;
                    tilavuus += 1.5;
                }
                if (valinto == "ruokaa")
                {
                    tavaraa += 1;
                    paino += 1;
                    tilavuus += 0.5;
                }
                if (valinto == "miekka")
                {
                    tavaraa += 1;
                    paino += 2;
                    tilavuus += 3;
                }
                else
                {
                    Console.WriteLine($"laita yks niistä");
                }
            }
        }
    }
}