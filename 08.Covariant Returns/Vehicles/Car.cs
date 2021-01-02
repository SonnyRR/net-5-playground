namespace CovariantReturns.Vehicles
{
    using CovariantReturns.Reports;
    
    internal class Car : Vehicle
    {
        public int Doors { get; set; }

        public bool IsHatchback { get; set; }

        public bool IsRoadster { get; set; }

        public float LuggageCapacity { get; set; }

        public string TrimLevel { get; set; }

        public override CarFaxReport GetVehicleReport()
            => new CarFaxReport();
    }
}
