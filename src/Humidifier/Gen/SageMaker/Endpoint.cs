namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using EndpointTypes;

    public class Endpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEndpointName, IHaveEndpointConfigName
    {
        public class Attributes
        {
            public static string EndpointName =  "EndpointName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Endpoint; }
        /// <summary>
        /// RetainAllVariantProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-retainallvariantproperties
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RetainAllVariantProperties { get; set; }
        public dynamic EndpointName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ExcludeRetainedVariantProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-excluderetainedvariantproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VariantProperty
        /// </summary>
        public List<Humidifier.SageMaker.EndpointTypes.VariantProperty> ExcludeRetainedVariantProperties { get; set; }

        /// <summary>
        /// EndpointConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-endpointconfigname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EndpointConfigName { get; set; }
        /// <summary>
        /// DeploymentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-deploymentconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentConfig
        /// </summary>
        public Humidifier.SageMaker.EndpointTypes.DeploymentConfig DeploymentConfig { get; set; }
        /// <summary>
        /// RetainDeploymentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-retaindeploymentconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RetainDeploymentConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
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
            public dynamic AlarmName { get; set; }
        }

        public class AutoRollbackConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-autorollbackconfig.html#cfn-sagemaker-endpoint-autorollbackconfig-alarms
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Alarm
            /// </summary>
            public List<Humidifier.SageMaker.EndpointTypes.Alarm> Alarms { get; set; }
        }

        public class BlueGreenUpdatePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumExecutionTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-bluegreenupdatepolicy.html#cfn-sagemaker-endpoint-bluegreenupdatepolicy-maximumexecutiontimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumExecutionTimeoutInSeconds { get; set; }
            /// <summary>
            /// TerminationWaitInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-bluegreenupdatepolicy.html#cfn-sagemaker-endpoint-bluegreenupdatepolicy-terminationwaitinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TerminationWaitInSeconds { get; set; }
            /// <summary>
            /// TrafficRoutingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-bluegreenupdatepolicy.html#cfn-sagemaker-endpoint-bluegreenupdatepolicy-trafficroutingconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TrafficRoutingConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.TrafficRoutingConfig TrafficRoutingConfiguration { get; set; }
        }

        public class CapacitySize : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-capacitysize.html#cfn-sagemaker-endpoint-capacitysize-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-capacitysize.html#cfn-sagemaker-endpoint-capacitysize-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class DeploymentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AutoRollbackConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-deploymentconfig.html#cfn-sagemaker-endpoint-deploymentconfig-autorollbackconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoRollbackConfig
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.AutoRollbackConfig AutoRollbackConfiguration { get; set; }
            /// <summary>
            /// RollingUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-deploymentconfig.html#cfn-sagemaker-endpoint-deploymentconfig-rollingupdatepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingUpdatePolicy
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.RollingUpdatePolicy RollingUpdatePolicy { get; set; }
            /// <summary>
            /// BlueGreenUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-deploymentconfig.html#cfn-sagemaker-endpoint-deploymentconfig-bluegreenupdatepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlueGreenUpdatePolicy
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.BlueGreenUpdatePolicy BlueGreenUpdatePolicy { get; set; }
        }

        public class RollingUpdatePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumExecutionTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-maximumexecutiontimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumExecutionTimeoutInSeconds { get; set; }
            /// <summary>
            /// MaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-maximumbatchsize
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.CapacitySize MaximumBatchSize { get; set; }
            /// <summary>
            /// WaitIntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-waitintervalinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WaitIntervalInSeconds { get; set; }
            /// <summary>
            /// RollbackMaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-rollingupdatepolicy.html#cfn-sagemaker-endpoint-rollingupdatepolicy-rollbackmaximumbatchsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.CapacitySize RollbackMaximumBatchSize { get; set; }
        }

        public class TrafficRoutingConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// LinearStepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-linearstepsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.CapacitySize LinearStepSize { get; set; }
            /// <summary>
            /// CanarySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-canarysize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacitySize
            /// </summary>
            public Humidifier.SageMaker.EndpointTypes.CapacitySize CanarySize { get; set; }
            /// <summary>
            /// WaitIntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-trafficroutingconfig.html#cfn-sagemaker-endpoint-trafficroutingconfig-waitintervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WaitIntervalInSeconds { get; set; }
        }

        public class VariantProperty : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VariantPropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-variantproperty.html#cfn-sagemaker-endpoint-variantproperty-variantpropertytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VariantPropertyType { get; set; }
        }
    }
}