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
            
        }
    }
}
