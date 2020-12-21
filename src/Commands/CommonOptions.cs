using CommandDotNet;

namespace aggregator.cli.Commands
{
    public class CommonOptions : IArgumentModel
    {
        [Option(Description = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [Option(Description = "Defines a template-set for generating names of Azure Resources.")]
        public string NamingTemplate { get; set; }
    }
}
