using Labb4_Enhetstestning;

namespace System.Test
{
    [TestClass]
    public sealed class LibrarySystemTest
    {
        [TestMethod]
        public void AddBook_ShouldAddBookMustHavISBN_ReturnTrue()
        {
            var system = new LibrarySystem();
            var book = new Book("New Book", "Author", "", 2020);
            bool result = system.AddBook(book);

            Assert.IsTrue(result);

        }


        [TestMethod]
        public void AddBook_ShouldNotAddBookIfISBNNumberExists_ReturnFalse()
        {
            var system = new LibrarySystem();
            var newISBN = "9780399501487"; // existing ISBN
            //var newISBN = "2222222222222"; // new ISBN

            var newBook = new Book("New Book", "Author", newISBN, 2020);
            bool result = system.AddBook(newBook);

            var foundBook = system.SearchByISBN(newISBN);

            Assert.AreNotEqual(newBook, foundBook); // The book sould not be replaced if found.
            Assert.IsFalse(result); // AddBook should return false if the book already exists.
        }


    }
}
