namespace Humidifier.Athena
{
    using System.Collections.Generic;
    using CapacityReservationTypes;

    public class CapacityReservation : Humidifier.Resource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AllocatedDpus =  "AllocatedDpus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastSuccessfulAllocationTime =  "LastSuccessfulAllocationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Athena::CapacityReservation";
            }
        }

        /// <summary>
        /// TargetDpus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-targetdpus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TargetDpus { get; set; }
        /// <summary>
        /// CapacityAssignmentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-capacityassignmentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityAssignmentConfiguration
        /// </summary>
        public CapacityAssignmentConfiguration CapacityAssignmentConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-capacityreservation.html#cfn-athena-capacityreservation-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace CapacityReservationTypes
    {
        public class CapacityAssignment
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

        public class CapacityAssignmentConfiguration
        {
            /// <summary>
            /// CapacityAssignments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-capacityreservation-capacityassignmentconfiguration.html#cfn-athena-capacityreservation-capacityassignmentconfiguration-capacityassignments
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CapacityAssignment
            /// </summary>
            public List<CapacityAssignment> CapacityAssignments { get; set; }
        }
    }
}