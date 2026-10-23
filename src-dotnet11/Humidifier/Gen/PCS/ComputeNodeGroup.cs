namespace Humidifier.PCS
{
    using global::System.Collections.Generic;
    using ComputeNodeGroupTypes;

    public class ComputeNodeGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClusterId, IHavePCSComputeNodeGroupTypesSpotOptionsSpotOptions, IHavePCSComputeNodeGroupTypesSlurmConfigurationSlurmConfiguration, IHaveStringListOfSubnetIds, IHaveName, IHavePCSComputeNodeGroupTypesNodeLifecycleActionsNodeLifecycleActions, IHavePCSComputeNodeGroupTypesScalingConfigurationScalingConfiguration, IHaveListOfPCSComputeNodeGroupTypesInstanceConfigInstanceConfigs, IHavePurchaseOption, IHavePCSComputeNodeGroupTypesCustomLaunchTemplateCustomLaunchTemplate, IHaveStringDictionaryOfTags, IHaveAmiId, IHaveIamInstanceProfileArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ErrorInfo =  "ErrorInfo" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.PCS.ComputeNodeGroup; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterId { get; set; }
        /// <summary>
        /// SpotOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-spotoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SpotOptions
        /// </summary>
        public Union<Humidifier.PCS.ComputeNodeGroupTypes.SpotOptions, BaseFunction>? SpotOptions { get; set; }
        /// <summary>
        /// SlurmConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-slurmconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SlurmConfiguration
        /// </summary>
        public Union<Humidifier.PCS.ComputeNodeGroupTypes.SlurmConfiguration, BaseFunction>? SlurmConfiguration { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// NodeLifecycleActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-nodelifecycleactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NodeLifecycleActions
        /// </summary>
        public Union<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleActions, BaseFunction>? NodeLifecycleActions { get; set; }

        /// <summary>
        /// ScalingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-scalingconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ScalingConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.PCS.ComputeNodeGroupTypes.ScalingConfiguration, BaseFunction>? ScalingConfiguration { get; set; }

        /// <summary>
        /// InstanceConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-instanceconfigs
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: InstanceConfig
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig>, IReadOnlyList<Union<Humidifier.PCS.ComputeNodeGroupTypes.InstanceConfig, BaseFunction>>, BaseFunction>? InstanceConfigs { get; set; }
        /// <summary>
        /// PurchaseOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-purchaseoption
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PurchaseOption { get; set; }
        /// <summary>
        /// CustomLaunchTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-customlaunchtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomLaunchTemplate
        /// </summary>
        public Union<Humidifier.PCS.ComputeNodeGroupTypes.CustomLaunchTemplate, BaseFunction>? CustomLaunchTemplate { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AmiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-amiid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AmiId { get; set; }

        /// <summary>
        /// IamInstanceProfileArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcs-computenodegroup.html#cfn-pcs-computenodegroup-iaminstanceprofilearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IamInstanceProfileArn { get; set; }
    }

    namespace ComputeNodeGroupTypes
    {
        public class CustomLaunchTemplate : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveTemplateId
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-customlaunchtemplate.html#cfn-pcs-computenodegroup-customlaunchtemplate-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// TemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-customlaunchtemplate.html#cfn-pcs-computenodegroup-customlaunchtemplate-templateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateId { get; set; }
        }

        public class ErrorInfo : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-errorinfo.html#cfn-pcs-computenodegroup-errorinfo-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-errorinfo.html#cfn-pcs-computenodegroup-errorinfo-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class InstanceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType
        {
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-instanceconfig.html#cfn-pcs-computenodegroup-instanceconfig-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class NodeLifecycleActions : Humidifier.Base.BaseSubResource, IHaveScriptCachingPolicy, IHavePCSComputeNodeGroupTypesNodeLifecycleStagesStages
        {
            /// <summary>
            /// ScriptCachingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecycleactions.html#cfn-pcs-computenodegroup-nodelifecycleactions-scriptcachingpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScriptCachingPolicy { get; set; }
            /// <summary>
            /// Stages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecycleactions.html#cfn-pcs-computenodegroup-nodelifecycleactions-stages
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NodeLifecycleStages
            /// </summary>
            public Union<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleStages, BaseFunction>? Stages { get; set; }
        }

        public class NodeLifecycleScript : Humidifier.Base.BaseSubResource, IHaveStringListOfArguments, IHaveOnError, IHaveExecutionPolicy, IHavePCSComputeNodeGroupTypesScriptSourceScriptSource, IHaveName
        {
            /// <summary>
            /// Arguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecyclescript.html#cfn-pcs-computenodegroup-nodelifecyclescript-arguments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Arguments { get; set; }
            /// <summary>
            /// OnError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecyclescript.html#cfn-pcs-computenodegroup-nodelifecyclescript-onerror
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnError { get; set; }
            /// <summary>
            /// ExecutionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecyclescript.html#cfn-pcs-computenodegroup-nodelifecyclescript-executionpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionPolicy { get; set; }
            /// <summary>
            /// ScriptSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecyclescript.html#cfn-pcs-computenodegroup-nodelifecyclescript-scriptsource
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScriptSource
            /// </summary>
            public Union<Humidifier.PCS.ComputeNodeGroupTypes.ScriptSource, BaseFunction>? ScriptSource { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecyclescript.html#cfn-pcs-computenodegroup-nodelifecyclescript-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class NodeLifecycleStages : Humidifier.Base.BaseSubResource, IHaveListOfPCSComputeNodeGroupTypesNodeLifecycleScriptNodeBootstrapped, IHaveListOfPCSComputeNodeGroupTypesNodeLifecycleScriptNodeReady
        {
            /// <summary>
            /// NodeBootstrapped
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecyclestages.html#cfn-pcs-computenodegroup-nodelifecyclestages-nodebootstrapped
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NodeLifecycleScript
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleScript>, IReadOnlyList<Union<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleScript, BaseFunction>>, BaseFunction>? NodeBootstrapped { get; set; }
            /// <summary>
            /// NodeReady
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-nodelifecyclestages.html#cfn-pcs-computenodegroup-nodelifecyclestages-nodeready
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NodeLifecycleScript
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleScript>, IReadOnlyList<Union<Humidifier.PCS.ComputeNodeGroupTypes.NodeLifecycleScript, BaseFunction>>, BaseFunction>? NodeReady { get; set; }
        }

        public class ScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxInstanceCount_Integer, IHaveMinInstanceCount_Integer
        {
            /// <summary>
            /// MaxInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-scalingconfiguration.html#cfn-pcs-computenodegroup-scalingconfiguration-maxinstancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxInstanceCount { get; set; }
            /// <summary>
            /// MinInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-scalingconfiguration.html#cfn-pcs-computenodegroup-scalingconfiguration-mininstancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinInstanceCount { get; set; }
        }

        public class ScriptSource : Humidifier.Base.BaseSubResource, IHaveChecksum, IHaveS3VersionId, IHaveScriptLocation
        {
            /// <summary>
            /// Checksum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-scriptsource.html#cfn-pcs-computenodegroup-scriptsource-checksum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Checksum { get; set; }
            /// <summary>
            /// S3VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-scriptsource.html#cfn-pcs-computenodegroup-scriptsource-s3versionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3VersionId { get; set; }
            /// <summary>
            /// ScriptLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-scriptsource.html#cfn-pcs-computenodegroup-scriptsource-scriptlocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScriptLocation { get; set; }
        }

        public class SlurmConfiguration : Humidifier.Base.BaseSubResource, IHaveGresCustomSettings_Json, IHaveScaleDownIdleTimeInSeconds_Integer, IHaveListOfPCSComputeNodeGroupTypesSlurmCustomSettingSlurmCustomSettings
        {
            /// <summary>
            /// GresCustomSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmconfiguration.html#cfn-pcs-computenodegroup-slurmconfiguration-grescustomsettings
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? GresCustomSettings { get; set; }
            /// <summary>
            /// ScaleDownIdleTimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmconfiguration.html#cfn-pcs-computenodegroup-slurmconfiguration-scaledownidletimeinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleDownIdleTimeInSeconds { get; set; }
            /// <summary>
            /// SlurmCustomSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmconfiguration.html#cfn-pcs-computenodegroup-slurmconfiguration-slurmcustomsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlurmCustomSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PCS.ComputeNodeGroupTypes.SlurmCustomSetting>, IReadOnlyList<Union<Humidifier.PCS.ComputeNodeGroupTypes.SlurmCustomSetting, BaseFunction>>, BaseFunction>? SlurmCustomSettings { get; set; }
        }

        public class SlurmCustomSetting : Humidifier.Base.BaseSubResource, IHaveParameterValue, IHaveParameterName
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmcustomsetting.html#cfn-pcs-computenodegroup-slurmcustomsetting-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-slurmcustomsetting.html#cfn-pcs-computenodegroup-slurmcustomsetting-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
        }

        public class SpotOptions : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcs-computenodegroup-spotoptions.html#cfn-pcs-computenodegroup-spotoptions-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
        }
    }
}