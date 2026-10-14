namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using DomainObjectTypeTypes;

    public class DomainObjectType : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDomainName, IHaveEncryptionKey, IHaveObjectTypeName
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.DomainObjectType; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domainobjecttype.html#cfn-customerprofiles-domainobjecttype-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Fields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domainobjecttype.html#cfn-customerprofiles-domainobjecttype-fields
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Map
        /// ItemType: DomainObjectTypeField
        /// </summary>
        [Required]
        public Dictionary<string, Humidifier.CustomerProfiles.DomainObjectTypeTypes.DomainObjectTypeField> Fields { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domainobjecttype.html#cfn-customerprofiles-domainobjecttype-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }

        /// <summary>
        /// ObjectTypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domainobjecttype.html#cfn-customerprofiles-domainobjecttype-objecttypename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ObjectTypeName { get; set; }
        /// <summary>
        /// EncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domainobjecttype.html#cfn-customerprofiles-domainobjecttype-encryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-domainobjecttype.html#cfn-customerprofiles-domainobjecttype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DomainObjectTypeTypes
    {
        public class DomainObjectTypeField : Humidifier.Base.BaseSubResource, IHaveSource, IHaveTarget, IHaveContentType
        {
            /// <summary>
            /// FeatureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domainobjecttype-domainobjecttypefield.html#cfn-customerprofiles-domainobjecttype-domainobjecttypefield-featuretype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeatureType { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domainobjecttype-domainobjecttypefield.html#cfn-customerprofiles-domainobjecttype-domainobjecttypefield-target
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domainobjecttype-domainobjecttypefield.html#cfn-customerprofiles-domainobjecttype-domainobjecttypefield-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-domainobjecttype-domainobjecttypefield.html#cfn-customerprofiles-domainobjecttype-domainobjecttypefield-source
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }
    }
}