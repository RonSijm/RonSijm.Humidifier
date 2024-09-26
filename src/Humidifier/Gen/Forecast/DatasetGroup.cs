namespace Humidifier.Forecast
{
    using System.Collections.Generic;

    public class DatasetGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomain
    {
        public class Attributes
        {
            public static string DatasetGroupArn =  "DatasetGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.Forecast.DatasetGroup; }
        /// <summary>
        /// DatasetArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-datasetgroup.html#cfn-forecast-datasetgroup-datasetarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DatasetArns { get; set; }
        public dynamic DatasetGroupName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-datasetgroup.html#cfn-forecast-datasetgroup-domain
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Domain { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-forecast-datasetgroup.html#cfn-forecast-datasetgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}