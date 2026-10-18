namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VerifiedAccessEndpointTypes;

    public class VerifiedAccessEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveAttachmentType, IHaveDescription, IHaveDomainCertificateArn, IHaveVerifiedAccessGroupId, IHaveStringListOfSecurityGroupIds, IHaveEC2VerifiedAccessEndpointTypesLoadBalancerOptionsLoadBalancerOptions, IHaveApplicationDomain, IHavePolicyEnabled_Boolean, IHaveEC2VerifiedAccessEndpointTypesCidrOptionsCidrOptions, IHaveEndpointDomainPrefix, IHaveEndpointType, IHavePolicyDocument, IHaveEC2VerifiedAccessEndpointTypesRdsOptionsRdsOptions, IHaveEC2VerifiedAccessEndpointTypesSseSpecificationSseSpecification, IHaveEC2VerifiedAccessEndpointTypesNetworkInterfaceOptionsNetworkInterfaceOptions
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string EndpointDomain =  "EndpointDomain" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string DeviceValidationDomain =  "DeviceValidationDomain" ;
            public static string VerifiedAccessInstanceId =  "VerifiedAccessInstanceId" ;
            public static string VerifiedAccessEndpointId =  "VerifiedAccessEndpointId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VerifiedAccessEndpoint; }

        /// <summary>
        /// AttachmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-attachmenttype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AttachmentType { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DomainCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-domaincertificatearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainCertificateArn { get; set; }

        /// <summary>
        /// VerifiedAccessGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-verifiedaccessgroupid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VerifiedAccessGroupId { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// LoadBalancerOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-loadbalanceroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoadBalancerOptions
        /// </summary>
        public Union<Humidifier.EC2.VerifiedAccessEndpointTypes.LoadBalancerOptions, BaseFunction>? LoadBalancerOptions { get; set; }
        /// <summary>
        /// ApplicationDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-applicationdomain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationDomain { get; set; }
        /// <summary>
        /// PolicyEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-policyenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PolicyEnabled { get; set; }
        /// <summary>
        /// CidrOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-cidroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CidrOptions
        /// </summary>
        public Union<Humidifier.EC2.VerifiedAccessEndpointTypes.CidrOptions, BaseFunction>? CidrOptions { get; set; }
        /// <summary>
        /// EndpointDomainPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-endpointdomainprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointDomainPrefix { get; set; }

        /// <summary>
        /// EndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-endpointtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointType { get; set; }
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyDocument { get; set; }
        /// <summary>
        /// RdsOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-rdsoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RdsOptions
        /// </summary>
        public Union<Humidifier.EC2.VerifiedAccessEndpointTypes.RdsOptions, BaseFunction>? RdsOptions { get; set; }
        /// <summary>
        /// SseSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-ssespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SseSpecification
        /// </summary>
        public Union<Humidifier.EC2.VerifiedAccessEndpointTypes.SseSpecification, BaseFunction>? SseSpecification { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// NetworkInterfaceOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-verifiedaccessendpoint.html#cfn-ec2-verifiedaccessendpoint-networkinterfaceoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkInterfaceOptions
        /// </summary>
        public Union<Humidifier.EC2.VerifiedAccessEndpointTypes.NetworkInterfaceOptions, BaseFunction>? NetworkInterfaceOptions { get; set; }
    }

    namespace VerifiedAccessEndpointTypes
    {
        public class CidrOptions : Humidifier.Base.BaseSubResource, IHaveCidr, IHaveListOfEC2VerifiedAccessEndpointTypesPortRangePortRanges, IHaveProtocol, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-cidroptions.html#cfn-ec2-verifiedaccessendpoint-cidroptions-cidr
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-cidroptions.html#cfn-ec2-verifiedaccessendpoint-cidroptions-portranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VerifiedAccessEndpointTypes.PortRange>, IReadOnlyList<Union<Humidifier.EC2.VerifiedAccessEndpointTypes.PortRange, BaseFunction>>, BaseFunction>? PortRanges { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-cidroptions.html#cfn-ec2-verifiedaccessendpoint-cidroptions-protocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-cidroptions.html#cfn-ec2-verifiedaccessendpoint-cidroptions-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class LoadBalancerOptions : Humidifier.Base.BaseSubResource, IHaveLoadBalancerArn, IHavePort_Integer, IHaveListOfEC2VerifiedAccessEndpointTypesPortRangePortRanges, IHaveProtocol, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// LoadBalancerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-loadbalanceroptions.html#cfn-ec2-verifiedaccessendpoint-loadbalanceroptions-loadbalancerarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadBalancerArn { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-loadbalanceroptions.html#cfn-ec2-verifiedaccessendpoint-loadbalanceroptions-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-loadbalanceroptions.html#cfn-ec2-verifiedaccessendpoint-loadbalanceroptions-portranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VerifiedAccessEndpointTypes.PortRange>, IReadOnlyList<Union<Humidifier.EC2.VerifiedAccessEndpointTypes.PortRange, BaseFunction>>, BaseFunction>? PortRanges { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-loadbalanceroptions.html#cfn-ec2-verifiedaccessendpoint-loadbalanceroptions-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-loadbalanceroptions.html#cfn-ec2-verifiedaccessendpoint-loadbalanceroptions-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class NetworkInterfaceOptions : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveListOfEC2VerifiedAccessEndpointTypesPortRangePortRanges, IHaveNetworkInterfaceId, IHaveProtocol
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-networkinterfaceoptions.html#cfn-ec2-verifiedaccessendpoint-networkinterfaceoptions-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// PortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-networkinterfaceoptions.html#cfn-ec2-verifiedaccessendpoint-networkinterfaceoptions-portranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VerifiedAccessEndpointTypes.PortRange>, IReadOnlyList<Union<Humidifier.EC2.VerifiedAccessEndpointTypes.PortRange, BaseFunction>>, BaseFunction>? PortRanges { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-networkinterfaceoptions.html#cfn-ec2-verifiedaccessendpoint-networkinterfaceoptions-networkinterfaceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-networkinterfaceoptions.html#cfn-ec2-verifiedaccessendpoint-networkinterfaceoptions-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveToPort_Integer, IHaveFromPort_Integer
        {
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-portrange.html#cfn-ec2-verifiedaccessendpoint-portrange-toport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-portrange.html#cfn-ec2-verifiedaccessendpoint-portrange-fromport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
        }

        public class RdsOptions : Humidifier.Base.BaseSubResource, IHaveRdsDbProxyArn, IHaveRdsDbClusterArn, IHaveRdsEndpoint, IHavePort_Integer, IHaveRdsDbInstanceArn, IHaveProtocol, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// RdsDbProxyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-rdsoptions.html#cfn-ec2-verifiedaccessendpoint-rdsoptions-rdsdbproxyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RdsDbProxyArn { get; set; }
            /// <summary>
            /// RdsDbClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-rdsoptions.html#cfn-ec2-verifiedaccessendpoint-rdsoptions-rdsdbclusterarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RdsDbClusterArn { get; set; }
            /// <summary>
            /// RdsEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-rdsoptions.html#cfn-ec2-verifiedaccessendpoint-rdsoptions-rdsendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RdsEndpoint { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-rdsoptions.html#cfn-ec2-verifiedaccessendpoint-rdsoptions-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// RdsDbInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-rdsoptions.html#cfn-ec2-verifiedaccessendpoint-rdsoptions-rdsdbinstancearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RdsDbInstanceArn { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-rdsoptions.html#cfn-ec2-verifiedaccessendpoint-rdsoptions-protocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-rdsoptions.html#cfn-ec2-verifiedaccessendpoint-rdsoptions-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class SseSpecification : Humidifier.Base.BaseSubResource, IHaveCustomerManagedKeyEnabled_Boolean, IHaveKmsKeyArn
        {
            /// <summary>
            /// CustomerManagedKeyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-ssespecification.html#cfn-ec2-verifiedaccessendpoint-ssespecification-customermanagedkeyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CustomerManagedKeyEnabled { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-verifiedaccessendpoint-ssespecification.html#cfn-ec2-verifiedaccessendpoint-ssespecification-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }
    }
}