using Common;

namespace KnowledgeUberization.Sender
{
    public interface IMqSender
    {
        public void Send(ExampleModelCommand command);
    }
}