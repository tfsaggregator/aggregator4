using CommandDotNet;
using CommandDotNet.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace aggregator.cli.Commands.Rule
{
    [Command(Description = "Executes a rule emulating an Azure DevOps event.")]
    public class Invoke
    {
        [Command(Description = "Invoke rule locally")]
        public void Local(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Required] CommonInvokeOptions invokeOptions,
            [Option('s', Description = "Aggregator rule code."), Required] string source)
        {
            Console.WriteLine($"rule called");
        }

        [Command(Description = "Invoke rule in Azure")]
        public void AzureFunction(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Required] InstanceIdOptions instanceOpts,
            [Required] CommonInvokeOptions invokeOptions,
            [Option('a', Description = "Azure DevOps account name."), Required] string account,
            [Option('n', Description = "Aggregator rule name."), Required] string name)
        {
            Console.WriteLine($"rule called");
        }
    }
}