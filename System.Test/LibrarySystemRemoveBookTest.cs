using Labb4_Enhetstestning;

namespace System.Test;

[TestClass]
public class LibrarySystemRemoveBookTest
{
    [TestMethod]
    [TestCategory("RemoveBook")]
    [DataRow("9780399501487", "Borrowed books can not be removed.", false)]
    public void RemoveBook_ShouldNotRemoveBookIfBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        system.BorrowBook(isbn);
        bool result = system.RemoveBook(isbn);

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("RemoveBook")]
    [DataRow("9780399501487", "Book is availeble and can be removed.", true)]
    public void RemoveBook_RemoveBookIfNotBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        bool result = system.RemoveBook(isbn);

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("RemoveBook")]
    [DataRow(null, "Cant remove book because it is null.", false)]
    [DataRow("", "Cant remove book because it is empty.", false)]
    public void RemoveBook_IfNullOrEmpty_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        bool result = system.RemoveBook(isbn);

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }
}
