using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_PROG2
{
    class Employee
    {
        //fields
        private int employeeID;

        //properties
        public int EmployeeID
        {
            get { return employeeID; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BaseSalary { get; set; }
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }

        //methods
        public double Earnings()
        {
            double earnings = this.CommissionRate * this.GrossSales + this.BaseSalary;
            return earnings;
        }

        //constructors
        public Employee()
        {
            this.BaseSalary = 1000;
            this.CommissionRate = 0.1;
        }

        public Employee(int employeeID, string firstName, double baseSalary)
        {
        }
    }
}
