namespace Humidifier.KafkaConnect
{
    using System.Collections.Generic;

    public class WorkerConfiguration : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Revision =  "Revision" ;
            public static string WorkerConfigurationArn =  "WorkerConfigurationArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::KafkaConnect::WorkerConfiguration";
            }
        }

        /// <summary>
        /// PropertiesFileContent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-workerconfiguration.html#cfn-kafkaconnect-workerconfiguration-propertiesfilecontent
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PropertiesFileContent { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-workerconfiguration.html#cfn-kafkaconnect-workerconfiguration-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-workerconfiguration.html#cfn-kafkaconnect-workerconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-workerconfiguration.html#cfn-kafkaconnect-workerconfiguration-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }
}