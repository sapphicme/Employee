using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_PROG2
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            double baseSalary, grossSales, commissionRate;
            Employee anon = new Employee();

            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter Base Salary: ");
            baseSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Gross Sales: ");
            grossSales = Convert.ToDouble(Console.ReadLine());

            //checks if grossSales is withing acceptable values
            while(grossSales <=0)
            {
                Console.WriteLine("Gross Sales cannot be negative or zero");
                Console.Write("Enter Gross Sales: ");
                grossSales = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Enter Commission Rate: ");
            commissionRate = Convert.ToDouble(Console.ReadLine());

            //checks if commissionRate is within acceptable values

            while (commissionRate < 0.1 || commissionRate > 1.0)
            {
                Console.WriteLine("Commission rate should be between 0.1% and 1.0%");
                Console.Write("Enter Commission Rate: ");
                commissionRate = Convert.ToDouble(Console.ReadLine());
            }

            Employee staff = new Employee(1, firstName, baseSalary);
            //calculates and displays earnings for staff in currency format
            Console.WriteLine("Earnings of {0} {1} come out to {2:c2}", staff.FirstName, staff.LastName, staff.Earnings());
        }
    }
}
