namespace Humidifier.RTBFabric
{
    using global::System.Collections.Generic;

    public class RequesterGateway : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveVpcId, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
    {
        public class Attributes
        {
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string RequesterGatewayStatus =  "RequesterGatewayStatus" ;
            public static string DomainName =  "DomainName" ;
            public static string ActiveLinksCount =  "ActiveLinksCount" ;
            public static string TotalLinksCount =  "TotalLinksCount" ;
            public static string GatewayId =  "GatewayId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RTBFabric.RequesterGateway; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-requestergateway.html#cfn-rtbfabric-requestergateway-description
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-requestergateway.html#cfn-rtbfabric-requestergateway-vpcid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-requestergateway.html#cfn-rtbfabric-requestergateway-subnetids
        /// Required: True
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-requestergateway.html#cfn-rtbfabric-requestergateway-securitygroupids
        /// Required: True
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-requestergateway.html#cfn-rtbfabric-requestergateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}