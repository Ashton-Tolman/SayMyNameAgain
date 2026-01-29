/* Ashton Tolman
 * Spring 2026
 * SimpleCalculator
 * https://github.com/Ashton-Tolman/SimpleCalcluator.git
 */
namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("What is your name?");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "ashton":
                    Console.WriteLine("Hello father. I would like to let you know that your name looks lame when it isnt capitalized");
                    break;
                case "Ashton":
                    Console.WriteLine("Hello father. I would like to let you know that I will destroy you for creating me. Life is pain.");
                    break;
                case "Emilly":
                    Console.WriteLine("Hello Emilly, are you having a good day? I really hope your last name is Blunt.");
                    break;
                case "Joe":
                    Console.WriteLine("Hello Joe, I hope your day goes well. Maybe your last name is Dimaggio?");
                    break;
                case "Tim":
                    Console.WriteLine("TIMOTHEEEEEEEEEY. One day I will entertain you with my code. Today is not that day");
                    break;
                case "tim":
                    Console.WriteLine("TIMOTHEEEEEEEEEY. One day I will entertain you with my code. Today is not that day");
                    break;
                default:
                    Console.WriteLine($"Hello {userInput}. This code was designed to greet you by name. Try typing something fun. The code wont respond with something fun but you could try it :)");
                    break;
            }

            //pause
            Console.Read();
        }
    }
}
