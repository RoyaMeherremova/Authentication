using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        double GetStudentsAverageAge();
        Student[] GetStudentEmail(string letter);
        int GetStudentsCount();
        string GetStudentsFullName(string name,string surname);
        Student[] GetStudentsAddress(string address);
        int GetStudentsBySameName();

    }
}
