namespace kordinaatti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string x = Console.ReadLine();
                int oikeax = 0;
                bool succes = int.TryParse(x, out oikeax);
                if (succes)
                {
                    Console.WriteLine("nyt y");
                    while (true)
                    {
                        string y = Console.ReadLine();
                        int oikeay = 0;
                        bool succesY = int.TryParse(x, out oikeax);
                        if (succesY)
                        {

                            if (oikeax == 0 && oikeay == 0)
                            {
                                Console.WriteLine("Annettu kordinaatti 0,0 on kordinaatissa 0,0.");
                            }
                            else
                            {
                                Console.WriteLine($"Annettu kordinaatti {x},{y} on kordinaatin 0,0 vieressä.");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("laita numero");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("laita numero");
                    continue;
                }
            }
        }
    }
}