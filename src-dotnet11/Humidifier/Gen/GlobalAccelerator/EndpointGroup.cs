namespace Humidifier.GlobalAccelerator
{
    using global::System.Collections.Generic;
    using EndpointGroupTypes;

    public class EndpointGroup : Humidifier.Base.BaseResource, IHaveListenerArn, IHaveListOfGlobalAcceleratorEndpointGroupTypesPortOverridePortOverrides, IHaveHealthCheckIntervalSeconds_Integer, IHaveEndpointGroupRegion, IHaveHealthCheckPath, IHaveTrafficDialPercentage_Double, IHaveHealthCheckProtocol, IHaveThresholdCount_Integer, IHaveHealthCheckPort_Integer, IHaveListOfGlobalAcceleratorEndpointGroupTypesEndpointConfigurationEndpointConfigurations
    {
        public class Attributes
        {
            public static string EndpointGroupArn =  "EndpointGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.GlobalAccelerator.EndpointGroup; }

        /// <summary>
        /// ListenerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-listenerarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ListenerArn { get; set; }
        /// <summary>
        /// PortOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-portoverrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PortOverride
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride>, IReadOnlyList<Union<Humidifier.GlobalAccelerator.EndpointGroupTypes.PortOverride, BaseFunction>>, BaseFunction>? PortOverrides { get; set; }
        /// <summary>
        /// HealthCheckIntervalSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-healthcheckintervalseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? HealthCheckIntervalSeconds { get; set; }

        /// <summary>
        /// EndpointGroupRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-endpointgroupregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointGroupRegion { get; set; }
        /// <summary>
        /// HealthCheckPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-healthcheckpath
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HealthCheckPath { get; set; }
        /// <summary>
        /// TrafficDialPercentage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-trafficdialpercentage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? TrafficDialPercentage { get; set; }
        /// <summary>
        /// HealthCheckProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-healthcheckprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HealthCheckProtocol { get; set; }
        /// <summary>
        /// ThresholdCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-thresholdcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ThresholdCount { get; set; }
        /// <summary>
        /// HealthCheckPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-healthcheckport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? HealthCheckPort { get; set; }
        /// <summary>
        /// EndpointConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-endpointgroup.html#cfn-globalaccelerator-endpointgroup-endpointconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EndpointConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration>, IReadOnlyList<Union<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration, BaseFunction>>, BaseFunction>? EndpointConfigurations { get; set; }
    }

    namespace EndpointGroupTypes
    {
        public class EndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveAttachmentArn, IHaveEndpointId, IHaveWeight_Integer, IHaveClientIPPreservationEnabled_Boolean
        {
            /// <summary>
            /// AttachmentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-endpointconfiguration.html#cfn-globalaccelerator-endpointgroup-endpointconfiguration-attachmentarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttachmentArn { get; set; }
            /// <summary>
            /// EndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-endpointconfiguration.html#cfn-globalaccelerator-endpointgroup-endpointconfiguration-endpointid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointId { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-endpointconfiguration.html#cfn-globalaccelerator-endpointgroup-endpointconfiguration-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// ClientIPPreservationEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-endpointconfiguration.html#cfn-globalaccelerator-endpointgroup-endpointconfiguration-clientippreservationenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ClientIPPreservationEnabled { get; set; }
        }

        public class PortOverride : Humidifier.Base.BaseSubResource, IHaveListenerPort_Integer, IHaveEndpointPort_Integer
        {
            /// <summary>
            /// ListenerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-portoverride.html#cfn-globalaccelerator-endpointgroup-portoverride-listenerport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ListenerPort { get; set; }
            /// <summary>
            /// EndpointPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-portoverride.html#cfn-globalaccelerator-endpointgroup-portoverride-endpointport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndpointPort { get; set; }
        }
    }
}