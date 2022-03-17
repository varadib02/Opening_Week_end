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
        }
    }
}
