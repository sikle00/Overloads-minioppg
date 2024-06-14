namespace Overloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var welcome = new WelcomeMessage("Hi and welcome to the room :)");
            var welcome2 = new WelcomeMessage("Hi and welcome", "you are nice");
            Console.WriteLine($"{welcome.Hey}");
            Console.WriteLine($"{welcome2.Hey}, {welcome2.Compliment}");

        }
    }
}
