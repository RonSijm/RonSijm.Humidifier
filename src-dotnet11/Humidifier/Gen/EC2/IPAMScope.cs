namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using IPAMScopeTypes;

    public class IPAMScope : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveIpamId, IHaveEC2IPAMScopeTypesIpamScopeExternalAuthorityConfigurationExternalAuthorityConfiguration
    {
        public class Attributes
        {
            public static string IpamScopeId =  "IpamScopeId" ;
            public static string IsDefault =  "IsDefault" ;
            public static string IpamArn =  "IpamArn" ;
            public static string IpamScopeType =  "IpamScopeType" ;
            public static string PoolCount =  "PoolCount" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMScope; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamscope.html#cfn-ec2-ipamscope-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// IpamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamscope.html#cfn-ec2-ipamscope-ipamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IpamId { get; set; }
        /// <summary>
        /// ExternalAuthorityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamscope.html#cfn-ec2-ipamscope-externalauthorityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IpamScopeExternalAuthorityConfiguration
        /// </summary>
        public Union<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration, BaseFunction>? ExternalAuthorityConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamscope.html#cfn-ec2-ipamscope-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IPAMScopeTypes
    {
        public class IpamScopeExternalAuthorityConfiguration : Humidifier.Base.BaseSubResource, IHaveExternalResourceIdentifier, IHaveIpamScopeExternalAuthorityType
        {
            /// <summary>
            /// ExternalResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamscope-ipamscopeexternalauthorityconfiguration.html#cfn-ec2-ipamscope-ipamscopeexternalauthorityconfiguration-externalresourceidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalResourceIdentifier { get; set; }
            /// <summary>
            /// IpamScopeExternalAuthorityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ipamscope-ipamscopeexternalauthorityconfiguration.html#cfn-ec2-ipamscope-ipamscopeexternalauthorityconfiguration-ipamscopeexternalauthoritytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpamScopeExternalAuthorityType { get; set; }
        }
    }
}