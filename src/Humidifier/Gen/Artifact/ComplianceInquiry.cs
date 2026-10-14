namespace Humidifier.Artifact
{
    using global::System.Collections.Generic;

    public class ComplianceInquiry : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string InputSource =  "InputSource" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string SupportMode =  "SupportMode" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Name =  "Name" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.Artifact.ComplianceInquiry; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-artifact-complianceinquiry.html#cfn-artifact-complianceinquiry-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}