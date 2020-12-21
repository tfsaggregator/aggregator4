using CommandDotNet;
using CommandDotNet.DataAnnotations;
using CommandDotNet.NameCasing;

namespace aggregator.cli
{
    class Program
    {
        static int Main(string[] args)
        {
            return new AppRunner<Commands.CLI>()
                    .UseDefaultMiddleware(excludePrompting: true)
                    .UseDataAnnotationValidations(showHelpOnError: true)
                    .UseNameCasing(Case.KebabCase)
                    .UseDefaultsFromEnvVar()
                    .Run(args);
        }
    }
}
