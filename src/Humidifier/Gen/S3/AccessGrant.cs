namespace Humidifier.S3
{
    using System.Collections.Generic;
    using AccessGrantTypes;

    public class AccessGrant : Humidifier.Base.BaseResource, IHaveTags, IHavePermission, IHaveApplicationArn
    {
        public class Attributes
        {
            public static string GrantScope =  "GrantScope" ;
            public static string AccessGrantId =  "AccessGrantId" ;
            public static string AccessGrantArn =  "AccessGrantArn" ;
        }

        public override string AWSTypeName { get => AWS.S3.AccessGrant; }

        /// <summary>
        /// Grantee
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-grantee
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Grantee
        /// </summary>
        [Required]
        public Humidifier.S3.AccessGrantTypes.Grantee Grantee { get; set; }
        /// <summary>
        /// AccessGrantsLocationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-accessgrantslocationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessGrantsLocationConfiguration
        /// </summary>
        public Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration AccessGrantsLocationConfiguration { get; set; }
        /// <summary>
        /// ApplicationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-applicationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationArn { get; set; }

        /// <summary>
        /// Permission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-permission
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Permission { get; set; }
        /// <summary>
        /// S3PrefixType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-s3prefixtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3PrefixType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// AccessGrantsLocationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-accessgrantslocationid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AccessGrantsLocationId { get; set; }
    }

    namespace AccessGrantTypes
    {
        public class AccessGrantsLocationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3SubPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accessgrant-accessgrantslocationconfiguration.html#cfn-s3-accessgrant-accessgrantslocationconfiguration-s3subprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3SubPrefix { get; set; }
        }

        public class Grantee : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GranteeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accessgrant-grantee.html#cfn-s3-accessgrant-grantee-granteetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GranteeType { get; set; }
            /// <summary>
            /// GranteeIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accessgrant-grantee.html#cfn-s3-accessgrant-grantee-granteeidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GranteeIdentifier { get; set; }
        }
    }
}