namespace Humidifier.S3
{
    using global::System.Collections.Generic;
    using AccessGrantTypes;

    public class AccessGrant : Humidifier.Base.BaseResource, IHaveTags, IHaveS3AccessGrantTypesGranteeGrantee, IHaveS3AccessGrantTypesAccessGrantsLocationConfigurationAccessGrantsLocationConfiguration, IHaveApplicationArn, IHavePermission, IHaveS3PrefixType, IHaveAccessGrantsLocationId
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
        public Union<Humidifier.S3.AccessGrantTypes.Grantee, BaseFunction>? Grantee { get; set; }
        /// <summary>
        /// AccessGrantsLocationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-accessgrantslocationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessGrantsLocationConfiguration
        /// </summary>
        public Union<Humidifier.S3.AccessGrantTypes.AccessGrantsLocationConfiguration, BaseFunction>? AccessGrantsLocationConfiguration { get; set; }
        /// <summary>
        /// ApplicationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-applicationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationArn { get; set; }

        /// <summary>
        /// Permission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-permission
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Permission { get; set; }
        /// <summary>
        /// S3PrefixType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-s3prefixtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3PrefixType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// AccessGrantsLocationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrant.html#cfn-s3-accessgrant-accessgrantslocationid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessGrantsLocationId { get; set; }
    }

    namespace AccessGrantTypes
    {
        public class AccessGrantsLocationConfiguration : Humidifier.Base.BaseSubResource, IHaveS3SubPrefix
        {
            /// <summary>
            /// S3SubPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accessgrant-accessgrantslocationconfiguration.html#cfn-s3-accessgrant-accessgrantslocationconfiguration-s3subprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3SubPrefix { get; set; }
        }

        public class Grantee : Humidifier.Base.BaseSubResource, IHaveGranteeType, IHaveGranteeIdentifier
        {
            /// <summary>
            /// GranteeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accessgrant-grantee.html#cfn-s3-accessgrant-grantee-granteetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GranteeType { get; set; }
            /// <summary>
            /// GranteeIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-accessgrant-grantee.html#cfn-s3-accessgrant-grantee-granteeidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GranteeIdentifier { get; set; }
        }
    }
}