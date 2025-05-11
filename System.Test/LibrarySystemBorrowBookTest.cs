using Labb4_Enhetstestning;

namespace System.Test;

[TestClass]
public class LibrarySystemBorrowBookTest
{
    [TestMethod]
    [TestCategory("BorrowBook")]
    [DataRow("9780451524935", "Book should be borrowed if it is available.", true)]
    public void BorrowBook_BorrowBookIfBookIsAvailable_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        bool result = system.BorrowBook(isbn);

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("BorrowBook")]
    [DataRow("9780451524935", "Book should not be borrowed twice.", false)]
    public void BorrowBook_ShouldFailIfBookIsAlreadyBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        system.BorrowBook(isbn); // First borrow the book.
        bool result = system.BorrowBook(isbn); // Tries to Borrow the book again.

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("BorrowBook")]
    [DataRow("9780451524935", "The borrowed book has been given a date", true)]
    public void BorrowBook_CheckForValidDate_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        system.BorrowBook(isbn);
        var dateValue = system.SearchByISBN(isbn).BorrowDate.GetValueOrDefault();
        Console.WriteLine($"Borrow date: {dateValue}");

        // Assert
        Assert.AreEqual(expectedResult, system.SearchByISBN(isbn).IsBorrowed);
        Assert.AreEqual(expectedResult, system.SearchByISBN(isbn).BorrowDate.HasValue, message);

    }
}
