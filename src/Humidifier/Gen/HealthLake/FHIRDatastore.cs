namespace Humidifier.HealthLake
{
    using System.Collections.Generic;
    using FHIRDatastoreTypes;

    public class FHIRDatastore : Humidifier.Base.BaseResource, IHaveTags, IHaveDatastoreName
    {
        public class Attributes
        {
            public static string DatastoreArn =  "DatastoreArn" ;
            public static string DatastoreId =  "DatastoreId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string DatastoreStatus =  "DatastoreStatus" ;
            public static string DatastoreEndpoint =  "DatastoreEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.HealthLake.FHIRDatastore; }

        /// <summary>
        /// DatastoreTypeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-datastoretypeversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatastoreTypeVersion { get; set; }
        /// <summary>
        /// DatastoreName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-datastorename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatastoreName { get; set; }
        /// <summary>
        /// IdentityProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: IdentityProviderConfiguration
        /// </summary>
        public Humidifier.HealthLake.FHIRDatastoreTypes.IdentityProviderConfiguration IdentityProviderConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// PreloadDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-preloaddataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PreloadDataConfig
        /// </summary>
        public Humidifier.HealthLake.FHIRDatastoreTypes.PreloadDataConfig PreloadDataConfig { get; set; }
        /// <summary>
        /// SseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-sseconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SseConfiguration
        /// </summary>
        public Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration SseConfiguration { get; set; }
    }

    namespace FHIRDatastoreTypes
    {
        public class CreatedAt : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Nanos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-createdat.html#cfn-healthlake-fhirdatastore-createdat-nanos
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Nanos { get; set; }
            /// <summary>
            /// Seconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-createdat.html#cfn-healthlake-fhirdatastore-createdat-seconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Seconds { get; set; }
        }

        public class IdentityProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-authorizationstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationStrategy { get; set; }
            /// <summary>
            /// IdpLambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-idplambdaarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdpLambdaArn { get; set; }
            /// <summary>
            /// FineGrainedAuthorizationEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-finegrainedauthorizationenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic FineGrainedAuthorizationEnabled { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-metadata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Metadata { get; set; }
        }

        public class KmsEncryptionConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-kmsencryptionconfig.html#cfn-healthlake-fhirdatastore-kmsencryptionconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// CmkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-kmsencryptionconfig.html#cfn-healthlake-fhirdatastore-kmsencryptionconfig-cmktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CmkType { get; set; }
        }

        public class PreloadDataConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PreloadDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-preloaddataconfig.html#cfn-healthlake-fhirdatastore-preloaddataconfig-preloaddatatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreloadDataType { get; set; }
        }

        public class SseConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KmsEncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-sseconfiguration.html#cfn-healthlake-fhirdatastore-sseconfiguration-kmsencryptionconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: KmsEncryptionConfig
            /// </summary>
            public Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig KmsEncryptionConfig { get; set; }
        }
    }
}