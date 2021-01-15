using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some letters below:");
            var letters = Console.ReadLine();
            string output = string.Empty;
            var count = 1;
            foreach (char c in letters)
            {
                for (int i = 0; i < count; i++)
                {
                    if (i == 0)
                    {
                        output += char.ToUpper(c);
                    }
                    else
                    {
                        output += c;
                    }
                }
                output += "-";
                count++;
            }
            string trimmed = output.TrimEnd('-');
            Console.WriteLine($"Here is the new output {trimmed}");

        }
    }
}
