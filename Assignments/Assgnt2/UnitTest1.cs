using Assgn1;

namespace TestProjectcal
{
    public class LibraryTests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            var book = new Book("Test Book", "Author", "123456");
            library.AddBook(book);
            Assert.Contains(book, library.Books);
        }

        [Test]
        public void RegisterBorrower_ShouldAddBorrowerToLibrary()
        {
            var borrower = new Borrower("Vshnavi", "001");
            library.RegisterBorrower(borrower);
            Assert.Contains(borrower, library.Borrowers);
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            var book = new Book("Test Book", "Author", "123456");
            var borrower = new Borrower("Vyshnavi", "001");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            bool success = library.BorrowBook("123456", "001");

            Assert.IsTrue(success);
            Assert.IsTrue(book.IsBorrowed);
            Assert.Contains(book, borrower.BorrowedBooks);
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            var book = new Book("Test Book", "Author", "123456");
            var borrower = new Borrower("Vyshnavi", "001");
            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("123456", "001");

            bool success = library.ReturnBook("123456", "001");

            Assert.IsTrue(success);
            Assert.IsFalse(book.IsBorrowed);
            Assert.IsFalse(borrower.BorrowedBooks.Contains(book));
        }

        [Test]
        public void ViewBooks_ShouldReturnListOfBooks()
        {
            var book = new Book("Test Book", "Author", "123456");
            library.AddBook(book);
            var books = library.ViewBooks();
            Assert.Contains(book, books);
        }

        [Test]
        public void ViewBorrowers_ShouldReturnListOfBorrowers()
        {
            var borrower = new Borrower("John Doe", "001");
            library.RegisterBorrower(borrower);
            var borrowers = library.ViewBorrowers();
            Assert.Contains(borrower, borrowers);
        }
    }

}