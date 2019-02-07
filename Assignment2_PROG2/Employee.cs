using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_PROG2
{
    class Employee
    {
        static void Main(string[] args)
        {


        }

        readonly public int EmployeeId;
        public string FirstName;
        public string LastName;
        public double BaseSalary = 1000.00;
        public double GrossSales;
        public double ComissionRate = 0.1;


        public void Earnings(double comissionCalc)
        {
            comissionCalc = ComissionRate * GrossSales + BaseSalary;
            return;
        }

        public void Employee()
        {
            
        }

        public Employee(int employeeID, string firstName, double baseSalary)
        {
            EmployeeId = employeeID;
            FirstName = firstName;
            BaseSalary = baseSalary;

        }
    }
}
