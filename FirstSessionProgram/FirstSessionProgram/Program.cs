using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSessionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your First Name:  ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Your Last Name:  ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}, nice to meet you", name,name1);
            Console.ReadLine();
            Console.WriteLine("Hello "+name + " " + name1+", nice to meet you");
            Console.ReadLine();
            Console.WriteLine($"Hello {name} {name1}, nice to meet you");
            Console.ReadLine();
            
            
            


        }
    }
}
