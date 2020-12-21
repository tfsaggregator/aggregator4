using CommandDotNet;
using CommandDotNet.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace aggregator.cli.Commands.Mapping
{
    [Command(Description = "Manages Aggregator Mapping in Azure DevOps.")]
    public class Local
    {
        [Command(Description = "Lists mappings from existing Azure DevOps Projects to Aggregator Rules.")]
        public void List(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [EnvVar("AGGREGATOR_PROJECT")]
            [Option(ShortName = "p", Description = "Azure DevOps project name."), Required]
            string project 
            )
        {
            Console.WriteLine($"list mappings");
        }

        [Command(Description = "Maps an Aggregator Rule to existing Azure DevOps Server Projects.")]
        public void Add(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] AddMappingOptions mappingOpts,
            [Option(ShortName ="t", Description = "Aggregator instance URL."), Required] string targetUrl)
        {
            Console.WriteLine($"rule added");
        }

        [Command(Description = "Removes a rule mapping.")]
        public void Remove(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] AddMappingOptions mappingOpts)
        {
            Console.WriteLine($"rule removed");
        }
    }
}