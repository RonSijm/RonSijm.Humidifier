namespace Humidifier.DRS
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string ParticipatingServers =  "ParticipatingServers" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string EndDateTime =  "EndDateTime" ;
            public static string InitiatedBy =  "InitiatedBy" ;
            public static string ParticipatingResources =  "ParticipatingResources" ;
            public static string Arn =  "Arn" ;
            public static string JobID =  "JobID" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.DRS.Job; }
    }

    namespace JobTypes
    {
        public class LaunchAction : Humidifier.Base.BaseSubResource, IHaveOrder_Integer, IHaveActionVersion, IHaveActionId, IHaveType, IHaveActive_Boolean, IHaveMapOfDRSJobTypesLaunchActionParameterParameters, IHaveDescription, IHaveCategory, IHaveOptional_Boolean, IHaveActionCode, IHaveName
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-order
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Order { get; set; }
            /// <summary>
            /// ActionVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-actionversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionVersion { get; set; }
            /// <summary>
            /// ActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-actionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Active
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-active
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Active { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: LaunchActionParameter
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.DRS.JobTypes.LaunchActionParameter>, IReadOnlyDictionary<string, Union<Humidifier.DRS.JobTypes.LaunchActionParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-category
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
            /// <summary>
            /// Optional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-optional
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Optional { get; set; }
            /// <summary>
            /// ActionCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-actioncode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionCode { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchaction.html#cfn-drs-job-launchaction-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LaunchActionParameter : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchactionparameter.html#cfn-drs-job-launchactionparameter-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchactionparameter.html#cfn-drs-job-launchactionparameter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class LaunchActionRun : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveDRSJobTypesLaunchActionAction, IHaveRunId
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchactionrun.html#cfn-drs-job-launchactionrun-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchactionrun.html#cfn-drs-job-launchactionrun-action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LaunchAction
            /// </summary>
            public Union<Humidifier.DRS.JobTypes.LaunchAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// RunId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchactionrun.html#cfn-drs-job-launchactionrun-runid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RunId { get; set; }
        }

        public class LaunchActionsStatus : Humidifier.Base.BaseSubResource, IHaveSsmAgentDiscoveryDatetime, IHaveListOfDRSJobTypesLaunchActionRunRuns
        {
            /// <summary>
            /// SsmAgentDiscoveryDatetime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchactionsstatus.html#cfn-drs-job-launchactionsstatus-ssmagentdiscoverydatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SsmAgentDiscoveryDatetime { get; set; }
            /// <summary>
            /// Runs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-launchactionsstatus.html#cfn-drs-job-launchactionsstatus-runs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LaunchActionRun
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DRS.JobTypes.LaunchActionRun>, IReadOnlyList<Union<Humidifier.DRS.JobTypes.LaunchActionRun, BaseFunction>>, BaseFunction>? Runs { get; set; }
        }

        public class ParticipatingResource : Humidifier.Base.BaseSubResource, IHaveDRSJobTypesParticipatingResourceIDParticipatingResourceID, IHaveLaunchStatus
        {
            /// <summary>
            /// ParticipatingResourceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-participatingresource.html#cfn-drs-job-participatingresource-participatingresourceid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParticipatingResourceID
            /// </summary>
            public Union<Humidifier.DRS.JobTypes.ParticipatingResourceID, BaseFunction>? ParticipatingResourceID { get; set; }
            /// <summary>
            /// LaunchStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-participatingresource.html#cfn-drs-job-participatingresource-launchstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchStatus { get; set; }
        }

        public class ParticipatingResourceID : Humidifier.Base.BaseSubResource, IHaveSourceNetworkID
        {
            /// <summary>
            /// SourceNetworkID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-participatingresourceid.html#cfn-drs-job-participatingresourceid-sourcenetworkid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceNetworkID { get; set; }
        }

        public class ParticipatingServer : Humidifier.Base.BaseSubResource, IHaveRecoveryInstanceID, IHaveDRSJobTypesLaunchActionsStatusLaunchActionsStatus, IHaveLaunchStatus, IHaveSourceServerID
        {
            /// <summary>
            /// RecoveryInstanceID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-participatingserver.html#cfn-drs-job-participatingserver-recoveryinstanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecoveryInstanceID { get; set; }
            /// <summary>
            /// LaunchActionsStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-participatingserver.html#cfn-drs-job-participatingserver-launchactionsstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LaunchActionsStatus
            /// </summary>
            public Union<Humidifier.DRS.JobTypes.LaunchActionsStatus, BaseFunction>? LaunchActionsStatus { get; set; }
            /// <summary>
            /// LaunchStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-participatingserver.html#cfn-drs-job-participatingserver-launchstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchStatus { get; set; }
            /// <summary>
            /// SourceServerID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-job-participatingserver.html#cfn-drs-job-participatingserver-sourceserverid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceServerID { get; set; }
        }
    }
}