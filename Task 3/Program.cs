using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kadry kadry = new Kadry();
            kadry.Fam = "Шентохин";
            kadry.Age = 20;
            kadry.Dol = "Администратор";
            kadry.Staj = 3;
            Console.WriteLine(kadry.ToString());
            Console.WriteLine();

            Kadry kadry1 = new Kadry ("Петров", 19, "Батя", 4);
            Console.WriteLine(kadry1.ToString());
            Console.ReadLine();
        }
    }
}
