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
            Figury figury = new Figury();
            List<double> siema = new List<double>();

            int n;
            double promien = 0;
            double bok1 = 0;
            double bok2 = 0;
            Console.Write("Co chcesz obliczyc 1-Pole okręgu, 2-Obwód okręgu, 3-Pole prostokąta, 4-ObwódProstokąta:  ");
            n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("Podaj promien kola: ");
                        promien = int.Parse(Console.ReadLine());
                        siema = figury.Okrag(promien);
                        Console.WriteLine("Wynik: " + siema[0]);
                        break;

                    case 2:
                        Console.Write("Podaj promien kola: ");
                        promien = int.Parse(Console.ReadLine());
                        siema = figury.Okrag(promien);
                        Console.WriteLine("Wynik: " + siema[1]);
                        break;

                    case 3:
                        Console.Write("Podaj bok 1: ");
                        bok1 = int.Parse(Console.ReadLine());
                        Console.Write("Podaj bok 2: ");
                        bok2 = int.Parse(Console.ReadLine());
                        siema = figury.Prostokat(bok1, bok2);
                        Console.WriteLine("Wynik: " + siema[0]);
                        break;


                    case 4:
                        Console.Write("Podaj bok 1: ");
                        bok1 = int.Parse(Console.ReadLine());
                        Console.Write("Podaj bok 2: ");
                        bok2 = int.Parse(Console.ReadLine());
                        siema = figury.Prostokat(bok1, bok2);
                        Console.WriteLine("Wynik: " + siema[1]);
                        break;
                }
            Console.ReadKey();
        }
    }


    class Figury
    {

        public List<double> Okrag(double promien)
        {
            List<double> x = new List<double>();
            x.Add(3.14 * promien);
            x.Add(2 * 3.14 * promien);
            return x;
        }

        public List<double> Prostokat(double bok1, double bok2)
        {
            List<double> x = new List<double>();
            x.Add(bok1 * bok2);
            x.Add(2 * (bok1 + bok2));
            return x;
        }
    }
}
