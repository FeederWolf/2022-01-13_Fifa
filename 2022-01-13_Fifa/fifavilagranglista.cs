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
            Console.WriteLine($"4. feladat: A csapatok átlagos pontszáma: {atlag} pont");


        }
    }
}
