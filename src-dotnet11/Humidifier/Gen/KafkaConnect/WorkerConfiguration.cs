namespace Humidifier.KafkaConnect
{
    using global::System.Collections.Generic;

    public class WorkerConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePropertiesFileContent, IHaveDescription, IHaveName
    {
        public class Attributes
        {
            public static string Revision =  "Revision" ;
            public static string WorkerConfigurationArn =  "WorkerConfigurationArn" ;
        }

        public override string AWSTypeName { get => AWS.KafkaConnect.WorkerConfiguration; }

        /// <summary>
        /// PropertiesFileContent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-workerconfiguration.html#cfn-kafkaconnect-workerconfiguration-propertiesfilecontent
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PropertiesFileContent { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-workerconfiguration.html#cfn-kafkaconnect-workerconfiguration-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kafkaconnect-workerconfiguration.html#cfn-kafkaconnect-workerconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}