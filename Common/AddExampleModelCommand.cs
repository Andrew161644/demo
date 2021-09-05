using Microsoft.Extensions.Logging;

namespace Common
{
    public class AddExampleModelCommand : ExampleModelCommand
    {
        public override void Execute(ILogger logger)
        {
            logger.Log(LogLevel.Information, "Execute AddExampleModelCommand");
        }
        
    }
}