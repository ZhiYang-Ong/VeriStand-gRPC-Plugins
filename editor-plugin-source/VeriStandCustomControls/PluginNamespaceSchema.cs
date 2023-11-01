using System.ComponentModel.Composition;
using System.Reflection;
using NationalInstruments.DynamicProperties;
using NationalInstruments.SourceModel.Persistence;
using NationalInstruments.VeriStand.GrpcPlugins.Resources;

namespace NationalInstruments.VeriStand.GrpcPlugins
{
    /// <summary>
    /// Defines the version of the plugin and allows for mutation if it is upgraded.
    /// </summary>
    [ParsableNamespaceSchema(ParsableNamespaceName, CurrentVersion)]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public sealed class PluginNamespaceSchema : NamespaceSchema
    {
        /// <summary>
        /// This must be unique among all plugins.
        /// </summary>
        public const string ParsableNamespaceName = "https://github.com/ZhiYang-Ong/VeriStandPlugins";

        /// <summary>
        /// The current version
        /// </summary>
        private const string CurrentVersion = "1.0.0f0";

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PluginNamespaceSchema() : base(Assembly.GetExecutingAssembly())
        {
            Version = VersionExtensions.Parse(CurrentVersion);
            OldestCompatibleVersion = VersionExtensions.Parse(CurrentVersion);
        }

        /// <inheritdoc/>
        public override string FeatureSetName => LocalizedStrings.PluginNamespaceSchema_FeatureSetName;

        /// <inheritdoc/>
        public override string NamespaceName => ParsableNamespaceName;
    }
}
