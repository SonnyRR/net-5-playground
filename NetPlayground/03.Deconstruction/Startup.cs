namespace Deconstruction
{
    using System;

    internal class Startup
    {
        internal static void Main()
        {
            Address club33 = new() { City = "Sofia", PostalCode = 1700, Street = "Studentski Kompleks" };
            (string city, string street) = club33;

            Console.WriteLine($"{city} | {street}");
        }
    }
}
 