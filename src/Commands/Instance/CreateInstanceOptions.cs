using CommandDotNet;

namespace aggregator.cli.Commands.Instance
{
    public class CreateInstanceOptions : CommonInstanceOptions, IArgumentModel
    {
        [Option(ShortName = "k", Description = "Azure AppPlan SKU hosting the Aggregator instances.")]
        public string HostingPlanSku { get; set; } = "Y1";

        [Option(ShortName = "t", Description = "Azure AppPlan Service tier hosting the Aggregator instances.")]
        public string HostingPlanTier { get; set; } = "Dynamic";

        [Option(Description = "AppInsight location (Azure region).")]
        public string AppInsightLocation { get; set; }
    }
}