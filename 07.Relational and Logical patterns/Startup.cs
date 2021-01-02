namespace RelationalAndLogicalPatterns
{
    using System;
    
    internal class Startup
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            var message = input switch
            {
                <= 0 => "Less than or equal to 0",
                > 0 and <= 10 => "More than 0 but less than or equal to 10",
                > 10 and not 666 and not 1313 => "More than 10, but not equal to 666 or 1313",
                666 or 1313 => "Symbolic number"
            };

            Console.WriteLine(message);
        }
    }
}
