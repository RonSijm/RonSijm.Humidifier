namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using CapacityReservationTypes;

    public class CapacityReservation : Humidifier.Base.BaseResource, IHaveTenancy, IHaveEndDateType, IHaveListOfEC2CapacityReservationTypesTagSpecificationTagSpecifications, IHaveUnusedReservationBillingOwnerId, IHaveAvailabilityZoneId, IHaveAvailabilityZone, IHaveEndDate, IHaveEbsOptimized_Boolean, IHaveOutPostArn, IHaveInstanceCount_Integer, IHavePlacementGroupArn, IHaveInstancePlatform, IHaveInstanceType, IHaveEphemeralStorage_Boolean, IHaveInstanceMatchCriteria
    {
        public class Attributes
        {
            public static string Tenancy =  "Tenancy" ;
            public static string CapacityReservationFleetId =  "CapacityReservationFleetId" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string TotalInstanceCount =  "TotalInstanceCount" ;
            public static string CreateDate =  "CreateDate" ;
            public static string StartDate =  "StartDate" ;
            public static string CapacityReservationArn =  "CapacityReservationArn" ;
            public static string DeliveryPreference =  "DeliveryPreference" ;
            public static string CommitmentInfo =  "CommitmentInfo" ;
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string AvailableInstanceCount =  "AvailableInstanceCount" ;
            public static string ReservationType =  "ReservationType" ;
            public static string Id =  "Id" ;
            public static string CapacityAllocationSet =  "CapacityAllocationSet" ;
            public static string InstanceType =  "InstanceType" ;
        }

        public override string AWSTypeName { get => AWS.EC2.CapacityReservation; }
        /// <summary>
        /// Tenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-tenancy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Tenancy { get; set; }
        /// <summary>
        /// EndDateType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-enddatetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndDateType { get; set; }
        /// <summary>
        /// TagSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-tagspecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.CapacityReservationTypes.TagSpecification>, IReadOnlyList<Union<Humidifier.EC2.CapacityReservationTypes.TagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
        /// <summary>
        /// UnusedReservationBillingOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-unusedreservationbillingownerid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UnusedReservationBillingOwnerId { get; set; }
        /// <summary>
        /// AvailabilityZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-availabilityzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// EndDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-enddate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndDate { get; set; }
        /// <summary>
        /// EbsOptimized
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-ebsoptimized
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EbsOptimized { get; set; }
        /// <summary>
        /// OutPostArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-outpostarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutPostArn { get; set; }

        /// <summary>
        /// InstanceCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-instancecount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? InstanceCount { get; set; }
        /// <summary>
        /// PlacementGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-placementgrouparn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlacementGroupArn { get; set; }

        /// <summary>
        /// InstancePlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-instanceplatform
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstancePlatform { get; set; }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-instancetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// EphemeralStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-ephemeralstorage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EphemeralStorage { get; set; }
        /// <summary>
        /// InstanceMatchCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html#cfn-ec2-capacityreservation-instancematchcriteria
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceMatchCriteria { get; set; }
    }

    namespace CapacityReservationTypes
    {
        public class CapacityAllocation : Humidifier.Base.BaseSubResource, IHaveAllocationType, IHaveCount_Integer
        {
            /// <summary>
            /// AllocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservation-capacityallocation.html#cfn-ec2-capacityreservation-capacityallocation-allocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationType { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservation-capacityallocation.html#cfn-ec2-capacityreservation-capacityallocation-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
        }

        public class CommitmentInfo : Humidifier.Base.BaseSubResource, IHaveCommittedInstanceCount_Integer, IHaveCommitmentEndDate
        {
            /// <summary>
            /// CommittedInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservation-commitmentinfo.html#cfn-ec2-capacityreservation-commitmentinfo-committedinstancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CommittedInstanceCount { get; set; }
            /// <summary>
            /// CommitmentEndDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservation-commitmentinfo.html#cfn-ec2-capacityreservation-commitmentinfo-commitmentenddate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommitmentEndDate { get; set; }
        }

        public class TagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservation-tagspecification.html#cfn-ec2-capacityreservation-tagspecification-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-capacityreservation-tagspecification.html#cfn-ec2-capacityreservation-tagspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }
    }
}