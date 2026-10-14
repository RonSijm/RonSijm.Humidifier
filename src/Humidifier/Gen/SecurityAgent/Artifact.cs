namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;

    public class Artifact : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ArtifactId =  "ArtifactId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityAgent.Artifact; }
        /// <summary>
        /// ArtifactContent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-artifact.html#cfn-securityagent-artifact-artifactcontent
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ArtifactContent { get; set; }

        /// <summary>
        /// ArtifactType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-artifact.html#cfn-securityagent-artifact-artifacttype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ArtifactType { get; set; }

        /// <summary>
        /// FileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-artifact.html#cfn-securityagent-artifact-filename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FileName { get; set; }

        /// <summary>
        /// AgentSpaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-artifact.html#cfn-securityagent-artifact-agentspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AgentSpaceId { get; set; }
    }
}