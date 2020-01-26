using System;
using System.Collections.Generic;

namespace Kolokvium_nr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book ksiazka1 = new Book("Stary_dom", "asd", "horror");
            Book ksiazka2 = new Book("Stary", "asdasd", "komedia");
            List<Book> lista_k = new List<Book>() {ksiazka1,ksiazka2};

            Biblioteka x = new Biblioteka();
            x.Znajdz_Ksiazke(lista_k, "horror");

        }
    }
}
