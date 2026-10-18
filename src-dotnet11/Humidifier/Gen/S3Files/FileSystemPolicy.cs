namespace Humidifier.S3Files
{
    using global::System.Collections.Generic;

    public class FileSystemPolicy : Humidifier.Base.BaseResource, IHavePolicy_Json, IHaveFileSystemId
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
        public Union<object, BaseFunction>? Policy { get; set; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystempolicy.html#cfn-s3files-filesystempolicy-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemId { get; set; }
    }
}