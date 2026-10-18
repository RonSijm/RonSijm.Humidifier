namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using NetworkMigrationDefinitionTypes;

    public class NetworkMigrationDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringDictionaryOfScopeTags, IHaveDescription, IHaveMGNNetworkMigrationDefinitionTypesTargetS3ConfigurationTargetS3Configuration, IHaveTargetDeployment, IHaveListOfMGNNetworkMigrationDefinitionTypesSourceConfigurationSourceConfigurations, IHaveMGNNetworkMigrationDefinitionTypesTargetNetworkTargetNetwork, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string NetworkMigrationDefinitionID =  "NetworkMigrationDefinitionID" ;
        }

        public override string AWSTypeName { get => AWS.MGN.NetworkMigrationDefinition; }
        /// <summary>
        /// ScopeTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-networkmigrationdefinition.html#cfn-mgn-networkmigrationdefinition-scopetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ScopeTags { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-networkmigrationdefinition.html#cfn-mgn-networkmigrationdefinition-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// TargetS3Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-networkmigrationdefinition.html#cfn-mgn-networkmigrationdefinition-targets3configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TargetS3Configuration
        /// </summary>
        [Required]
        public Union<Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetS3Configuration, BaseFunction>? TargetS3Configuration { get; set; }
        /// <summary>
        /// TargetDeployment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-networkmigrationdefinition.html#cfn-mgn-networkmigrationdefinition-targetdeployment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetDeployment { get; set; }

        /// <summary>
        /// SourceConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-networkmigrationdefinition.html#cfn-mgn-networkmigrationdefinition-sourceconfigurations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SourceConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration>, IReadOnlyList<Union<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration, BaseFunction>>, BaseFunction>? SourceConfigurations { get; set; }

        /// <summary>
        /// TargetNetwork
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-networkmigrationdefinition.html#cfn-mgn-networkmigrationdefinition-targetnetwork
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TargetNetwork
        /// </summary>
        [Required]
        public Union<Humidifier.MGN.NetworkMigrationDefinitionTypes.TargetNetwork, BaseFunction>? TargetNetwork { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-networkmigrationdefinition.html#cfn-mgn-networkmigrationdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace NetworkMigrationDefinitionTypes
    {
        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveMGNNetworkMigrationDefinitionTypesSourceS3ConfigurationSourceS3Configuration, IHaveSourceEnvironment
        {
            /// <summary>
            /// SourceS3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-sourceconfiguration.html#cfn-mgn-networkmigrationdefinition-sourceconfiguration-sources3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceS3Configuration
            /// </summary>
            public Union<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration, BaseFunction>? SourceS3Configuration { get; set; }
            /// <summary>
            /// SourceEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-sourceconfiguration.html#cfn-mgn-networkmigrationdefinition-sourceconfiguration-sourceenvironment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceEnvironment { get; set; }
        }

        public class SourceS3Configuration : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key, IHaveS3BucketOwner
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-sources3configuration.html#cfn-mgn-networkmigrationdefinition-sources3configuration-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-sources3configuration.html#cfn-mgn-networkmigrationdefinition-sources3configuration-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-sources3configuration.html#cfn-mgn-networkmigrationdefinition-sources3configuration-s3bucketowner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketOwner { get; set; }
        }

        public class TargetNetwork : Humidifier.Base.BaseSubResource, IHaveInboundCidr, IHaveOutboundCidr, IHaveTopology, IHaveInspectionCidr
        {
            /// <summary>
            /// InboundCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-targetnetwork.html#cfn-mgn-networkmigrationdefinition-targetnetwork-inboundcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundCidr { get; set; }
            /// <summary>
            /// OutboundCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-targetnetwork.html#cfn-mgn-networkmigrationdefinition-targetnetwork-outboundcidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutboundCidr { get; set; }
            /// <summary>
            /// Topology
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-targetnetwork.html#cfn-mgn-networkmigrationdefinition-targetnetwork-topology
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Topology { get; set; }
            /// <summary>
            /// InspectionCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-targetnetwork.html#cfn-mgn-networkmigrationdefinition-targetnetwork-inspectioncidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InspectionCidr { get; set; }
        }

        public class TargetS3Configuration : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3BucketOwner
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-targets3configuration.html#cfn-mgn-networkmigrationdefinition-targets3configuration-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-networkmigrationdefinition-targets3configuration.html#cfn-mgn-networkmigrationdefinition-targets3configuration-s3bucketowner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketOwner { get; set; }
        }
    }
}