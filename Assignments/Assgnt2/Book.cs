using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn1
{
    
    
        public class Book
        {
            public string Title { get; }
            public string Author { get; }
            public string ISBN { get; }
            public bool IsBorrowed { get; private set; }

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                IsBorrowed = false;
            }

            public void Borrow() => IsBorrowed = true;
            public void Return() => IsBorrowed = false;
        }

        // Borrower.cs
        public class Borrower
        {
            public string Name { get; }
            public string LibraryCardNumber { get; }
            public List<Book> BorrowedBooks { get; }

            public Borrower(string name, string libraryCardNumber)
            {
                Name = name;
                LibraryCardNumber = libraryCardNumber;
                BorrowedBooks = new List<Book>();
            }

            public void BorrowBook(Book book)
            {
                if (!book.IsBorrowed)
                {
                    book.Borrow();
                    BorrowedBooks.Add(book);
                }
            }

            public void ReturnBook(Book book)
            {
                if (BorrowedBooks.Contains(book))
                {
                    book.Return();
                    BorrowedBooks.Remove(book);
                }
            }
        }

        // Library.cs
        public class Library
        {
            public List<Book> Books { get; }
            public List<Borrower> Borrowers { get; }

            public Library()
            {
                Books = new List<Book>();
                Borrowers = new List<Borrower>();
            }

            public void AddBook(Book book) => Books.Add(book);
            public void RegisterBorrower(Borrower borrower) => Borrowers.Add(borrower);

            public bool BorrowBook(string isbn, string libraryCardNumber)
            {
                var book = Books.FirstOrDefault(b => b.ISBN == isbn && !b.IsBorrowed);
                var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

                if (book != null && borrower != null)
                {
                    borrower.BorrowBook(book);
                    return true;
                }
                return false;
            }

            public bool ReturnBook(string isbn, string libraryCardNumber)
            {
                var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);
                var book = borrower?.BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

                if (book != null)
                {
                    borrower.ReturnBook(book);
                    return true;
                }
                return false;
            }

            public List<Book> ViewBooks() => Books;
            public List<Borrower> ViewBorrowers() => Borrowers;
        }


    }

    

