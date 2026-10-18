namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using SecurityRequirementPackTypes;

    public class SecurityRequirementPack : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveDescription, IHaveKmsKeyId, IHaveListOfSecurityAgentSecurityRequirementPackTypesSecurityRequirementSecurityRequirements, IHaveName
    {
        public class Attributes
        {
            public static string PackId =  "PackId" ;
        }

        public override string AWSTypeName { get => AWS.SecurityAgent.SecurityRequirementPack; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-securityrequirementpack.html#cfn-securityagent-securityrequirementpack-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-securityrequirementpack.html#cfn-securityagent-securityrequirementpack-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-securityrequirementpack.html#cfn-securityagent-securityrequirementpack-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// SecurityRequirements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-securityrequirementpack.html#cfn-securityagent-securityrequirementpack-securityrequirements
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SecurityRequirement
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement>, IReadOnlyList<Union<Humidifier.SecurityAgent.SecurityRequirementPackTypes.SecurityRequirement, BaseFunction>>, BaseFunction>? SecurityRequirements { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-securityrequirementpack.html#cfn-securityagent-securityrequirementpack-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SecurityRequirementPackTypes
    {
        public class SecurityRequirement : Humidifier.Base.BaseSubResource, IHaveEvaluation, IHaveDescription, IHaveRemediation, IHaveDomain, IHaveName
        {
            /// <summary>
            /// Evaluation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-securityrequirementpack-securityrequirement.html#cfn-securityagent-securityrequirementpack-securityrequirement-evaluation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Evaluation { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-securityrequirementpack-securityrequirement.html#cfn-securityagent-securityrequirementpack-securityrequirement-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Remediation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-securityrequirementpack-securityrequirement.html#cfn-securityagent-securityrequirementpack-securityrequirement-remediation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Remediation { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-securityrequirementpack-securityrequirement.html#cfn-securityagent-securityrequirementpack-securityrequirement-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-securityrequirementpack-securityrequirement.html#cfn-securityagent-securityrequirementpack-securityrequirement-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}