namespace InitOnlySetters
{
    using System;
    
    internal class Startup
    {
        internal static void Main()
        {
            Subscription netflix = new("Vasil", new DateTime(2021, 12, 31));
            
            // CS8852
            netflix.User = "Emiliya";
        }

        private class Subscription
        {
            public Subscription()
            {
            }

            public Subscription(string user, DateTime validTo)
            {
                this.User = user;
                this.ValidTo = validTo;
            }

            public string User { get; init; }

            public DateTime ValidTo { get; init; }
        }
    }
}
