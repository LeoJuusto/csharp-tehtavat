namespace nuoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double maksu = 0;
                while (true)
                {
                    Console.WriteLine("puu teräs vai timantti");
                    string kärki = Console.ReadLine();
                    
                    if (kärki == "puu")
                    {
                        maksu += 3;
                        break;
                    }
                    if (kärki == "teräs")
                    {
                        maksu += 5;
                        break;
                    }
                    if (kärki == "timantti")
                    {
                        maksu += 50;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("laita teräs timantti tai puu");
                        continue;
                    }

                }
                while (true)
                {
                    Console.WriteLine("Perä: Lehti 0 kultaa, kanansulka 1 kulta ja kotkansulka 5 kultaa");
                    string perä = Console.ReadLine();

                    if (perä == "lehti")
                    {
                        break;
                    }
                    if (perä == "kanansulka")
                    {
                        maksu += 1;
                        break;
                    }
                    if (perä == "kotkansulka")
                    {
                        maksu +=5;
                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine("laita lehti kanasulka tai kotkasulka");
                        continue;
                    }



                }

                
                bool sallittuPituus = true;
                while (sallittuPituus)
                {
                    Console.WriteLine("laita nuolen pituus 60-100");
                    string pituus = Console.ReadLine();
                    int iPituus = 0;
                    bool succes = int.TryParse(pituus, out iPituus);
                    if(succes)
                    {
                        // tarkista onko välillä 60-100
                        if (iPituus > 100 && iPituus < 60)
                        {
                            Console.WriteLine("laita numero 60 ja 100 välille");
                            break;
                        }
                        // laske hinta pituus*yksikkö
                        maksu += iPituus * 0.05;
                        Console.WriteLine($"maksu on {maksu}");
                        break;
                        
                    }
                    else
                    {
                        Console.WriteLine("laita numero");
                        continue;
                        // Ilmoita käyttäjälle virheellisestä syötteestä
                    }
                    
                }



                break;









            }
        }
    }
}