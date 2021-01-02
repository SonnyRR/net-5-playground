namespace SampleAPI.Models
{
    public record Employee
    {
        public Employee()
        {
        }

        public Employee(string firstName, string middleName, string lastName, string payrollNumber, decimal salary)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.PayrollNumber = payrollNumber;
            this.Salary = salary;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string PayrollNumber { get; set; }

        public decimal Salary { get; set; }
    }
}