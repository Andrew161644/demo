using MediatR;
using Microsoft.Extensions.Logging;

namespace Common
{
    public abstract class ExampleModelCommand : IRequest<ExampleModel>
    {
        public ExampleModel _model
        {
            get;
            set;
        }
        public virtual void Execute(ILogger logger)
        {
        }
    }
}