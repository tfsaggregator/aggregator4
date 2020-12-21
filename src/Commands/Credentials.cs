using CommandDotNet;
using System.ComponentModel.DataAnnotations;

namespace aggregator.cli.Commands
{
    public class Credentials : IArgumentModel
    {
        [EnvVar("AGGREGATOR_SUBSCRIPTIONID")]
        [Required]
        [Option(Description = "Azure SubscriptionID")]
        public string SubscriptionID { get; set; }

        [EnvVar("AGGREGATOR_CLIENTID")]
        [Required]
        [Option(Description = "Azure ClientID")]
        public string ClientID { get; set; }

        [EnvVar("AGGREGATOR_CLIENTSECRET")]
        [Required]
        [Option(Description = "Azure Client secret")]
        public Password ClientSecret { get; set; }

        [EnvVar("AGGREGATOR_AZDO_TOKEN")]
        [Required]
        [Option(Description = "Azure DevOps PAT")]
        public Password PAT { get; set; }
    }
}
