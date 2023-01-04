using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    internal class StudentController
    {
        private readonly StudentService _service;

        public StudentController()
        {
            _service= new StudentService();
        }

        public void GetStudentsAverageAge()=>Console.WriteLine(_service.GetStudentsAverageAge());

        public void GetStudentsCount()=>Console.WriteLine(_service.GetStudentsCount());

        public void GetStudentsBySameName()=>Console.WriteLine(_service.GetStudentsBySameName());

        public void GetStudentEmail()
        {
            var result = _service.GetStudentEmail("c");
            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Address} {item.Education} {item.Age} {item.Email}");
                }
            }
        }

        public void GetStudentsAddress()
        {
            var result = _service.GetStudentsAddress("Ehmedli");
            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Address} {item.Education} {item.Age} {item.Email}");
                }
            }
        }
        public void GetStudentsFullName()
        {
            Console.WriteLine("Add name:");
            string name=Console.ReadLine();
            Console.WriteLine("Add surname:");
            string surname=Console.ReadLine();
            var result=_service.GetStudentsFullName(name, surname);
            Console.WriteLine(result);
            
        }


    }
}
