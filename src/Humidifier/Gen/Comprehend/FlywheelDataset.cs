namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;

    public class FlywheelDataset : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDatasetName, IHaveDatasetType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DatasetS3Uri =  "DatasetS3Uri" ;
            public static string DatasetArn =  "DatasetArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string NumberOfDocuments =  "NumberOfDocuments" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.FlywheelDataset; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheeldataset.html#cfn-comprehend-flywheeldataset-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DatasetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheeldataset.html#cfn-comprehend-flywheeldataset-datasetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatasetName { get; set; }
        /// <summary>
        /// DatasetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheeldataset.html#cfn-comprehend-flywheeldataset-datasettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatasetType { get; set; }

        /// <summary>
        /// FlywheelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheeldataset.html#cfn-comprehend-flywheeldataset-flywheelarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FlywheelArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-flywheeldataset.html#cfn-comprehend-flywheeldataset-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}