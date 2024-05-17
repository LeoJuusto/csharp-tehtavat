namespace taistelupeli_harjoitus_eiluokkia
{
    internal class Program
    {
 
        static void Main(string[] args)
        {       

            int miekkadamage = 3;
            bool life = true;
            bool pyhäkranaatti = false;
            bool suojapotion = false;
            int kulta = 20;
            while (true)
            {
                if (life == false)
                {
                    break;
                }
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("haluatko mennä taistelemaan vai kauppaan");
                Console.WriteLine($"sulla on {kulta} kultaa");
                string valinto = Console.ReadLine();


                if (valinto == "taistelemaan")
                {
                    int orkki = 9;
                    int luuranko = 1;
                    int haamu = 1;
                    int pelaaja = 13;

                    Console.WriteLine("orkki luuranko ja haamu hyökkää mitä teet");
                    while (true)
                    {
                        Console.WriteLine("--------------------------------------------------------------------------");
                        if (orkki <= 0 && luuranko <= 0 && haamu <= 0)
                        {
                            Console.WriteLine("voitit sait 5 kultaa");
                            kulta += 5;
                            break;
                        }
                        pelaaja -= 2;
                        Console.WriteLine($"yksi hirviöistä hyökkäsi ja menetit 2 elämää nyt sulla on {pelaaja}/13 elämää jäljel");

                        Console.WriteLine("valitse ketä hyökkäät");
                        if (suojapotion == true)
                        {
                            Console.WriteLine("sulla on suoja potion sano suoja potion jos haluut käyttää sitä");
                        }
                        if (pyhäkranaatti == true)
                        {
                            Console.WriteLine("sulla on pyhäkranaatti sano pyhä kranaatti jos haluut käyttää sitä");
                        }
                        string vastustajavalinto = Console.ReadLine();
                        if (suojapotion == true && vastustajavalinto == "suojapotion")
                        {
                            Console.WriteLine("käytit sen sulla on enemmän elämää mut sä käytit sun vuoron");
                            pelaaja += 999;
                        }
                        if (pyhäkranaatti == true && vastustajavalinto == "pyhä kranaatti")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("heitit pyhä kranaatin ja räjähdys oli niin iso et kaikki 1 kilometrin alueella oli tuhottu ja kuolit vihollisten kanssa");
                            life = false;
                            break;
                        }
                        if (vastustajavalinto == "orkki" && orkki >= 0)
                        {
                            Console.WriteLine("millä tavalla hyökkäät orkkia, miekka, jousi, crucifix");
                            string hyökkäysvalinto = Console.ReadLine();
                            if (hyökkäysvalinto == "miekka")
                            {
                                Console.WriteLine($"hyokkäsit ja orkki menetti {pelaaja} elämää");
                                orkki -= miekkadamage;
                                if (orkki <= 0)
                                {
                                    Console.WriteLine("se kuoli");
                                }
                                else
                                {
                                    Console.WriteLine($"{orkki}/9 elämää jäljellä");
                                }
                            }
                            else if (hyökkäysvalinto == "jousi")
                            {
                                Console.WriteLine($"hyokkäsit ja orkki menetti {miekkadamage} elämää");
                                orkki -= miekkadamage;
                                if (orkki <= 0)
                                {
                                    Console.WriteLine("se kuoli");
                                }
                                else
                                {
                                    Console.WriteLine($"{orkki}/9 elämää jäljellä");
                                }

                            }
                            else if (hyökkäysvalinto == "crucifix")
                            {
                                Console.WriteLine("ei se toimi orkkia vastaan");
                            }
                            else
                            {
                                Console.WriteLine("et tehny mitää");
                            }
                        }
                        else if (vastustajavalinto == "luuranko" && luuranko >= 0)
                        {
                            Console.WriteLine("millä tavalla hyökkäät luurankoa, miekka, jousi, crucifix");
                            string hyökkäysvalinto = Console.ReadLine();
                            if (hyökkäysvalinto == "miekka")
                            {
                                Console.WriteLine("mursit sen luut ja se kuoli heti");
                                luuranko -= 100;
                            }
                            else if (hyökkäysvalinto == "jousi")
                            {
                                Console.WriteLine("nuoli meni sen läpi ja se ei tehny mitää");
                            }
                            else if (hyökkäysvalinto == "crucifix")
                            {
                                Console.WriteLine("se näki sen ja meni tuleen ja kuoli");
                                luuranko -= 100;
                            }
                            else
                            {
                                Console.WriteLine("et tehny mitää");
                            }
                        }
                        else if (vastustajavalinto == "haamu" && haamu >= 0)
                        {
                            Console.WriteLine("millä tavalla hyökkäät haamua, miekka, jousi, crucifix");
                            string hyökkäysvalinto = Console.ReadLine();
                            if (hyökkäysvalinto == "miekka")
                            {
                                Console.WriteLine("ei se tehny mitää se meni sen läpi");
                            }
                            if (hyökkäysvalinto == "jousi")
                            {
                                Console.WriteLine("ei se tehny mitää se meni sen läpi");
                            }
                            if (hyökkäysvalinto == "crucifix")
                            {
                                Console.WriteLine("se näki sen ja katos");
                                haamu -= 100;
                            }
                            else
                            {
                                Console.WriteLine("et tehny mitää");
                            }
                        }
                        else
                        {
                            Console.WriteLine("et valinnu ketää tai se eliö on kuollu");
                        }

                        if (pelaaja <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("kuolit");
                            life = false;
                            break;
                        }
                    }
                }


                else if (valinto == "kauppaan")
                {
                    while (true)
                    {
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine("myyjä myy päivitetyn miekan ja jousen, suoja potionin, ja myös pyhä kranaatin");
                        Console.WriteLine("miekka ja jousi on 5 kultaa, suoja potion 10 ja kranaatti on 20");
                        Console.WriteLine("mitä haluat tehdä");
                        Console.WriteLine("osta paremmat miekka ja jousi, osta suoja potion, osta pyhä kranaatti, varasta, lähde");
                        string ostovalinto = Console.ReadLine();
                        if (ostovalinto == "osta paremmat miekka ja jousi" && kulta >= 5)
                        {
                            Console.WriteLine("ostit ne ja nyt ne tekee enemmän vahinkoa");
                            kulta -= 5;
                            miekkadamage += 2;
                        }
                        else if (ostovalinto == "osta pyhä kranaatti" && pyhäkranaatti == false)
                        {
                            Console.WriteLine("ostit sen ja voit käyttää sitä taistelussa");
                            kulta -= 20;
                            pyhäkranaatti = true;

                        }
                        else if (ostovalinto == "osta suoja potion" && suojapotion == false)
                        {
                            Console.WriteLine("ostit sen ja voit käyttää sitä taistelussa");
                            kulta -= 10;
                            suojapotion = true;

                        }
                        else if (ostovalinto == "varasta")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("varastit esineen ja myyjä ampu sua ja sä kuolit");
                            life = false;
                            break;
                        }
                        else if (ostovalinto == "lähde")
                        {
                            Console.WriteLine("lähdit kaupasta");

                            break;
                        }
                        else
                        {

                            Console.WriteLine("laita oikein tai oot varmaa ostanu sen jo");
                            continue;
                        }

                    }
                }


                else
                {
                    Console.WriteLine("laita oikein");
                    continue;
                }



            }
        }
    }
}