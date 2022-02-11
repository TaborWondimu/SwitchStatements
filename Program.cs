using System;
namespace SwitchStatements
{
    public class progam
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter Favorite Subject");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "English":
                    Console.WriteLine(" Mee too");
                    break;
                case "Math":
                    Console.WriteLine("Nerd");
                    break;
                case "Bio":
                    Console.WriteLine("My guy");
                    break;
                case "C#":
                    Console.WriteLine("You Go");
                    break;
                case "JAVA":
                    Console.WriteLine("NO NOT YET");
                    break;
                default:
                    Console.WriteLine("Never Mind");
                    break;
            }
        }
    }
}