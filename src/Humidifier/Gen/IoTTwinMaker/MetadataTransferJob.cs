namespace Humidifier.IoTTwinMaker
{
    using global::System.Collections.Generic;
    using MetadataTransferJobTypes;

    public class MetadataTransferJob : Humidifier.Base.BaseResource, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string UpdateDateTime =  "UpdateDateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTTwinMaker.MetadataTransferJob; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-metadatatransferjob.html#cfn-iottwinmaker-metadatatransferjob-destination
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DestinationConfiguration
        /// </summary>
        [Required]
        public Humidifier.IoTTwinMaker.MetadataTransferJobTypes.DestinationConfiguration Destination { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-metadatatransferjob.html#cfn-iottwinmaker-metadatatransferjob-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// MetadataTransferJobId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-metadatatransferjob.html#cfn-iottwinmaker-metadatatransferjob-metadatatransferjobid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MetadataTransferJobId { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-metadatatransferjob.html#cfn-iottwinmaker-metadatatransferjob-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: SourceConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.SourceConfiguration> Sources { get; set; }
    }

    namespace MetadataTransferJobTypes
    {
        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-metadatatransferjob-destinationconfiguration.html#cfn-iottwinmaker-metadatatransferjob-destinationconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-metadatatransferjob-destinationconfiguration.html#cfn-iottwinmaker-metadatatransferjob-destinationconfiguration-s3configuration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration S3Configuration { get; set; }
        }

        public class MetadataTransferJobStatus : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-metadatatransferjob-metadatatransferjobstatus.html#cfn-iottwinmaker-metadatatransferjob-metadatatransferjobstatus-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveLocation
        {
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-metadatatransferjob-s3destinationconfiguration.html#cfn-iottwinmaker-metadatatransferjob-s3destinationconfiguration-location
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Location { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iottwinmaker-metadatatransferjob-sourceconfiguration.html#cfn-iottwinmaker-metadatatransferjob-sourceconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }
    }
}