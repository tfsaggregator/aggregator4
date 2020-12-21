using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace aggregator.cli.Commands
{
    public class InstanceIdOptions : IArgumentModel
    {
        [Required]
        [Option(ShortName = "i", Description = "Aggregator instance name.")]
        public string Instance { get; set; }

        [EnvVar("AGGREGATOR_RESOURCEGROUP")]
        [Required]
        [Option(ShortName = "g", Description = "Azure Resource Group hosting the Aggregator instance.")]
        public string ResourceGroup { get; set; }
    }
}