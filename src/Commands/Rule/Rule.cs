using CommandDotNet;
using CommandDotNet.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace aggregator.cli.Commands.Rule
{
    [Command(Description = "Manages Aggregator Rules.")]
    public class Rule
    {
        [Command(Description = "List the rule in existing Aggregator instance in Azure.")]
        public void List(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts)
        {
            Console.WriteLine($"list rules");
        }

        [Command(Description = "Add a rule to existing Aggregator instance in Azure.")]
        public void Add(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Option('n', Description = "Aggregator rule name."),Required] string name,
            [Option('f', Description = "Aggregator rule code."), Required] string file)
        {
            Console.WriteLine($"rule added");
        }

        [Command(Description = "Remove a rule from existing Aggregator instance in Azure.")]
        public void Remove(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Option('n', Description = "Aggregator rule name."), Required] string name)
        {
            Console.WriteLine($"rule removed");
        }

        [Command(Description = "Update code of a rule in an existing Aggregator instance in Azure.")]
        public void Update(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Option('n', Description = "Aggregator rule name."), Required] string name,
            [Option('f', Description = "Aggregator rule code."), Required] string file)
        {
            Console.WriteLine($"rule updated");
        }

        [Command(Description = "Enable a rule.")]
        public void Enable(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Option('n', Description = "Aggregator rule name."), Required] string name)
        {
            Console.WriteLine($"rule enabled");
        }

        [Command(Description = "Disable a rule.")]
        public void Disable(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Option('n', Description = "Aggregator rule name."), Required] string name)
        {
            Console.WriteLine($"rule disabled");
        }

        [Subcommand]
        public Configure Configure { get; set; }

        [Subcommand]
        public Invoke Invoke { get; set; }
    }
}