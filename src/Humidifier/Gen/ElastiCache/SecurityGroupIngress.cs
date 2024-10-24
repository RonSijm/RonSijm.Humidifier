namespace Humidifier.ElastiCache
{
    using System.Collections.Generic;

    public class SecurityGroupIngress : Humidifier.Base.BaseResource, IHaveEC2SecurityGroupName, IHaveEC2SecurityGroupOwnerId
    {
        public override string AWSTypeName { get => AWS.ElastiCache.SecurityGroupIngress; }

        /// <summary>
        /// CacheSecurityGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-cachesecuritygroupname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CacheSecurityGroupName { get; set; }

        /// <summary>
        /// EC2SecurityGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EC2SecurityGroupName { get; set; }
        /// <summary>
        /// EC2SecurityGroupOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group-ingress.html#cfn-elasticache-securitygroupingress-ec2securitygroupownerid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EC2SecurityGroupOwnerId { get; set; }
    }
}