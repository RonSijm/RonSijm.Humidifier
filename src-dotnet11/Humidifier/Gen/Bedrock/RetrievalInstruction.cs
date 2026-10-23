namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using RetrievalInstructionTypes;

    public class RetrievalInstruction : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveCustomerEncryptionKeyArn, IHaveBedrockRetrievalInstructionTypesInstructionInstruction, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastTransitionStatus =  "LastTransitionStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string RetrievalInstructionId =  "RetrievalInstructionId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.RetrievalInstruction; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-retrievalinstruction.html#cfn-bedrock-retrievalinstruction-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// CustomerEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-retrievalinstruction.html#cfn-bedrock-retrievalinstruction-customerencryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Instruction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-retrievalinstruction.html#cfn-bedrock-retrievalinstruction-instruction
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Instruction
        /// </summary>
        [Required]
        public Union<Humidifier.Bedrock.RetrievalInstructionTypes.Instruction, BaseFunction>? Instruction { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-retrievalinstruction.html#cfn-bedrock-retrievalinstruction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RetrievalInstructionTypes
    {
        public class Instruction : Humidifier.Base.BaseSubResource, IHaveRetrievalGuidance, IHavePersona, IHaveAnswerFormat, IHaveAnswerPolicy
        {
            /// <summary>
            /// RetrievalGuidance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-retrievalinstruction-instruction.html#cfn-bedrock-retrievalinstruction-instruction-retrievalguidance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RetrievalGuidance { get; set; }
            /// <summary>
            /// Persona
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-retrievalinstruction-instruction.html#cfn-bedrock-retrievalinstruction-instruction-persona
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Persona { get; set; }
            /// <summary>
            /// AnswerFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-retrievalinstruction-instruction.html#cfn-bedrock-retrievalinstruction-instruction-answerformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerFormat { get; set; }
            /// <summary>
            /// AnswerPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-retrievalinstruction-instruction.html#cfn-bedrock-retrievalinstruction-instruction-answerpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerPolicy { get; set; }
        }
    }
}