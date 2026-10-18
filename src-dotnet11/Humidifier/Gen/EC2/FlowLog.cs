namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using FlowLogTypes;

    public class FlowLog : Humidifier.Base.BaseResource, IHaveTags, IHaveLogFormat, IHaveMaxAggregationInterval_Integer, IHaveEC2FlowLogTypesDestinationOptionsDestinationOptions, IHaveResourceType, IHaveLogDestinationType, IHaveResourceId, IHaveListOfEC2FlowLogTypesTagFieldSpecificationTagFieldSpecifications, IHaveDeliverCrossAccountRole, IHaveLogDestination, IHaveLogGroupName, IHaveDeliverLogsPermissionArn, IHaveTrafficType
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.FlowLog; }
        /// <summary>
        /// LogFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-logformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogFormat { get; set; }
        /// <summary>
        /// MaxAggregationInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-maxaggregationinterval
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxAggregationInterval { get; set; }
        /// <summary>
        /// DestinationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-destinationoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DestinationOptions
        /// </summary>
        public Union<Humidifier.EC2.FlowLogTypes.DestinationOptions, BaseFunction>? DestinationOptions { get; set; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceType { get; set; }
        /// <summary>
        /// LogDestinationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-logdestinationtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogDestinationType { get; set; }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-resourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceId { get; set; }
        /// <summary>
        /// TagFieldSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-tagfieldspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagFieldSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.FlowLogTypes.TagFieldSpecification>, IReadOnlyList<Union<Humidifier.EC2.FlowLogTypes.TagFieldSpecification, BaseFunction>>, BaseFunction>? TagFieldSpecifications { get; set; }
        /// <summary>
        /// DeliverCrossAccountRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-delivercrossaccountrole
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeliverCrossAccountRole { get; set; }
        /// <summary>
        /// LogDestination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-logdestination
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogDestination { get; set; }
        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-loggroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogGroupName { get; set; }
        /// <summary>
        /// DeliverLogsPermissionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-deliverlogspermissionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeliverLogsPermissionArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TrafficType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-flowlog.html#cfn-ec2-flowlog-traffictype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrafficType { get; set; }
    }

    namespace FlowLogTypes
    {
        public class DestinationOptions : Humidifier.Base.BaseSubResource, IHavePerHourPartition_Boolean, IHaveHiveCompatiblePartitions_Boolean, IHaveFileFormat
        {
            /// <summary>
            /// PerHourPartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-flowlog-destinationoptions.html#cfn-ec2-flowlog-destinationoptions-perhourpartition
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PerHourPartition { get; set; }
            /// <summary>
            /// HiveCompatiblePartitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-flowlog-destinationoptions.html#cfn-ec2-flowlog-destinationoptions-hivecompatiblepartitions
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? HiveCompatiblePartitions { get; set; }
            /// <summary>
            /// FileFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-flowlog-destinationoptions.html#cfn-ec2-flowlog-destinationoptions-fileformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileFormat { get; set; }
        }

        public class TagFieldSpecification : Humidifier.Base.BaseSubResource, IHaveResourceType, IHaveStringListOfTagKeys
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-flowlog-tagfieldspecification.html#cfn-ec2-flowlog-tagfieldspecification-resourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// TagKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-flowlog-tagfieldspecification.html#cfn-ec2-flowlog-tagfieldspecification-tagkeys
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TagKeys { get; set; }
        }
    }
}