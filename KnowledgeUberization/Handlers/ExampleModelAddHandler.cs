using System.Threading;
using System.Threading.Tasks;
using Common;
using KnowledgeUberization.Sender;
using MediatR;
using Microsoft.Extensions.Logging;

namespace KnowledgeUberization.Handlers
{
    public class ExampleModelAddHandler: IRequestHandler<AddExampleModelCommand, ExampleModel>
    {
        private IMqSender _sender;
        private ILogger<ExampleModelAddHandler> _logger;
        public ExampleModelAddHandler(IMqSender sender, ILogger<ExampleModelAddHandler> logger)
        {
            _sender = sender;
            _logger = logger;
        }

        public Task<ExampleModel> Handle(AddExampleModelCommand request, CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Information, "Handle ExampleModelAddHandler");
            _sender.Send(request);
            return new Task<ExampleModel>(() => request._model);
        }
    }
}