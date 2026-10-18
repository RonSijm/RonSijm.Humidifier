namespace Humidifier.VpcLattice
{
    using global::System.Collections.Generic;
    using ListenerTypes;

    public class Listener : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVpcLatticeListenerTypesDefaultActionDefaultAction, IHavePort_Integer, IHaveServiceIdentifier, IHaveProtocol, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string Arn =  "Arn" ;
            public static string ServiceId =  "ServiceId" ;
        }

        public override string AWSTypeName { get => AWS.VpcLattice.Listener; }

        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DefaultAction
        /// </summary>
        [Required]
        public Union<Humidifier.VpcLattice.ListenerTypes.DefaultAction, BaseFunction>? DefaultAction { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// ServiceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-serviceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceIdentifier { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-protocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ListenerTypes
    {
        public class DefaultAction : Humidifier.Base.BaseSubResource, IHaveVpcLatticeListenerTypesForwardForward, IHaveVpcLatticeListenerTypesFixedResponseFixedResponse
        {
            /// <summary>
            /// Forward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-defaultaction.html#cfn-vpclattice-listener-defaultaction-forward
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Forward
            /// </summary>
            public Union<Humidifier.VpcLattice.ListenerTypes.Forward, BaseFunction>? Forward { get; set; }
            /// <summary>
            /// FixedResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-defaultaction.html#cfn-vpclattice-listener-defaultaction-fixedresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FixedResponse
            /// </summary>
            public Union<Humidifier.VpcLattice.ListenerTypes.FixedResponse, BaseFunction>? FixedResponse { get; set; }
        }

        public class FixedResponse : Humidifier.Base.BaseSubResource, IHaveStatusCode_Integer
        {
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-fixedresponse.html#cfn-vpclattice-listener-fixedresponse-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StatusCode { get; set; }
        }

        public class Forward : Humidifier.Base.BaseSubResource, IHaveListOfVpcLatticeListenerTypesWeightedTargetGroupTargetGroups
        {
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-forward.html#cfn-vpclattice-listener-forward-targetgroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTargetGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.VpcLattice.ListenerTypes.WeightedTargetGroup>, IReadOnlyList<Union<Humidifier.VpcLattice.ListenerTypes.WeightedTargetGroup, BaseFunction>>, BaseFunction>? TargetGroups { get; set; }
        }

        public class WeightedTargetGroup : Humidifier.Base.BaseSubResource, IHaveWeight_Integer, IHaveTargetGroupIdentifier
        {
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-weightedtargetgroup.html#cfn-vpclattice-listener-weightedtargetgroup-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// TargetGroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-weightedtargetgroup.html#cfn-vpclattice-listener-weightedtargetgroup-targetgroupidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupIdentifier { get; set; }
        }
    }
}