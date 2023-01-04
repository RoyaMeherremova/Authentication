using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class EmployeeController
    {
      public void Employee()
        {
            IEmployeeService employee = new EmployeeService();
            var startDate = new DateTime(1950, 05, 05);
            var endDate = new DateTime(2010, 05, 05);
            var result =employee.GetEmployeeByBirthdaySalary(startDate, endDate);
            Console.WriteLine(result);
        }

    }
}
