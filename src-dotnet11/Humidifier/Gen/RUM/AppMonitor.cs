namespace Humidifier.RUM
{
    using global::System.Collections.Generic;
    using AppMonitorTypes;

    public class AppMonitor : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRUMAppMonitorTypesCustomEventsCustomEvents, IHavePlatform, IHaveCwLogEnabled_Boolean, IHaveRUMAppMonitorTypesResourcePolicyResourcePolicy, IHaveStringListOfDomainList, IHaveRUMAppMonitorTypesDeobfuscationConfigurationDeobfuscationConfiguration, IHaveDomain, IHaveRUMAppMonitorTypesAppMonitorConfigurationAppMonitorConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.RUM.AppMonitor; }
        /// <summary>
        /// CustomEvents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-customevents
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomEvents
        /// </summary>
        public Union<Humidifier.RUM.AppMonitorTypes.CustomEvents, BaseFunction>? CustomEvents { get; set; }
        /// <summary>
        /// Platform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-platform
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Platform { get; set; }
        /// <summary>
        /// CwLogEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-cwlogenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CwLogEnabled { get; set; }
        /// <summary>
        /// ResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-resourcepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ResourcePolicy
        /// </summary>
        public Union<Humidifier.RUM.AppMonitorTypes.ResourcePolicy, BaseFunction>? ResourcePolicy { get; set; }
        /// <summary>
        /// DomainList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-domainlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DomainList { get; set; }
        /// <summary>
        /// DeobfuscationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-deobfuscationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeobfuscationConfiguration
        /// </summary>
        public Union<Humidifier.RUM.AppMonitorTypes.DeobfuscationConfiguration, BaseFunction>? DeobfuscationConfiguration { get; set; }
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-domain
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Domain { get; set; }
        /// <summary>
        /// AppMonitorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-appmonitorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AppMonitorConfiguration
        /// </summary>
        public Union<Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration, BaseFunction>? AppMonitorConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AppMonitorTypes
    {
        public class AppMonitorConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfRUMAppMonitorTypesMetricDestinationMetricDestinations, IHaveStringListOfIncludedPages, IHaveStringListOfExcludedPages, IHaveStringListOfFavoritePages, IHaveSessionSampleRate_Double, IHaveAllowCookies_Boolean, IHaveStringListOfTelemetries, IHaveIdentityPoolId, IHaveGuestRoleArn, IHaveEnableXRay_Boolean
        {
            /// <summary>
            /// MetricDestinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-metricdestinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDestination
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RUM.AppMonitorTypes.MetricDestination>, IReadOnlyList<Union<Humidifier.RUM.AppMonitorTypes.MetricDestination, BaseFunction>>, BaseFunction>? MetricDestinations { get; set; }
            /// <summary>
            /// IncludedPages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-includedpages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedPages { get; set; }
            /// <summary>
            /// ExcludedPages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-excludedpages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedPages { get; set; }
            /// <summary>
            /// FavoritePages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-favoritepages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FavoritePages { get; set; }
            /// <summary>
            /// SessionSampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-sessionsamplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SessionSampleRate { get; set; }
            /// <summary>
            /// AllowCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-allowcookies
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowCookies { get; set; }
            /// <summary>
            /// Telemetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-telemetries
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Telemetries { get; set; }
            /// <summary>
            /// IdentityPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-identitypoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityPoolId { get; set; }
            /// <summary>
            /// GuestRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-guestrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GuestRoleArn { get; set; }
            /// <summary>
            /// EnableXRay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-enablexray
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableXRay { get; set; }
        }

        public class CustomEvents : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-customevents.html#cfn-rum-appmonitor-customevents-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class DeobfuscationConfiguration : Humidifier.Base.BaseSubResource, IHaveRUMAppMonitorTypesJavaScriptSourceMapsJavaScriptSourceMaps
        {
            /// <summary>
            /// JavaScriptSourceMaps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-deobfuscationconfiguration.html#cfn-rum-appmonitor-deobfuscationconfiguration-javascriptsourcemaps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JavaScriptSourceMaps
            /// </summary>
            public Union<Humidifier.RUM.AppMonitorTypes.JavaScriptSourceMaps, BaseFunction>? JavaScriptSourceMaps { get; set; }
        }

        public class JavaScriptSourceMaps : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveS3Uri
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-javascriptsourcemaps.html#cfn-rum-appmonitor-javascriptsourcemaps-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-javascriptsourcemaps.html#cfn-rum-appmonitor-javascriptsourcemaps-s3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class MetricDefinition : Humidifier.Base.BaseSubResource, IHaveEventPattern, IHaveValueKey, IHaveUnitLabel, IHaveStringDictionaryOfDimensionKeys, IHaveNamespace_, IHaveName
        {
            /// <summary>
            /// EventPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-eventpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventPattern { get; set; }
            /// <summary>
            /// ValueKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-valuekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueKey { get; set; }
            /// <summary>
            /// UnitLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-unitlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnitLabel { get; set; }
            /// <summary>
            /// DimensionKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-dimensionkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DimensionKeys { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MetricDestination : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveIamRoleArn, IHaveListOfRUMAppMonitorTypesMetricDefinitionMetricDefinitions, IHaveDestinationArn
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-destination
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleArn { get; set; }
            /// <summary>
            /// MetricDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-metricdefinitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.RUM.AppMonitorTypes.MetricDefinition>, IReadOnlyList<Union<Humidifier.RUM.AppMonitorTypes.MetricDefinition, BaseFunction>>, BaseFunction>? MetricDefinitions { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationArn { get; set; }
        }

        public class ResourcePolicy : Humidifier.Base.BaseSubResource, IHavePolicyRevisionId, IHavePolicyDocument
        {
            /// <summary>
            /// PolicyRevisionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-resourcepolicy.html#cfn-rum-appmonitor-resourcepolicy-policyrevisionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyRevisionId { get; set; }
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-resourcepolicy.html#cfn-rum-appmonitor-resourcepolicy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyDocument { get; set; }
        }
    }
}