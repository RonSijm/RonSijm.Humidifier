namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using CapacityReservationFleetTypes;

    public class CapacityReservationFleet : Humidifier.Base.BaseResource, IHaveTenancy, IHaveTotalTargetCapacity_Integer, IHaveAllocationStrategy, IHaveListOfEC2CapacityReservationFleetTypesTagSpecificationTagSpecifications, IHaveNoRemoveEndDate_Boolean, IHaveListOfEC2CapacityReservationFleetTypesInstanceTypeSpecificationInstanceTypeSpecifications, IHaveRemoveEndDate_Boolean, IHaveInstanceMatchCriteria, IHaveEndDate
    {
        public class Attributes
        {
            public static string CapacityReservationFleetId =  "CapacityReservationFleetId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.CapacityReservationFleet; }
        /// <summary>
        /// Tenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-tenancy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Tenancy { get; set; }
        /// <summary>
        /// TotalTargetCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-totaltargetcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TotalTargetCapacity { get; set; }
        /// <summary>
        /// AllocationStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-allocationstrategy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllocationStrategy { get; set; }
        /// <summary>
        /// TagSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-tagspecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification>, IReadOnlyList<Union<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
        /// <summary>
        /// NoRemoveEndDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-noremoveenddate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NoRemoveEndDate { get; set; }
        /// <summary>
        /// InstanceTypeSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-instancetypespecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: InstanceTypeSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification>, IReadOnlyList<Union<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification, BaseFunction>>, BaseFunction>? InstanceTypeSpecifications { get; set; }
        /// <summary>
        /// RemoveEndDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-removeenddate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RemoveEndDate { get; set; }
        /// <summary>
        /// InstanceMatchCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-instancematchcriteria
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceMatchCriteria { get; set; }
        /// <summary>
        /// EndDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservationfleet.html#cfn-ec2-capacityreservationfleet-enddate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndDate { get; set; }
    }

    namespace CapacityReservationFleetTypes
    {
        public class InstanceTypeSpecification : Humidifier.Base.BaseSubResource, IHavePriority_Integer, IHaveAvailabilityZoneId, IHaveAvailabilityZone, IHaveInstancePlatform, IHaveInstanceType, IHaveWeight_Double, IHaveEbsOptimized_Boolean
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-instancetypespecification.html#cfn-ec2-capacityreservationfleet-instancetypespecification-priority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-instancetypespecification.html#cfn-ec2-capacityreservationfleet-instancetypespecification-availabilityzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-instancetypespecification.html#cfn-ec2-capacityreservationfleet-instancetypespecification-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// InstancePlatform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-instancetypespecification.html#cfn-ec2-capacityreservationfleet-instancetypespecification-instanceplatform
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstancePlatform { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-instancetypespecification.html#cfn-ec2-capacityreservationfleet-instancetypespecification-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-instancetypespecification.html#cfn-ec2-capacityreservationfleet-instancetypespecification-weight
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-instancetypespecification.html#cfn-ec2-capacityreservationfleet-instancetypespecification-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
        }

        public class TagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-tagspecification.html#cfn-ec2-capacityreservationfleet-tagspecification-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservationfleet-tagspecification.html#cfn-ec2-capacityreservationfleet-tagspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }
    }
}