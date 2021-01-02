namespace PatternMatching
{
    using System;

    internal static class Startup
    {
        internal static void Main()
        {
            Console.Write("Please enter a character:");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || input.Length is not 1)
            {
                throw new ArgumentException();
            }

            Console.WriteLine($"Is input symbol a letter or separator: {input[0].IsLetterOrSeparator()}");
        }

        private static bool IsLetterOrSeparator(this char c) 
            => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
    }
}
