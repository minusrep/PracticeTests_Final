using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Final
{
    public class Library
    {
        private Dictionary<string, int> _books;

        public Library()
        {
            _books = new Dictionary<string, int>();
        }


        public void AddBook(string book)
        {
            if (_books.ContainsKey(book))
            {
                _books[book]++;
            }
            else
            {
                _books[book] = 1;
            }
        }

        public void RemoveBook(string book)
        {
            if (_books.ContainsKey(book))
            {
                _books[book]--;
                if (_books[book] == 0)
                {
                    _books.Remove(book);
                }
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public bool FindBook(string book)
        {
            return _books.ContainsKey(book) && _books[book] > 0;
        }
    }
}
