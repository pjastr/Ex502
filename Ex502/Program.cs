using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex502
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();
            pracownicy.Add(new Pracownik("Jan", 3000));
            pracownicy.Add(new Pracownik("Anna", 2500));
            pracownicy.Add(new Pracownik("Jan", 3200));
            pracownicy.Add(new Pracownik("Zofia", 4100));
            pracownicy.Add(new Pracownik("Barbara", 4100));
            pracownicy.Sort();
            foreach(var element in pracownicy)
            {
                Console.WriteLine(element.Info());
            }
            Console.ReadKey();
        }
    }
}
