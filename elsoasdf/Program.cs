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
            // "Hello World!"
            Console.WriteLine("Hello World!");

            //bekérések
            int Szam_1;
            int Szam_2;
            int Sum = 0;
            Console.WriteLine("Kérek egy számot:");
            Szam_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Az első szám értéke: {Szam_1}");
            Console.WriteLine("Kérek egy másik számot:");
            Szam_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Az első szám értéke: {Szam_2}");
            Sum = Szam_1 + Szam_2;
            Console.WriteLine($"A két szám összege: {Sum}");

            // Ciklusok
            int sum = 0;
            double atlag = 0.00;
            double szorzata = 1;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
            }
            atlag = sum / 10;
            int j = 1;
            while (j <= 10)
            {
                szorzata *= j;
                j++;
            }
            Console.WriteLine("A számok összege: ");
            Console.WriteLine(sum);
            Console.WriteLine("A számok átlaga: ");
            Console.WriteLine(atlag);
            Console.WriteLine("A számok szorzata: ");
            Console.WriteLine(szorzata);

            // Stringkezelés

            string keresztnev = "";
            string vezeteknev = "";
            string harmadiknev = "";
            string monogram = "";
            Console.Write("Kérem a vezetéknevét: ");
            vezeteknev = Console.ReadLine();
            Console.Write("Kérem a keresztnevét: ");
            keresztnev = Console.ReadLine();
            Console.Write("Kérem a harmadik nevét: ");
            harmadiknev = Console.ReadLine();
            monogram = Convert.ToString(vezeteknev[0]);
            monogram += Convert.ToString(keresztnev[0]);
            monogram += Convert.ToString(harmadiknev[0]);

            Console.Write("A monogram: ");
            Console.WriteLine(monogram);
            Console.ReadKey();

        }
    }
}
