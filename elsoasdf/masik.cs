using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsoasdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Szam_1;
            int Szam_2;
            Console.WriteLine("Kérek egy számot:");
            Szam_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Az első szám értéke: {Szam_1}");
            Console.WriteLine("Kérek egy másik számot:");
            Szam_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Az első szám értéke: {Szam_2}");
            Console.Readkey();
        }
    }
}
