using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpeningWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<O_weekend> nyito_weekend = new List<O_weekend>();
            foreach (var sor in File.ReadAllLines("nyitohetvege.txt").Skip(1))
            {
                nyito_weekend.Add(new O_weekend(sor));
            }
            Console.WriteLine($"3.feladat: Filmek száma az állományban: {nyito_weekend.Count} db ");
            
            Console.WriteLine($"4.feladat: UIP Duna film forgalmazó 1.hetes bevételeinek összege: {nyito_weekend.Where(x => x.forgalmazo == "UIP").Sum((x => (long)x.bevetel))} Ft ");

            Console.WriteLine($"5.feladat: Legtöbb látógató az első héten:");
            O_weekend legtöbb = nyito_weekend.OrderBy(x => x.latogato).Last();
            Console.WriteLine($"\tEredeti cím:{legtöbb.eredetiCim}");
            Console.WriteLine($"\tMagyar cím:{legtöbb.magyarCim}");
            Console.WriteLine($"\tForgalmazó:{legtöbb.forgalmazo}");
            Console.WriteLine($"\tBevétel:{legtöbb.bevetel} Ft");
            Console.WriteLine($"\tLátogatók száma:{legtöbb.latogato} fő");
            bool igaz = nyito_weekend
                .Any(x => x.eredetiCim.ToLower().Split(' ').All(y => y.ToLower().First() == 'w') &&
                          x.magyarCim.ToLower().Split(' ').All(y => y.ToLower().First() == 'w'));
            Console.WriteLine($"6.feladat: Ilyen film{(igaz ? "" : "nem")} volt!");

            Console.WriteLine($"7.feladat: ->stat.csv");
            File.Create("stat.csv");
            StreamWriter sw = new StreamWriter(@"stat.csv");
            sw.WriteLine("forgalmazo;filmekSzama");
            nyito_weekend.GroupBy(x => x.forgalmazo);
            foreach (var i in )
            {
                sw.WriteLine($"");
            }
        }
    }
}
