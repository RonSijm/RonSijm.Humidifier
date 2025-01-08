namespace Humidifier.AppRunner
{
    using System.Collections.Generic;
    using ObservabilityConfigurationTypes;

    public class ObservabilityConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string ObservabilityConfigurationRevision =  "ObservabilityConfigurationRevision" ;
            public static string ObservabilityConfigurationArn =  "ObservabilityConfigurationArn" ;
            public static string Latest =  "Latest" ;
        }

        public override string AWSTypeName { get => AWS.AppRunner.ObservabilityConfiguration; }
        /// <summary>
        /// TraceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-observabilityconfiguration.html#cfn-apprunner-observabilityconfiguration-traceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TraceConfiguration
        /// </summary>
        public Humidifier.AppRunner.ObservabilityConfigurationTypes.TraceConfiguration TraceConfiguration { get; set; }
        public dynamic ObservabilityConfigurationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-observabilityconfiguration.html#cfn-apprunner-observabilityconfiguration-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ObservabilityConfigurationTypes
    {
        public class TraceConfiguration : Humidifier.Base.BaseSubResource, IHaveVendor
        {
            /// <summary>
            /// Vendor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apprunner-observabilityconfiguration-traceconfiguration.html#cfn-apprunner-observabilityconfiguration-traceconfiguration-vendor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Vendor { get; set; }
        }
    }
}