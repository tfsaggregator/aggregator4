using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace aggregator.cli.Commands.Rule
{
    public enum SaveMode
    {
        Default = 0,
        Item = 1,
        Batch = 2,
        TwoPhases = 3
    }

    public class CommonInvokeOptions : IArgumentModel
    {

        [Option(ShortName = "d", LongName = "dryrun", Description = "Non-committing run.")]
        public bool DryRun { get; set; }

        [EnvVar("AGGREGATOR_PROJECT")]
        [Option(ShortName = "p", Description = "Azure DevOps project name."), Required]
        public string Project { get; set; }

        [Option(ShortName = "e", Description = "Event to emulate."), Required]
        public string Event { get; set; }

        [Option(ShortName = "w", Description = "Id of workitem for the emulated event."), Required]
        public int WorkItemId { get; set; }

        [Option(ShortName = "m", Description = "Save behaviour.")]
        public SaveMode SaveMode { get; set; } = SaveMode.Default;

        [Option(LongName = "impersonate", Description = "Do rule changes on behalf of the person triggered the rule execution. See wiki for details, requires special account privileges.")]
        public bool ImpersonateExecution { get; set; }

    }
}