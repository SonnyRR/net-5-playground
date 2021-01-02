namespace CovariantReturns.Reports
{
    internal record SpecialVehicleReport : VehicleReport
    {
        public bool HasSpecialLicencePlate { get; set; }

        public bool HasSpecialDrivingPermission { get; set; }

        public string OperatedBy { get; set; }
    }
}
