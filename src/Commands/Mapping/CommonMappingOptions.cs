using CommandDotNet;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aggregator.cli.Commands.Mapping
{
    public class CommonMappingOptions : IArgumentModel
    {
        [EnvVar("AGGREGATOR_PROJECT")]
        [Option(ShortName = "p", Description = "Azure DevOps project name."), Required]
        public string Project { get; set; }

        [Option(ShortName = "e", Description = "Event to emulate."), Required]
        public string Event { get; set; }

        [Option(ShortName = "r", Description = "Aggregator rule name."), Required]
        public string Rule { get; set; }
    }

    public class AddMappingOptions : CommonMappingOptions, IArgumentModel
    {
        [Option(LongName = "impersonate", Description = "Do rule changes on behalf of the person triggered the rule execution. See wiki for details, requires special account privileges.")]
        public bool ImpersonateExecution { get; set; }

        // event filters: but cannot make AreaPath & Tag work
        //[Option("filterAreaPath", Required = false, HelpText = "Filter Azure DevOps event to include only Work Items under the specified Area Path.")]
        //public string FilterAreaPath { get; set; }

        [Option(Description = "Filter Azure DevOps event to include only Work Items of the specified Work Item Type.")]
        public string FilterType { get; set; }

        //[Option("filterTag", Required = false, HelpText = "Filter Azure DevOps event to include only Work Items containing the specified Tag.")]
        //public string FilterTag { get; set; }

        [Option(Description = "Filter Azure DevOps event to include only work items with the specified Field(s) changed.")]
        public IEnumerable<string> FilterFields { get; set; }
    }
}