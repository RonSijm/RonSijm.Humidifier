namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using IPAMPrefixListResolverTypes;

    public class IPAMPrefixListResolver : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveAddressFamily, IHaveIpamId
    {
        public class Attributes
        {
            public static string IpamPrefixListResolverArn =  "IpamPrefixListResolverArn" ;
            public static string IpamArn =  "IpamArn" ;
            public static string IpamPrefixListResolverId =  "IpamPrefixListResolverId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMPrefixListResolver; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolver.html#cfn-ec2-ipamprefixlistresolver-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// IpamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolver.html#cfn-ec2-ipamprefixlistresolver-ipamid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IpamId { get; set; }

        /// <summary>
        /// AddressFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolver.html#cfn-ec2-ipamprefixlistresolver-addressfamily
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AddressFamily { get; set; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolver.html#cfn-ec2-ipamprefixlistresolver-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpamPrefixListResolverRule
        /// </summary>
        public List<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRule> Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamprefixlistresolver.html#cfn-ec2-ipamprefixlistresolver-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace IPAMPrefixListResolverTypes
    {
        public class IpamPrefixListResolverRule : Humidifier.Base.BaseSubResource, IHaveResourceType
        {
            /// <summary>
            /// IpamScopeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule-ipamscopeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpamScopeId { get; set; }
            /// <summary>
            /// StaticCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule-staticcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticCidr { get; set; }
            /// <summary>
            /// RuleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule-ruletype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleType { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrule-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IpamPrefixListResolverRuleCondition
            /// </summary>
            public List<Humidifier.EC2.IPAMPrefixListResolverTypes.IpamPrefixListResolverRuleCondition> Conditions { get; set; }
        }

        public class IpamPrefixListResolverRuleCondition : Humidifier.Base.BaseSubResource, IHaveResourceId, IHaveCidr, IHaveOperation, IHaveIpamPoolId, IHaveResourceOwner
        {
            /// <summary>
            /// ResourceRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition-resourceregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceRegion { get; set; }
            /// <summary>
            /// ResourceTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition-resourcetag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Tag
            /// </summary>
            public Humidifier.Tag ResourceTag { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
            /// <summary>
            /// IpamPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition-ipampoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpamPoolId { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceId { get; set; }
            /// <summary>
            /// ResourceOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition-resourceowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceOwner { get; set; }
            /// <summary>
            /// Operation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition.html#cfn-ec2-ipamprefixlistresolver-ipamprefixlistresolverrulecondition-operation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operation { get; set; }
        }
    }
}