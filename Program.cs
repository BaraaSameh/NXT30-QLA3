using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;

namespace linqtest

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author aut = new Author();
            List<Author> authors = new List<Author>()
            {
                new Author{Id=1,Name="Author1"},
                new Author{Id=2,Name="Author2"},
                new Author{Id=3,Name="Author3"},
                new Author{Id=4,Name="Author4"},
                new Author{Id=5,Name="Author5"},

            };

            List<Book> books1 = new List<Book>()
            {
                new Book{Title="C#",Genre="Programming",IsAvailable=true,Price=500,PublishedYear=2020,AuthorId=1},
                new Book{Title="Java",Genre="Programming",IsAvailable=true,Price=600,PublishedYear=2019,AuthorId=2},
                new Book{Title="Python",Genre="Programming",IsAvailable=false,Price=700,PublishedYear=2018,AuthorId=3},
                new Book{Title="JavaScript",Genre="Programming",IsAvailable=true,Price=800,PublishedYear=2021,AuthorId=4},
                new Book{Title="HTML",Genre="Web Development",IsAvailable=true,Price=300,PublishedYear=2017,AuthorId=5},
            };
            List<member> members = new List<member>()
            {
                new member{Id=1,Name="Member1",BorrowedBookIds=new List<int>{1,2}},
                new member{Id=2,Name="Member2",BorrowedBookIds=new List<int>{3}},
                new member{Id=3,Name="Member3",BorrowedBookIds=new List<int>{4,5}},
            };
            List<leons> leons1 = new List<leons>()
            {
                new leons{Id=1,Name="Leon1",BorrowedBookIds=new List<int>{1,2}},
                new leons{Id=2,Name="Leon2",BorrowedBookIds=new List<int>{3}},
                new leons{Id=3,Name="Leon3",BorrowedBookIds=new List<int>{4,5}},
            };


            //1 
            Console.WriteLine("////////////////////////////////////////////////////");
            var availableBooks = from book in books1
                                 where book.IsAvailable
                                 select book;
            foreach (var book in availableBooks)
            {
                Console.WriteLine($"Available Book: {book.Title}");
            }
            //2
            Console.WriteLine("////////////////////////////////////////////////////");
            var bookTitles = books1.Select(b => b.Title).ToList();
            Console.WriteLine("Book Titles: " + string.Join(", ", bookTitles));

            //3
            Console.WriteLine("////////////////////////////////////////////////////");
            var q3 = books1.Where(b => b.Genre == "Programming").ToList();
            Console.WriteLine("Programming Books: " + string.Join(", ", q3.Select(b => b.Title)));


            //4
            Console.WriteLine("////////////////////////////////////////////////////");
            var q4 = books1.OrderBy(b => b.Title).ToList();
            Console.WriteLine("Books sorted by Title: " + string.Join(", ", q4.Select(b => b.Title)));

            //5 
            Console.WriteLine("////////////////////////////////////////////////////");
            var q5 = from boo in books1
                     where boo.Price < 30
                     select boo;
            Console.WriteLine("Books with Price less than 30: " + string.Join(", ", q5.Select(b => b.Title)));// no book found
                                                                                                              //6
            Console.WriteLine("////////////////////////////////////////////////////");
            var q6 = books1.Select(b => b.Genre).Distinct().ToList();
            Console.WriteLine("Distinct Genres: " + string.Join(", ", q6));
            Console.WriteLine("////////////////////////////////////////////////////");
            //7
            var booksWithAuthors = from b in books1
                                   join a in authors on b.AuthorId equals a.Id
                                   select new { b.Title, AuthorName = a.Name, b.Genre };
            foreach (var item in booksWithAuthors)
            {
                Console.WriteLine($"Title: {item.Title}, Author: {item.AuthorName}, Genre: {item.Genre}");
            }
            //8
            Console.WriteLine("////////////////////////////////////////////////////");
            var recentBooks = books1.Where(b => b.PublishedYear > 2010).ToList();
            Console.WriteLine("Books published after 2010: " + string.Join(", ", recentBooks.Select(b => b.Title)));
            //9
            Console.WriteLine("////////////////////////////////////////////////////");
            var firstFiveBooks = books1.Take(5).ToList();
            Console.WriteLine("First five books: " + string.Join(", ", firstFiveBooks.Select(b => b.Title)));
            //10
            Console.WriteLine("////////////////////////////////////////////////////");
            bool hasExpensiveBooks = books1.Any(b => b.Price > 50);
            Console.WriteLine("Are there any books with price greater than 50? " + hasExpensiveBooks);
            Console.WriteLine("////////////////////////////////////////////////////");
            //11
            var booksWithAuthor = from b in books1
                                  join a in authors on b.AuthorId equals a.Id
                                  select new
                                  {
                                      Title = b.Title,
                                      AuthorName = a.Name,
                                      Genre = b.Genre
                                  };
            foreach (var item in booksWithAuthor)

            {
                Console.WriteLine($"Title: {item.Title}, Author: {item.AuthorName}, Genre: {item.Genre}");
            }
            Console.WriteLine("////////////////////////////////////////////////////");
            //12
            var averagePriceByGenre = books1
                 .GroupBy(b => b.Genre)
                     .Select(g => new {
                         Genre = g.Key,
                         AveragePrice = g.Average(b => b.Price)
                     });
            foreach (var item in averagePriceByGenre)
            {
                Console.WriteLine($"Genre: {item.Genre}, Average Price: {item.AveragePrice}");
            }
            Console.WriteLine("////////////////////////////////////////////////////");
            //13
            var mostExpensiveBook = books1
                    .OrderByDescending(b => b.Price)
                     .FirstOrDefault();
            foreach (var item in books1)
            {
                if (item.Price == mostExpensiveBook.Price)
                {
                    Console.WriteLine($"Most Expensive Book: {item.Title}, Price: {item.Price}");
                }
            }
            Console.WriteLine("////////////////////////////////////////////////////");
            //14
            var booksByDecade = books1
                .GroupBy(b => (b.PublishedYear / 10) * 10)
                .Select(g => new {
                    Decade = $"{g.Key}s",
                    Books = g.ToList()
                });
            foreach (var group in booksByDecade)
            {
                Console.WriteLine($"Decade: {group.Decade}");
                foreach (var book in group.Books)
                {
                    Console.WriteLine($" - {book.Title} ({book.PublishedYear})");
                }
            }
            Console.WriteLine("////////////////////////////////////////////////////");
            //15

            var membersWithActiveLoans = members
                .Where(m => leons1.Any(l => l.Id == m.Id))
                .ToList();
            foreach (var member in membersWithActiveLoans)
            {
                Console.WriteLine($"Member with active loans: {member.Name}");
            }

            Console.WriteLine("////////////////////////////////////////////////////");

            //16

            var frequentlyBorrowedBooks = leons1
                .GroupBy(l => l.Id)
                .Where(g => g.Count() > 1)
                .Select(g => new {
                    BookId = g.Key,
                    LoanCount = g.Count()
                });
            foreach (var item in frequentlyBorrowedBooks)
            {
                Console.WriteLine($"Book ID: {item.BookId}, Loan Count: {item.LoanCount}");
            }
            Console.WriteLine("////////////////////////////////////////////////////");
            //17

            //18
            var authorBookCounts = books1
                .GroupBy(b => b.AuthorId)
                .Select(g => new {
                    AuthorId = g.Key,
                    BookCount = g.Count()
                })
                .OrderByDescending(a => a.BookCount);
            foreach (var item in authorBookCounts)
            {
                var authorName = authors.FirstOrDefault(a => a.Id == item.AuthorId)?.Name;
                Console.WriteLine($"Author: {authorName}, Book Count: {item.BookCount}");

            }


            Console.WriteLine("///////////////////////////////////");
            //19
            var priceRangeCounts = books1
                    .GroupBy(b =>
                        b.Price < 20 ? "Cheap" :
                        b.Price <= 40 ? "Medium" :
                        "Expensive")
                    .Select(g => new {
                        PriceRange = g.Key,
                        Count = g.Count()
                    });
            foreach (var item in priceRangeCounts)
                {
                Console.WriteLine($"Price Range: {item.PriceRange}, Count: {item.Count}");
            }
            Console.WriteLine("///////////////////////////////////");
            //20
           


        }
    }
   

}
