namespace CovariantReturns.Vehicles
{
    using CovariantReturns.Reports;
    
    internal class Ambulance : Vehicle
    {
        public bool HasDefribrilator { get; set; }

        public int CrewCount { get; set; }

        public int Capacity { get; set; }

        public override SpecialVehicleReport GetVehicleReport()
            => new SpecialVehicleReport();
    }
}
