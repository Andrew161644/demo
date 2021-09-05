using System.Net.Http;
using System.Threading.Tasks;
using BFF.Demo;
using Clients;
using Common;
using HotChocolate;
using HotChocolate.Subscriptions;

namespace BFF_app.GraphQL
{
    public class Mutation
    {
        public async Task<string> AddBook(Book book, [Service] ITopicEventSender sender)
        {
            await sender.SendAsync("BookAdded", book);
            return book.Title;
        }

        public async Task<string> AddExampleModel(int value)
        {
            var client = new Client("https://localhost:8080", new HttpClient());
            await client.ExampleAsync(new ExampleModel{Value = value});
            return "Ok";
        }

        public async Task<string> UpdateExampleModel(int value)
        {
            var client = new Client("https://localhost:8080", new HttpClient());
            await client.ExamplePUTAsync(new ExampleModel{Value = value});
            return "Ok";
        }
    }
}