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
            Cat cat1 = new Cat("Vaska", 12.6F, BreedEnum.Exotic);
            Cat cat2 = new Cat("Milka", 3.6F);
            Cat cat3 = new Cat("Kapa", 10.3F, BreedEnum.None);

            Console.WriteLine(cat1);
        }
    }


}


