using System;
using System.Collections.Generic;
using System.Text;

namespace _1_biblio_system
{
    [Serializable]
    public class Book
    {
        public readonly int id;
        public readonly string author;
        public readonly string name;

        public Book(int id, string author, string name)
        {
            this.id = id;
            this.author = author;
            this.name = name;
        }


        public override string ToString()
        {
            return name + " - " + author + " (" + id + ")";
        }
    }
}
