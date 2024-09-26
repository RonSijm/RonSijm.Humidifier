namespace Humidifier.S3
{
    using System.Collections.Generic;

    public class AccessGrantsLocation : Humidifier.Base.BaseResource, IHaveTags, IHaveIamRoleArn
    {
        public class Attributes
        {
            public static string AccessGrantsLocationArn =  "AccessGrantsLocationArn" ;
            public static string AccessGrantsLocationId =  "AccessGrantsLocationId" ;
        }

        public override string AWSTypeName { get => AWS.S3.AccessGrantsLocation; }
        /// <summary>
        /// LocationScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrantslocation.html#cfn-s3-accessgrantslocation-locationscope
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LocationScope { get; set; }
        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrantslocation.html#cfn-s3-accessgrantslocation-iamrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IamRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrantslocation.html#cfn-s3-accessgrantslocation-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}