namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using KeyValueStoreTypes;

    public class KeyValueStore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveComment
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFront.KeyValueStore; }
        /// <summary>
        /// Comment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-keyvaluestore.html#cfn-cloudfront-keyvaluestore-comment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Comment { get; set; }
        /// <summary>
        /// ImportSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-keyvaluestore.html#cfn-cloudfront-keyvaluestore-importsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImportSource
        /// </summary>
        public Humidifier.CloudFront.KeyValueStoreTypes.ImportSource ImportSource { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace KeyValueStoreTypes
    {
        public class ImportSource : Humidifier.Base.BaseSubResource, IHaveSourceArn, IHaveSourceType
        {
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-keyvaluestore-importsource.html#cfn-cloudfront-keyvaluestore-importsource-sourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceArn { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-keyvaluestore-importsource.html#cfn-cloudfront-keyvaluestore-importsource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
        }
    }
}