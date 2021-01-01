using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleAPI.Models;
using System;
using System.Collections.Generic;

namespace SampleAPI.Controllers
{
    public class EmployeesController : BaseApiController
    {
        private readonly ILogger<EmployeesController> logger;

        private readonly List<Employee> Employees = new()
        {
            new()
            {
                FirstName = "Vasil",
                MiddleName = "'Sonny'",
                LastName = "Kotsev",
                PayrollNumber = "14NQ205110",
                Salary = 1337M
            },
            new()
            {
                FirstName = "Dj",
                MiddleName = "Damyan",
                PayrollNumber = "91MQPZQM33",
                Salary = 10_111M
            },
            new()
            {
                FirstName = "Emiliya",
                MiddleName = "Ivanova",
                LastName = "Tsvetkova",
                PayrollNumber = "512251MQRK",
                Salary = 13412M
            }
        };
        public EmployeesController(ILogger<EmployeesController> logger)
            => this.logger = logger;


        [HttpGet]
        public IReadOnlyCollection<Employee> All()
            => this.Employees.AsReadOnly();

        [HttpPost]
        public Employee Create(string firstName, string middleName, string lastName, string payrollNum, decimal salary)
            => new(firstName, middleName, lastName, payrollNum, salary);

        [HttpPut("vasil/update-salary")]
        public Employee UpdateSalaryOfVasil(decimal amount)
        {
            Employee vasko = new("Vasil", "'Sonny'", "Kotsev", "14NQ205110", 1337M);
            return vasko with { Salary = amount };
        }

        [HttpDelete]
        public bool Delete(Employee employeeToDelete)
        {
            bool isDeletionSuccessful = default;

            if (employeeToDelete is not null)
            {
                if (this.Employees.Contains(employeeToDelete))
                {
                    this.Employees.Remove(employeeToDelete);
                    isDeletionSuccessful = true;
                }
                else
                {
                    this.logger.LogError("User does not exist!");
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(employeeToDelete));
            }

            return isDeletionSuccessful;
        }

    }
}
