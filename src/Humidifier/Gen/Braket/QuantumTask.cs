namespace Humidifier.Braket
{
    using global::System.Collections.Generic;
    using QuantumTaskTypes;

    public class QuantumTask : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string QuantumTaskArn =  "QuantumTaskArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string OutputS3Directory =  "OutputS3Directory" ;
            public static string ActionMetadata =  "ActionMetadata" ;
        }

        public override string AWSTypeName { get => AWS.Braket.QuantumTask; }

        /// <summary>
        /// DeviceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-quantumtask.html#cfn-braket-quantumtask-devicearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeviceArn { get; set; }

        /// <summary>
        /// OutputS3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-quantumtask.html#cfn-braket-quantumtask-outputs3bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OutputS3Bucket { get; set; }

        /// <summary>
        /// Shots
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-quantumtask.html#cfn-braket-quantumtask-shots
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Shots { get; set; }
        /// <summary>
        /// ExperimentalCapabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-quantumtask.html#cfn-braket-quantumtask-experimentalcapabilities
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExperimentalCapabilities
        /// </summary>
        public Humidifier.Braket.QuantumTaskTypes.ExperimentalCapabilities ExperimentalCapabilities { get; set; }
        /// <summary>
        /// Associations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-quantumtask.html#cfn-braket-quantumtask-associations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Association
        /// </summary>
        public List<Humidifier.Braket.QuantumTaskTypes.Association> Associations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-quantumtask.html#cfn-braket-quantumtask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// DeviceParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-braket-quantumtask.html#cfn-braket-quantumtask-deviceparameters
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeviceParameters { get; set; }
    }

    namespace QuantumTaskTypes
    {
        public class ActionMetadata : Humidifier.Base.BaseSubResource, IHaveActionType
        {
            /// <summary>
            /// ActionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-quantumtask-actionmetadata.html#cfn-braket-quantumtask-actionmetadata-actiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionType { get; set; }
        }

        public class Association : Humidifier.Base.BaseSubResource, IHaveType, IHaveArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-quantumtask-association.html#cfn-braket-quantumtask-association-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-quantumtask-association.html#cfn-braket-quantumtask-association-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class ExperimentalCapabilities : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-braket-quantumtask-experimentalcapabilities.html#cfn-braket-quantumtask-experimentalcapabilities-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}