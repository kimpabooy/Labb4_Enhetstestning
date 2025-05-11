# Labb4_Enhetstestning

**Lägga till böcker**
- Filnamn: LibrarySystem.cs
- Metod: AddBook
- Rad: 21
- Problem: You could add a new book without ISBN-number.
- Lösning:
  `
  if (book.ISBN == null || book.ISBN.Length < 13)
{ 
    return false;
}
  `
---
**Lägga till böcker**
- Filnamn: LibrarySystem.cs
- Metod: AddBook
- Rad: 21
- Problem: You could add a new book with a ISBN-number that already excisted.
- Lösning: added `books.Any(b => b.ISBN == book.ISBN)`
-   to
-   ` if (book.ISBN == null || book.ISBN.Length < 13)
{ 
    return false;
}`
---

**Sökning**
- Filnamn: LibrarySystem.cs
- Metod: SearchByISBN
- Rad: 45
- Problem: Could not search for partial matching SIBN-number
- Lösning: Changed 
`return books.FirstOrDefault(b => b.ISBN == isbn);` to `return books.FirstOrDefault(b => b.ISBN.StartsWith(isbn));`

---

**Sökning**
- Filnamn: LibrarySystem.cs
- Metod: SearchByISBN
- Rad: 45
- Problem: There was no null handling
- Lösning: Added
`if (string.IsNullOrEmpty(title))
{
    return null;
}`

---

**Sökning**
- Filnamn: LibrarySystem.cs
- Metod: SearchByTitle
- Rad: 50
- Problem: There was no null handling
- Lösning: Added
`if (string.IsNullOrEmpty(title))
{
    return new List<Book>();
}`

---

**Sökning**
- Filnamn: LibrarySystem.cs
- Metod: SearchByAuthor
- Rad: 65
- Problem: There was no null handling
- Lösning: Added
`if (string.IsNullOrEmpty(author))
{
    return new List<Book>();
}`
---

**Återlämning**
- Filnamn: LibrarySystem.cs
- Metod: ReturnBook
- Rad: 87
- Problem: Returning a book did not reset the date correctly
- Lösning: Added `book.BorrowDate = null;`
---

**Förseningshantering**
- Filnamn: LibrarySystem.cs
- Metod: CalculateLateFee
- Rad: 104
- Problem: Returned (days + fee) when i should be (days * fee)
- Lösning: Changed `return daysLate + feePerDay;` to `return daysLate * feePerDay;`
---

**Förseningshantering**
- Filnamn: LibrarySystem.cs
- Metod: CalculateLateFee
- Rad: 104
- Problem: Method didn´t had null check for daysLate
- Lösning: Added `daysLate == null`
---

**Titel**
- Filnamn:
- Metod:
- Rad: 
- Problem:
- Lösning:
---

**Titel**
- Filnamn:
- Metod:
- Rad: 
- Problem:
- Lösning:
---

**Titel**
- Filnamn:
- Metod:
- Rad: 
- Problem:
- Lösning:
---

**Titel**
- Filnamn:
- Metod:
- Rad: 
- Problem:
- Lösning:
---

**Titel**
- Filnamn:
- Metod:
- Rad: 
- Problem:
- Lösning:
---








### Heading

# H1
## H2
### H3

### Bold

**bold text**

### Italic

*italicized text*

### Blockquote

> blockquote

### Ordered List

1. First item
2. Second item
3. Third item

### Unordered List

- First item
- Second item
- Third item

### Code

`code`

### Horizontal Rule

---

### Link

[Markdown Guide](https://www.markdownguide.org)

### Image

![alt text](https://www.markdownguide.org/assets/images/tux.png)

## Extended Syntax

These elements extend the basic syntax by adding additional features. Not all Markdown applications support these elements.

### Table

| Syntax | Description |
| ----------- | ----------- |
| Header | Title |
| Paragraph | Text |

### Fenced Code Block

```
{
  "firstName": "John",
  "lastName": "Smith",
  "age": 25
}
```

### Footnote

Here's a sentence with a footnote. [^1]

[^1]: This is the footnote.

### Heading ID

### My Great Heading {#custom-id}

### Definition List

term
: definition

### Strikethrough

~~The world is flat.~~

### Task List

- [x] Write the press release
- [ ] Update the website
- [ ] Contact the media

### Emoji

That is so funny! :joy:

(See also [Copying and Pasting Emoji](https://www.markdownguide.org/extended-syntax/#copying-and-pasting-emoji))

### Highlight

I need to highlight these ==very important words==.

### Subscript

H~2~O

### Superscript

X^2^
