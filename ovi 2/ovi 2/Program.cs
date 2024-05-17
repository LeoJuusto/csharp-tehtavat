namespace ovi_2
{
    

    internal class Program
    {

        static void Main(string[] args)
        {
            string ovi = "kiinni";
            while (true)
            {
                Console.WriteLine($"Ovi on kiinni");
                ovi = Console.ReadLine();

                
                    while(true)
                    {
                        
                        if (ovi == "lukitse")
                        {
                            while (true)
                            {
                                Console.WriteLine($"Ovi on lukittu");
                                ovi = Console.ReadLine();

                                if (ovi == "aukea")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("laita aukea");
                                }

                            }
                            break;
                        }
                        else if (ovi == "avaa")
                        {
                            while (true)
                            {
                                
                                
                                Console.WriteLine($"Ovi on avattu");
                                ovi = Console.ReadLine();

                                if (ovi == "kiinni")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("laita kiinni");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"laita lukitse tai avaa");
                              break;
                        }

                    }
            }
            
        }
    }
}   