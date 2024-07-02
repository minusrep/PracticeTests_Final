using Practice_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_FinalTests
{
    [TestClass]
    public class LibraryTests
    {
        private Library _library;

        [TestInitialize]
        public void SetUp()
        {
            _library = new Library();
        }

        [TestMethod]
        public void TestAddBook()
        {
            _library.AddBook("Book A");
            Assert.IsTrue(_library.FindBook("Book A"));
            Assert.IsFalse(_library.FindBook("Book B")); // Исправлено
        }

        [TestMethod]
        public void TestRemoveBook()
        {
            _library.AddBook("Book A");
            _library.AddBook("Book A");
            _library.RemoveBook("Book A");
            Assert.IsTrue(_library.FindBook("Book A"));
            _library.RemoveBook("Book A");
            Assert.IsFalse(_library.FindBook("Book A"));
            _library.RemoveBook("Book B"); // Ожидаем сообщение "Book not found"
        }

        [TestMethod]
        public void TestFindBook()
        {
            _library.AddBook("Book A");
            Assert.IsTrue(_library.FindBook("Book A"));
            _library.RemoveBook("Book A");
            Assert.IsFalse(_library.FindBook("Book A")); // Исправлено
        }
    }
}
