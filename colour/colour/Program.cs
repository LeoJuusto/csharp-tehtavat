namespace colour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Miekka");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Jousi");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kirves");
        }
    }
}