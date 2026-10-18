namespace Humidifier.ServerlessRepo
{
    using global::System.Collections.Generic;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveSourceCodeUrl, IHaveDescription, IHaveSpdxLicenseId, IHaveReadmeBody, IHaveHomePageUrl, IHaveLicenseBody, IHaveAuthor, IHaveStringListOfLabels, IHaveTemplateBody, IHaveName, IHaveSemanticVersion
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string IsVerifiedAuthor =  "IsVerifiedAuthor" ;
            public static string ApplicationId =  "ApplicationId" ;
        }

        public override string AWSTypeName { get => AWS.ServerlessRepo.Application; }
        /// <summary>
        /// SourceCodeUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-sourcecodeurl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceCodeUrl { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SpdxLicenseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-spdxlicenseid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SpdxLicenseId { get; set; }
        /// <summary>
        /// ReadmeBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-readmebody
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReadmeBody { get; set; }
        /// <summary>
        /// HomePageUrl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-homepageurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HomePageUrl { get; set; }
        /// <summary>
        /// LicenseBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-licensebody
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LicenseBody { get; set; }

        /// <summary>
        /// Author
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-author
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Author { get; set; }
        /// <summary>
        /// Labels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-labels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Labels { get; set; }
        /// <summary>
        /// TemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-templatebody
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateBody { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SemanticVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-serverlessrepo-application.html#cfn-serverlessrepo-application-semanticversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SemanticVersion { get; set; }
    }
}