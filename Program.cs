using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_24_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto avto = new Avto("BMW", "Black", 200);
            Console.WriteLine(avto.ToString());
            Console.ReadLine();
        }
    }
}
