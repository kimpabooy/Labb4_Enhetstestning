using Labb4_Enhetstestning;

namespace System.Test
{
    [TestClass]
    public sealed class LibrarySystemTest
    {
        [TestMethod]
        public void AddBook_ShouldAddBookIfISBNNumberIsUnique_ReturnTrue()
        {
            var system = new LibrarySystem();
            var book = new Book("New Book", "Author", "1234567890", 2020);
            bool result = system.AddBook(book);

            Assert.AreEqual(book, system.SearchByISBN("1234567890"));

        }

        [TestMethod]
        public void AddBook_ShouldNotAddBookIfISBNNumberExcists_ReturnFalse()
        {
            var system = new LibrarySystem();
            var book = new Book("New Book", "Author", "9780060850524", 2020);
            bool result = system.AddBook(book);

            Assert.AreEqual(book, system.SearchByISBN("9780060850524"));

        }
    }
}
