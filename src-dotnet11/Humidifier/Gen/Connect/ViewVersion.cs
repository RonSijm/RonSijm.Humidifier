namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class ViewVersion : Humidifier.Base.BaseResource, IHaveViewArn, IHaveVersionDescription, IHaveViewContentSha256
    {
        public class Attributes
        {
            public static string ViewVersionArn =  "ViewVersionArn" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName { get => AWS.Connect.ViewVersion; }

        /// <summary>
        /// ViewArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-viewversion.html#cfn-connect-viewversion-viewarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ViewArn { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-viewversion.html#cfn-connect-viewversion-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionDescription { get; set; }
        /// <summary>
        /// ViewContentSha256
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-viewversion.html#cfn-connect-viewversion-viewcontentsha256
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ViewContentSha256 { get; set; }
    }
}