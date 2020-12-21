using CommandDotNet;
using CommandDotNet.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace aggregator.cli.Commands.Mapping
{
    [Command(Description = "Manages Aggregator Mapping in Azure DevOps.")]
    public class Mapping
    {
        [SubCommand]
        public Local Local { get; set; }
        [SubCommand]
        public Remote Remote { get; set; }
    }
}