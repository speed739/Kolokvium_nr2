using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvium_nr2
{

    class Procesory
    {
        string[] nazvy_proc = new string[] { "AMD_Razen,Intel_Pentium,Inetel_K,AMD_Super" };
        Procesory(string[] nazvy)
        {
            String random = nazvy_proc[new Random().Next(nazvy_proc.Length)];
        }
    }
        
    class Zad_1_Komputer
    {
        string Procesor, RAM, HDD, Grafika;

        public Zad_1_Komputer(string procesor, string rAM, string hDD, string grafika)  
        {
            Procesor = procesor;
            RAM = rAM;
            HDD = hDD;
            Grafika = grafika;
        }
    }
}
