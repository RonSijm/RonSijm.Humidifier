namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class ClusterSecurityGroupIngress : Humidifier.Base.BaseResource, IHaveCIDRIP, IHaveClusterSecurityGroupName, IHaveEC2SecurityGroupName, IHaveEC2SecurityGroupOwnerId
    {
        public override string AWSTypeName { get => AWS.Redshift.ClusterSecurityGroupIngress; }
        /// <summary>
        /// CIDRIP
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-cidrip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CIDRIP { get; set; }

        /// <summary>
        /// ClusterSecurityGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-clustersecuritygroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterSecurityGroupName { get; set; }
        /// <summary>
        /// EC2SecurityGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-ec2securitygroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EC2SecurityGroupName { get; set; }
        /// <summary>
        /// EC2SecurityGroupOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-ec2securitygroupownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EC2SecurityGroupOwnerId { get; set; }
    }
}