using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class CalculateController
    {
        public void Calculate()
        {
          Console.WriteLine("Add first number:");
          Number1: string number=Console.ReadLine();
            double checkedNum1;
            bool IsParsed=double.TryParse(number, out checkedNum1);
            if (!IsParsed)
            {
                Console.WriteLine("Please add correct format number:");
                goto Number1;
            }
            Console.WriteLine("Please add operation:");
            string operation=Console.ReadLine();

            Console.WriteLine("Add second number:");
        Number2: string number2 = Console.ReadLine();
            double checkedNum2;
            bool IsParsed2 = double.TryParse(number2, out checkedNum2);
            if (!IsParsed2)
            {
                Console.WriteLine("Please add correct format number:");
                goto Number2;
            }
            ICalculateService calculate = new CalculateService();
            var result = calculate.Calculate(checkedNum1,checkedNum2,operation);
            Console.WriteLine("Result="+result);


        }
       
        

       
        
    }
}
