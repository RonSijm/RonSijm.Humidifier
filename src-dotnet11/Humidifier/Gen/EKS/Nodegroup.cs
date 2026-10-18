namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using NodegroupTypes;

    public class Nodegroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEKSNodegroupTypesUpdateConfigUpdateConfig, IHaveEKSNodegroupTypesScalingConfigScalingConfig, IHaveStringDictionaryOfLabels, IHaveEKSNodegroupTypesWarmPoolConfigWarmPoolConfig, IHaveListOfEKSNodegroupTypesTaintTaints, IHaveCapacityType, IHaveReleaseVersion, IHaveEKSNodegroupTypesNodeRepairConfigNodeRepairConfig, IHaveNodegroupName, IHaveNodeRole, IHaveStringListOfSubnets, IHaveAmiType, IHaveForceUpdateEnabled_Boolean, IHaveVersion, IHaveEKSNodegroupTypesLaunchTemplateSpecificationLaunchTemplate, IHaveEKSNodegroupTypesRemoteAccessRemoteAccess, IHaveDiskSize_Integer, IHaveClusterName, IHaveStringListOfInstanceTypes, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string NodegroupName =  "NodegroupName" ;
            public static string ClusterName =  "ClusterName" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EKS.Nodegroup; }
        /// <summary>
        /// UpdateConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-updateconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UpdateConfig
        /// </summary>
        public Union<Humidifier.EKS.NodegroupTypes.UpdateConfig, BaseFunction>? UpdateConfig { get; set; }
        /// <summary>
        /// ScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-scalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScalingConfig
        /// </summary>
        public Union<Humidifier.EKS.NodegroupTypes.ScalingConfig, BaseFunction>? ScalingConfig { get; set; }
        /// <summary>
        /// Labels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-labels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Labels { get; set; }
        /// <summary>
        /// WarmPoolConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-warmpoolconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WarmPoolConfig
        /// </summary>
        public Union<Humidifier.EKS.NodegroupTypes.WarmPoolConfig, BaseFunction>? WarmPoolConfig { get; set; }
        /// <summary>
        /// Taints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-taints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Taint
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EKS.NodegroupTypes.Taint>, IReadOnlyList<Union<Humidifier.EKS.NodegroupTypes.Taint, BaseFunction>>, BaseFunction>? Taints { get; set; }
        /// <summary>
        /// CapacityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-capacitytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CapacityType { get; set; }
        /// <summary>
        /// ReleaseVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-releaseversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReleaseVersion { get; set; }
        /// <summary>
        /// NodeRepairConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-noderepairconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NodeRepairConfig
        /// </summary>
        public Union<Humidifier.EKS.NodegroupTypes.NodeRepairConfig, BaseFunction>? NodeRepairConfig { get; set; }
        public Union<string, BaseFunction>? NodegroupName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// NodeRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-noderole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NodeRole { get; set; }

        /// <summary>
        /// Subnets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-subnets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        /// <summary>
        /// AmiType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-amitype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AmiType { get; set; }
        /// <summary>
        /// ForceUpdateEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-forceupdateenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ForceUpdateEnabled { get; set; }
        /// <summary>
        /// Version
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-version
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Version { get; set; }
        /// <summary>
        /// LaunchTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-launchtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LaunchTemplateSpecification
        /// </summary>
        public Union<Humidifier.EKS.NodegroupTypes.LaunchTemplateSpecification, BaseFunction>? LaunchTemplate { get; set; }
        /// <summary>
        /// RemoteAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-remoteaccess
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RemoteAccess
        /// </summary>
        public Union<Humidifier.EKS.NodegroupTypes.RemoteAccess, BaseFunction>? RemoteAccess { get; set; }
        /// <summary>
        /// DiskSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-disksize
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DiskSize { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterName { get; set; }
        /// <summary>
        /// InstanceTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-instancetypes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceTypes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-nodegroup.html#cfn-eks-nodegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace NodegroupTypes
    {
        public class LaunchTemplateSpecification : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveId, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-launchtemplatespecification.html#cfn-eks-nodegroup-launchtemplatespecification-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-launchtemplatespecification.html#cfn-eks-nodegroup-launchtemplatespecification-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-launchtemplatespecification.html#cfn-eks-nodegroup-launchtemplatespecification-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class NodeRepairConfig : Humidifier.Base.BaseSubResource, IHaveListOfEKSNodegroupTypesNodeRepairConfigOverridesNodeRepairConfigOverrides, IHaveMaxParallelNodesRepairedCount_Integer, IHaveEnabled_Boolean, IHaveMaxUnhealthyNodeThresholdPercentage_Integer, IHaveMaxParallelNodesRepairedPercentage_Integer, IHaveMaxUnhealthyNodeThresholdCount_Integer
        {
            /// <summary>
            /// NodeRepairConfigOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfig.html#cfn-eks-nodegroup-noderepairconfig-noderepairconfigoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NodeRepairConfigOverrides
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.NodegroupTypes.NodeRepairConfigOverrides>, IReadOnlyList<Union<Humidifier.EKS.NodegroupTypes.NodeRepairConfigOverrides, BaseFunction>>, BaseFunction>? NodeRepairConfigOverrides { get; set; }
            /// <summary>
            /// MaxParallelNodesRepairedCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfig.html#cfn-eks-nodegroup-noderepairconfig-maxparallelnodesrepairedcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxParallelNodesRepairedCount { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfig.html#cfn-eks-nodegroup-noderepairconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// MaxUnhealthyNodeThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfig.html#cfn-eks-nodegroup-noderepairconfig-maxunhealthynodethresholdpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxUnhealthyNodeThresholdPercentage { get; set; }
            /// <summary>
            /// MaxParallelNodesRepairedPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfig.html#cfn-eks-nodegroup-noderepairconfig-maxparallelnodesrepairedpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxParallelNodesRepairedPercentage { get; set; }
            /// <summary>
            /// MaxUnhealthyNodeThresholdCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfig.html#cfn-eks-nodegroup-noderepairconfig-maxunhealthynodethresholdcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxUnhealthyNodeThresholdCount { get; set; }
        }

        public class NodeRepairConfigOverrides : Humidifier.Base.BaseSubResource, IHaveNodeUnhealthyReason, IHaveRepairAction, IHaveMinRepairWaitTimeMins_Integer, IHaveNodeMonitoringCondition
        {
            /// <summary>
            /// NodeUnhealthyReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfigoverrides.html#cfn-eks-nodegroup-noderepairconfigoverrides-nodeunhealthyreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NodeUnhealthyReason { get; set; }
            /// <summary>
            /// RepairAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfigoverrides.html#cfn-eks-nodegroup-noderepairconfigoverrides-repairaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepairAction { get; set; }
            /// <summary>
            /// MinRepairWaitTimeMins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfigoverrides.html#cfn-eks-nodegroup-noderepairconfigoverrides-minrepairwaittimemins
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinRepairWaitTimeMins { get; set; }
            /// <summary>
            /// NodeMonitoringCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-noderepairconfigoverrides.html#cfn-eks-nodegroup-noderepairconfigoverrides-nodemonitoringcondition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NodeMonitoringCondition { get; set; }
        }

        public class RemoteAccess : Humidifier.Base.BaseSubResource, IHaveStringListOfSourceSecurityGroups, IHaveEc2SshKey
        {
            /// <summary>
            /// SourceSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-remoteaccess.html#cfn-eks-nodegroup-remoteaccess-sourcesecuritygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceSecurityGroups { get; set; }
            /// <summary>
            /// Ec2SshKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-remoteaccess.html#cfn-eks-nodegroup-remoteaccess-ec2sshkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ec2SshKey { get; set; }
        }

        public class ScalingConfig : Humidifier.Base.BaseSubResource, IHaveMinSize_Integer, IHaveDesiredSize_Integer, IHaveMaxSize_Integer
        {
            /// <summary>
            /// MinSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-scalingconfig.html#cfn-eks-nodegroup-scalingconfig-minsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinSize { get; set; }
            /// <summary>
            /// DesiredSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-scalingconfig.html#cfn-eks-nodegroup-scalingconfig-desiredsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DesiredSize { get; set; }
            /// <summary>
            /// MaxSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-scalingconfig.html#cfn-eks-nodegroup-scalingconfig-maxsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSize { get; set; }
        }

        public class Taint : Humidifier.Base.BaseSubResource, IHaveValue, IHaveEffect, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-taint.html#cfn-eks-nodegroup-taint-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Effect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-taint.html#cfn-eks-nodegroup-taint-effect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Effect { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-taint.html#cfn-eks-nodegroup-taint-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class UpdateConfig : Humidifier.Base.BaseSubResource, IHaveMaxUnavailablePercentage_Double, IHaveUpdateStrategy, IHaveMaxUnavailable_Double
        {
            /// <summary>
            /// MaxUnavailablePercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-updateconfig.html#cfn-eks-nodegroup-updateconfig-maxunavailablepercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxUnavailablePercentage { get; set; }
            /// <summary>
            /// UpdateStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-updateconfig.html#cfn-eks-nodegroup-updateconfig-updatestrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateStrategy { get; set; }
            /// <summary>
            /// MaxUnavailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-updateconfig.html#cfn-eks-nodegroup-updateconfig-maxunavailable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxUnavailable { get; set; }
        }

        public class WarmPoolConfig : Humidifier.Base.BaseSubResource, IHaveMinSize_Integer, IHaveMaxGroupPreparedCapacity_Integer, IHaveEnabled_Boolean, IHavePoolState, IHaveReuseOnScaleIn_Boolean
        {
            /// <summary>
            /// MinSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-warmpoolconfig.html#cfn-eks-nodegroup-warmpoolconfig-minsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinSize { get; set; }
            /// <summary>
            /// MaxGroupPreparedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-warmpoolconfig.html#cfn-eks-nodegroup-warmpoolconfig-maxgrouppreparedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxGroupPreparedCapacity { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-warmpoolconfig.html#cfn-eks-nodegroup-warmpoolconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// PoolState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-warmpoolconfig.html#cfn-eks-nodegroup-warmpoolconfig-poolstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PoolState { get; set; }
            /// <summary>
            /// ReuseOnScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-nodegroup-warmpoolconfig.html#cfn-eks-nodegroup-warmpoolconfig-reuseonscalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReuseOnScaleIn { get; set; }
        }
    }
}