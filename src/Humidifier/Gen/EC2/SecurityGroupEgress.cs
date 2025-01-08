namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class SecurityGroupEgress : Humidifier.Base.BaseResource, IHaveDescription, IHaveFromPort, IHaveToPort, IHaveGroupId, IHaveCidrIp, IHaveCidrIpv6, IHaveIpProtocol, IHaveDestinationPrefixListId, IHaveDestinationSecurityGroupId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SecurityGroupEgress; }
        /// <summary>
        /// CidrIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-cidrip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CidrIp { get; set; }
        /// <summary>
        /// CidrIpv6
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-cidripv6
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CidrIpv6 { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// FromPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-fromport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic FromPort { get; set; }
        /// <summary>
        /// ToPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-toport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ToPort { get; set; }

        /// <summary>
        /// IpProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-ipprotocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpProtocol { get; set; }
        /// <summary>
        /// DestinationSecurityGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-destinationsecuritygroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationSecurityGroupId { get; set; }
        /// <summary>
        /// DestinationPrefixListId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-destinationprefixlistid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationPrefixListId { get; set; }

        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-securitygroupegress.html#cfn-ec2-securitygroupegress-groupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupId { get; set; }
    }
}