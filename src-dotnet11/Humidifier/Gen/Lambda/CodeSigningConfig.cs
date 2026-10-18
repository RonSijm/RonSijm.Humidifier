namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using CodeSigningConfigTypes;

    public class CodeSigningConfig : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveLambdaCodeSigningConfigTypesAllowedPublishersAllowedPublishers, IHaveLambdaCodeSigningConfigTypesCodeSigningPoliciesCodeSigningPolicies
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AllowedPublishers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html#cfn-lambda-codesigningconfig-allowedpublishers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AllowedPublishers
        /// </summary>
        [Required]
        public Union<Humidifier.Lambda.CodeSigningConfigTypes.AllowedPublishers, BaseFunction>? AllowedPublishers { get; set; }
        /// <summary>
        /// CodeSigningPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html#cfn-lambda-codesigningconfig-codesigningpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CodeSigningPolicies
        /// </summary>
        public Union<Humidifier.Lambda.CodeSigningConfigTypes.CodeSigningPolicies, BaseFunction>? CodeSigningPolicies { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-codesigningconfig.html#cfn-lambda-codesigningconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CodeSigningConfigTypes
    {
        public class AllowedPublishers : Humidifier.Base.BaseSubResource, IHaveStringListOfSigningProfileVersionArns
        {
            /// <summary>
            /// SigningProfileVersionArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-codesigningconfig-allowedpublishers.html#cfn-lambda-codesigningconfig-allowedpublishers-signingprofileversionarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SigningProfileVersionArns { get; set; }
        }

        public class CodeSigningPolicies : Humidifier.Base.BaseSubResource, IHaveUntrustedArtifactOnDeployment
        {
            /// <summary>
            /// UntrustedArtifactOnDeployment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-codesigningconfig-codesigningpolicies.html#cfn-lambda-codesigningconfig-codesigningpolicies-untrustedartifactondeployment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UntrustedArtifactOnDeployment { get; set; }
        }
    }
}