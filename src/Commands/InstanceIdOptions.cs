using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace aggregator.cli.Commands
{
    public class InstanceIdOptions : IArgumentModel
    {
        [Required]
        [Named('i', Description = "Aggregator instance name.")]
        public string Instance { get; set; }

        [EnvVar("AGGREGATOR_RESOURCEGROUP")]
        [Required]
        [Named('g', Description = "Azure Resource Group hosting the Aggregator instance.")]
        public string ResourceGroup { get; set; }
    }
}