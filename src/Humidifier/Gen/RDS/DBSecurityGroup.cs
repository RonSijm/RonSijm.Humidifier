namespace Humidifier.RDS
{
    using System.Collections.Generic;
    using DBSecurityGroupTypes;

    public class DBSecurityGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveGroupDescription
    {
        public override string AWSTypeName { get => AWS.RDS.DBSecurityGroup; }

        /// <summary>
        /// DBSecurityGroupIngress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-dbsecuritygroupingress
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Ingress
        /// </summary>
        [Required]
        public List<Humidifier.RDS.DBSecurityGroupTypes.Ingress> DBSecurityGroupIngress { get; set; }
        /// <summary>
        /// EC2VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-ec2vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EC2VpcId { get; set; }

        /// <summary>
        /// GroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-groupdescription
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupDescription { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group.html#cfn-rds-dbsecuritygroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DBSecurityGroupTypes
    {
        public class Ingress : Humidifier.Base.BaseSubResource, IHaveEC2SecurityGroupName, IHaveEC2SecurityGroupOwnerId, IHaveCIDRIP, IHaveEC2SecurityGroupId
        {
            /// <summary>
            /// CIDRIP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-cidrip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CIDRIP { get; set; }
            /// <summary>
            /// EC2SecurityGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-ec2securitygroupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EC2SecurityGroupId { get; set; }
            /// <summary>
            /// EC2SecurityGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-ec2securitygroupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EC2SecurityGroupName { get; set; }
            /// <summary>
            /// EC2SecurityGroupOwnerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-security-group-rule.html#cfn-rds-securitygroup-ec2securitygroupownerid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EC2SecurityGroupOwnerId { get; set; }
        }
    }
}