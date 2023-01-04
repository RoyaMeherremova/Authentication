using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
        public double Calculate(double num1, double num2, string operation)
        {
            double result = 0;
            switch(operation)
            {
               case "+":
               result=num1+num2;
               break;
               case "-":
               result=num1-num2;
               break;
               case "*":
               result=num1*num2;
               break;
               case "/":
               result=num1/num2;
               if (num2==0&&operation=="/")
               {
                 Console.WriteLine("Please dont add 0");
               }
               break;
            }
            return default;
        }
    }
}
