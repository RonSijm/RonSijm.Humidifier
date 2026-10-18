namespace Humidifier.Rekognition
{
    using global::System.Collections.Generic;

    public class Dataset : Humidifier.Base.BaseResource, IHaveTags, IHaveProjectArn, IHaveDatasetType
    {
        public class Attributes
        {
            public static string DatasetArn =  "DatasetArn" ;
        }

        public override string AWSTypeName { get => AWS.Rekognition.Dataset; }
        /// <summary>
        /// ProjectArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-dataset.html#cfn-rekognition-dataset-projectarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectArn { get; set; }

        /// <summary>
        /// DatasetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-dataset.html#cfn-rekognition-dataset-datasettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatasetType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-dataset.html#cfn-rekognition-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}