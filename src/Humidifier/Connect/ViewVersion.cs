namespace Humidifier.Connect
{
    using System.Collections.Generic;

    public class ViewVersion : Humidifier.Resource
    {
        public class Attributes
        {
            public static string ViewVersionArn =  "ViewVersionArn" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Connect::ViewVersion";
            }
        }

        /// <summary>
        /// ViewArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-viewversion.html#cfn-connect-viewversion-viewarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ViewArn { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-viewversion.html#cfn-connect-viewversion-versiondescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionDescription { get; set; }
        /// <summary>
        /// ViewContentSha256
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-viewversion.html#cfn-connect-viewversion-viewcontentsha256
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ViewContentSha256 { get; set; }
    }
}