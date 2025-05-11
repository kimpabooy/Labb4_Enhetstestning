using Labb4_Enhetstestning;

namespace System.Test;

[TestClass]
public class LibrarySystemAddBookTest
{
    [TestMethod]
    [TestCategory("AddBook")]
    [DataRow("Valid ISBN-Number", "1234567890123", true)] // 13 digits
    [DataRow("Empty ISBN-Number", "", false)]
    [DataRow("Null ISBN-Number", null, false)]
    public void AddBook_ShouldValidateISBN_ReturnsExpectedResult(string message, string isbn, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();
        var book = new Book("New Book", "Author", isbn, 2020);

        // Act
        bool result = system.AddBook(book);

        // Assert
        Assert.AreEqual(expectedResult, result, message);
    }

    [TestMethod]
    [TestCategory("AddBook")]
    [DataRow("2222222222222", "Should add book with unique ISBN", true)]
    [DataRow("9780399501487", "Should not add book with existing ISBN", false)]
    public void AddBook_ShouldHandleUniqueAnddoubleISBN_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();
        var newBook = new Book("Test Book", "Author", isbn, 2020);

        // Act
        bool result = system.AddBook(newBook);

        // Assert
        Assert.AreEqual(expectedResult, result, message);
    }
}
