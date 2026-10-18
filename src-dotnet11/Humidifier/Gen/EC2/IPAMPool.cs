namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using IPAMPoolTypes;

    public class IPAMPool : Humidifier.Base.BaseResource, IHaveTags, IHaveAwsService, IHaveLocale, IHavePublicIpSource, IHaveDescription, IHaveEC2IPAMPoolTypesSourceResourceSourceResource, IHaveSourceIpamPoolId, IHaveAllocationMinNetmaskLength_Integer, IHaveIpamScopeId, IHaveListOfEC2IPAMPoolTypesProvisionedCidrProvisionedCidrs, IHaveAllocationMaxNetmaskLength_Integer, IHaveAllocationDefaultNetmaskLength_Integer, IHaveAutoImport_Boolean, IHaveAddressFamily, IHaveTagListOfAllocationResourceTags, IHavePubliclyAdvertisable_Boolean
    {
        public class Attributes
        {
            public static string IpamPoolId =  "IpamPoolId" ;
            public static string IpamArn =  "IpamArn" ;
            public static string PoolDepth =  "PoolDepth" ;
            public static string State =  "State" ;
            public static string IpamScopeArn =  "IpamScopeArn" ;
            public static string IpamScopeType =  "IpamScopeType" ;
            public static string Arn =  "Arn" ;
            public static string StateMessage =  "StateMessage" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMPool; }
        /// <summary>
        /// AwsService
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-awsservice
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsService { get; set; }
        /// <summary>
        /// Locale
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-locale
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Locale { get; set; }
        /// <summary>
        /// PublicIpSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-publicipsource
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PublicIpSource { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SourceResource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-sourceresource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceResource
        /// </summary>
        public Union<Humidifier.EC2.IPAMPoolTypes.SourceResource, BaseFunction>? SourceResource { get; set; }
        /// <summary>
        /// SourceIpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-sourceipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceIpamPoolId { get; set; }
        /// <summary>
        /// AllocationMinNetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-allocationminnetmasklength
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AllocationMinNetmaskLength { get; set; }

        /// <summary>
        /// IpamScopeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-ipamscopeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IpamScopeId { get; set; }
        /// <summary>
        /// ProvisionedCidrs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-provisionedcidrs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProvisionedCidr
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr>, IReadOnlyList<Union<Humidifier.EC2.IPAMPoolTypes.ProvisionedCidr, BaseFunction>>, BaseFunction>? ProvisionedCidrs { get; set; }
        /// <summary>
        /// AllocationMaxNetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-allocationmaxnetmasklength
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AllocationMaxNetmaskLength { get; set; }
        /// <summary>
        /// AllocationDefaultNetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-allocationdefaultnetmasklength
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AllocationDefaultNetmaskLength { get; set; }
        /// <summary>
        /// AutoImport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-autoimport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoImport { get; set; }

        /// <summary>
        /// AddressFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-addressfamily
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AddressFamily { get; set; }
        /// <summary>
        /// AllocationResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-allocationresourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? AllocationResourceTags { get; set; }
        /// <summary>
        /// PubliclyAdvertisable
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-publiclyadvertisable
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PubliclyAdvertisable { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampool.html#cfn-ec2-ipampool-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IPAMPoolTypes
    {
        public class ProvisionedCidr : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipampool-provisionedcidr.html#cfn-ec2-ipampool-provisionedcidr-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
        }

        public class SourceResource : Humidifier.Base.BaseSubResource, IHaveResourceRegion, IHaveResourceId, IHaveResourceOwner, IHaveResourceType
        {
            /// <summary>
            /// ResourceRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipampool-sourceresource.html#cfn-ec2-ipampool-sourceresource-resourceregion
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceRegion { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipampool-sourceresource.html#cfn-ec2-ipampool-sourceresource-resourceid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// ResourceOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipampool-sourceresource.html#cfn-ec2-ipampool-sourceresource-resourceowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceOwner { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipampool-sourceresource.html#cfn-ec2-ipampool-sourceresource-resourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
        }
    }
}