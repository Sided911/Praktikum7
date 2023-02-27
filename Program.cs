using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.задание 
            //for (int x=10;x<=99;x++)
            //{
            //    Console.WriteLine(x);
            //}
            //2.задание 
            for (int x = 10; x <= 99; x++)
            {
                if (x%11== 0)
                Console.WriteLine(x);
            }
        }
    }
}
