using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokvium_nr2
{
    enum gatunki
    {
        Horror,
        Akcja,
        Komedia

    };
    class Biblioteka : Book
    {
        public string Znajdz_Ksiazke(List<Book> lista, string napis)
        {
            string a = " ";
            lista.ForEach(x =>
            {
                if (x.gatunek == napis)
                {
                    Console.WriteLine(x.Autor + " " + x.gatunek + " " + " " + x.Tytul);
                }

            });
            return a;
        }

    }
    class Book
    {
        public string Tytul, Autor, gatunek;

        public Book()
        {
        }
        public Book(string tytul, string autor, string gatunek)
        {
            Tytul = tytul;
            Autor = autor;
            this.gatunek = gatunek;
        }


    }
}
