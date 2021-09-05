using Microsoft.Extensions.Logging;

namespace Common
{
    public class UpdateExampleCommand : ExampleModelCommand
    {
        public override void Execute(ILogger logger)
        {
            logger.Log(LogLevel.Information, "Execute UpdateExampleCommand");
        }
    }
}