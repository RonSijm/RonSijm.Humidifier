namespace Humidifier.GlobalAccelerator
{
    using global::System.Collections.Generic;
    using ListenerTypes;

    public class Listener : Humidifier.Base.BaseResource, IHaveListOfGlobalAcceleratorListenerTypesPortRangePortRanges, IHaveAcceleratorArn, IHaveProtocol, IHaveClientAffinity
    {
        public class Attributes
        {
            public static string ListenerArn =  "ListenerArn" ;
        }

        public override string AWSTypeName { get => AWS.GlobalAccelerator.Listener; }

        /// <summary>
        /// PortRanges
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-listener.html#cfn-globalaccelerator-listener-portranges
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PortRange
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.GlobalAccelerator.ListenerTypes.PortRange>, IReadOnlyList<Union<Humidifier.GlobalAccelerator.ListenerTypes.PortRange, BaseFunction>>, BaseFunction>? PortRanges { get; set; }

        /// <summary>
        /// AcceleratorArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-listener.html#cfn-globalaccelerator-listener-acceleratorarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AcceleratorArn { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-listener.html#cfn-globalaccelerator-listener-protocol
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// ClientAffinity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-globalaccelerator-listener.html#cfn-globalaccelerator-listener-clientaffinity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientAffinity { get; set; }
    }

    namespace ListenerTypes
    {
        public class PortRange : Humidifier.Base.BaseSubResource, IHaveFromPort_Integer, IHaveToPort_Integer
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-listener-portrange.html#cfn-globalaccelerator-listener-portrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-listener-portrange.html#cfn-globalaccelerator-listener-portrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
        }
    }
}