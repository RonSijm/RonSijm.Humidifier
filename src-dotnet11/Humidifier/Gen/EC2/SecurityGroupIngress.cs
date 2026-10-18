namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class SecurityGroupIngress : Humidifier.Base.BaseResource, IHaveGroupName, IHaveCidrIp, IHaveCidrIpv6, IHaveDescription, IHaveFromPort_Integer, IHaveSourceSecurityGroupName, IHaveToPort_Integer, IHaveSourceSecurityGroupOwnerId, IHaveIpProtocol, IHaveSourceSecurityGroupId, IHaveSourcePrefixListId, IHaveGroupId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SecurityGroupIngress; }
        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-groupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupName { get; set; }
        /// <summary>
        /// CidrIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-cidrip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CidrIp { get; set; }
        /// <summary>
        /// CidrIpv6
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-cidripv6
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CidrIpv6 { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// FromPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-fromport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? FromPort { get; set; }
        /// <summary>
        /// SourceSecurityGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-sourcesecuritygroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceSecurityGroupName { get; set; }
        /// <summary>
        /// ToPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-toport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ToPort { get; set; }
        /// <summary>
        /// SourceSecurityGroupOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-sourcesecuritygroupownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceSecurityGroupOwnerId { get; set; }

        /// <summary>
        /// IpProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-ipprotocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IpProtocol { get; set; }
        /// <summary>
        /// SourceSecurityGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-sourcesecuritygroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceSecurityGroupId { get; set; }
        /// <summary>
        /// SourcePrefixListId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-sourceprefixlistid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourcePrefixListId { get; set; }
        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupingress.html#cfn-ec2-securitygroupingress-groupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupId { get; set; }
    }
}