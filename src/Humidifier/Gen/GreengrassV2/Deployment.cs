namespace Humidifier.GreengrassV2
{
    using System.Collections.Generic;
    using DeploymentTypes;

    public class Deployment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTargetArn
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
        public Dictionary<string, Humidifier.GreengrassV2.DeploymentTypes.ComponentDeploymentSpecification> Components { get; set; }
        public dynamic DeploymentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IotJobConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-iotjobconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DeploymentIoTJobConfiguration
        /// </summary>
        public Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration IotJobConfiguration { get; set; }
        /// <summary>
        /// DeploymentPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-deploymentpolicies
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DeploymentPolicies
        /// </summary>
        public Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies DeploymentPolicies { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetArn { get; set; }
        /// <summary>
        /// ParentTargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-parenttargetarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ParentTargetArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-deployment.html#cfn-greengrassv2-deployment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace DeploymentTypes
    {
        public class ComponentConfigurationUpdate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Merge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentconfigurationupdate.html#cfn-greengrassv2-deployment-componentconfigurationupdate-merge
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Merge { get; set; }
            /// <summary>
            /// Reset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentconfigurationupdate.html#cfn-greengrassv2-deployment-componentconfigurationupdate-reset
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Reset { get; set; }
        }

        public class ComponentDeploymentSpecification : Humidifier.Base.BaseSubResource, IHaveComponentVersion
        {
            /// <summary>
            /// RunWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentdeploymentspecification.html#cfn-greengrassv2-deployment-componentdeploymentspecification-runwith
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ComponentRunWith
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.ComponentRunWith RunWith { get; set; }
            /// <summary>
            /// ConfigurationUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentdeploymentspecification.html#cfn-greengrassv2-deployment-componentdeploymentspecification-configurationupdate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ComponentConfigurationUpdate
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.ComponentConfigurationUpdate ConfigurationUpdate { get; set; }
            /// <summary>
            /// ComponentVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentdeploymentspecification.html#cfn-greengrassv2-deployment-componentdeploymentspecification-componentversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentVersion { get; set; }
        }

        public class ComponentRunWith : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WindowsUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentrunwith.html#cfn-greengrassv2-deployment-componentrunwith-windowsuser
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WindowsUser { get; set; }
            /// <summary>
            /// SystemResourceLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentrunwith.html#cfn-greengrassv2-deployment-componentrunwith-systemresourcelimits
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SystemResourceLimits
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.SystemResourceLimits SystemResourceLimits { get; set; }
            /// <summary>
            /// PosixUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-componentrunwith.html#cfn-greengrassv2-deployment-componentrunwith-posixuser
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PosixUser { get; set; }
        }

        public class DeploymentComponentUpdatePolicy : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTimeoutInSeconds
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentcomponentupdatepolicy.html#cfn-greengrassv2-deployment-deploymentcomponentupdatepolicy-action
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentcomponentupdatepolicy.html#cfn-greengrassv2-deployment-deploymentcomponentupdatepolicy-timeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutInSeconds { get; set; }
        }

        public class DeploymentConfigurationValidationPolicy : Humidifier.Base.BaseSubResource, IHaveTimeoutInSeconds
        {
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentconfigurationvalidationpolicy.html#cfn-greengrassv2-deployment-deploymentconfigurationvalidationpolicy-timeoutinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutInSeconds { get; set; }
        }

        public class DeploymentIoTJobConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// JobExecutionsRolloutConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentiotjobconfiguration.html#cfn-greengrassv2-deployment-deploymentiotjobconfiguration-jobexecutionsrolloutconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobExecutionsRolloutConfig
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }
            /// <summary>
            /// TimeoutConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentiotjobconfiguration.html#cfn-greengrassv2-deployment-deploymentiotjobconfiguration-timeoutconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobTimeoutConfig
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.IoTJobTimeoutConfig TimeoutConfig { get; set; }
            /// <summary>
            /// AbortConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentiotjobconfiguration.html#cfn-greengrassv2-deployment-deploymentiotjobconfiguration-abortconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobAbortConfig
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortConfig AbortConfig { get; set; }
        }

        public class DeploymentPolicies : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ComponentUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentpolicies.html#cfn-greengrassv2-deployment-deploymentpolicies-componentupdatepolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DeploymentComponentUpdatePolicy
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.DeploymentComponentUpdatePolicy ComponentUpdatePolicy { get; set; }
            /// <summary>
            /// ConfigurationValidationPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentpolicies.html#cfn-greengrassv2-deployment-deploymentpolicies-configurationvalidationpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DeploymentConfigurationValidationPolicy
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.DeploymentConfigurationValidationPolicy ConfigurationValidationPolicy { get; set; }
            /// <summary>
            /// FailureHandlingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-deploymentpolicies.html#cfn-greengrassv2-deployment-deploymentpolicies-failurehandlingpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureHandlingPolicy { get; set; }
        }

        public class IoTJobAbortConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CriteriaList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortconfig.html#cfn-greengrassv2-deployment-iotjobabortconfig-criterialist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IoTJobAbortCriteria
            /// </summary>
            public List<Humidifier.GreengrassV2.DeploymentTypes.IoTJobAbortCriteria> CriteriaList { get; set; }
        }

        public class IoTJobAbortCriteria : Humidifier.Base.BaseSubResource, IHaveAction, IHaveFailureType, IHaveThresholdPercentage, IHaveMinNumberOfExecutedThings
        {
            /// <summary>
            /// FailureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-failuretype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureType { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-action
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-thresholdpercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ThresholdPercentage { get; set; }
            /// <summary>
            /// MinNumberOfExecutedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobabortcriteria.html#cfn-greengrassv2-deployment-iotjobabortcriteria-minnumberofexecutedthings
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinNumberOfExecutedThings { get; set; }
        }

        public class IoTJobExecutionsRolloutConfig : Humidifier.Base.BaseSubResource, IHaveMaximumPerMinute
        {
            /// <summary>
            /// MaximumPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexecutionsrolloutconfig.html#cfn-greengrassv2-deployment-iotjobexecutionsrolloutconfig-maximumperminute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumPerMinute { get; set; }
            /// <summary>
            /// ExponentialRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexecutionsrolloutconfig.html#cfn-greengrassv2-deployment-iotjobexecutionsrolloutconfig-exponentialrate
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IoTJobExponentialRolloutRate
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate ExponentialRate { get; set; }
        }

        public class IoTJobExponentialRolloutRate : Humidifier.Base.BaseSubResource, IHaveBaseRatePerMinute, IHaveIncrementFactor
        {
            /// <summary>
            /// RateIncreaseCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexponentialrolloutrate.html#cfn-greengrassv2-deployment-iotjobexponentialrolloutrate-rateincreasecriteria
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IoTJobRateIncreaseCriteria
            /// </summary>
            public Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria RateIncreaseCriteria { get; set; }
            /// <summary>
            /// BaseRatePerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexponentialrolloutrate.html#cfn-greengrassv2-deployment-iotjobexponentialrolloutrate-baserateperminute
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BaseRatePerMinute { get; set; }
            /// <summary>
            /// IncrementFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobexponentialrolloutrate.html#cfn-greengrassv2-deployment-iotjobexponentialrolloutrate-incrementfactor
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IncrementFactor { get; set; }
        }

        public class IoTJobRateIncreaseCriteria : Humidifier.Base.BaseSubResource, IHaveNumberOfSucceededThings, IHaveNumberOfNotifiedThings
        {
            /// <summary>
            /// NumberOfSucceededThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobrateincreasecriteria.html#cfn-greengrassv2-deployment-iotjobrateincreasecriteria-numberofsucceededthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfSucceededThings { get; set; }
            /// <summary>
            /// NumberOfNotifiedThings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobrateincreasecriteria.html#cfn-greengrassv2-deployment-iotjobrateincreasecriteria-numberofnotifiedthings
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfNotifiedThings { get; set; }
        }

        public class IoTJobTimeoutConfig : Humidifier.Base.BaseSubResource, IHaveInProgressTimeoutInMinutes
        {
            /// <summary>
            /// InProgressTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-iotjobtimeoutconfig.html#cfn-greengrassv2-deployment-iotjobtimeoutconfig-inprogresstimeoutinminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InProgressTimeoutInMinutes { get; set; }
        }

        public class SystemResourceLimits : Humidifier.Base.BaseSubResource, IHaveMemory
        {
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-systemresourcelimits.html#cfn-greengrassv2-deployment-systemresourcelimits-memory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Memory { get; set; }
            /// <summary>
            /// Cpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrassv2-deployment-systemresourcelimits.html#cfn-greengrassv2-deployment-systemresourcelimits-cpus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Cpus { get; set; }
        }
    }
}