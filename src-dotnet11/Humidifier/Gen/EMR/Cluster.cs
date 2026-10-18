namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAdditionalInfo_Json, IHaveListOfEMRClusterTypesApplicationApplications, IHaveAutoScalingRole, IHaveEMRClusterTypesAutoTerminationPolicyAutoTerminationPolicy, IHaveListOfEMRClusterTypesBootstrapActionConfigBootstrapActions, IHaveListOfEMRClusterTypesConfigurationConfigurations, IHaveCustomAmiId, IHaveEbsRootVolumeIops_Integer, IHaveEbsRootVolumeSize_Integer, IHaveEbsRootVolumeThroughput_Integer, IHaveEMRClusterTypesJobFlowInstancesConfigInstances, IHaveJobFlowRole, IHaveEMRClusterTypesKerberosAttributesKerberosAttributes, IHaveLogEncryptionKmsKeyId, IHaveLogUri, IHaveEMRClusterTypesManagedScalingPolicyManagedScalingPolicy, IHaveName, IHaveOSReleaseLabel, IHaveListOfEMRClusterTypesPlacementGroupConfigPlacementGroupConfigs, IHaveReleaseLabel, IHaveScaleDownBehavior, IHaveSecurityConfiguration, IHaveServiceRole, IHaveStepConcurrencyLevel_Integer, IHaveListOfEMRClusterTypesStepConfigSteps, IHaveVisibleToAllUsers_Boolean
    {
        public class Attributes
        {
            public static string MasterPublicDNS =  "MasterPublicDNS" ;
        }

        public override string AWSTypeName { get => AWS.EMR.Cluster; }
        /// <summary>
        /// AdditionalInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-additionalinfo
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? AdditionalInfo { get; set; }
        /// <summary>
        /// Applications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-applications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Application
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.Application>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.Application, BaseFunction>>, BaseFunction>? Applications { get; set; }
        /// <summary>
        /// AutoScalingRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-autoscalingrole
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutoScalingRole { get; set; }
        /// <summary>
        /// AutoTerminationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-autoterminationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoTerminationPolicy
        /// </summary>
        public Union<Humidifier.EMR.ClusterTypes.AutoTerminationPolicy, BaseFunction>? AutoTerminationPolicy { get; set; }
        /// <summary>
        /// BootstrapActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-bootstrapactions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: BootstrapActionConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.BootstrapActionConfig>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.BootstrapActionConfig, BaseFunction>>, BaseFunction>? BootstrapActions { get; set; }
        /// <summary>
        /// Configurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-configurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Configuration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
        /// <summary>
        /// CustomAmiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-customamiid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomAmiId { get; set; }
        /// <summary>
        /// EbsRootVolumeIops
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-ebsrootvolumeiops
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EbsRootVolumeIops { get; set; }
        /// <summary>
        /// EbsRootVolumeSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-ebsrootvolumesize
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EbsRootVolumeSize { get; set; }
        /// <summary>
        /// EbsRootVolumeThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-ebsrootvolumethroughput
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EbsRootVolumeThroughput { get; set; }

        /// <summary>
        /// Instances
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-instances
        /// Required: True
        /// UpdateType: Conditional
        /// Type: JobFlowInstancesConfig
        /// </summary>
        [Required]
        public Union<Humidifier.EMR.ClusterTypes.JobFlowInstancesConfig, BaseFunction>? Instances { get; set; }

        /// <summary>
        /// JobFlowRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-jobflowrole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobFlowRole { get; set; }
        /// <summary>
        /// KerberosAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-kerberosattributes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KerberosAttributes
        /// </summary>
        public Union<Humidifier.EMR.ClusterTypes.KerberosAttributes, BaseFunction>? KerberosAttributes { get; set; }
        /// <summary>
        /// LogEncryptionKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-logencryptionkmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogEncryptionKmsKeyId { get; set; }
        /// <summary>
        /// LogUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-loguri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogUri { get; set; }
        /// <summary>
        /// ManagedScalingPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-managedscalingpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManagedScalingPolicy
        /// </summary>
        public Union<Humidifier.EMR.ClusterTypes.ManagedScalingPolicy, BaseFunction>? ManagedScalingPolicy { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OSReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-osreleaselabel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OSReleaseLabel { get; set; }
        /// <summary>
        /// PlacementGroupConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-placementgroupconfigs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: PlacementGroupConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.PlacementGroupConfig>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.PlacementGroupConfig, BaseFunction>>, BaseFunction>? PlacementGroupConfigs { get; set; }
        /// <summary>
        /// ReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-releaselabel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReleaseLabel { get; set; }
        /// <summary>
        /// ScaleDownBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-scaledownbehavior
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScaleDownBehavior { get; set; }
        /// <summary>
        /// SecurityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-securityconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityConfiguration { get; set; }

        /// <summary>
        /// ServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-servicerole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceRole { get; set; }
        /// <summary>
        /// StepConcurrencyLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-stepconcurrencylevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? StepConcurrencyLevel { get; set; }
        /// <summary>
        /// Steps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-steps
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: StepConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.StepConfig>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.StepConfig, BaseFunction>>, BaseFunction>? Steps { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// VisibleToAllUsers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-cluster.html#cfn-elasticmapreduce-cluster-visibletoallusers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? VisibleToAllUsers { get; set; }
    }

    namespace ClusterTypes
    {
        public class Application : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfAdditionalInfo, IHaveStringListOfArgs, IHaveName, IHaveVersion
        {
            /// <summary>
            /// AdditionalInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-application.html#cfn-elasticmapreduce-cluster-application-additionalinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalInfo { get; set; }
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-application.html#cfn-elasticmapreduce-cluster-application-args
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Args { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-application.html#cfn-elasticmapreduce-cluster-application-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-application.html#cfn-elasticmapreduce-cluster-application-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }

        public class AutoScalingPolicy : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesScalingConstraintsConstraints, IHaveListOfEMRClusterTypesScalingRuleRules
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html#cfn-elasticmapreduce-cluster-autoscalingpolicy-constraints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingConstraints
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.ScalingConstraints, BaseFunction>? Constraints { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html#cfn-elasticmapreduce-cluster-autoscalingpolicy-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScalingRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.ScalingRule>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.ScalingRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class AutoTerminationPolicy : Humidifier.Base.BaseSubResource, IHaveIdleTimeout_Long
        {
            /// <summary>
            /// IdleTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoterminationpolicy.html#cfn-elasticmapreduce-cluster-autoterminationpolicy-idletimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? IdleTimeout { get; set; }
        }

        public class BootstrapActionConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveEMRClusterTypesScriptBootstrapActionConfigScriptBootstrapAction
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-bootstrapactionconfig.html#cfn-elasticmapreduce-cluster-bootstrapactionconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ScriptBootstrapAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-bootstrapactionconfig.html#cfn-elasticmapreduce-cluster-bootstrapactionconfig-scriptbootstrapaction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScriptBootstrapActionConfig
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig, BaseFunction>? ScriptBootstrapAction { get; set; }
        }

        public class CloudWatchAlarmDefinition : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveListOfEMRClusterTypesMetricDimensionDimensions, IHaveEvaluationPeriods_Integer, IHaveMetricName, IHaveNamespace_, IHavePeriod_Integer, IHaveStatistic, IHaveThreshold_Double, IHaveUnit
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.MetricDimension>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.MetricDimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// EvaluationPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-evaluationperiods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EvaluationPeriods { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Threshold { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class ComputeLimits : Humidifier.Base.BaseSubResource, IHaveMaximumCapacityUnits_Integer, IHaveMaximumCoreCapacityUnits_Integer, IHaveMaximumOnDemandCapacityUnits_Integer, IHaveMinimumCapacityUnits_Integer, IHaveUnitType
        {
            /// <summary>
            /// MaximumCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-computelimits.html#cfn-elasticmapreduce-cluster-computelimits-maximumcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumCapacityUnits { get; set; }
            /// <summary>
            /// MaximumCoreCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-computelimits.html#cfn-elasticmapreduce-cluster-computelimits-maximumcorecapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumCoreCapacityUnits { get; set; }
            /// <summary>
            /// MaximumOnDemandCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-computelimits.html#cfn-elasticmapreduce-cluster-computelimits-maximumondemandcapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumOnDemandCapacityUnits { get; set; }
            /// <summary>
            /// MinimumCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-computelimits.html#cfn-elasticmapreduce-cluster-computelimits-minimumcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumCapacityUnits { get; set; }
            /// <summary>
            /// UnitType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-computelimits.html#cfn-elasticmapreduce-cluster-computelimits-unittype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnitType { get; set; }
        }

        public class Configuration : Humidifier.Base.BaseSubResource, IHaveClassification, IHaveStringDictionaryOfConfigurationProperties, IHaveListOfEMRClusterTypesConfigurationConfigurations
        {
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-elasticmapreduce-cluster-configuration-classification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-elasticmapreduce-cluster-configuration-configurationproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ConfigurationProperties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-elasticmapreduce-cluster-configuration-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
        }

        public class EbsBlockDeviceConfig : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesVolumeSpecificationVolumeSpecification, IHaveVolumesPerInstance_Integer
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ebsblockdeviceconfig.html#cfn-elasticmapreduce-cluster-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VolumeSpecification
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.VolumeSpecification, BaseFunction>? VolumeSpecification { get; set; }
            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ebsblockdeviceconfig.html#cfn-elasticmapreduce-cluster-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumesPerInstance { get; set; }
        }

        public class EbsConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEMRClusterTypesEbsBlockDeviceConfigEbsBlockDeviceConfigs, IHaveEbsOptimized_Boolean
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ebsconfiguration.html#cfn-elasticmapreduce-cluster-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EbsBlockDeviceConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.EbsBlockDeviceConfig>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.EbsBlockDeviceConfig, BaseFunction>>, BaseFunction>? EbsBlockDeviceConfigs { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ebsconfiguration.html#cfn-elasticmapreduce-cluster-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
        }

        public class HadoopJarStepConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfArgs, IHaveJar, IHaveMainClass, IHaveListOfEMRClusterTypesKeyValueStepProperties
        {
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-args
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Args { get; set; }
            /// <summary>
            /// Jar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-jar
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Jar { get; set; }
            /// <summary>
            /// MainClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-mainclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MainClass { get; set; }
            /// <summary>
            /// StepProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-stepproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.KeyValue>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.KeyValue, BaseFunction>>, BaseFunction>? StepProperties { get; set; }
        }

        public class InstanceFleetConfig : Humidifier.Base.BaseSubResource, IHaveListOfEMRClusterTypesInstanceTypeConfigInstanceTypeConfigs, IHaveEMRClusterTypesInstanceFleetProvisioningSpecificationsLaunchSpecifications, IHaveName, IHaveEMRClusterTypesInstanceFleetResizingSpecificationsResizeSpecifications, IHaveTargetOnDemandCapacity_Integer, IHaveTargetSpotCapacity_Integer
        {
            /// <summary>
            /// InstanceTypeConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-instancetypeconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InstanceTypeConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.InstanceTypeConfig>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.InstanceTypeConfig, BaseFunction>>, BaseFunction>? InstanceTypeConfigs { get; set; }
            /// <summary>
            /// LaunchSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-launchspecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceFleetProvisioningSpecifications
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications, BaseFunction>? LaunchSpecifications { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// ResizeSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-resizespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceFleetResizingSpecifications
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.InstanceFleetResizingSpecifications, BaseFunction>? ResizeSpecifications { get; set; }
            /// <summary>
            /// TargetOnDemandCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-targetondemandcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetOnDemandCapacity { get; set; }
            /// <summary>
            /// TargetSpotCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-targetspotcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetSpotCapacity { get; set; }
        }

        public class InstanceFleetProvisioningSpecifications : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesOnDemandProvisioningSpecificationOnDemandSpecification, IHaveEMRClusterTypesSpotProvisioningSpecificationSpotSpecification
        {
            /// <summary>
            /// OnDemandSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-cluster-instancefleetprovisioningspecifications-ondemandspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandProvisioningSpecification
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification, BaseFunction>? OnDemandSpecification { get; set; }
            /// <summary>
            /// SpotSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-cluster-instancefleetprovisioningspecifications-spotspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotProvisioningSpecification
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.SpotProvisioningSpecification, BaseFunction>? SpotSpecification { get; set; }
        }

        public class InstanceFleetResizingSpecifications : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesOnDemandResizingSpecificationOnDemandResizeSpecification, IHaveEMRClusterTypesSpotResizingSpecificationSpotResizeSpecification
        {
            /// <summary>
            /// OnDemandResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetresizingspecifications.html#cfn-elasticmapreduce-cluster-instancefleetresizingspecifications-ondemandresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandResizingSpecification
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.OnDemandResizingSpecification, BaseFunction>? OnDemandResizeSpecification { get; set; }
            /// <summary>
            /// SpotResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetresizingspecifications.html#cfn-elasticmapreduce-cluster-instancefleetresizingspecifications-spotresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotResizingSpecification
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.SpotResizingSpecification, BaseFunction>? SpotResizeSpecification { get; set; }
        }

        public class InstanceGroupConfig : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesAutoScalingPolicyAutoScalingPolicy, IHaveBidPrice, IHaveListOfEMRClusterTypesConfigurationConfigurations, IHaveCustomAmiId, IHaveEMRClusterTypesEbsConfigurationEbsConfiguration, IHaveInstanceCount_Integer, IHaveInstanceType, IHaveMarket, IHaveName
        {
            /// <summary>
            /// AutoScalingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-autoscalingpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingPolicy
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.AutoScalingPolicy, BaseFunction>? AutoScalingPolicy { get; set; }
            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-bidprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BidPrice { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// CustomAmiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-customamiid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomAmiId { get; set; }
            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-ebsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsConfiguration
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.EbsConfiguration, BaseFunction>? EbsConfiguration { get; set; }
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-instancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Market
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-market
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Market { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InstanceTypeConfig : Humidifier.Base.BaseSubResource, IHaveBidPrice, IHaveBidPriceAsPercentageOfOnDemandPrice_Double, IHaveListOfEMRClusterTypesConfigurationConfigurations, IHaveCustomAmiId, IHaveEMRClusterTypesEbsConfigurationEbsConfiguration, IHaveInstanceType, IHavePriority_Double, IHaveWeightedCapacity_Integer
        {
            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-bidprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BidPrice { get; set; }
            /// <summary>
            /// BidPriceAsPercentageOfOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-bidpriceaspercentageofondemandprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BidPriceAsPercentageOfOnDemandPrice { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// CustomAmiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-customamiid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomAmiId { get; set; }
            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-ebsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsConfiguration
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.EbsConfiguration, BaseFunction>? EbsConfiguration { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-weightedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WeightedCapacity { get; set; }
        }

        public class JobFlowInstancesConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfAdditionalMasterSecurityGroups, IHaveStringListOfAdditionalSlaveSecurityGroups, IHaveEMRClusterTypesInstanceFleetConfigCoreInstanceFleet, IHaveEMRClusterTypesInstanceGroupConfigCoreInstanceGroup, IHaveEc2KeyName, IHaveEc2SubnetId, IHaveStringListOfEc2SubnetIds, IHaveEmrManagedMasterSecurityGroup, IHaveEmrManagedSlaveSecurityGroup, IHaveHadoopVersion, IHaveKeepJobFlowAliveWhenNoSteps_Boolean, IHaveEMRClusterTypesInstanceFleetConfigMasterInstanceFleet, IHaveEMRClusterTypesInstanceGroupConfigMasterInstanceGroup, IHaveEMRClusterTypesPlacementTypePlacement, IHaveServiceAccessSecurityGroup, IHaveListOfEMRClusterTypesInstanceFleetConfigTaskInstanceFleets, IHaveListOfEMRClusterTypesInstanceGroupConfigTaskInstanceGroups, IHaveTerminationProtected_Boolean, IHaveUnhealthyNodeReplacement_Boolean
        {
            /// <summary>
            /// AdditionalMasterSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-additionalmastersecuritygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalMasterSecurityGroups { get; set; }
            /// <summary>
            /// AdditionalSlaveSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-additionalslavesecuritygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalSlaveSecurityGroups { get; set; }
            /// <summary>
            /// CoreInstanceFleet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-coreinstancefleet
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceFleetConfig
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.InstanceFleetConfig, BaseFunction>? CoreInstanceFleet { get; set; }
            /// <summary>
            /// CoreInstanceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-coreinstancegroup
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceGroupConfig
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.InstanceGroupConfig, BaseFunction>? CoreInstanceGroup { get; set; }
            /// <summary>
            /// Ec2KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-ec2keyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ec2KeyName { get; set; }
            /// <summary>
            /// Ec2SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-ec2subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ec2SubnetId { get; set; }
            /// <summary>
            /// Ec2SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-ec2subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ec2SubnetIds { get; set; }
            /// <summary>
            /// EmrManagedMasterSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-emrmanagedmastersecuritygroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmrManagedMasterSecurityGroup { get; set; }
            /// <summary>
            /// EmrManagedSlaveSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-emrmanagedslavesecuritygroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmrManagedSlaveSecurityGroup { get; set; }
            /// <summary>
            /// HadoopVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-hadoopversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HadoopVersion { get; set; }
            /// <summary>
            /// KeepJobFlowAliveWhenNoSteps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-keepjobflowalivewhennosteps
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? KeepJobFlowAliveWhenNoSteps { get; set; }
            /// <summary>
            /// MasterInstanceFleet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-masterinstancefleet
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceFleetConfig
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.InstanceFleetConfig, BaseFunction>? MasterInstanceFleet { get; set; }
            /// <summary>
            /// MasterInstanceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-masterinstancegroup
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceGroupConfig
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.InstanceGroupConfig, BaseFunction>? MasterInstanceGroup { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-placement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PlacementType
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.PlacementType, BaseFunction>? Placement { get; set; }
            /// <summary>
            /// ServiceAccessSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-serviceaccesssecuritygroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccessSecurityGroup { get; set; }
            /// <summary>
            /// TaskInstanceFleets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-taskinstancefleets
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: InstanceFleetConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.InstanceFleetConfig>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.InstanceFleetConfig, BaseFunction>>, BaseFunction>? TaskInstanceFleets { get; set; }
            /// <summary>
            /// TaskInstanceGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-taskinstancegroups
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: InstanceGroupConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.ClusterTypes.InstanceGroupConfig>, IReadOnlyList<Union<Humidifier.EMR.ClusterTypes.InstanceGroupConfig, BaseFunction>>, BaseFunction>? TaskInstanceGroups { get; set; }
            /// <summary>
            /// TerminationProtected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-terminationprotected
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TerminationProtected { get; set; }
            /// <summary>
            /// UnhealthyNodeReplacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-unhealthynodereplacement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UnhealthyNodeReplacement { get; set; }
        }

        public class KerberosAttributes : Humidifier.Base.BaseSubResource, IHaveADDomainJoinPassword, IHaveADDomainJoinUser, IHaveCrossRealmTrustPrincipalPassword, IHaveKdcAdminPassword, IHaveRealm
        {
            /// <summary>
            /// ADDomainJoinPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-kerberosattributes.html#cfn-elasticmapreduce-cluster-kerberosattributes-addomainjoinpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ADDomainJoinPassword { get; set; }
            /// <summary>
            /// ADDomainJoinUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-kerberosattributes.html#cfn-elasticmapreduce-cluster-kerberosattributes-addomainjoinuser
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ADDomainJoinUser { get; set; }
            /// <summary>
            /// CrossRealmTrustPrincipalPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-kerberosattributes.html#cfn-elasticmapreduce-cluster-kerberosattributes-crossrealmtrustprincipalpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrossRealmTrustPrincipalPassword { get; set; }
            /// <summary>
            /// KdcAdminPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-kerberosattributes.html#cfn-elasticmapreduce-cluster-kerberosattributes-kdcadminpassword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KdcAdminPassword { get; set; }
            /// <summary>
            /// Realm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-kerberosattributes.html#cfn-elasticmapreduce-cluster-kerberosattributes-realm
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Realm { get; set; }
        }

        public class KeyValue : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValue
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-keyvalue.html#cfn-elasticmapreduce-cluster-keyvalue-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-keyvalue.html#cfn-elasticmapreduce-cluster-keyvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class ManagedScalingPolicy : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesComputeLimitsComputeLimits, IHaveScalingStrategy, IHaveUtilizationPerformanceIndex_Integer
        {
            /// <summary>
            /// ComputeLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-managedscalingpolicy.html#cfn-elasticmapreduce-cluster-managedscalingpolicy-computelimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComputeLimits
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.ComputeLimits, BaseFunction>? ComputeLimits { get; set; }
            /// <summary>
            /// ScalingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-managedscalingpolicy.html#cfn-elasticmapreduce-cluster-managedscalingpolicy-scalingstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingStrategy { get; set; }
            /// <summary>
            /// UtilizationPerformanceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-managedscalingpolicy.html#cfn-elasticmapreduce-cluster-managedscalingpolicy-utilizationperformanceindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UtilizationPerformanceIndex { get; set; }
        }

        public class MetricDimension : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValue
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-metricdimension.html#cfn-elasticmapreduce-cluster-metricdimension-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-metricdimension.html#cfn-elasticmapreduce-cluster-metricdimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class OnDemandCapacityReservationOptions : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveCapacityReservationResourceGroupArn, IHaveUsageStrategy
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandcapacityreservationoptions.html#cfn-elasticmapreduce-cluster-ondemandcapacityreservationoptions-capacityreservationpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandcapacityreservationoptions.html#cfn-elasticmapreduce-cluster-ondemandcapacityreservationoptions-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// UsageStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandcapacityreservationoptions.html#cfn-elasticmapreduce-cluster-ondemandcapacityreservationoptions-usagestrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageStrategy { get; set; }
        }

        public class OnDemandProvisioningSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveEMRClusterTypesOnDemandCapacityReservationOptionsCapacityReservationOptions
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandprovisioningspecification.html#cfn-elasticmapreduce-cluster-ondemandprovisioningspecification-allocationstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandprovisioningspecification.html#cfn-elasticmapreduce-cluster-ondemandprovisioningspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions, BaseFunction>? CapacityReservationOptions { get; set; }
        }

        public class OnDemandResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveEMRClusterTypesOnDemandCapacityReservationOptionsCapacityReservationOptions, IHaveTimeoutDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandresizingspecification.html#cfn-elasticmapreduce-cluster-ondemandresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandresizingspecification.html#cfn-elasticmapreduce-cluster-ondemandresizingspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions, BaseFunction>? CapacityReservationOptions { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandresizingspecification.html#cfn-elasticmapreduce-cluster-ondemandresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
        }

        public class PlacementGroupConfig : Humidifier.Base.BaseSubResource, IHaveInstanceRole, IHavePlacementStrategy
        {
            /// <summary>
            /// InstanceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-placementgroupconfig.html#cfn-elasticmapreduce-cluster-placementgroupconfig-instancerole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceRole { get; set; }
            /// <summary>
            /// PlacementStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-placementgroupconfig.html#cfn-elasticmapreduce-cluster-placementgroupconfig-placementstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlacementStrategy { get; set; }
        }

        public class PlacementType : Humidifier.Base.BaseSubResource, IHaveAvailabilityZone
        {
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-placementtype.html#cfn-elasticmapreduce-cluster-placementtype-availabilityzone
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }

        public class ScalingAction : Humidifier.Base.BaseSubResource, IHaveMarket, IHaveEMRClusterTypesSimpleScalingPolicyConfigurationSimpleScalingPolicyConfiguration
        {
            /// <summary>
            /// Market
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-elasticmapreduce-cluster-scalingaction-market
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Market { get; set; }
            /// <summary>
            /// SimpleScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-elasticmapreduce-cluster-scalingaction-simplescalingpolicyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SimpleScalingPolicyConfiguration
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.SimpleScalingPolicyConfiguration, BaseFunction>? SimpleScalingPolicyConfiguration { get; set; }
        }

        public class ScalingConstraints : Humidifier.Base.BaseSubResource, IHaveMaxCapacity_Integer, IHaveMinCapacity_Integer
        {
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html#cfn-elasticmapreduce-cluster-scalingconstraints-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html#cfn-elasticmapreduce-cluster-scalingconstraints-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinCapacity { get; set; }
        }

        public class ScalingRule : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesScalingActionAction, IHaveDescription, IHaveName, IHaveEMRClusterTypesScalingTriggerTrigger
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingAction
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.ScalingAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingTrigger
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.ScalingTrigger, BaseFunction>? Trigger { get; set; }
        }

        public class ScalingTrigger : Humidifier.Base.BaseSubResource, IHaveEMRClusterTypesCloudWatchAlarmDefinitionCloudWatchAlarmDefinition
        {
            /// <summary>
            /// CloudWatchAlarmDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingtrigger.html#cfn-elasticmapreduce-cluster-scalingtrigger-cloudwatchalarmdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchAlarmDefinition
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.CloudWatchAlarmDefinition, BaseFunction>? CloudWatchAlarmDefinition { get; set; }
        }

        public class ScriptBootstrapActionConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfArgs, IHavePath
        {
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scriptbootstrapactionconfig.html#cfn-elasticmapreduce-cluster-scriptbootstrapactionconfig-args
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Args { get; set; }
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scriptbootstrapactionconfig.html#cfn-elasticmapreduce-cluster-scriptbootstrapactionconfig-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
        }

        public class SimpleScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveAdjustmentType, IHaveCoolDown_Integer, IHaveScalingAdjustment_Integer
        {
            /// <summary>
            /// AdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-cluster-simplescalingpolicyconfiguration-adjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdjustmentType { get; set; }
            /// <summary>
            /// CoolDown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-cluster-simplescalingpolicyconfiguration-cooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CoolDown { get; set; }
            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-cluster-simplescalingpolicyconfiguration-scalingadjustment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScalingAdjustment { get; set; }
        }

        public class SpotProvisioningSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveBlockDurationMinutes_Integer, IHaveTimeoutAction, IHaveTimeoutDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// BlockDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-blockdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BlockDurationMinutes { get; set; }
            /// <summary>
            /// TimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-timeoutaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeoutAction { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-timeoutdurationminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
        }

        public class SpotResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotresizingspecification.html#cfn-elasticmapreduce-cluster-spotresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotresizingspecification.html#cfn-elasticmapreduce-cluster-spotresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
        }

        public class StepConfig : Humidifier.Base.BaseSubResource, IHaveActionOnFailure, IHaveEMRClusterTypesHadoopJarStepConfigHadoopJarStep, IHaveName
        {
            /// <summary>
            /// ActionOnFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-stepconfig.html#cfn-elasticmapreduce-cluster-stepconfig-actiononfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionOnFailure { get; set; }
            /// <summary>
            /// HadoopJarStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-stepconfig.html#cfn-elasticmapreduce-cluster-stepconfig-hadoopjarstep
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HadoopJarStepConfig
            /// </summary>
            public Union<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig, BaseFunction>? HadoopJarStep { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-stepconfig.html#cfn-elasticmapreduce-cluster-stepconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class VolumeSpecification : Humidifier.Base.BaseSubResource, IHaveIops_Integer, IHaveSizeInGB_Integer, IHaveThroughput_Integer, IHaveVolumeType
        {
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-volumespecification.html#cfn-elasticmapreduce-cluster-volumespecification-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-volumespecification.html#cfn-elasticmapreduce-cluster-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGB { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-volumespecification.html#cfn-elasticmapreduce-cluster-volumespecification-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-volumespecification.html#cfn-elasticmapreduce-cluster-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
        }
    }
}