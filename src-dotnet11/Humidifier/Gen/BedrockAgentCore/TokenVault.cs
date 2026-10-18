namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using TokenVaultTypes;

    public class TokenVault : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string LastModifiedDate =  "LastModifiedDate" ;
            public static string KmsConfiguration =  "KmsConfiguration" ;
            public static string TokenVaultId =  "TokenVaultId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.TokenVault; }
    }

    namespace TokenVaultTypes
    {
        public class KmsConfiguration : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveKmsKeyArn
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-tokenvault-kmsconfiguration.html#cfn-bedrockagentcore-tokenvault-kmsconfiguration-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-tokenvault-kmsconfiguration.html#cfn-bedrockagentcore-tokenvault-kmsconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }
    }
}