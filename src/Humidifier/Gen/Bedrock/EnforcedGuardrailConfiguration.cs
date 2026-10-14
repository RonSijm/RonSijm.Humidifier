namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using EnforcedGuardrailConfigurationTypes;

    public class EnforcedGuardrailConfiguration : Humidifier.Base.BaseResource, IHaveGuardrailIdentifier, IHaveGuardrailVersion
    {
        public class Attributes
        {
            public static string GuardrailId =  "GuardrailId" ;
            public static string UpdatedBy =  "UpdatedBy" ;
            public static string Owner =  "Owner" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string GuardrailArn =  "GuardrailArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ConfigId =  "ConfigId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.EnforcedGuardrailConfiguration; }

        /// <summary>
        /// GuardrailIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-enforcedguardrailconfiguration.html#cfn-bedrock-enforcedguardrailconfiguration-guardrailidentifier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GuardrailIdentifier { get; set; }

        /// <summary>
        /// GuardrailVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-enforcedguardrailconfiguration.html#cfn-bedrock-enforcedguardrailconfiguration-guardrailversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GuardrailVersion { get; set; }
        /// <summary>
        /// ModelEnforcement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-enforcedguardrailconfiguration.html#cfn-bedrock-enforcedguardrailconfiguration-modelenforcement
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ModelEnforcement
        /// </summary>
        public Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.ModelEnforcement ModelEnforcement { get; set; }
        /// <summary>
        /// SelectiveContentGuarding
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-enforcedguardrailconfiguration.html#cfn-bedrock-enforcedguardrailconfiguration-selectivecontentguarding
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SelectiveContentGuarding
        /// </summary>
        public Humidifier.Bedrock.EnforcedGuardrailConfigurationTypes.SelectiveContentGuarding SelectiveContentGuarding { get; set; }
    }

    namespace EnforcedGuardrailConfigurationTypes
    {
        public class ModelEnforcement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExcludedModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-enforcedguardrailconfiguration-modelenforcement.html#cfn-bedrock-enforcedguardrailconfiguration-modelenforcement-excludedmodels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedModels { get; set; }
            /// <summary>
            /// IncludedModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-enforcedguardrailconfiguration-modelenforcement.html#cfn-bedrock-enforcedguardrailconfiguration-modelenforcement-includedmodels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedModels { get; set; }
        }

        public class SelectiveContentGuarding : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Messages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-enforcedguardrailconfiguration-selectivecontentguarding.html#cfn-bedrock-enforcedguardrailconfiguration-selectivecontentguarding-messages
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Messages { get; set; }
            /// <summary>
            /// System
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-enforcedguardrailconfiguration-selectivecontentguarding.html#cfn-bedrock-enforcedguardrailconfiguration-selectivecontentguarding-system
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic System { get; set; }
        }
    }
}