namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using EndpointTypes;

    public class Endpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRetainAllVariantProperties_Boolean, IHaveEndpointName, IHaveListOfSageMakerEndpointTypesVariantPropertyExcludeRetainedVariantProperties, IHaveEndpointConfigName, IHaveSageMakerEndpointTypesDeploymentConfigDeploymentConfig, IHaveRetainDeploymentConfig_Boolean
    {
        public class Attributes
        {
            public static string EndpointName =  "EndpointName" ;
            public static string EndpointArn =  "EndpointArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Endpoint; }
        /// <summary>
        /// RetainAllVariantProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-retainallvariantproperties
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RetainAllVariantProperties { get; set; }
        public Union<string, BaseFunction>? EndpointName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ExcludeRetainedVariantProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-excluderetainedvariantproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VariantProperty
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.EndpointTypes.VariantProperty>, IReadOnlyList<Union<Humidifier.SageMaker.EndpointTypes.VariantProperty, BaseFunction>>, BaseFunction>? ExcludeRetainedVariantProperties { get; set; }

        /// <summary>
        /// EndpointConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-endpointconfigname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointConfigName { get; set; }
        /// <summary>
        /// DeploymentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-deploymentconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentConfig
        /// </summary>
        public Union<Humidifier.SageMaker.EndpointTypes.DeploymentConfig, BaseFunction>? DeploymentConfig { get; set; }
        /// <summary>
        /// RetainDeploymentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-retaindeploymentconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RetainDeploymentConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EndpointTypes
    {
        public class Alarm : Humidifier.Base.BaseSubResource, IHaveAlarmName
        {
            /// <summary>
            /// AlarmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-alarm.html#cfn-sagemaker-endpoint-alarm-alarmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmName { get; set; }
        }

        public class AutoRollbackConfig : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerEndpointTypesAlarmAlarms
        {
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-autorollbackconfig.html#cfn-sagemaker-endpoint-autorollbackconfig-alarms
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Alarm
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.EndpointTypes.Alarm>, IReadOnlyList<Union<Humidifier.SageMaker.EndpointTypes.Alarm, BaseFunction>>, BaseFunction>? Alarms { get; set; }
        }

        public class BlueGreenUpdatePolicy : Humidifier.Base.BaseSubResource, IHaveMaximumExecutionTimeoutInSeconds_Integer, IHaveTerminationWaitInSeconds_Integer, IHaveSageMakerEndpointTypesTrafficRoutingConfigTrafficRoutingConfiguration
        {
            /// <summary>
            /// MaximumExecutionTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-bluegreenupdatepolicy.html#cfn-sagemaker-endpoint-bluegreenupdatepolicy-maximumexecutiontimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumExecutionTimeoutInSeconds { get; set; }
            /// <summary>
            /// TerminationWaitInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-bluegreenupdatepolicy.html#cfn-sagemaker-endpoint-bluegreenupdatepolicy-terminationwaitinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TerminationWaitInSeconds { get; set; }
            /// <summary>
            /// TrafficRoutingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-bluegreenupdatepolicy.html#cfn-sagemaker-endpoint-bluegreenupdatepolicy-trafficroutingconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TrafficRoutingConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig, BaseFunction>? TrafficRoutingConfiguration { get; set; }
        }

        public class CapacitySize : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveType
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-capacitysize.html#cfn-sagemaker-endpoint-capacitysize-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-capacitysize.html#cfn-sagemaker-endpoint-capacitysize-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class DeploymentConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerEndpointTypesAutoRollbackConfigAutoRollbackConfiguration, IHaveSageMakerEndpointTypesRollingUpdatePolicyRollingUpdatePolicy, IHaveSageMakerEndpointTypesBlueGreenUpdatePolicyBlueGreenUpdatePolicy
        {
            /// <summary>
            /// AutoRollbackConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-deploymentconfig.html#cfn-sagemaker-endpoint-deploymentconfig-autorollbackconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoRollbackConfig
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.AutoRollbackConfig, BaseFunction>? AutoRollbackConfiguration { get; set; }
            /// <summary>
            /// RollingUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-deploymentconfig.html#cfn-sagemaker-endpoint-deploymentconfig-rollingupdatepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingUpdatePolicy
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy, BaseFunction>? RollingUpdatePolicy { get; set; }
            /// <summary>
            /// BlueGreenUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-deploymentconfig.html#cfn-sagemaker-endpoint-deploymentconfig-bluegreenupdatepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlueGreenUpdatePolicy
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy, BaseFunction>? BlueGreenUpdatePolicy { get; set; }
        }

        public class RollingUpdatePolicy : Humidifier.Base.BaseSubResource, IHaveMaximumExecutionTimeoutInSeconds_Integer, IHaveSageMakerEndpointTypesCapacitySizeMaximumBatchSize, IHaveWaitIntervalInSeconds_Integer, IHaveSageMakerEndpointTypesCapacitySizeRollbackMaximumBatchSize
        {
            /// <summary>
            /// MaximumExecutionTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-maximumexecutiontimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumExecutionTimeoutInSeconds { get; set; }
            /// <summary>
            /// MaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-maximumbatchsize
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.CapacitySize, BaseFunction>? MaximumBatchSize { get; set; }
            /// <summary>
            /// WaitIntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-waitintervalinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WaitIntervalInSeconds { get; set; }
            /// <summary>
            /// RollbackMaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-rollbackmaximumbatchsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.CapacitySize, BaseFunction>? RollbackMaximumBatchSize { get; set; }
        }

        public class TrafficRoutingConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveSageMakerEndpointTypesCapacitySizeLinearStepSize, IHaveSageMakerEndpointTypesCapacitySizeCanarySize, IHaveWaitIntervalInSeconds_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// LinearStepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-linearstepsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.CapacitySize, BaseFunction>? LinearStepSize { get; set; }
            /// <summary>
            /// CanarySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-canarysize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Union<Humidifier.SageMaker.EndpointTypes.CapacitySize, BaseFunction>? CanarySize { get; set; }
            /// <summary>
            /// WaitIntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-waitintervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WaitIntervalInSeconds { get; set; }
        }

        public class VariantProperty : Humidifier.Base.BaseSubResource, IHaveVariantPropertyType
        {
            /// <summary>
            /// VariantPropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-variantproperty.html#cfn-sagemaker-endpoint-variantproperty-variantpropertytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VariantPropertyType { get; set; }
        }
    }
}