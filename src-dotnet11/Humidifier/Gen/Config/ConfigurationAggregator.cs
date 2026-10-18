namespace Humidifier.Config
{
    using global::System.Collections.Generic;
    using ConfigurationAggregatorTypes;

    public class ConfigurationAggregator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfConfigConfigurationAggregatorTypesAccountAggregationSourceAccountAggregationSources, IHaveConfigurationAggregatorName, IHaveConfigConfigurationAggregatorTypesOrganizationAggregationSourceOrganizationAggregationSource
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
        public Union<IReadOnlyList<Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource>, IReadOnlyList<Union<Humidifier.Config.ConfigurationAggregatorTypes.AccountAggregationSource, BaseFunction>>, BaseFunction>? AccountAggregationSources { get; set; }
        public Union<string, BaseFunction>? ConfigurationAggregatorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OrganizationAggregationSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-organizationaggregationsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OrganizationAggregationSource
        /// </summary>
        public Union<Humidifier.Config.ConfigurationAggregatorTypes.OrganizationAggregationSource, BaseFunction>? OrganizationAggregationSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html#cfn-config-configurationaggregator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ConfigurationAggregatorTypes
    {
        public class AccountAggregationSource : Humidifier.Base.BaseSubResource, IHaveAllAwsRegions_Boolean, IHaveStringListOfAwsRegions, IHaveStringListOfAccountIds
        {
            /// <summary>
            /// AllAwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-accountaggregationsource.html#cfn-config-configurationaggregator-accountaggregationsource-allawsregions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllAwsRegions { get; set; }
            /// <summary>
            /// AwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-accountaggregationsource.html#cfn-config-configurationaggregator-accountaggregationsource-awsregions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AwsRegions { get; set; }
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-accountaggregationsource.html#cfn-config-configurationaggregator-accountaggregationsource-accountids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountIds { get; set; }
        }

        public class OrganizationAggregationSource : Humidifier.Base.BaseSubResource, IHaveAllAwsRegions_Boolean, IHaveStringListOfAwsRegions, IHaveRoleArn
        {
            /// <summary>
            /// AllAwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-allawsregions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllAwsRegions { get; set; }
            /// <summary>
            /// AwsRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-awsregions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AwsRegions { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html#cfn-config-configurationaggregator-organizationaggregationsource-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}