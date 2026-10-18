namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCEndpointServiceTypes;

    public class VPCEndpointService : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfNetworkLoadBalancerArns, IHavePayerResponsibility, IHavePrivateDnsName, IHaveAcceptanceRequired_Boolean, IHaveEC2VPCEndpointServiceTypesPrivateDnsNameConfigurationPrivateDnsNameConfiguration, IHaveContributorInsightsEnabled_Boolean, IHaveStringListOfSupportedIpAddressTypes, IHaveStringListOfGatewayLoadBalancerArns, IHaveStringListOfSupportedRegions
    {
        public class Attributes
        {
            public static string ServiceId =  "ServiceId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCEndpointService; }
        /// <summary>
        /// NetworkLoadBalancerArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-networkloadbalancerarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NetworkLoadBalancerArns { get; set; }
        /// <summary>
        /// PayerResponsibility
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-payerresponsibility
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PayerResponsibility { get; set; }
        /// <summary>
        /// PrivateDnsName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-privatednsname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateDnsName { get; set; }
        /// <summary>
        /// AcceptanceRequired
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-acceptancerequired
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AcceptanceRequired { get; set; }
        /// <summary>
        /// PrivateDnsNameConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-privatednsnameconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PrivateDnsNameConfiguration
        /// </summary>
        public Union<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration, BaseFunction>? PrivateDnsNameConfiguration { get; set; }
        /// <summary>
        /// ContributorInsightsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-contributorinsightsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ContributorInsightsEnabled { get; set; }
        /// <summary>
        /// SupportedIpAddressTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-supportedipaddresstypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedIpAddressTypes { get; set; }
        /// <summary>
        /// GatewayLoadBalancerArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-gatewayloadbalancerarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GatewayLoadBalancerArns { get; set; }
        /// <summary>
        /// SupportedRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-supportedregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedRegions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VPCEndpointServiceTypes
    {
        public class PrivateDnsNameConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveState, IHaveValue, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpointservice-privatednsnameconfiguration.html#cfn-ec2-vpcendpointservice-privatednsnameconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpointservice-privatednsnameconfiguration.html#cfn-ec2-vpcendpointservice-privatednsnameconfiguration-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpointservice-privatednsnameconfiguration.html#cfn-ec2-vpcendpointservice-privatednsnameconfiguration-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpointservice-privatednsnameconfiguration.html#cfn-ec2-vpcendpointservice-privatednsnameconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}