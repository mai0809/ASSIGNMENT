using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Enter a number:");
            int a = (int)Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(a + "*" + i + "=" + i * a);
                i++;

            }

            Console.ReadLine();
        }
    }
}
