using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MetodaListaa
    {
        public float a, b, c;
        public List<float> PoczatkowaLista = new List<float> { };

        public List<float> SortowanieListy(List<float> ToSort)
        {
            return new List<float>() { ToSort.Min(), ToSort.Max(), ToSort.Average() };
        }
    }
}
