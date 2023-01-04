using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Controllers
{
    public class FibonacciController
    {
        public void Fibonacci()
        {
            Console.WriteLine("Add number:");
            int num=int.Parse(Console.ReadLine());
          IFibonacciService fibonacci = new FibonacciService();
           var result=fibonacci.Fibonacci(num);
            Console.WriteLine("Result=" + result);
        }
        
        
    }
}
