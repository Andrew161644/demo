using System.Collections.Generic;
using BFF.Demo;

namespace BFF_app.GraphQL
{
    public class Query
    {
        public Book GetBook()
        {
            return new Book { Title  = "C# in depth", Author = new Author
            {
                Name = "Alex"
            } };
        }
        
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title  = "C# in depth", Author = new Author
                {
                    Name = "Alex"
                } }
            };
        }
    }
    
}