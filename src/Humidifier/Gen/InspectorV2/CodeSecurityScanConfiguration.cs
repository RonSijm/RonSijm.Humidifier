namespace Humidifier.InspectorV2
{
    using global::System.Collections.Generic;
    using CodeSecurityScanConfigurationTypes;

    public class CodeSecurityScanConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveLevel
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.InspectorV2.CodeSecurityScanConfiguration; }
        /// <summary>
        /// ScopeSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-scopesettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ScopeSettings
        /// </summary>
        public Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ScopeSettings ScopeSettings { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CodeSecurityScanConfiguration
        /// </summary>
        public Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.CodeSecurityScanConfiguration Configuration { get; set; }
        /// <summary>
        /// Level
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-level
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Level { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CodeSecurityScanConfigurationTypes
    {
        public class CodeSecurityScanConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// continuousIntegrationScanConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration-continuousintegrationscanconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContinuousIntegrationScanConfiguration
            /// </summary>
            public Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ContinuousIntegrationScanConfiguration continuousIntegrationScanConfiguration { get; set; }
            /// <summary>
            /// periodicScanConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration-periodicscanconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodicScanConfiguration
            /// </summary>
            public Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.PeriodicScanConfiguration periodicScanConfiguration { get; set; }
            /// <summary>
            /// ruleSetCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration-rulesetcategories
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ruleSetCategories { get; set; }
        }

        public class ContinuousIntegrationScanConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// supportedEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-continuousintegrationscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-continuousintegrationscanconfiguration-supportedevents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic supportedEvents { get; set; }
        }

        public class PeriodicScanConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// frequencyExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration-frequencyexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic frequencyExpression { get; set; }
            /// <summary>
            /// frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic frequency { get; set; }
        }

        public class ScopeSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// projectSelectionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-scopesettings.html#cfn-inspectorv2-codesecurityscanconfiguration-scopesettings-projectselectionscope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic projectSelectionScope { get; set; }
        }
    }
}