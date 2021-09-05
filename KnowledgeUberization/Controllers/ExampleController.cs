using Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeUberization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private IMediator _mediator;

        public ExampleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public void AddExampleModel(ExampleModel model)
        {
            _mediator.Send(new AddExampleModelCommand
            {
                _model = model
            });
        }
        
        [HttpPut]
        public void UpdateExampleModel(ExampleModel model)
        {
            _mediator.Send(new UpdateExampleCommand()
            {
                _model = model
            });
        }
    }
}