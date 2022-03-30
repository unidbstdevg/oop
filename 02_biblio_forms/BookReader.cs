using System;
using System.Collections.Generic;
using System.Text;

namespace _1_biblio_system
{
    [Serializable]
    public class BookReader
    {
        const int BOOKS_LIMIT = 10;

        public string name;
        public int birthyear;
        private List<Book> books;

        public BookReader(string name, int birthyear)
        {
            this.name = name;
            this.birthyear = birthyear;

            this.books = new List<Book>();
        }
        public bool TakeBook(Book bk)
        {
            if (books.Count > BOOKS_LIMIT)
                return false;

            books.Add(bk);
            return true;
        }

        public Book BookBack()
        {
            if (books.Count == 0)
                return null;

            Book bk = books[0];
            books.RemoveAt(0);
            return bk;
        }

        public Book BookBack(int id)
        {
            foreach(Book bk in books)
            {
                if (bk.id == id)
                {
                    books.Remove(bk);
                    return bk;
                }
            }

            return null;
        }

        public List<Book> GetList()
        {
            List<Book> bks = new List<Book>(books);
            return bks;
        }

        public List<Book> BackAll()
        {
            List<Book> bks = new List<Book>(books);
            books.Clear();

            return bks;
        }

        public override string ToString()
        {
            return name + " (" + birthyear + " г)";
        }
    }
}
