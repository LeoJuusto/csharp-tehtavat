while (true)
{
    Console.WriteLine("pääruoka aine nautaa kanaa kasviksia : ");

    string pääruoka = Console.ReadLine();
    if (pääruoka == "kanaa")
    {
        Console.WriteLine("ok");
    }
    else if (pääruoka == "nautaa")
    {
        Console.WriteLine("ok");
    }
    else if (pääruoka == "kasviksia")
    {
        Console.WriteLine("ok");
    }
    else
    {
        Console.WriteLine("laita aine");
        continue;
    }
    Console.WriteLine("lisukkeet perunaa riisiä pastaa : ");
    string lisuke = Console.ReadLine();
    if (lisuke == "perunaa")
    {
        Console.WriteLine("ok");
    }
    else if (lisuke == "riisiä")
    {
        Console.WriteLine("ok");
    }
    else if (lisuke == "pastaa")
    {
        Console.WriteLine("ok");
    }
    else
    {
        Console.WriteLine("laita lisuke");
        continue;
    }
    Console.WriteLine("kastike pippuri chili tomaatti curry : ");
    string kastike = Console.ReadLine();
    if (kastike == "pippuri")
    {
        Console.WriteLine("ok");
    }
    else if (kastike == "chili")
    {
        Console.WriteLine("ok");
    }
    else if (kastike == "tomaatti")
    {
        Console.WriteLine("ok");
    }
    else if (kastike == "curry")
    {
        Console.WriteLine("ok");
    }
    else
    {
        Console.WriteLine("laita kastike");
        continue;
    }
    Console.WriteLine($"{pääruoka} ja {lisuke} {kastike}-kastikkeella");
    break;

}