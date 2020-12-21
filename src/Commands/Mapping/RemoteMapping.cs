using CommandDotNet;
using CommandDotNet.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace aggregator.cli.Commands.Mapping
{
    [Command(Description = "Manages Aggregator Mapping in Azure DevOps.")]
    public class Remote
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

        [Command(Description = "Add a rule to existing Aggregator instance in Azure.")]
        public void Add(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Required] AddMappingOptions mappingOpts)
        {
            Console.WriteLine($"rule added");
        }

        [Command(Description = "Removes a rule mapping.")]
        public void Remove(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Required] CommonMappingOptions mappingOpts)
        {
            Console.WriteLine($"rule removed");
        }

        [Command(Description = "Updates existing mappings from old to new Aggregator Instance.")]
        public void Update(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [EnvVar("AGGREGATOR_RESOURCEGROUP")]
            [Option(ShortName = "g", Description = "Azure Resource Group hosting the Aggregator instance."),Required]
            string resourceGroup,
            [Option(Description = "The name of an existing Aggregator instance (Azure Function App), where the mappings currently points."),Required]
            string sourceInstance,
            [Option(Description = "The name of an existing Aggregator instance (Azure Function App), where the mappings will point if the command is successful."),Required]
            string destInstance,
            [EnvVar("AGGREGATOR_PROJECT")]
            [Option(ShortName = "p", Description = "Azure DevOps project name."), Required]
            string project)
        {
            Console.WriteLine($"mapping updated");
        }
    }
}