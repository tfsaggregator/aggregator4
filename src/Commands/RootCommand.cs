using CommandDotNet;

namespace aggregator.cli.Commands
{
    [Command(Description = "Aggregator CLI is a tool for Azure DevOps that enables running custom rules in reaction to Work Item events. ")]
    public class RootCommand
    {
        [Subcommand]
        public Instance.Instance Instance { get; set; }

        [Subcommand]
        public Rule.Rule Rule { get; set; }

        [Subcommand]
        public Mapping.Mapping Mapping { get; set; }
    }
}
