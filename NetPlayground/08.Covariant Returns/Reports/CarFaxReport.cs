using System;

namespace CovariantReturns.Reports
{
    internal record CarFaxReport : VehicleReport
    {
        public int PreviousOwners { get; set; }

        public DateTime MOT { get; set; }
    }
}
