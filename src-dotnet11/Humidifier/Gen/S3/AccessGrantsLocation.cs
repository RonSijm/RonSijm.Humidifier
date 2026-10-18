namespace Humidifier.S3
{
    using global::System.Collections.Generic;

    public class AccessGrantsLocation : Humidifier.Base.BaseResource, IHaveTags, IHaveLocationScope, IHaveIamRoleArn
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
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LocationScope { get; set; }

        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrantslocation.html#cfn-s3-accessgrantslocation-iamrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IamRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-accessgrantslocation.html#cfn-s3-accessgrantslocation-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}