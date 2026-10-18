namespace Humidifier.GreengrassV2
{
    using global::System.Collections.Generic;
    using DeploymentTypes;

    public class Deployment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMapOfGreengrassV2DeploymentTypesComponentDeploymentSpecificationComponents, IHaveDeploymentName, IHaveGreengrassV2DeploymentTypesDeploymentIoTJobConfigurationIotJobConfiguration, IHaveGreengrassV2DeploymentTypesDeploymentPoliciesDeploymentPolicies, IHaveTargetArn, IHaveParentTargetArn, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string DeploymentId =  "DeploymentId" ;
        }

        public override string AWSTypeName { get => AWS.GreengrassV2.Deployment; }
        /// <summary>
        /// Components
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-components
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// ItemType: ComponentDeploymentSpecification
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.GreengrassV2.DeploymentTypes.ComponentDeploymentSpecification>, IReadOnlyDictionary<string, Union<Humidifier.GreengrassV2.DeploymentTypes.ComponentDeploymentSpecification, BaseFunction>>, BaseFunction>? Components { get; set; }
        public Union<string, BaseFunction>? DeploymentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IotJobConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-iotjobconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DeploymentIoTJobConfiguration
        /// </summary>
        public Union<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration, BaseFunction>? IotJobConfiguration { get; set; }
        /// <summary>
        /// DeploymentPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-deploymentpolicies
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DeploymentPolicies
        /// </summary>
        public Union<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies, BaseFunction>? DeploymentPolicies { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetArn { get; set; }
        /// <summary>
        /// ParentTargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-parenttargetarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParentTargetArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DeploymentTypes
    {
        public class ComponentConfigurationUpdate : Humidifier.Base.BaseSubResource, IHaveMerge, IHaveStringListOfReset
        {
            /// <summary>
            /// Merge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentconfigurationupdate.html#cfn-greengrassv2-deployment-componentconfigurationupdate-merge
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Merge { get; set; }
            /// <summary>
            /// Reset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentconfigurationupdate.html#cfn-greengrassv2-deployment-componentconfigurationupdate-reset
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Reset { get; set; }
        }

        public class ComponentDeploymentSpecification : Humidifier.Base.BaseSubResource, IHaveGreengrassV2DeploymentTypesComponentRunWithRunWith, IHaveGreengrassV2DeploymentTypesComponentConfigurationUpdateConfigurationUpdate, IHaveComponentVersion
        {
            /// <summary>
            /// RunWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentdeploymentspecification.html#cfn-greengrassv2-deployment-componentdeploymentspecification-runwith
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ComponentRunWith
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.ComponentRunWith, BaseFunction>? RunWith { get; set; }
            /// <summary>
            /// ConfigurationUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentdeploymentspecification.html#cfn-greengrassv2-deployment-componentdeploymentspecification-configurationupdate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ComponentConfigurationUpdate
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.ComponentConfigurationUpdate, BaseFunction>? ConfigurationUpdate { get; set; }
            /// <summary>
            /// ComponentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentdeploymentspecification.html#cfn-greengrassv2-deployment-componentdeploymentspecification-componentversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentVersion { get; set; }
        }

        public class ComponentRunWith : Humidifier.Base.BaseSubResource, IHaveWindowsUser, IHaveGreengrassV2DeploymentTypesSystemResourceLimitsSystemResourceLimits, IHavePosixUser
        {
            /// <summary>
            /// WindowsUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentrunwith.html#cfn-greengrassv2-deployment-componentrunwith-windowsuser
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WindowsUser { get; set; }
            /// <summary>
            /// SystemResourceLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentrunwith.html#cfn-greengrassv2-deployment-componentrunwith-systemresourcelimits
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SystemResourceLimits
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.SystemResourceLimits, BaseFunction>? SystemResourceLimits { get; set; }
            /// <summary>
            /// PosixUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentrunwith.html#cfn-greengrassv2-deployment-componentrunwith-posixuser
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PosixUser { get; set; }
        }

        public class DeploymentComponentUpdatePolicy : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTimeoutInSeconds_Integer
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentcomponentupdatepolicy.html#cfn-greengrassv2-deployment-deploymentcomponentupdatepolicy-action
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentcomponentupdatepolicy.html#cfn-greengrassv2-deployment-deploymentcomponentupdatepolicy-timeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
        }

        public class DeploymentConfigurationValidationPolicy : Humidifier.Base.BaseSubResource, IHaveTimeoutInSeconds_Integer
        {
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentconfigurationvalidationpolicy.html#cfn-greengrassv2-deployment-deploymentconfigurationvalidationpolicy-timeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
        }

        public class DeploymentIoTJobConfiguration : Humidifier.Base.BaseSubResource, IHaveGreengrassV2DeploymentTypesIoTJobExecutionsRolloutConfigJobExecutionsRolloutConfig, IHaveGreengrassV2DeploymentTypesIoTJobTimeoutConfigTimeoutConfig, IHaveGreengrassV2DeploymentTypesIoTJobAbortConfigAbortConfig
        {
            /// <summary>
            /// JobExecutionsRolloutConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentiotjobconfiguration.html#cfn-greengrassv2-deployment-deploymentiotjobconfiguration-jobexecutionsrolloutconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobExecutionsRolloutConfig
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig, BaseFunction>? JobExecutionsRolloutConfig { get; set; }
            /// <summary>
            /// TimeoutConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentiotjobconfiguration.html#cfn-greengrassv2-deployment-deploymentiotjobconfiguration-timeoutconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobTimeoutConfig
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.IoTJobTimeoutConfig, BaseFunction>? TimeoutConfig { get; set; }
            /// <summary>
            /// AbortConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentiotjobconfiguration.html#cfn-greengrassv2-deployment-deploymentiotjobconfiguration-abortconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobAbortConfig
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortConfig, BaseFunction>? AbortConfig { get; set; }
        }

        public class DeploymentPolicies : Humidifier.Base.BaseSubResource, IHaveGreengrassV2DeploymentTypesDeploymentComponentUpdatePolicyComponentUpdatePolicy, IHaveGreengrassV2DeploymentTypesDeploymentConfigurationValidationPolicyConfigurationValidationPolicy, IHaveFailureHandlingPolicy
        {
            /// <summary>
            /// ComponentUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentpolicies.html#cfn-greengrassv2-deployment-deploymentpolicies-componentupdatepolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DeploymentComponentUpdatePolicy
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.DeploymentComponentUpdatePolicy, BaseFunction>? ComponentUpdatePolicy { get; set; }
            /// <summary>
            /// ConfigurationValidationPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentpolicies.html#cfn-greengrassv2-deployment-deploymentpolicies-configurationvalidationpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DeploymentConfigurationValidationPolicy
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.DeploymentConfigurationValidationPolicy, BaseFunction>? ConfigurationValidationPolicy { get; set; }
            /// <summary>
            /// FailureHandlingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentpolicies.html#cfn-greengrassv2-deployment-deploymentpolicies-failurehandlingpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureHandlingPolicy { get; set; }
        }

        public class IoTJobAbortConfig : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassV2DeploymentTypesIoTJobAbortCriteriaCriteriaList
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortconfig.html#cfn-greengrassv2-deployment-iotjobabortconfig-criterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IoTJobAbortCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortCriteria>, IReadOnlyList<Union<Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortCriteria, BaseFunction>>, BaseFunction>? CriteriaList { get; set; }
        }

        public class IoTJobAbortCriteria : Humidifier.Base.BaseSubResource, IHaveFailureType, IHaveAction, IHaveThresholdPercentage_Double, IHaveMinNumberOfExecutedThings_Integer
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureType { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-action
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinNumberOfExecutedThings { get; set; }
        }

        public class IoTJobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute_Integer, IHaveGreengrassV2DeploymentTypesIoTJobExponentialRolloutRateExponentialRate
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexecutionsrolloutconfig.html#cfn-greengrassv2-deployment-iotjobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexecutionsrolloutconfig.html#cfn-greengrassv2-deployment-iotjobexecutionsrolloutconfig-exponentialrate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobExponentialRolloutRate
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate, BaseFunction>? ExponentialRate { get; set; }
        }

        public class IoTJobExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveGreengrassV2DeploymentTypesIoTJobRateIncreaseCriteriaRateIncreaseCriteria, IHaveBaseRatePerMinute_Integer, IHaveIncrementFactor_Double
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexponentialrolloutrate.html#cfn-greengrassv2-deployment-iotjobexponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IoTJobRateIncreaseCriteria
            /// </summary>
            public Union<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria, BaseFunction>? RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexponentialrolloutrate.html#cfn-greengrassv2-deployment-iotjobexponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexponentialrolloutrate.html#cfn-greengrassv2-deployment-iotjobexponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IncrementFactor { get; set; }
        }

        public class IoTJobRateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings_Integer, IHaveNumberOfNotifiedThings_Integer
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobrateincreasecriteria.html#cfn-greengrassv2-deployment-iotjobrateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobrateincreasecriteria.html#cfn-greengrassv2-deployment-iotjobrateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfNotifiedThings { get; set; }
        }

        public class IoTJobTimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes_Integer
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobtimeoutconfig.html#cfn-greengrassv2-deployment-iotjobtimeoutconfig-inprogresstimeoutinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InProgressTimeoutInMinutes { get; set; }
        }

        public class SystemResourceLimits : Humidifier.Base.BaseSubResource, IHaveMemory_Long, IHaveCpus_Double
        {
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-systemresourcelimits.html#cfn-greengrassv2-deployment-systemresourcelimits-memory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Cpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-systemresourcelimits.html#cfn-greengrassv2-deployment-systemresourcelimits-cpus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Cpus { get; set; }
        }
    }
}