namespace Humidifier.VpcLattice
{
    using System.Collections.Generic;

    public class ServiceNetworkVpcAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveSecurityGroupIds
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string VpcId =  "VpcId" ;
            public static string ServiceNetworkId =  "ServiceNetworkId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ServiceNetworkName =  "ServiceNetworkName" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ServiceNetworkArn =  "ServiceNetworkArn" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.ServiceNetworkVpcAssociation; }
        /// <summary>
        /// ServiceNetworkIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-servicenetworkidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceNetworkIdentifier { get; set; }
        /// <summary>
        /// VpcIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-vpcidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcIdentifier { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroupIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}