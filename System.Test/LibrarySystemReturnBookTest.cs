using Labb4_Enhetstestning;

namespace System.Test;

[TestClass]
public class LibrarySystemReturnBookTest
{
    [TestMethod]
    [TestCategory("ReturnBook")]
    [DataRow("9780451524935", "Returning a borrowed book should succeed.", true)]
    public void ReturnBook_ShoulReturnBookIfBookIsBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        system.BorrowBook(isbn);
        bool result = system.ReturnBook(isbn);

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("ReturnBook")]
    [DataRow("9780451524935", "Should fail if book was not borrowed.", false)]
    public void ReturnBook_ShouldFailIfBookWasNotBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();
        var bookStatus = system.SearchByISBN(isbn).IsBorrowed;
        // Act

        //system.BorrowBook(isbn); //(For testing)
        bool result = system.ReturnBook(isbn);

        // Assert
        Assert.AreEqual(result, bookStatus, message);
    }
}