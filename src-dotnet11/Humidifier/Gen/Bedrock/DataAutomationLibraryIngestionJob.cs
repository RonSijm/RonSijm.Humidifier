namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using DataAutomationLibraryIngestionJobTypes;

    public class DataAutomationLibraryIngestionJob : Humidifier.Base.BaseResource, IHaveTags, IHaveEntityType, IHaveBedrockDataAutomationLibraryIngestionJobTypesOutputConfigurationOutputConfiguration, IHaveOperationType, IHaveLibraryArn
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string JobStatus =  "JobStatus" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.DataAutomationLibraryIngestionJob; }

        /// <summary>
        /// EntityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibraryingestionjob.html#cfn-bedrock-dataautomationlibraryingestionjob-entitytype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EntityType { get; set; }

        /// <summary>
        /// OutputConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibraryingestionjob.html#cfn-bedrock-dataautomationlibraryingestionjob-outputconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OutputConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Bedrock.DataAutomationLibraryIngestionJobTypes.OutputConfiguration, BaseFunction>? OutputConfiguration { get; set; }

        /// <summary>
        /// OperationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibraryingestionjob.html#cfn-bedrock-dataautomationlibraryingestionjob-operationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OperationType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibraryingestionjob.html#cfn-bedrock-dataautomationlibraryingestionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// LibraryArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-dataautomationlibraryingestionjob.html#cfn-bedrock-dataautomationlibraryingestionjob-libraryarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LibraryArn { get; set; }
    }

    namespace DataAutomationLibraryIngestionJobTypes
    {
        public class OutputConfiguration : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-dataautomationlibraryingestionjob-outputconfiguration.html#cfn-bedrock-dataautomationlibraryingestionjob-outputconfiguration-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }
    }
}