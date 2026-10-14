namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using HubTypes;

    public class Hub : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string HubArn =  "HubArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string HubStatus =  "HubStatus" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Hub; }
        public dynamic HubName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// HubDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hub.html#cfn-sagemaker-hub-hubdisplayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HubDisplayName { get; set; }

        /// <summary>
        /// HubDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hub.html#cfn-sagemaker-hub-hubdescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HubDescription { get; set; }

        [Ignore]
        public dynamic Description { get => HubDescription; set => HubDescription = value; }
        /// <summary>
        /// S3StorageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hub.html#cfn-sagemaker-hub-s3storageconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3StorageConfig
        /// </summary>
        public Humidifier.SageMaker.HubTypes.S3StorageConfig S3StorageConfig { get; set; }
        /// <summary>
        /// HubSearchKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hub.html#cfn-sagemaker-hub-hubsearchkeywords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic HubSearchKeywords { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hub.html#cfn-sagemaker-hub-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace HubTypes
    {
        public class S3StorageConfig : Humidifier.Base.BaseSubResource, IHaveS3OutputPath
        {
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hub-s3storageconfig.html#cfn-sagemaker-hub-s3storageconfig-s3outputpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputPath { get; set; }
        }
    }
}