using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_13_Fifa
{
    class fifa
    {
        public string csapat { get; set; }
        public int helyezes { get; set; }
        public int valtozas { get; set; }
        public int pontszam { get; set; }
        public fifa(string sor)
        {
            string[] s = sor.Split(';');
            csapat = s[0];
            helyezes = int.Parse(s[1]);
            valtozas = int.Parse(s[2]);
            pontszam = int.Parse(s[3]);
        }
    }

}
