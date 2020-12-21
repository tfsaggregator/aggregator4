using CommandDotNet;

namespace aggregator.cli.Commands
{
    [Command(Description = "Aggregator CLI is a tool for Azure DevOps that enables running custom rules in reaction to Work Item events. ")]
    public class CLI
    {
        [SubCommand]
        public Instance.Instance Instance { get; set; }

        [SubCommand]
        public Rule.Rule Rule { get; set; }

        [SubCommand]
        public Mapping.Mapping Mapping { get; set; }
    }
}
