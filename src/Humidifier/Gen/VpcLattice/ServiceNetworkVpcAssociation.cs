namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using ServiceNetworkVpcAssociationTypes;

    public class ServiceNetworkVpcAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveSecurityGroupIds, IHaveVpcIdentifier, IHaveServiceNetworkIdentifier
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
        /// PrivateDnsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-privatednsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PrivateDnsEnabled { get; set; }
        /// <summary>
        /// ServiceNetworkIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-servicenetworkidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceNetworkIdentifier { get; set; }
        /// <summary>
        /// DnsOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-dnsoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DnsOptions
        /// </summary>
        public Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions DnsOptions { get; set; }
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
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ServiceNetworkVpcAssociationTypes
    {
        public class DnsOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrivateDnsSpecifiedDomains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetworkvpcassociation-dnsoptions.html#cfn-vpclattice-servicenetworkvpcassociation-dnsoptions-privatednsspecifieddomains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PrivateDnsSpecifiedDomains { get; set; }
            /// <summary>
            /// PrivateDnsPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetworkvpcassociation-dnsoptions.html#cfn-vpclattice-servicenetworkvpcassociation-dnsoptions-privatednspreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateDnsPreference { get; set; }
        }
    }
}