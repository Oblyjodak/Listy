using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodaListaa metodaLista = new MetodaListaa();

            WartoscPodana(metodaLista);

            metodaLista.SortowanieListy(metodaLista.PoczatkowaLista);

            Wyswietl(metodaLista);

            Console.ReadKey();
        }

        static void WartoscPodana(MetodaListaa obdzekt)
        {
            obdzekt.a = float.Parse(Console.ReadLine());
            obdzekt.PoczatkowaLista.Add(obdzekt.a);
            obdzekt.b = float.Parse(Console.ReadLine());
            obdzekt.PoczatkowaLista.Add(obdzekt.b);
            obdzekt.c = float.Parse(Console.ReadLine());
            obdzekt.PoczatkowaLista.Add(obdzekt.c);
        }

        static void Wyswietl(MetodaListaa obdzekt)
        {
            List<float> wyswietlanie = obdzekt.SortowanieListy(obdzekt.PoczatkowaLista);
            Console.WriteLine("Min: " + wyswietlanie[0]);
            Console.WriteLine("Max: " + wyswietlanie[1]);
            Console.WriteLine("Avg: " + wyswietlanie[2]);
        }
    }
}