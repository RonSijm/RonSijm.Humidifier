namespace Humidifier.Bedrock
{
    using System.Collections.Generic;

    public class GuardrailVersion : Humidifier.Resource
    {
        public class Attributes
        {
            public static string GuardrailId =  "GuardrailId" ;
            public static string GuardrailArn =  "GuardrailArn" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Bedrock::GuardrailVersion";
            }
        }

        /// <summary>
        /// GuardrailIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrailversion.html#cfn-bedrock-guardrailversion-guardrailidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GuardrailIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrailversion.html#cfn-bedrock-guardrailversion-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
    }
}