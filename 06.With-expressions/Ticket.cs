using System;

namespace WithExpressions
{
    internal record Ticket
    {
        public string Event { get; init; }

        public decimal Price { get; init; }

        public string Attendee { get; init; }

        public string Sector { get; init; }

        public DateTime Date { get; set; }
    }
}
