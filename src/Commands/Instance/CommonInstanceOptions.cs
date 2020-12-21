using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace aggregator.cli.Commands.Instance
{
    public class CommonInstanceOptions : IArgumentModel
    {
        [Required]
        [Option(ShortName = "n", Description = "Aggregator instance name.")]
        public string Name { get; set; }

        [Required]
        [Option(ShortName = "g", Description = "Azure Resource Group hosting the Aggregator instance.")]
        public string ResourceGroup { get; set; }

        [Option(ShortName = "l", Description = "Aggregator instance location (Azure region).")]
        public string Location { get; set; }
    }
}