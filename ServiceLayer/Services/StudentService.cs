using DomainLayer.Models;
using ServiceLayer.Helpers.Constans;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace ServiceLayer.Services
{
    public class StudentService : IStudentService

    {
        public Student[] GetStudentEmail(string letter)
        {
            Student[]students= GetAll();
            Student[]arr=new Student[students.Length];
            int count = 0;
            bool checkEmail=false;
            foreach (Student student in students)
            {
                if (letter==student.Email.Substring(0,1))
                {
                    arr[count] = student;
                    count++;
                    checkEmail = true;

                }
            }
            if(!checkEmail)
            {
                Console.WriteLine(Error.ErrorEmail);
            }
            return arr;
        }

        public Student[] GetStudentsAddress(string address)
        {
            Student[]students= GetAll();
            Student[] arr = new Student[students.Length];
            int count = 0;
            bool checkAddress=false;
            foreach (Student student in students)
            {
                if (student.Address==address)
                {
                    arr[count] = student;
                    count++;
                    checkAddress = true;
                }
            }
            if(!checkAddress)
            {
                Console.WriteLine(Error.ErrorAddress);
            }
            return arr;
        }

        public double GetStudentsAverageAge()
        {
            Student[] students = GetAll();
            double sumAge = 0;
            foreach (var item in students)
            {
                sumAge += item.Age;
            }
            return Math.Ceiling(sumAge / students.Length);

        }

        public int GetStudentsBySameName()
        {
            Student[]students= GetAll();
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i+1; j < students.Length; j++)
                {
                    if (students[i].Name == students[j].Name)
                    {
                        count++;
                    }
                }
                
            }
            return count;
        }

        public int GetStudentsCount()
        {
            Student[] students = GetAll();
            int count = 0;
            foreach (var item in students)
            {
                count++;
            }
            return count;
        }

        public string GetStudentsFullName(string name, string surname)
        {
            Student[] students = GetAll();
            foreach (var item in students)
            {
                if (item.Name == name && item.Surname == surname)
                {
                    return $"{item.Name} {item.Surname} {item.Address} {item.Education} {item.Age} {item.Email}";
                }  
            }
            return Error.ErrorFullName;

        }

        private Student[] GetAll()
            {
                Student student1 = new Student
                {
                    Id = 1,
                    Name = "Aytac",
                    Surname = "Esedova",
                    Education = "Code Academy",
                    Address = "Baku",
                    Email = "gunel@code.edu.az",
                    Age = 21


                };
                Student student2 = new Student
                {
                    Id = 2,
                    Name = "Semed",
                    Surname = "Esedov",
                    Education = "Code Academy",
                    Address = "Sumqayit",
                    Email = "semed@code.edu.az",
                    Age = 25


                };
                Student student3 = new Student
                {
                    Id = 3,
                    Name = "Ibrahim",
                    Surname = "Qurbanov",
                    Education = "Code Academy",
                    Address = "Xetai",
                    Email = "ibrahim@code.edu.az",
                    Age = 26


                };
                Student student4 = new Student
                {
                    Id = 4,
                    Name = "Aytac",
                    Surname = "Celilova",
                    Education = "Code Academy",
                    Address = "Ehmedli",
                    Email = "celilova@code.edu.az",
                    Age = 30


                };
                Student student5 = new Student
                {
                    Id = 5,
                    Name = "Ceyla",
                    Surname = "Seyidli",
                    Education = "Code Academy",
                    Address = "Neftciler",
                    Email = "ceyla@code.edu.az",
                    Age = 19


                };
                Student[] arr = { student1, student2, student3, student4, student5 };
                return arr;

            }
    }
}
