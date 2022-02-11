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
                    Console.WriteLine(" English Mee too");
                    break;
                case "Math":
                    Console.WriteLine("Math is for Nerds");
                    break;
                case "Bio":
                    Console.WriteLine(" Bio is the way My guy");
                    break;
                case "C#":
                    Console.WriteLine(" C#, You Go");
                    break;
                case "JAVA":
                    Console.WriteLine("No no Java NO NOT YET");
                    break;
                default:
                    Console.WriteLine("Never Mind");
                    break;
            }
        }
    }
}