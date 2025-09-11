using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtest
{
    public class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
        public double Price { get; set; }
        public int PublishedYear { get; set; }
        public int AuthorId { get; set; }
    }
    public class Author:Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class  member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> BorrowedBookIds { get; set; }

    }
    public class  leons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> BorrowedBookIds { get; set; }

    }
}
