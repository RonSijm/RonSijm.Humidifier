namespace Humidifier.VpcLattice
{
    using System.Collections.Generic;
    using ListenerTypes;

    public class Listener : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string Arn =  "Arn" ;
            public static string ServiceId =  "ServiceId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::VpcLattice::Listener";
            }
        }

        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DefaultAction
        /// </summary>
        public DefaultAction DefaultAction { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Port { get; set; }
        /// <summary>
        /// ServiceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-serviceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceIdentifier { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-protocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Protocol { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-vpclattice-listener.html#cfn-vpclattice-listener-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace ListenerTypes
    {
        public class DefaultAction
        {
            /// <summary>
            /// Forward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-defaultaction.html#cfn-vpclattice-listener-defaultaction-forward
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Forward
            /// </summary>
            public Forward Forward { get; set; }
            /// <summary>
            /// FixedResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-defaultaction.html#cfn-vpclattice-listener-defaultaction-fixedresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FixedResponse
            /// </summary>
            public FixedResponse FixedResponse { get; set; }
        }

        public class FixedResponse
        {
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-fixedresponse.html#cfn-vpclattice-listener-fixedresponse-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StatusCode { get; set; }
        }

        public class Forward
        {
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-forward.html#cfn-vpclattice-listener-forward-targetgroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTargetGroup
            /// </summary>
            public List<WeightedTargetGroup> TargetGroups { get; set; }
        }

        public class WeightedTargetGroup
        {
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-weightedtargetgroup.html#cfn-vpclattice-listener-weightedtargetgroup-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight { get; set; }
            /// <summary>
            /// TargetGroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-vpclattice-listener-weightedtargetgroup.html#cfn-vpclattice-listener-weightedtargetgroup-targetgroupidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetGroupIdentifier { get; set; }
        }
    }
}