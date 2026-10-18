namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;

    public class SourceCredential : Humidifier.Base.BaseResource, IHaveServerType, IHaveUsername, IHaveToken, IHaveAuthType
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.SourceCredential; }

        /// <summary>
        /// ServerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-servertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServerType { get; set; }
        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-username
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Username { get; set; }

        /// <summary>
        /// Token
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-token
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Token { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-authtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthType { get; set; }
    }
}