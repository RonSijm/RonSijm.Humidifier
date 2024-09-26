namespace Humidifier.S3
{
    using System.Collections.Generic;

    public class AccessGrantsInstance : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string AccessGrantsInstanceArn =  "AccessGrantsInstanceArn" ;
            public static string AccessGrantsInstanceId =  "AccessGrantsInstanceId" ;
        }

        public override string AWSTypeName { get => AWS.S3.AccessGrantsInstance; }
        /// <summary>
        /// IdentityCenterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrantsinstance.html#cfn-s3-accessgrantsinstance-identitycenterarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityCenterArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrantsinstance.html#cfn-s3-accessgrantsinstance-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}