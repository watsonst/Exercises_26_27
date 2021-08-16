using System;

namespace Exercise_27
{
    class Program
    {
        public static void Main(string[] args)
        {
            string answer = string.Empty;

            do
            {
                Console.Write("Please enter some text: ");
                string userInput = Console.ReadLine().ToLower();


                char[] array = userInput.ToCharArray();
                int numberOfConsonants = 0;


                foreach (char ch in array)
                {
                    if (ch.ToString() != "a" || ch.ToString() != "e" || ch.ToString() != "i" || ch.ToString() != "o" || ch.ToString() != "u")
                        numberOfConsonants++;
                }

                Console.WriteLine($"There were {numberOfConsonants} consonants.");

                Console.Write("\nWould you like to continue? (y/n): ");
                answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

            } while (answer == "y");
        }

    }

}

