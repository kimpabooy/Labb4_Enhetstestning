# Labb 4 Enhetstestning ( Unit Testing )

**AddBooks**
- FileName: LibrarySystem.cs
- Method: AddBook
- Row: 21
- Problem: You could add a new book without ISBN-number.
- Solution:
  `
  if (book.ISBN == null || book.ISBN.Length < 13)
{ 
    return false;
}
  `
---

**AddBooks**
- FileName: LibrarySystem.cs
- Method: AddBook
- Row: 21
- Problem: You could add a new book with a ISBN-number that already excisted.
- Solution: added `books.Any(b => b.ISBN == book.ISBN)`
-   to
-   ` if (book.ISBN == null || book.ISBN.Length < 13)
{ 
    return false;
}`
---

**Search**
- FileName: LibrarySystem.cs
- Method: SearchByISBN
- Row: 45
- Problem: Could not search for partial matching SIBN-number.
- Solution: Changed 
`return books.FirstOrDefault(b => b.ISBN == isbn);` to `return books.FirstOrDefault(b => b.ISBN.StartsWith(isbn));`

---

**Search**
- FileName: LibrarySystem.cs
- Method: SearchByISBN
- Row: 45
- Problem: There was no null handling.
- Solution: Added
`if (string.IsNullOrEmpty(title))
{
    return null;
}`

---

**Search**
- FileName: LibrarySystem.cs
- Method: SearchByTitle
- Row: 50
- Problem: There was no null handling.
- Solution: Added
`if (string.IsNullOrEmpty(title))
{
    return new List<Book>();
}`

---

**Search**
- FileName: LibrarySystem.cs
- Method: SearchByAuthor
- Row: 65
- Problem: There was no null handling.
- Solution: Added
`if (string.IsNullOrEmpty(author))
{
    return new List<Book>();
}`
---

**BookReturn**
- FileName: LibrarySystem.cs
- Method: ReturnBook
- Row: 87
- Problem: Returning a book did not reset the date correctly.
- Solution: Added `book.BorrowDate = null;`
---

**DelayManagement**
- FileName: LibrarySystem.cs
- Method: CalculateLateFee
- Row: 104
- Problem: Returned (days + fee) when i should be (days * fee).
- Solution: Changed `return daysLate + feePerDay;` to `return daysLate * feePerDay;`
---

**DelayManagement**
- FileName: LibrarySystem.cs
- Method: CalculateLateFee
- Row: 104
- Problem: Method didn´t had null check for daysLate.
- Solution: Added `daysLate == null`
---



