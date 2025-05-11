using Labb4_Enhetstestning;

namespace System.Test;

[TestClass]
public class LibrarySystemSearchByTest
{
    [TestMethod]
    [TestCategory("SearchByISBN")]
    [DataRow("9780451524935", "Should find ISBN", true)]
    [DataRow("2222222222222", "Should not find ISBN", false)]
    public void SearchByISBN_ShouldFindExcistingISBN_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var result = system.SearchByISBN(input) != null;

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("SearchByISBN")]
    [DataRow("9780451524", "Should find ISBN when partial search", true)]
    [DataRow("97804", "Should find ISBN when partial search", true)]
    [DataRow("978", "Should find ISBN when partial search", true)]
    [DataRow("22222222", "Should not find ISBN when partial search", false)]
    public void SearchByISBN_ShouldSupportPartialMatchISBN_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var result = system.SearchByISBN(input) != null;

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }

    [TestMethod]
    [DataRow(null, "Search cannot be null", false)]
    [DataRow("", "Search cannot be empty", false)]
    public void SearchByISBN_ShouldNotFindIfNullOrEmpty_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var result = system.SearchByISBN(input) != null;

        // Assert
        Assert.AreEqual(result, expectedResult, message);
    }


    [TestMethod]
    [TestCategory("SearchByTitle")]
    [DataRow("mockingbird", "Should find title ignoring lowercase", true)]
    [DataRow("MOCKINGBIRD", "Should find title ignoring uppercase", true)]
    [DataRow("MockingBird", "Should find title ignoring mixed case", true)]
    [DataRow("הההה", "FINNS INTE", false)]
    public void SearchByTitle_ShouldNotBeCaseSensitive_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var results = system.SearchByTitle(input);

        // Assert
        Assert.AreEqual(results.Count > 0, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("SearchByTitle")]
    [DataRow("Mock", "Should find title ignoring uppercase", true)]
    [DataRow("Great", "Should find title ignoring uppercase", true)]
    [DataRow("pride", "Should find title ignoring uppercase", true)]
    [DataRow("984", "Should find title ignoring uppercase", true)]
    [DataRow("הההה", "FINNS INTE", false)]
    public void SearchByTitle_ShouldSupportPartialMatchTitle_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var results = system.SearchByTitle(input);

        // Assert
        Assert.AreEqual(results.Count > 0, expectedResult, message);
    }

    [DataTestMethod]
    [TestCategory("SearchByTitle")]
    [DataRow(null, "Search cannot be null", false)]
    [DataRow("", "Search cannot be empty", false)]
    public void SearchByTitle_ShouldNotFindIfNullOrEmpty_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var results = system.SearchByTitle(input);

        // Assert
        Assert.AreEqual(results.Count > 0, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("SearchByAuthor")]
    [DataRow("harper lee", "should find Harper Lee", true)]
    [DataRow("AuSten", "Should find Jane Austen", true)]
    [DataRow("Salinger", "Should find J.D. Salinger", true)]
    [DataRow("King", "Should not find a Author", false)]
    [DataRow("kinG", "Should not find a Author", false)]
    public void SearchByAuthor_ShouldNotBeCaseSensitive_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var results = system.SearchByAuthor(input);

        // Assert
        Assert.AreEqual(results.Count > 0, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("SearchByAuthor")]
    [DataRow("Fitz", "Should find F. Scott Fitzgerald", true)]
    [DataRow("Tol", "Should find J.R.R. Tolkien", true)]
    public void SearchByAuthor_ShouldSupportPartialMatchAuthor_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var result = system.SearchByAuthor(input);

        // Assert
        Assert.AreEqual(result.Count > 0, expectedResult, message);
    }

    [TestMethod]
    [TestCategory("SearchByAuthor")]
    [DataRow(null, "Search cannot be null", false)]
    [DataRow("", "Search cannot be empty", false)]
    public void SearchByAuthor_ShouldNotFindIfNullOrEmpty_ReturnsExpectedResult(string input, string message, bool expectedResult)
    {
        // Arrange
        var system = new LibrarySystem();

        // Act
        var results = system.SearchByTitle(input);

        // Assert
        Assert.AreEqual(results.Count > 0, expectedResult, message);
    }
}
