﻿namespace Labb4_Enhetstestning
{
    public class LibrarySystem
    {
        private List<Book> books;

        public LibrarySystem()
        {
            books = new List<Book>();
            // Add some initial books
            books.Add(new Book("1984", "George Orwell", "9780451524935", 1949));
            books.Add(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084", 1960));
            books.Add(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 1925));
            books.Add(new Book("The Hobbit", "J.R.R. Tolkien", "9780547928227", 1937));
            books.Add(new Book("Pride and Prejudice", "Jane Austen", "9780141439518", 1813));
            books.Add(new Book("The Catcher in the Rye", "J.D. Salinger", "9780316769488", 1951));
            books.Add(new Book("Lord of the Flies", "William Golding", "9780399501487", 1954));
            books.Add(new Book("Brave New World", "Aldous Huxley", "9780060850524", 1932));
        }

        public bool AddBook(Book book)
        {
            if (book.ISBN == null || book.ISBN.Length < 13 || books.Any(b => b.ISBN == book.ISBN))
            {
                return false;
            }

            books.Add(book);
            return true;
        }

        public bool RemoveBook(string isbn)
        {
            //Book book = SearchByISBN(isbn);

            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if (book == null || book.IsBorrowed)
            {
                return false;
            }
                books.Remove(book);
                return true;
        }

        public Book SearchByISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                return null;
            }

            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public List<Book> SearchByTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                return new List<Book>();
            }
                
            return books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> SearchByAuthor(string author)
        {
            if (string.IsNullOrEmpty(author))
            {
                return new List<Book>();
            }

            return books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool BorrowBook(string isbn)
        {
            Book book = SearchByISBN(isbn);
            if (book != null && !book.IsBorrowed)
            {
                book.IsBorrowed = true;
                book.BorrowDate = DateTime.Now;
                return true;
            }
            return false;
        }

        public bool ReturnBook(string isbn)
        {
            Book book = SearchByISBN(isbn);
            if (book != null && book.IsBorrowed)
            {
                book.IsBorrowed = false;
                book.BorrowDate = null;
                return true;
            }
            return false;
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public decimal CalculateLateFee(string isbn, int daysLate)
        {
            if (daysLate == null || daysLate <= 0)
                return 0;

            Book book = SearchByISBN(isbn);
            if (book == null)
                return 0;

            decimal feePerDay = 0.5m;
            return daysLate * feePerDay;
        }

        public bool IsBookOverdue(string isbn, int loanPeriodDays)
        {
            Book book = SearchByISBN(isbn);
            if (book != null && book.IsBorrowed && book.BorrowDate.HasValue)
            {
                TimeSpan borrowedFor = DateTime.Now - book.BorrowDate.Value;
                return borrowedFor.Days > loanPeriodDays;
            }
            return false;
        }
    }
}
