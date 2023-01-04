using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FibonacciService : IFibonacciService
    {
        public int Fibonacci(int num)
        {
            int number = num - 1;
            int[]Fib=new int[number+1];
            Fib[0] = 0;
            Fib[1]=1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
            
         
           
        }
    }
}
