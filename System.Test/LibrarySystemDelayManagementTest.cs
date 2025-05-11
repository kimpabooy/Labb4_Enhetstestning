using Labb4_Enhetstestning;

namespace System.Test;

[TestClass]
public class LibrarySystemDelayManagementTest
{
    [TestMethod]
    [TestCategory("DelayManagement")]
    [DataRow("9780451524935", 4, "Should return 4.5.", 2)]
    [DataRow("9780547928227", null, "Should return 0 late fee if null.", 0)]
    public void CalculateLateFee_ShouldReturnCorrectFee_ReturnsExpectedResult(string isbn, int daysLate, string message, int expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        decimal fee = system.CalculateLateFee(isbn, daysLate);

        // Assert
        Assert.AreEqual(fee, expectedResult, message);
        Console.WriteLine($"Days late: {daysLate}");
        Console.WriteLine($"Late fee: {fee} kr");
    }

    [TestMethod]
    [TestCategory("DelayManagement")]
    [DataRow("2222222222222", 5, "Should return 0 if book does not exist.", 0)]
    public void CalculateLateFee_ShouldReturnZeroIfBookNotFound_ReturnsExpectedResult(string isbn, int daysLate, string message, int expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        decimal fee = system.CalculateLateFee(isbn, daysLate);

        // Assert
        Assert.AreEqual(fee, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("DelayManagement")]
    [DataRow("9780743273565", 0, "Should return 0 late fee.", 0)]
    [DataRow("9780061120084", -10, "Should return 0 late fee.", 0)]
    public void CalculateLateFee_ShouldReturnZeroIfDaysLateIsZeroOrNegative_ReturnsExpectedResult(string isbn, int daysLate, string message, int expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        decimal fee = system.CalculateLateFee(isbn, daysLate);

        // Assert
        Assert.AreEqual(fee, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("DelayManagement")]
    [DataRow("9780451524935", -15, 14, "Should return 0 late fee if not borrowed.", true)]
    public void IsBookOverdue_ShouldReturnTrueIfLoanPeriodPassed_ReturnsExpectedResult(string isbn, int borrowedDaysAgo, int borrowPeriod, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        system.BorrowBook(isbn);
        system.SearchByISBN(isbn).BorrowDate = DateTime.Now.AddDays(borrowedDaysAgo);
        bool result = system.IsBookOverdue(isbn, borrowPeriod);

        // Assert
        Assert.AreEqual(result, expectedResult, "Book should be overdue if borrowed more days than loan period.");
    }

    [TestMethod]
    [TestCategory("DelayManagement")]
    [DataRow("9780451524935", -5, 14, "Book should not be overdue within loan period.", false)]
    public void IsBookOverdue_ShouldReturnFalseIfLoanPeriodNotPassed_ReturnsExpectedResult(string isbn, int borrowedDaysAgo, int borrowPeriod, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        system.BorrowBook(isbn);
        system.SearchByISBN(isbn).BorrowDate = DateTime.Now.AddDays(borrowedDaysAgo);
        bool result = system.IsBookOverdue(isbn, borrowPeriod);

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("DelayManagement")]
    [DataRow("9780451524935", 14, "Should return false if book is not currently borrowed.", false)]
    public void IsBookOverdue_ShouldReturnFalseIfBookIsNotBorrowed_ReturnsExpectedResult(string isbn, int borrowPeriod, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        bool result = system.IsBookOverdue(isbn, borrowPeriod);

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }
}
