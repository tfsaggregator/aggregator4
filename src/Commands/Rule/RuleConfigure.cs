using CommandDotNet;
using CommandDotNet.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace aggregator.cli.Commands.Rule
{
    [Command(Description = "Configure rule behaviour.")]
    public class Configure
    {
        [Command(Description = "Impersonation execute the rule on behalf of the person triggered the rule execution. See wiki for details, requires special account privileges.")]
        public void Impersonation(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Option(ShortName = "n", Description = "Aggregator rule name."), Required] string name,
            [Option] bool enable)
        {
            Console.WriteLine($"rule impersonate {enable}");
        }
    }
}