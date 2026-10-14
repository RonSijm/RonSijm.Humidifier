namespace Humidifier.DataExchange
{
    using global::System.Collections.Generic;
    using EventActionTypes;

    public class EventAction : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string EventActionId =  "EventActionId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DataExchange.EventAction; }

        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-eventaction.html#cfn-dataexchange-eventaction-action
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Action
        /// </summary>
        [Required]
        public Humidifier.DataExchange.EventActionTypes.Action Action { get; set; }

        /// <summary>
        /// Event
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-eventaction.html#cfn-dataexchange-eventaction-event
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Event
        /// </summary>
        [Required]
        public Humidifier.DataExchange.EventActionTypes.Event Event { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dataexchange-eventaction.html#cfn-dataexchange-eventaction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace EventActionTypes
    {
        public class Action : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExportRevisionToS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-action.html#cfn-dataexchange-eventaction-action-exportrevisiontos3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoExportRevisionToS3RequestDetails
            /// </summary>
            public Humidifier.DataExchange.EventActionTypes.AutoExportRevisionToS3RequestDetails ExportRevisionToS3 { get; set; }
        }

        public class AutoExportRevisionDestinationEntry : Humidifier.Base.BaseSubResource, IHaveBucket
        {
            /// <summary>
            /// KeyPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-autoexportrevisiondestinationentry.html#cfn-dataexchange-eventaction-autoexportrevisiondestinationentry-keypattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPattern { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-autoexportrevisiondestinationentry.html#cfn-dataexchange-eventaction-autoexportrevisiondestinationentry-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
        }

        public class AutoExportRevisionToS3RequestDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Encryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-autoexportrevisiontos3requestdetails.html#cfn-dataexchange-eventaction-autoexportrevisiontos3requestdetails-encryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExportServerSideEncryption
            /// </summary>
            public Humidifier.DataExchange.EventActionTypes.ExportServerSideEncryption Encryption { get; set; }
            /// <summary>
            /// RevisionDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-autoexportrevisiontos3requestdetails.html#cfn-dataexchange-eventaction-autoexportrevisiontos3requestdetails-revisiondestination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AutoExportRevisionDestinationEntry
            /// </summary>
            public Humidifier.DataExchange.EventActionTypes.AutoExportRevisionDestinationEntry RevisionDestination { get; set; }
        }

        public class Event : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RevisionPublished
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-event.html#cfn-dataexchange-eventaction-event-revisionpublished
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RevisionPublished
            /// </summary>
            public Humidifier.DataExchange.EventActionTypes.RevisionPublished RevisionPublished { get; set; }
        }

        public class ExportServerSideEncryption : Humidifier.Base.BaseSubResource, IHaveType, IHaveKmsKeyArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-exportserversideencryption.html#cfn-dataexchange-eventaction-exportserversideencryption-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-exportserversideencryption.html#cfn-dataexchange-eventaction-exportserversideencryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }

        public class RevisionPublished : Humidifier.Base.BaseSubResource, IHaveDataSetId
        {
            /// <summary>
            /// DataSetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dataexchange-eventaction-revisionpublished.html#cfn-dataexchange-eventaction-revisionpublished-datasetid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSetId { get; set; }
        }
    }
}