using Labb4_Enhetstestning;

namespace System.Test
{
    [TestClass]
    public sealed class LibrarySystemTest
    {
        //[TestMethod]
        //[TestCategory("AddBook")]
        //[DataRow("Valid ISBN-Number", "1234567890123", true)] // 13 digits
        //[DataRow("Empty ISBN-Number", "", false)]
        //[DataRow("Null ISBN-Number", null, false)]
        //public void AddBook_ShouldValidateISBN_ReturnsExpectedResult(string message, string isbn, bool expectedResult)
        //{
        //    var system = new LibrarySystem();
        //    var book = new Book("New Book", "Author", isbn, 2020);

        //    bool result = system.AddBook(book);

        //    Assert.AreEqual(expectedResult, result, message);
        //}

        //[TestMethod]
        //[TestCategory("AddBook")]
        //[DataRow("2222222222222", "Should add book with unique ISBN", true)]
        //[DataRow("9780399501487", "Should not add book with existing ISBN", false)]
        //public void AddBook_ShouldHandleUniqueAnddoubleISBN_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();
        //    var newBook = new Book("Test Book", "Author", isbn, 2020);

        //    bool result = system.AddBook(newBook);

        //    Assert.AreEqual(expectedResult, result, message);
        //}

        //[TestMethod]
        //[TestCategory("RemoveBook")]
        //[DataRow("9780399501487", "Borrowed books can not be removed.", false)]
        //public void RemoveBook_ShouldNotRemoveBookIfBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();
        //    system.BorrowBook(isbn);

        //    bool result = system.RemoveBook(isbn);

        //    Assert.AreEqual(result, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("RemoveBook")]
        //[DataRow("9780399501487", "Book is availeble and can be removed.", true)]
        //public void RemoveBook_RemoveBookIfNotBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    bool result = system.RemoveBook(isbn);

        //    Assert.AreEqual(result, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("RemoveBook")]
        //[DataRow(null, "Cant remove book because it is null.", false)]
        //[DataRow("", "Cant remove book because it is empty.", false)]
        //public void RemoveBook_IfNullOrEmpty_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    bool result = system.RemoveBook(isbn);

        //    Assert.AreEqual(result, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("SearchByTitle")]
        //[DataRow("mockingbird", "Should find title ignoring lowercase", true)]
        //[DataRow("MOCKINGBIRD", "Should find title ignoring uppercase", true)]
        //[DataRow("MockingBird", "Should find title ignoring mixed case", true)]
        //[DataRow("ääää", "FINNS INTE", false)]
        //public void SearchByTitle_ShouldNotBeCaseInsensitive_ReturnsExpectedResult(string input, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    var results = system.SearchByTitle(input);

        //    Assert.AreEqual(results.Count > 0, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("SearchByTitle")]
        //[DataRow("Mock", "Should find title ignoring uppercase", true)]
        //[DataRow("Great", "Should find title ignoring uppercase", true)]
        //[DataRow("pride", "Should find title ignoring uppercase", true)]
        //[DataRow("984", "Should find title ignoring uppercase", true)]
        //[DataRow("ääää", "FINNS INTE", false)]
        //public void SearchByTitle_ShouldSupportPartialMatch_ReturnsExpectedResult(string input, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    var results = system.SearchByTitle(input);

        //    Assert.AreEqual(results.Count > 0, expectedResult, message);
        //}

        //[DataTestMethod]
        //[TestCategory("SearchByTitle")]
        //[DataRow(null, "Search cannot be null", false)]
        //[DataRow("", "Search cannot be empty", false)]
        //public void SearchByTitle_IfNullOrEmpty_ReturnsExpectedResult(string input, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    var results = system.SearchByTitle(input);

        //    Assert.AreEqual(results.Count > 0, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("SearchByAuthor")]
        //[DataRow("Fitz", "Should find F. Scott Fitzgerald", true)]
        //[DataRow("Tol", "Should find J.R.R. Tolkien", true)]
        //[DataRow("Row", "Should not find J.K. Rowling", false)]
        //[DataRow("kin", "Should not find Stephen King", false)]
        //public void SearchByAuthor_ShouldSupportPartialMatch_ReturnsExpectedResult(string input, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    var result = system.SearchByAuthor(input);

        //    Assert.AreEqual(result.Count > 0, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("SearchByAuthor")]
        //[DataRow(null, "Search cannot be null", false)]
        //[DataRow("", "Search cannot be empty", false)]
        //public void SearchByAuthor_IfNullOrEmpty_ReturnsExpectedResult(string input, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    var results = system.SearchByTitle(input);

        //    Assert.AreEqual(results.Count > 0, expectedResult, message);
        //}

   
        //[TestMethod]
        //[TestCategory("BorrowBook")]
        //[DataRow("9780451524935", "Book should be borrowed if it is available.", true)]
        //public void BorrowBook_BorrowBookIfBookIsAvailable_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    bool result = system.BorrowBook(isbn);

        //    Assert.AreEqual(result, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("BorrowBook")]
        //[DataRow("9780451524935", "Book can not be borroed", false)]
        //public void BorrowBook_ShouldFailIfBookIsAlreadyBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    system.BorrowBook(isbn); // First borrow the book.
        //    bool result = system.BorrowBook(isbn); // Tries to Borrow the book again.

        //    Assert.AreEqual(result, expectedResult, "Book should not be borrowed twice.");
        //    //Assert.IsTrue(system.SearchByISBN(isbn).IsBorrowed);
        //}

        //[TestMethod]
        //[TestCategory("BorrowBook")]
        //[DataRow("9780451524935", "The borrowed book has been given a date", true)]
        //public void BorrowBook_CheckForValidDate_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    system.BorrowBook(isbn);
        //    var dateValue = system.SearchByISBN(isbn).BorrowDate.GetValueOrDefault();
        //    Console.WriteLine($"Borrow date: {dateValue}");

        //    Assert.AreEqual(expectedResult, system.SearchByISBN(isbn).IsBorrowed);
        //    Assert.AreEqual(expectedResult, system.SearchByISBN(isbn).BorrowDate.HasValue, message);

        //}

        //[TestMethod]
        //[TestCategory("ReturnBook")]
        //[DataRow("9780451524935", "Returning a borrowed book should succeed.", true)]
        //public void ReturnBook_ShoulReturnBookIfBookIsBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    system.BorrowBook(isbn);
        //    bool result = system.ReturnBook(isbn);

        //    Assert.AreEqual(result, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("ReturnBook")]
        //[DataRow("9780451524935", "Should fail if book was not borrowed.", false)]
        //public void ReturnBook_ShouldFailIfBookWasNotBorrowed_ReturnsExpectedResult(string isbn, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    //system.BorrowBook(isbn);
        //    bool result = system.ReturnBook(isbn);

        //    Assert.AreEqual(result, system.SearchByISBN(isbn).IsBorrowed, message);
        //}

        //[TestMethod]
        //[TestCategory("DelayManagement")]
        //[DataRow("9780451524935", 4, "Should return 4.5.", 2)]
        //[DataRow("9780547928227", null, "Should return 0 late fee if null.", 0)]
        //public void CalculateLateFee_ShouldReturnCorrectFee_ReturnsExpectedResult(string isbn, int daysLate, string message, int expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    decimal fee = system.CalculateLateFee(isbn, daysLate);

        //    Assert.AreEqual(fee, expectedResult, message);
        //    Console.WriteLine($"Days late: {daysLate}");
        //    Console.WriteLine($"Late fee: {fee}");
        //}

        //[TestMethod]
        //[TestCategory("DelayManagement")]
        //[DataRow("2222222222222", 5, "Should return 0 if book does not exist.", 0)]
        //public void CalculateLateFee_ShouldReturnZeroIfBookNotFound_ReturnsExpectedResult(string isbn, int daysLate, string message, int expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    decimal fee = system.CalculateLateFee(isbn, daysLate);

        //    Assert.AreEqual(fee, expectedResult, message);
        //}

        //[TestMethod]
        //[TestCategory("DelayManagement")]
        //[DataRow("9780743273565", 0, "Should return 0 late fee.", 0)]
        //[DataRow("9780061120084", -10, "Should return 0 late fee.", 0)]
        //public void CalculateLateFee_ShouldReturnZeroIfDaysLateIsZeroOrNegative_ReturnsExpectedResult(string isbn, int daysLate, string message, int expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    decimal fee = system.CalculateLateFee(isbn, daysLate);

        //    Assert.AreEqual(fee, expectedResult, "Should return 0 if days late is 0 or less.");
        //}

        //[TestMethod]
        //[TestCategory("DelayManagement")]
        //[DataRow("9780451524935", -15, 14, "Should return 0 late fee if not borrowed.", true)]
        //public void IsBookOverdue_ShouldReturnTrueIfLoanPeriodPassed_ReturnsExpectedResult(string isbn, int borrowedDaysAgo, int borrowPeriod, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    system.BorrowBook(isbn);
        //    system.SearchByISBN(isbn).BorrowDate = DateTime.Now.AddDays(borrowedDaysAgo); // borrowed the book 15 days ago.

        //    bool result = system.IsBookOverdue(isbn, borrowPeriod);

        //    Assert.AreEqual(result, expectedResult, "Book should be overdue if borrowed more days than loan period.");
        //}

        //[TestMethod]
        //[TestCategory("DelayManagement")]
        //[DataRow("9780451524935", -5, 14, "Should return 0 late fee if not borrowed.", false)]
        //public void IsBookOverdue_ShouldReturnFalseIfLoanPeriodNotPassed_ReturnsExpectedResult(string isbn, int borrowedDaysAgo, int borrowPeriod, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    system.BorrowBook(isbn);
        //    system.SearchByISBN(isbn).BorrowDate = DateTime.Now.AddDays(borrowedDaysAgo);

        //    bool result = system.IsBookOverdue(isbn, borrowPeriod);

        //    Assert.AreEqual(result, expectedResult, "Book should not be overdue within loan period.");
        //}

        //[TestMethod]
        //[TestCategory("DelayManagement")]
        //[DataRow("9780451524935", 14, "Should return 0 late fee if not borrowed.", false)]
        //public void IsBookOverdue_ShouldReturnFalseIfBookIsNotBorrowed_ReturnsExpectedResult(string isbn, int borrowPeriod, string message, bool expectedResult)
        //{
        //    var system = new LibrarySystem();

        //    bool result = system.IsBookOverdue(isbn, borrowPeriod);

        //    Assert.AreEqual(result, expectedResult, "Should return false if book is not currently borrowed.");
        //}
    }
}
