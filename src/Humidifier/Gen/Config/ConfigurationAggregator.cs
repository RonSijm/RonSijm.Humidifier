namespace Humidifier.Config
{
    using System.Collections.Generic;
    using ConfigurationAggregatorTypes;

    public class ConfigurationAggregator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string ConfigurationAggregatorArn =  "ConfigurationAggregatorArn" ;
        }

        public override string AWSTypeName { get => AWS.Config.ConfigurationAggregator; }
        /// <summary>
        /// AccountAggregationSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-accountaggregationsources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccountAggregationSource
        /// </summary>
        public List<Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource> AccountAggregationSources { get; set; }
        public dynamic ConfigurationAggregatorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OrganizationAggregationSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-organizationaggregationsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OrganizationAggregationSource
        /// </summary>
        public Humidifier.Config.ConfigurationAggregatorTypes.OrganizationAggregationSource OrganizationAggregationSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ConfigurationAggregatorTypes
    {
        public class AccountAggregationSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllAwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-accountaggregationsource.html#cfn-config-configurationaggregator-accountaggregationsource-allawsregions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllAwsRegions { get; set; }
            /// <summary>
            /// AwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-accountaggregationsource.html#cfn-config-configurationaggregator-accountaggregationsource-awsregions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AwsRegions { get; set; }
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-accountaggregationsource.html#cfn-config-configurationaggregator-accountaggregationsource-accountids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AccountIds { get; set; }
        }

        public class OrganizationAggregationSource : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// AllAwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-allawsregions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllAwsRegions { get; set; }
            /// <summary>
            /// AwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-awsregions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AwsRegions { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}