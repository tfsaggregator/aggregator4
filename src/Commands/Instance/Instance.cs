using CommandDotNet;
using CommandDotNet.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace aggregator.cli.Commands.Instance
{
    [Command(Description = "Manages Aggregator Instances.")]
    public class Instance
    {
        readonly IGreeter _greeter;

        public Instance(IGreeter greeter)
        {
            _greeter = greeter;
        }

        [Command(Description = "Lists Aggregator instances in Azure.")]
        public void List(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            [Option('l', Description = "Aggregator instance location (Azure region).")] string Location,
            [Option('g', Description = "Azure Resource Group hosting the Aggregator instance.")] string resourceGroup)
        {
            _greeter.Greet();
            console.WriteLine($"list instances");
        }

        [Command(Description = "Creates a new Aggregator instance in Azure.")]
        public void Create(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            CreateInstanceOptions createOpts,
            [Option(Description = "Version of Aggregator Runtime required.")] Version requiredVersion
            )
        {
            console.WriteLine($"instance added");
        }

        [Command(Description = "Creates a new Aggregator instance in Azure using custom source.")]
        public void CreateFrom(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            CreateInstanceOptions createOpts,
            [Option(Description = "URL of Aggregator Runtime.")][Required] string sourceUrl
            )
        {
            console.WriteLine($"instance added");
        }

        [Command(Description = "Updates an existing Aggregator instance in Azure, with latest runtime binaries.")]
        public void Update(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            CreateInstanceOptions createOpts,
            [Option(Description = "Version of Aggregator Runtime required.")] Version requiredVersion
            )
        {
            console.WriteLine($"instance added");
        }

        [Command(Description = "Updates an existing Aggregator instance in Azure, with latest runtime binaries.")]
        public void UpdateFrom(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            CreateInstanceOptions createOpts,
            [Option(Description = "URL of Aggregator Runtime.")][Required] string sourceUrl
            )
        {
            console.WriteLine($"instance added");
        }

        [Command(Description = "Destroys an Aggregator instance in Azure.")]
        public void Destroy(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            CommonInstanceOptions instanceOpts,
            [Option('m', "dont-remove-mappings", Description = "Do not remove mappings from Azure DevOps (default is to remove them).")] bool Mappings = true)
        {
            console.WriteLine($"instance removed");
        }

        [Command(Description = "Refresh authentication data.")]
        public void SetCredentials(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            CommonInstanceOptions instanceOpts)
        {
            console.WriteLine($"config authN");
        }

        public enum SaveMode
        {
            Default = 0,
            Item = 1,
            Batch = 2,
            TwoPhases = 3
        }

        [Command(Description = "Refresh authentication data.")]
        public void Configure(IConsole console, CancellationToken cancellationToken,
            CommonOptions commonOpts, [Required] Credentials cred,
            CommonInstanceOptions instanceOpts,
            SaveMode saveMode)
        {
            console.WriteLine($"instance config'd");
        }
    }
}