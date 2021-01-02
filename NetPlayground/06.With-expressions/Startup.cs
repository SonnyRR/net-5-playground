namespace WithExpressions
{
    using System;
    
    internal class Startup
    {
        internal static void Main()
        {
            Ticket megadethSofiaConcert = new()
            {
                Attendee = "VK",
                Event = "Megadeth/FFDP 2020 Sofia",
                Price = 159M,
                Sector = "A1",
                Date = new DateTime(2020, 2, 22)
            };

            Ticket plazzaEmanuelaTicket = megadethSofiaConcert with { Event = "Plazza: Emanuela", Sector = "VIP Separe"};

            Console.WriteLine($"{megadethSofiaConcert}{Environment.NewLine}{plazzaEmanuelaTicket}");
        }
    }
}
