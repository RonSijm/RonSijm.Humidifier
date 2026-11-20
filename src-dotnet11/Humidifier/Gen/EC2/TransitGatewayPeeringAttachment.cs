namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayPeeringAttachmentTypes;

    public class TransitGatewayPeeringAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveEC2TransitGatewayPeeringAttachmentTypesTransitGatewayPeeringAttachmentOptionsOptions, IHaveTransitGatewayId, IHavePeerTransitGatewayId, IHavePeerAccountId, IHavePeerRegion
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AccepterAllowMultipathResilience =  "AccepterAllowMultipathResilience" ;
            public static string RequesterMultipathResilienceMode =  "RequesterMultipathResilienceMode" ;
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string RequesterAllowMultipathResilience =  "RequesterAllowMultipathResilience" ;
            public static string TransitGatewayAttachmentId =  "TransitGatewayAttachmentId" ;
            public static string MultipathResilienceStatus =  "MultipathResilienceStatus" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayPeeringAttachment; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TransitGatewayPeeringAttachmentOptions
        /// </summary>
        public Union<Humidifier.EC2.TransitGatewayPeeringAttachmentTypes.TransitGatewayPeeringAttachmentOptions, BaseFunction>? Options { get; set; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayId { get; set; }

        /// <summary>
        /// PeerTransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peertransitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeerTransitGatewayId { get; set; }

        /// <summary>
        /// PeerAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peeraccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeerAccountId { get; set; }

        /// <summary>
        /// PeerRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peerregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeerRegion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TransitGatewayPeeringAttachmentTypes
    {
        public class PeeringAttachmentStatus : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypeeringattachment-peeringattachmentstatus.html#cfn-ec2-transitgatewaypeeringattachment-peeringattachmentstatus-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypeeringattachment-peeringattachmentstatus.html#cfn-ec2-transitgatewaypeeringattachment-peeringattachmentstatus-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class TransitGatewayPeeringAttachmentOptions : Humidifier.Base.BaseSubResource, IHaveMultipathResilienceMode, IHaveAllowMultipathResilience_Boolean
        {
            /// <summary>
            /// MultipathResilienceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions-multipathresiliencemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MultipathResilienceMode { get; set; }
            /// <summary>
            /// AllowMultipathResilience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions-allowmultipathresilience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowMultipathResilience { get; set; }
        }
    }
}