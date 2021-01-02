namespace CovariantReturns.Vehicles
{
    using CovariantReturns.Reports;
    
    internal abstract class Vehicle
    {
        public string Type { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public float Horsepower { get; set; }

        public abstract VehicleReport GetVehicleReport();
    }
}
