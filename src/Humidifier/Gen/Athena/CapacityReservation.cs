namespace Humidifier.Athena
{
    using System.Collections.Generic;
    using CapacityReservationTypes;

    public class CapacityReservation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic TargetDpus { get; set; }
        /// <summary>
        /// CapacityAssignmentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-capacityassignmentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityAssignmentConfiguration
        /// </summary>
        public Humidifier.Athena.CapacityReservationTypes.CapacityAssignmentConfiguration CapacityAssignmentConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CapacityReservationTypes
    {
        public class CapacityAssignment : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WorkgroupNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-capacityreservation-capacityassignment.html#cfn-athena-capacityreservation-capacityassignment-workgroupnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WorkgroupNames { get; set; }
        }

        public class CapacityAssignmentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CapacityAssignments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-capacityreservation-capacityassignmentconfiguration.html#cfn-athena-capacityreservation-capacityassignmentconfiguration-capacityassignments
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CapacityAssignment
            /// </summary>
            public List<Humidifier.Athena.CapacityReservationTypes.CapacityAssignment> CapacityAssignments { get; set; }
        }
    }
}