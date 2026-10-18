namespace Humidifier.Athena
{
    using global::System.Collections.Generic;
    using CapacityReservationTypes;

    public class CapacityReservation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTargetDpus_Long, IHaveAthenaCapacityReservationTypesCapacityAssignmentConfigurationCapacityAssignmentConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AllocatedDpus =  "AllocatedDpus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastSuccessfulAllocationTime =  "LastSuccessfulAllocationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Athena.CapacityReservation; }

        /// <summary>
        /// TargetDpus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-targetdpus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Long
        /// </summary>
        [Required]
        public Union<long, BaseFunction>? TargetDpus { get; set; }
        /// <summary>
        /// CapacityAssignmentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-capacityassignmentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityAssignmentConfiguration
        /// </summary>
        public Union<Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration, BaseFunction>? CapacityAssignmentConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CapacityReservationTypes
    {
        public class CapacityAssignment : Humidifier.Base.BaseSubResource, IHaveStringListOfWorkgroupNames
        {
            /// <summary>
            /// WorkgroupNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-capacityreservation-capacityassignment.html#cfn-athena-capacityreservation-capacityassignment-workgroupnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WorkgroupNames { get; set; }
        }

        public class CapacityAssignmentConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfAthenaCapacityReservationTypesCapacityAssignmentCapacityAssignments
        {
            /// <summary>
            /// CapacityAssignments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-capacityreservation-capacityassignmentconfiguration.html#cfn-athena-capacityreservation-capacityassignmentconfiguration-capacityassignments
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CapacityAssignment
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Athena.CapacityReservationTypes.CapacityAssignment>, IReadOnlyList<Union<Humidifier.Athena.CapacityReservationTypes.CapacityAssignment, BaseFunction>>, BaseFunction>? CapacityAssignments { get; set; }
        }
    }
}