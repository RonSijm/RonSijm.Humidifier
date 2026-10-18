namespace Humidifier.InspectorV2
{
    using global::System.Collections.Generic;
    using CodeSecurityScanConfigurationTypes;

    public class CodeSecurityScanConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveInspectorV2CodeSecurityScanConfigurationTypesScopeSettingsScopeSettings, IHaveInspectorV2CodeSecurityScanConfigurationTypesCodeSecurityScanConfigurationConfiguration, IHaveLevel, IHaveStringDictionaryOfTags, IHaveName
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
        public Union<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ScopeSettings, BaseFunction>? ScopeSettings { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CodeSecurityScanConfiguration
        /// </summary>
        public Union<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.CodeSecurityScanConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// Level
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-level
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Level { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CodeSecurityScanConfigurationTypes
    {
        public class CodeSecurityScanConfiguration : Humidifier.Base.BaseSubResource, IHaveInspectorV2CodeSecurityScanConfigurationTypesContinuousIntegrationScanConfigurationcontinuousIntegrationScanConfiguration, IHaveInspectorV2CodeSecurityScanConfigurationTypesPeriodicScanConfigurationperiodicScanConfiguration, IHaveStringListOfruleSetCategories
        {
            /// <summary>
            /// continuousIntegrationScanConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration-continuousintegrationscanconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContinuousIntegrationScanConfiguration
            /// </summary>
            public Union<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.ContinuousIntegrationScanConfiguration, BaseFunction>? continuousIntegrationScanConfiguration { get; set; }
            /// <summary>
            /// periodicScanConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration-periodicscanconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PeriodicScanConfiguration
            /// </summary>
            public Union<Humidifier.InspectorV2.CodeSecurityScanConfigurationTypes.PeriodicScanConfiguration, BaseFunction>? periodicScanConfiguration { get; set; }
            /// <summary>
            /// ruleSetCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-codesecurityscanconfiguration-rulesetcategories
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ruleSetCategories { get; set; }
        }

        public class ContinuousIntegrationScanConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfsupportedEvents
        {
            /// <summary>
            /// supportedEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-continuousintegrationscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-continuousintegrationscanconfiguration-supportedevents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? supportedEvents { get; set; }
        }

        public class PeriodicScanConfiguration : Humidifier.Base.BaseSubResource, IHavefrequencyExpression, IHavefrequency
        {
            /// <summary>
            /// frequencyExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration-frequencyexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? frequencyExpression { get; set; }
            /// <summary>
            /// frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration.html#cfn-inspectorv2-codesecurityscanconfiguration-periodicscanconfiguration-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? frequency { get; set; }
        }

        public class ScopeSettings : Humidifier.Base.BaseSubResource, IHaveprojectSelectionScope
        {
            /// <summary>
            /// projectSelectionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-codesecurityscanconfiguration-scopesettings.html#cfn-inspectorv2-codesecurityscanconfiguration-scopesettings-projectselectionscope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? projectSelectionScope { get; set; }
        }
    }
}