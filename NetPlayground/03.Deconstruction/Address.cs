namespace Deconstruction
{
    public record Address
    {
        public string City { get; init; }

        public string Street { get; init; }

        public string BuildingNumber { get; init; }

        public int PostalCode { get; init; }

        internal void Deconstruct(out string city, out string street)
            => (city, street) = (this.City, this.Street);
    }
}
