using System;

namespace Exercise_26
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
                int numberOfVowels = 0;


                foreach (char ch in array)
                {
                    if (ch.ToString() == "a" || ch.ToString() == "e" || ch.ToString() == "i" || ch.ToString() == "o" || ch.ToString() == "u")
                        numberOfVowels++;
                }

                Console.WriteLine($"There were {numberOfVowels} vowels.");

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
