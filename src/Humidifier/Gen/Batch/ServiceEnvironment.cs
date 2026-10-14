namespace Humidifier.Batch
{
    using global::System.Collections.Generic;
    using ServiceEnvironmentTypes;

    public class ServiceEnvironment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveState
    {
        public class Attributes
        {
            public static string ServiceEnvironmentArn =  "ServiceEnvironmentArn" ;
        }

        public override string AWSTypeName { get => AWS.Batch.ServiceEnvironment; }
        public dynamic ServiceEnvironmentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic State { get; set; }

        /// <summary>
        /// ServiceEnvironmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-serviceenvironmenttype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceEnvironmentType { get; set; }

        /// <summary>
        /// CapacityLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-capacitylimits
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CapacityLimit
        /// </summary>
        [Required]
        public List<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> CapacityLimits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace ServiceEnvironmentTypes
    {
        public class CapacityLimit : Humidifier.Base.BaseSubResource, IHaveMaxCapacity
        {
            /// <summary>
            /// CapacityUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-serviceenvironment-capacitylimit.html#cfn-batch-serviceenvironment-capacitylimit-capacityunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityUnit { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-serviceenvironment-capacitylimit.html#cfn-batch-serviceenvironment-capacitylimit-maxcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCapacity { get; set; }
        }
    }
}