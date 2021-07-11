using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Print(int x, int y)
        {
            Console.WriteLine(x+y);
        }
       
        static void Main(string[] args)
        {
            int res = Sum(8, 6);
            Console.WriteLine(res);
            int Sum(int x, int y)
            {
                return x + y;
            }
            
              
          
          

        }

    }
}

