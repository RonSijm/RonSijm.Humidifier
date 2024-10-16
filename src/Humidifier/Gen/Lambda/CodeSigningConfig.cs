namespace Humidifier.Lambda
{
    using System.Collections.Generic;
    using CodeSigningConfigTypes;

    public class CodeSigningConfig : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string CodeSigningConfigId =  "CodeSigningConfigId" ;
            public static string CodeSigningConfigArn =  "CodeSigningConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.CodeSigningConfig; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html#cfn-lambda-codesigningconfig-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// AllowedPublishers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html#cfn-lambda-codesigningconfig-allowedpublishers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AllowedPublishers
        /// </summary>
        [Required]
        public Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers AllowedPublishers { get; set; }
        /// <summary>
        /// CodeSigningPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html#cfn-lambda-codesigningconfig-codesigningpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CodeSigningPolicies
        /// </summary>
        public Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies CodeSigningPolicies { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html#cfn-lambda-codesigningconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace CodeSigningConfigTypes
    {
        public class AllowedPublishers : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SigningProfileVersionArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-codesigningconfig-allowedpublishers.html#cfn-lambda-codesigningconfig-allowedpublishers-signingprofileversionarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SigningProfileVersionArns { get; set; }
        }

        public class CodeSigningPolicies : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UntrustedArtifactOnDeployment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-codesigningconfig-codesigningpolicies.html#cfn-lambda-codesigningconfig-codesigningpolicies-untrustedartifactondeployment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UntrustedArtifactOnDeployment { get; set; }
        }
    }
}