using Common;
using Microsoft.Extensions.Logging;

namespace Reciever.Services
{
    public class MessageService : IMessageService
    {
        private readonly ILogger<MessageService> _logger;

        public MessageService(ILogger<MessageService> logger)
        {
            _logger = logger;
        }

        public void Serve(ExampleModelCommand command)
        {
            _logger.Log(LogLevel.Information, command._model.Value.ToString());
            command.Execute(_logger);
        }
    }
}