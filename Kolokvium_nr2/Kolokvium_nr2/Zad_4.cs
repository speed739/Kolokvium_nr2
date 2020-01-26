using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvium_nr2
{
    interface IDostavca
    {
        int Send();
        void Status(int id);
        void Odbierz(int id);
    }

    class Poczta : IDostavca
    {
        public void Odbierz(int id)
        {
            ;
        }

        public int Send()
        {
            Console.WriteLine("Paczka vyslana poczta ");
            return 0;
        }

        public void Status(int id)
        {
            Console.WriteLine("Status przesylki " + id + " " + Send());
        }
    }
    class Kurier : IDostavca
    {
        public void Odbierz(int id)
        {

        }

        public int Send()
        {
            return 0;
        }

        public void Status(int id)
        {

        }
    }

    class Zad_4
    {

    }
}
