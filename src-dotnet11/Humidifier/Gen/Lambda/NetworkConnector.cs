namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using NetworkConnectorTypes;

    public class NetworkConnector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLambdaNetworkConnectorTypesConfigConfiguration, IHaveOperatorRole, IHaveName
    {
        public class Attributes
        {
            public static string LatestVersion =  "LatestVersion" ;
            public static string State =  "State" ;
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.NetworkConnector; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-networkconnector.html#cfn-lambda-networkconnector-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Config
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.NetworkConnectorTypes.Config, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// OperatorRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-networkconnector.html#cfn-lambda-networkconnector-operatorrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OperatorRole { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-networkconnector.html#cfn-lambda-networkconnector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace NetworkConnectorTypes
    {
        public class Config : Humidifier.Base.BaseSubResource, IHaveLambdaNetworkConnectorTypesVpcEgressConfigurationVpcEgressConfiguration
        {
            /// <summary>
            /// VpcEgressConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-networkconnector-config.html#cfn-lambda-networkconnector-config-vpcegressconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VpcEgressConfiguration
            /// </summary>
            public Union<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration, BaseFunction>? VpcEgressConfiguration { get; set; }
        }

        public class VpcEgressConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAssociatedComputeResourceTypes, IHaveNetworkProtocol, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// AssociatedComputeResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-networkconnector-vpcegressconfiguration.html#cfn-lambda-networkconnector-vpcegressconfiguration-associatedcomputeresourcetypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AssociatedComputeResourceTypes { get; set; }
            /// <summary>
            /// NetworkProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-networkconnector-vpcegressconfiguration.html#cfn-lambda-networkconnector-vpcegressconfiguration-networkprotocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkProtocol { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-networkconnector-vpcegressconfiguration.html#cfn-lambda-networkconnector-vpcegressconfiguration-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-networkconnector-vpcegressconfiguration.html#cfn-lambda-networkconnector-vpcegressconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}