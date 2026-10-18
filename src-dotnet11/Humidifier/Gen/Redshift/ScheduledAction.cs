namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;
    using ScheduledActionTypes;

    public class ScheduledAction : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveScheduledActionDescription, IHaveScheduledActionName, IHaveEndTime, IHaveSchedule, IHaveIamRole, IHaveStartTime, IHaveEnable_Boolean, IHaveRedshiftScheduledActionTypesScheduledActionTypeTargetAction, IHaveDescription
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string NextInvocations =  "NextInvocations" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.ScheduledAction; }
        /// <summary>
        /// ScheduledActionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-scheduledaction.html#cfn-redshift-scheduledaction-scheduledactiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScheduledActionDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ScheduledActionDescription; set => ScheduledActionDescription = value; }
        public Union<string, BaseFunction>? ScheduledActionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-scheduledaction.html#cfn-redshift-scheduledaction-endtime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndTime { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-scheduledaction.html#cfn-redshift-scheduledaction-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// IamRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-scheduledaction.html#cfn-redshift-scheduledaction-iamrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IamRole { get; set; }
        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-scheduledaction.html#cfn-redshift-scheduledaction-starttime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartTime { get; set; }
        /// <summary>
        /// Enable
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-scheduledaction.html#cfn-redshift-scheduledaction-enable
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enable { get; set; }
        /// <summary>
        /// TargetAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-scheduledaction.html#cfn-redshift-scheduledaction-targetaction
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScheduledActionType
        /// </summary>
        public Union<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType, BaseFunction>? TargetAction { get; set; }
    }

    namespace ScheduledActionTypes
    {
        public class PauseClusterMessage : Humidifier.Base.BaseSubResource, IHaveClusterIdentifier
        {
            /// <summary>
            /// ClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-pauseclustermessage.html#cfn-redshift-scheduledaction-pauseclustermessage-clusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterIdentifier { get; set; }
        }

        public class ResizeClusterMessage : Humidifier.Base.BaseSubResource, IHaveNodeType, IHaveNumberOfNodes_Integer, IHaveClusterType, IHaveClassic_Boolean, IHaveClusterIdentifier
        {
            /// <summary>
            /// NodeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-resizeclustermessage.html#cfn-redshift-scheduledaction-resizeclustermessage-nodetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NodeType { get; set; }
            /// <summary>
            /// NumberOfNodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-resizeclustermessage.html#cfn-redshift-scheduledaction-resizeclustermessage-numberofnodes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfNodes { get; set; }
            /// <summary>
            /// ClusterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-resizeclustermessage.html#cfn-redshift-scheduledaction-resizeclustermessage-clustertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterType { get; set; }
            /// <summary>
            /// Classic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-resizeclustermessage.html#cfn-redshift-scheduledaction-resizeclustermessage-classic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Classic { get; set; }
            /// <summary>
            /// ClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-resizeclustermessage.html#cfn-redshift-scheduledaction-resizeclustermessage-clusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterIdentifier { get; set; }
        }

        public class ResumeClusterMessage : Humidifier.Base.BaseSubResource, IHaveClusterIdentifier
        {
            /// <summary>
            /// ClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-resumeclustermessage.html#cfn-redshift-scheduledaction-resumeclustermessage-clusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterIdentifier { get; set; }
        }

        public class ScheduledActionType : Humidifier.Base.BaseSubResource, IHaveRedshiftScheduledActionTypesPauseClusterMessagePauseCluster, IHaveRedshiftScheduledActionTypesResumeClusterMessageResumeCluster, IHaveRedshiftScheduledActionTypesResizeClusterMessageResizeCluster
        {
            /// <summary>
            /// PauseCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-scheduledactiontype.html#cfn-redshift-scheduledaction-scheduledactiontype-pausecluster
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PauseClusterMessage
            /// </summary>
            public Union<Humidifier.Redshift.ScheduledActionTypes.PauseClusterMessage, BaseFunction>? PauseCluster { get; set; }
            /// <summary>
            /// ResumeCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-scheduledactiontype.html#cfn-redshift-scheduledaction-scheduledactiontype-resumecluster
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResumeClusterMessage
            /// </summary>
            public Union<Humidifier.Redshift.ScheduledActionTypes.ResumeClusterMessage, BaseFunction>? ResumeCluster { get; set; }
            /// <summary>
            /// ResizeCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-scheduledaction-scheduledactiontype.html#cfn-redshift-scheduledaction-scheduledactiontype-resizecluster
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResizeClusterMessage
            /// </summary>
            public Union<Humidifier.Redshift.ScheduledActionTypes.ResizeClusterMessage, BaseFunction>? ResizeCluster { get; set; }
        }
    }
}