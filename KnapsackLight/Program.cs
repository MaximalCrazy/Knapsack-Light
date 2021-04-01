using System;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackLight
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kata.KnapsackLight(10, 5, 6, 4, 8);
        }
    }

    public class Kata
    {
        public static int KnapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            var gegenstand1 = new Gegenstand {Wert = value1, Gewicht = weight1};
            var gegenstand2 = new Gegenstand {Wert = value2, Gewicht = weight2};

            List<Gegenstand> gegenstandsliste = new List<Gegenstand>
            {
                gegenstand1,
                gegenstand2
            };

            List<Gegenstand> gegenstandslisteSortiert = gegenstandsliste.OrderByDescending(o=>o.Wert).ToList();
             
            int aktuellerWert = 0;
            int aktuellesGewicht = 0;
            foreach (var gegenstand in gegenstandslisteSortiert)
            {
                if (gegenstand.Gewicht + aktuellesGewicht <= maxW)
                {
                    aktuellesGewicht += gegenstand.Gewicht;
                    aktuellerWert += gegenstand.Wert;
                }
            }
            
            return aktuellerWert;
        }
    }

    public class Gegenstand
    {
        public int Wert { get; set; }
        public int Gewicht { get; set; }
    }

}
