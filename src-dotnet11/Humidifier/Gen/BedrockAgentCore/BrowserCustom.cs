namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using BrowserCustomTypes;

    public class BrowserCustom : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveExecutionRoleArn, IHaveDescription, IHaveBedrockAgentCoreBrowserCustomTypesRecordingConfigRecordingConfig, IHaveListOfBedrockAgentCoreBrowserCustomTypesCertificateCertificates, IHaveListOfBedrockAgentCoreBrowserCustomTypesBrowserEnterprisePolicyEnterprisePolicies, IHaveBedrockAgentCoreBrowserCustomTypesBrowserNetworkConfigurationNetworkConfiguration, IHaveBedrockAgentCoreBrowserCustomTypesBrowserSigningBrowserSigning, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string BrowserId =  "BrowserId" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string BrowserArn =  "BrowserArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FailureReason =  "FailureReason" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.BrowserCustom; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RecordingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-recordingconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RecordingConfig
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.RecordingConfig, BaseFunction>? RecordingConfig { get; set; }
        /// <summary>
        /// Certificates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-certificates
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Certificate
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.Certificate, BaseFunction>>, BaseFunction>? Certificates { get; set; }
        /// <summary>
        /// EnterprisePolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-enterprisepolicies
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: BrowserEnterprisePolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserEnterprisePolicy, BaseFunction>>, BaseFunction>? EnterprisePolicies { get; set; }

        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-networkconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: BrowserNetworkConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserNetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// BrowserSigning
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-browsersigning
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BrowserSigning
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.BrowserSigning, BaseFunction>? BrowserSigning { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-browsercustom.html#cfn-bedrockagentcore-browsercustom-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace BrowserCustomTypes
    {
        public class BrowserEnterprisePolicy : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockAgentCoreBrowserCustomTypesS3LocationLocation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-browserenterprisepolicy.html#cfn-bedrockagentcore-browsercustom-browserenterprisepolicy-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-browserenterprisepolicy.html#cfn-bedrockagentcore-browsercustom-browserenterprisepolicy-location
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location, BaseFunction>? Location { get; set; }
        }

        public class BrowserNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreBrowserCustomTypesVpcConfigVpcConfig, IHaveNetworkMode
        {
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-browsernetworkconfiguration.html#cfn-bedrockagentcore-browsercustom-browsernetworkconfiguration-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
            /// <summary>
            /// NetworkMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-browsernetworkconfiguration.html#cfn-bedrockagentcore-browsercustom-browsernetworkconfiguration-networkmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkMode { get; set; }
        }

        public class BrowserSigning : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-browsersigning.html#cfn-bedrockagentcore-browsercustom-browsersigning-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class Certificate : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreBrowserCustomTypesCertificateLocationCertificateLocation
        {
            /// <summary>
            /// CertificateLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-certificate.html#cfn-bedrockagentcore-browsercustom-certificate-certificatelocation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CertificateLocation
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.CertificateLocation, BaseFunction>? CertificateLocation { get; set; }
        }

        public class CertificateLocation : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-certificatelocation.html#cfn-bedrockagentcore-browsercustom-certificatelocation-secretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class RecordingConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveBedrockAgentCoreBrowserCustomTypesS3LocationS3Location
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-recordingconfig.html#cfn-bedrockagentcore-browsercustom-recordingconfig-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-recordingconfig.html#cfn-bedrockagentcore-browsercustom-recordingconfig-s3location
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.BrowserCustomTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-s3location.html#cfn-bedrockagentcore-browsercustom-s3location-bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-s3location.html#cfn-bedrockagentcore-browsercustom-s3location-prefix
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-vpcconfig.html#cfn-bedrockagentcore-browsercustom-vpcconfig-securitygroups
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-browsercustom-vpcconfig.html#cfn-bedrockagentcore-browsercustom-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }
    }
}