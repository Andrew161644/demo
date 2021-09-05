using BFF.Demo;
using HotChocolate;
using HotChocolate.Types;

namespace BFF_app.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic("BookAdded")]
        public Book BookAdded([EventMessage] Book book) => book;
    }
}