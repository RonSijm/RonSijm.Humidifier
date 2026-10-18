namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;

    public class GuardrailVersion : Humidifier.Base.BaseResource, IHaveGuardrailIdentifier, IHaveDescription
    {
        public class Attributes
        {
            public static string GuardrailId =  "GuardrailId" ;
            public static string GuardrailArn =  "GuardrailArn" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.GuardrailVersion; }

        /// <summary>
        /// GuardrailIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrailversion.html#cfn-bedrock-guardrailversion-guardrailidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GuardrailIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrailversion.html#cfn-bedrock-guardrailversion-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
    }
}