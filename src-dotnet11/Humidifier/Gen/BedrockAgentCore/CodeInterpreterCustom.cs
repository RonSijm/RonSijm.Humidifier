namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using CodeInterpreterCustomTypes;

    public class CodeInterpreterCustom : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveExecutionRoleArn, IHaveDescription, IHaveListOfBedrockAgentCoreCodeInterpreterCustomTypesCertificateCertificates, IHaveBedrockAgentCoreCodeInterpreterCustomTypesCodeInterpreterNetworkConfigurationNetworkConfiguration, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string FailureReason =  "FailureReason" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string CodeInterpreterArn =  "CodeInterpreterArn" ;
            public static string CodeInterpreterId =  "CodeInterpreterId" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.CodeInterpreterCustom; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-codeinterpretercustom.html#cfn-bedrockagentcore-codeinterpretercustom-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-codeinterpretercustom.html#cfn-bedrockagentcore-codeinterpretercustom-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Certificates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-codeinterpretercustom.html#cfn-bedrockagentcore-codeinterpretercustom-certificates
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Certificate
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.Certificate, BaseFunction>>, BaseFunction>? Certificates { get; set; }

        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-codeinterpretercustom.html#cfn-bedrockagentcore-codeinterpretercustom-networkconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: CodeInterpreterNetworkConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CodeInterpreterNetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-codeinterpretercustom.html#cfn-bedrockagentcore-codeinterpretercustom-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CodeInterpreterCustomTypes
    {
        public class Certificate : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreCodeInterpreterCustomTypesCertificateLocationCertificateLocation
        {
            /// <summary>
            /// CertificateLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-codeinterpretercustom-certificate.html#cfn-bedrockagentcore-codeinterpretercustom-certificate-certificatelocation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CertificateLocation
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.CertificateLocation, BaseFunction>? CertificateLocation { get; set; }
        }

        public class CertificateLocation : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-codeinterpretercustom-certificatelocation.html#cfn-bedrockagentcore-codeinterpretercustom-certificatelocation-secretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class CodeInterpreterNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreCodeInterpreterCustomTypesVpcConfigVpcConfig, IHaveNetworkMode
        {
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-codeinterpretercustom-codeinterpreternetworkconfiguration.html#cfn-bedrockagentcore-codeinterpretercustom-codeinterpreternetworkconfiguration-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CodeInterpreterCustomTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
            /// <summary>
            /// NetworkMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-codeinterpretercustom-codeinterpreternetworkconfiguration.html#cfn-bedrockagentcore-codeinterpretercustom-codeinterpreternetworkconfiguration-networkmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkMode { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-codeinterpretercustom-vpcconfig.html#cfn-bedrockagentcore-codeinterpretercustom-vpcconfig-securitygroups
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-codeinterpretercustom-vpcconfig.html#cfn-bedrockagentcore-codeinterpretercustom-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }
    }
}