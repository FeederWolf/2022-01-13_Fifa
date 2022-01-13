using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _2022_01_13_Fifa
{
    class fifavilagranglista
    {
        static void Main(string[] args)
        {
            List<fifa> fifakxd = new List<fifa>();
            foreach (var sor in File.ReadAllLines("fifa.txt").Skip(1))
            {
                fifakxd.Add(new fifa(sor));
            }
            Console.WriteLine($"3. feladat: A világranglistán {fifakxd.Count} csapat szerepel");

            double atlag;
            int pontok = 0;
            foreach (var i in fifakxd)
            {
                pontok += i.pontszam;
            }
            atlag = pontok / fifakxd.Count; //double - kényszerítés
            Console.WriteLine($"4. feladat: A csapatok átlagos pontszáma: {atlag:0.00} pont");
            fifa maxV = fifakxd //feltöltjük a fifakxd adatokat a maxV-be
                .OrderBy(fa => fa.valtozas)
                .Last();
            Console.WriteLine("5. feladat: A legtöbbet javító csapat:");
            Console.WriteLine($"\tHelyezés: {maxV.helyezes}");
            Console.WriteLine($"\tCsapat: {maxV.csapat}");
            Console.WriteLine($"\tPontszam: {maxV.pontszam}");
            
            Console.WriteLine($"6. feladat A csapatok között {(fifakxd.Any(fa => fa.csapat == "Magyarország") ? "van" : "nincs")} Magyarország");

            Console.WriteLine($"7. feladat: Statisztika:");
            fifakxd
                .GroupBy(x => x.valtozas)
                .Select(g => new { valt = g.Key, db = g.Count() })
                .Where(x => x.db > 1)
                .ToList()
                .ForEach(x => Console.WriteLine($"\t{x.valt} helyet vátozott: {x.db} csapat"));
        }
    }
}
