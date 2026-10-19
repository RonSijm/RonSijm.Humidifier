namespace Humidifier.RDS
{
    using global::System.Collections.Generic;
    using DeploymentTypes;

    public class Deployment : Humidifier.Base.BaseResource, IHaveTags, IHaveSource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Target =  "Target" ;
            public static string Tasks =  "Tasks" ;
            public static string CreateTime =  "CreateTime" ;
            public static string BlueGreenDeploymentIdentifier =  "BlueGreenDeploymentIdentifier" ;
            public static string SwitchoverDetails =  "SwitchoverDetails" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RDS.Deployment; }

        /// <summary>
        /// BlueGreenDeploymentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-bluegreendeploymentname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BlueGreenDeploymentName { get; set; }
        /// <summary>
        /// TargetAllocatedStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetallocatedstorage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TargetAllocatedStorage { get; set; }
        /// <summary>
        /// UpgradeTargetStorageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-upgradetargetstorageconfig
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic UpgradeTargetStorageConfig { get; set; }
        /// <summary>
        /// TargetDBParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetdbparametergroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetDBParameterGroupName { get; set; }
        /// <summary>
        /// TargetDBInstanceClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetdbinstanceclass
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetDBInstanceClass { get; set; }
        /// <summary>
        /// TargetIops
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetiops
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TargetIops { get; set; }
        /// <summary>
        /// TargetStorageThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetstoragethroughput
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TargetStorageThroughput { get; set; }
        /// <summary>
        /// TargetDBClusterParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetdbclusterparametergroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetDBClusterParameterGroupName { get; set; }
        /// <summary>
        /// TargetEngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetengineversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetEngineVersion { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-source
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Source { get; set; }
        /// <summary>
        /// TargetStorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-targetstoragetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetStorageType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-deployment.html#cfn-rds-deployment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DeploymentTypes
    {
        public class DeploymentTask : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TaskName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-deployment-deploymenttask.html#cfn-rds-deployment-deploymenttask-taskname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskName { get; set; }
            /// <summary>
            /// TaskStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-deployment-deploymenttask.html#cfn-rds-deployment-deploymenttask-taskstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskStatus { get; set; }
        }

        public class SwitchoverDetail : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceMember
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-deployment-switchoverdetail.html#cfn-rds-deployment-switchoverdetail-sourcemember
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceMember { get; set; }
            /// <summary>
            /// SwitchoverDetailStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-deployment-switchoverdetail.html#cfn-rds-deployment-switchoverdetail-switchoverdetailstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SwitchoverDetailStatus { get; set; }
            /// <summary>
            /// TargetMember
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-deployment-switchoverdetail.html#cfn-rds-deployment-switchoverdetail-targetmember
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetMember { get; set; }
        }
    }
}