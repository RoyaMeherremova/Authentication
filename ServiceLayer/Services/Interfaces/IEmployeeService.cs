using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmployeeService
    {
        int GetEmployeeByBirthdaySalary(DateTime start,DateTime end);
    }
}
