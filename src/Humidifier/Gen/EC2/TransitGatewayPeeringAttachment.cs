namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayPeeringAttachmentTypes;

    public class TransitGatewayPeeringAttachment : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayId, IHavePeerRegion
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
        public Humidifier.EC2.TransitGatewayPeeringAttachmentTypes.TransitGatewayPeeringAttachmentOptions Options { get; set; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayId { get; set; }

        /// <summary>
        /// PeerTransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peertransitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PeerTransitGatewayId { get; set; }

        /// <summary>
        /// PeerAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peeraccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PeerAccountId { get; set; }

        /// <summary>
        /// PeerRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-peerregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PeerRegion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaypeeringattachment.html#cfn-ec2-transitgatewaypeeringattachment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
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
            public dynamic Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypeeringattachment-peeringattachmentstatus.html#cfn-ec2-transitgatewaypeeringattachment-peeringattachmentstatus-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Code { get; set; }
        }

        public class TransitGatewayPeeringAttachmentOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MultipathResilienceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions-multipathresiliencemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MultipathResilienceMode { get; set; }
            /// <summary>
            /// AllowMultipathResilience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions.html#cfn-ec2-transitgatewaypeeringattachment-transitgatewaypeeringattachmentoptions-allowmultipathresilience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowMultipathResilience { get; set; }
        }
    }
}