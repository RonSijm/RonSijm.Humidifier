namespace Humidifier.Batch
{
    using global::System.Collections.Generic;
    using ServiceEnvironmentTypes;

    public class ServiceEnvironment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveServiceEnvironmentName, IHaveState, IHaveServiceEnvironmentType, IHaveListOfBatchServiceEnvironmentTypesCapacityLimitCapacityLimits, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string ServiceEnvironmentArn =  "ServiceEnvironmentArn" ;
        }

        public override string AWSTypeName { get => AWS.Batch.ServiceEnvironment; }
        public Union<string, BaseFunction>? ServiceEnvironmentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }

        /// <summary>
        /// ServiceEnvironmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-serviceenvironmenttype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceEnvironmentType { get; set; }

        /// <summary>
        /// CapacityLimits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-capacitylimits
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CapacityLimit
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit>, IReadOnlyList<Union<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit, BaseFunction>>, BaseFunction>? CapacityLimits { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-serviceenvironment.html#cfn-batch-serviceenvironment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ServiceEnvironmentTypes
    {
        public class CapacityLimit : Humidifier.Base.BaseSubResource, IHaveCapacityUnit, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// CapacityUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-serviceenvironment-capacitylimit.html#cfn-batch-serviceenvironment-capacitylimit-capacityunit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityUnit { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-serviceenvironment-capacitylimit.html#cfn-batch-serviceenvironment-capacitylimit-maxcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }
    }
}