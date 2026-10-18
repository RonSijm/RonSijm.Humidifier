namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using SecurityGroupTypes;

    public class SecurityGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveGroupDescription, IHaveGroupName, IHaveVpcId, IHaveListOfEC2SecurityGroupTypesIngressSecurityGroupIngress, IHaveListOfEC2SecurityGroupTypesEgressSecurityGroupEgress
    {
        public class Attributes
        {
            public static string VpcId =  "VpcId" ;
            public static string Id =  "Id" ;
            public static string GroupId =  "GroupId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SecurityGroup; }

        /// <summary>
        /// GroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroup.html#cfn-ec2-securitygroup-groupdescription
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupDescription { get; set; }
        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroup.html#cfn-ec2-securitygroup-groupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupName { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroup.html#cfn-ec2-securitygroup-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// SecurityGroupIngress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroup.html#cfn-ec2-securitygroup-securitygroupingress
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Ingress
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.SecurityGroupTypes.Ingress>, IReadOnlyList<Union<Humidifier.EC2.SecurityGroupTypes.Ingress, BaseFunction>>, BaseFunction>? SecurityGroupIngress { get; set; }
        /// <summary>
        /// SecurityGroupEgress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroup.html#cfn-ec2-securitygroup-securitygroupegress
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Egress
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.SecurityGroupTypes.Egress>, IReadOnlyList<Union<Humidifier.EC2.SecurityGroupTypes.Egress, BaseFunction>>, BaseFunction>? SecurityGroupEgress { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroup.html#cfn-ec2-securitygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SecurityGroupTypes
    {
        public class Egress : Humidifier.Base.BaseSubResource, IHaveCidrIp, IHaveCidrIpv6, IHaveDescription, IHaveFromPort_Integer, IHaveToPort_Integer, IHaveIpProtocol, IHaveDestinationSecurityGroupId, IHaveDestinationPrefixListId
        {
            /// <summary>
            /// CidrIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-cidrip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrIp { get; set; }
            /// <summary>
            /// CidrIpv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-cidripv6
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrIpv6 { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-fromport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-toport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// IpProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-ipprotocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpProtocol { get; set; }
            /// <summary>
            /// DestinationSecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-destinationsecuritygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationSecurityGroupId { get; set; }
            /// <summary>
            /// DestinationPrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-egress.html#cfn-ec2-securitygroup-egress-destinationprefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPrefixListId { get; set; }
        }

        public class Ingress : Humidifier.Base.BaseSubResource, IHaveCidrIp, IHaveCidrIpv6, IHaveDescription, IHaveFromPort_Integer, IHaveSourceSecurityGroupName, IHaveToPort_Integer, IHaveSourceSecurityGroupOwnerId, IHaveIpProtocol, IHaveSourceSecurityGroupId, IHaveSourcePrefixListId
        {
            /// <summary>
            /// CidrIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-cidrip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrIp { get; set; }
            /// <summary>
            /// CidrIpv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-cidripv6
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrIpv6 { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-fromport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// SourceSecurityGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-sourcesecuritygroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceSecurityGroupName { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-toport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// SourceSecurityGroupOwnerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-sourcesecuritygroupownerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceSecurityGroupOwnerId { get; set; }
            /// <summary>
            /// IpProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-ipprotocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpProtocol { get; set; }
            /// <summary>
            /// SourceSecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-sourcesecuritygroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceSecurityGroupId { get; set; }
            /// <summary>
            /// SourcePrefixListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-securitygroup-ingress.html#cfn-ec2-securitygroup-ingress-sourceprefixlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePrefixListId { get; set; }
        }
    }
}