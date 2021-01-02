namespace Records
{
    using System;
    
    public class Startup
    {
        public static void Main()
        {
            Message fineMessage = new("You've been fined 50$ for going 10 km/h over the speed limit.", "KAT Montana", DateTime.Now);
            Console.WriteLine(fineMessage + Environment.NewLine);

            Message A = new("Lorem Ipsum", "John Doe", new DateTime(2020, 12, 31));
            Message B = new("Lorem Ipsum", "John Doe", new DateTime(2020, 12, 31));
            Message C = new("Lorem Ipsum", "John Doe", new DateTime(2021, 1, 1));
            Console.WriteLine($"Is message A equal to message B:{A == B}");
            Console.WriteLine($"Is message A equal to message C:{A == C}{Environment.NewLine}");
        }
    }
}