namespace Humidifier.HealthLake
{
    using global::System.Collections.Generic;
    using FHIRDatastoreTypes;

    public class FHIRDatastore : Humidifier.Base.BaseResource, IHaveTags, IHaveHealthLakeFHIRDatastoreTypesAnalyticsConfigurationAnalyticsConfiguration, IHaveDatastoreTypeVersion, IHaveHealthLakeFHIRDatastoreTypesProfileConfigurationProfileConfiguration, IHaveHealthLakeFHIRDatastoreTypesNlpConfigurationNlpConfiguration, IHaveDatastoreName, IHaveHealthLakeFHIRDatastoreTypesIdentityProviderConfigurationIdentityProviderConfiguration, IHaveHealthLakeFHIRDatastoreTypesPreloadDataConfigPreloadDataConfig, IHaveHealthLakeFHIRDatastoreTypesSseConfigurationSseConfiguration
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
        /// AnalyticsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-analyticsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnalyticsConfiguration
        /// </summary>
        public Union<Humidifier.HealthLake.FHIRDatastoreTypes.AnalyticsConfiguration, BaseFunction>? AnalyticsConfiguration { get; set; }

        /// <summary>
        /// DatastoreTypeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-datastoretypeversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatastoreTypeVersion { get; set; }
        /// <summary>
        /// ProfileConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-profileconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProfileConfiguration
        /// </summary>
        public Union<Humidifier.HealthLake.FHIRDatastoreTypes.ProfileConfiguration, BaseFunction>? ProfileConfiguration { get; set; }
        /// <summary>
        /// NlpConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-nlpconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NlpConfiguration
        /// </summary>
        public Union<Humidifier.HealthLake.FHIRDatastoreTypes.NlpConfiguration, BaseFunction>? NlpConfiguration { get; set; }
        /// <summary>
        /// DatastoreName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-datastorename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatastoreName { get; set; }
        /// <summary>
        /// IdentityProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityProviderConfiguration
        /// </summary>
        public Union<Humidifier.HealthLake.FHIRDatastoreTypes.IdentityProviderConfiguration, BaseFunction>? IdentityProviderConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// PreloadDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-preloaddataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PreloadDataConfig
        /// </summary>
        public Union<Humidifier.HealthLake.FHIRDatastoreTypes.PreloadDataConfig, BaseFunction>? PreloadDataConfig { get; set; }
        /// <summary>
        /// SseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-healthlake-fhirdatastore.html#cfn-healthlake-fhirdatastore-sseconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SseConfiguration
        /// </summary>
        public Union<Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration, BaseFunction>? SseConfiguration { get; set; }
    }

    namespace FHIRDatastoreTypes
    {
        public class AnalyticsConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-analyticsconfiguration.html#cfn-healthlake-fhirdatastore-analyticsconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class CreatedAt : Humidifier.Base.BaseSubResource, IHaveNanos_Integer, IHaveSeconds
        {
            /// <summary>
            /// Nanos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-createdat.html#cfn-healthlake-fhirdatastore-createdat-nanos
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Nanos { get; set; }
            /// <summary>
            /// Seconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-createdat.html#cfn-healthlake-fhirdatastore-createdat-seconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Seconds { get; set; }
        }

        public class IdentityProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveAuthorizationStrategy, IHaveIdpLambdaArn, IHaveFineGrainedAuthorizationEnabled_Boolean, IHaveMetadata
        {
            /// <summary>
            /// AuthorizationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-authorizationstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationStrategy { get; set; }
            /// <summary>
            /// IdpLambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-idplambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdpLambdaArn { get; set; }
            /// <summary>
            /// FineGrainedAuthorizationEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-finegrainedauthorizationenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FineGrainedAuthorizationEnabled { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-identityproviderconfiguration.html#cfn-healthlake-fhirdatastore-identityproviderconfiguration-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Metadata { get; set; }
        }

        public class KmsEncryptionConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveCmkType
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-kmsencryptionconfig.html#cfn-healthlake-fhirdatastore-kmsencryptionconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// CmkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-kmsencryptionconfig.html#cfn-healthlake-fhirdatastore-kmsencryptionconfig-cmktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CmkType { get; set; }
        }

        public class NlpConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-nlpconfiguration.html#cfn-healthlake-fhirdatastore-nlpconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class PreloadDataConfig : Humidifier.Base.BaseSubResource, IHavePreloadDataType
        {
            /// <summary>
            /// PreloadDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-preloaddataconfig.html#cfn-healthlake-fhirdatastore-preloaddataconfig-preloaddatatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreloadDataType { get; set; }
        }

        public class ProfileConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfDefaultProfiles
        {
            /// <summary>
            /// DefaultProfiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-profileconfiguration.html#cfn-healthlake-fhirdatastore-profileconfiguration-defaultprofiles
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DefaultProfiles { get; set; }
        }

        public class SseConfiguration : Humidifier.Base.BaseSubResource, IHaveHealthLakeFHIRDatastoreTypesKmsEncryptionConfigKmsEncryptionConfig
        {
            /// <summary>
            /// KmsEncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-healthlake-fhirdatastore-sseconfiguration.html#cfn-healthlake-fhirdatastore-sseconfiguration-kmsencryptionconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: KmsEncryptionConfig
            /// </summary>
            public Union<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig, BaseFunction>? KmsEncryptionConfig { get; set; }
        }
    }
}