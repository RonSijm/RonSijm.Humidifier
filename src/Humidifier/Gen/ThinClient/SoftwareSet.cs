namespace Humidifier.ThinClient
{
    using global::System.Collections.Generic;
    using SoftwareSetTypes;

    public class SoftwareSet : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ValidationStatus =  "ValidationStatus" ;
            public static string ReleasedAt =  "ReleasedAt" ;
            public static string Version =  "Version" ;
            public static string Software =  "Software" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ThinClient.SoftwareSet; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-thinclient-softwareset.html#cfn-thinclient-softwareset-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace SoftwareSetTypes
    {
        public class Software : Humidifier.Base.BaseSubResource, IHaveName, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-thinclient-softwareset-software.html#cfn-thinclient-softwareset-software-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-thinclient-softwareset-software.html#cfn-thinclient-softwareset-software-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}