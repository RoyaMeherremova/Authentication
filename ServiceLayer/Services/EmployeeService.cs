using DomainLayer.Models;
using ServiceLayer.Helpers.Constans;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public int GetEmployeeByBirthdaySalary(DateTime start, DateTime end)
        {
            Employee[] arr = GetEmployee();
            int count = 0;
            bool checkEmployee=false;
            foreach (var item in arr)
            {
                if (item.Birthday > start && item.Birthday < end && item.Salary > 2000)
                {
                    count++;
                    checkEmployee = true;
                }              
            }
            if (!checkEmployee)
            {
                Console.WriteLine(Error.ErrorFullName);
            }
            return count;
            
            
        }

        private Employee[] GetEmployee()
        {
            Employee employee1 = new Employee()
            {
                Name = "Gunel",
                Surname = "Cahandarova",
                Salary = 1990,
                Birthday = new DateTime(1987, 05, 07)

            };
            Employee employee2 = new Employee()
            {
                Name = "Rehim",
                Surname = "Kerimov",
                Salary = 2500,
                Birthday = new DateTime(1999, 06, 03)

            };
            Employee employee3 = new Employee()
            {
                Name = "Xayale",
                Surname = "Seyidova",
                Salary = 2300,
                Birthday = new DateTime(2001, 04, 07)

            };
            Employee employee4 = new Employee()
            {
                Name = "Seyid",
                Surname = "Cahandarov",
                Salary = 2200,
                Birthday = new DateTime(1951, 08, 07)

            };
            Employee[] arr = { employee1, employee2, employee3, employee4 };
            return arr;

        }



    }
}