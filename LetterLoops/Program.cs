using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some letters");
            string input = Console.ReadLine();
            string output = "";

            // Iterate over the input string
            for (int i = 0; i < input.Length; i++)
            {
                // Write a capital letter to ouput at each indexed letter
                output += char.ToUpper(input[i]);

                // Iterate over each character the number of times equal to the index
                for (int j = 0; j < i; j++)
                {
                    // At each iteration, write a lowercase letter
                    output += char.ToLower(input[i]);
                }

                // Add a dash for every indexed character
                output += "-";
            }

            // Remove the last dash
            string finalOutput = output.Remove(output.Length - 1);

            Console.WriteLine(finalOutput);
            Console.ReadKey();
        }
    }
}
