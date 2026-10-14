namespace Humidifier.S3Files
{
    using global::System.Collections.Generic;

    public class FileSystemPolicy : Humidifier.Base.BaseResource, IHavePolicy, IHaveFileSystemId
    {
        public override string AWSTypeName { get => AWS.S3Files.FileSystemPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystempolicy.html#cfn-s3files-filesystempolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Policy { get; set; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystempolicy.html#cfn-s3files-filesystempolicy-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FileSystemId { get; set; }
    }
}