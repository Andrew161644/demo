using Common;

namespace Reciever.Services
{
    public interface IMessageService
    {
        public void Serve(ExampleModelCommand command);
    }
}