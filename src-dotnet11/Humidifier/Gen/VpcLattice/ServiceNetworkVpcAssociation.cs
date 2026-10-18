namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using ServiceNetworkVpcAssociationTypes;

    public class ServiceNetworkVpcAssociation : Humidifier.Base.BaseResource, IHaveTags, IHavePrivateDnsEnabled_Boolean, IHaveServiceNetworkIdentifier, IHaveVpcLatticeServiceNetworkVpcAssociationTypesDnsOptionsDnsOptions, IHaveVpcIdentifier, IHaveStringListOfSecurityGroupIds
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
        public Union<bool, BaseFunction>? PrivateDnsEnabled { get; set; }
        /// <summary>
        /// ServiceNetworkIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-servicenetworkidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceNetworkIdentifier { get; set; }
        /// <summary>
        /// DnsOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-dnsoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DnsOptions
        /// </summary>
        public Union<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions, BaseFunction>? DnsOptions { get; set; }
        /// <summary>
        /// VpcIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-vpcidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcIdentifier { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-servicenetworkvpcassociation.html#cfn-vpclattice-servicenetworkvpcassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ServiceNetworkVpcAssociationTypes
    {
        public class DnsOptions : Humidifier.Base.BaseSubResource, IHaveStringListOfPrivateDnsSpecifiedDomains, IHavePrivateDnsPreference
        {
            /// <summary>
            /// PrivateDnsSpecifiedDomains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetworkvpcassociation-dnsoptions.html#cfn-vpclattice-servicenetworkvpcassociation-dnsoptions-privatednsspecifieddomains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PrivateDnsSpecifiedDomains { get; set; }
            /// <summary>
            /// PrivateDnsPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-servicenetworkvpcassociation-dnsoptions.html#cfn-vpclattice-servicenetworkvpcassociation-dnsoptions-privatednspreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateDnsPreference { get; set; }
        }
    }
}