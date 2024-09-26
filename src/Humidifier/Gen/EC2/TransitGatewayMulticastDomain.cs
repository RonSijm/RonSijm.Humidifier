namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using TransitGatewayMulticastDomainTypes;

    public class TransitGatewayMulticastDomain : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayId
    {
        public class Attributes
        {
            public static string TransitGatewayMulticastDomainArn =  "TransitGatewayMulticastDomainArn" ;
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string TransitGatewayMulticastDomainId =  "TransitGatewayMulticastDomainId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayMulticastDomain; }
        /// <summary>
        /// Options
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomain.html#cfn-ec2-transitgatewaymulticastdomain-options
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Options
        /// </summary>
        public Humidifier.EC2.TransitGatewayMulticastDomainTypes.Options Options { get; set; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomain.html#cfn-ec2-transitgatewaymulticastdomain-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomain.html#cfn-ec2-transitgatewaymulticastdomain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace TransitGatewayMulticastDomainTypes
    {
        public class Options : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StaticSourcesSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaymulticastdomain-options.html#cfn-ec2-transitgatewaymulticastdomain-options-staticsourcessupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StaticSourcesSupport { get; set; }
            /// <summary>
            /// AutoAcceptSharedAssociations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaymulticastdomain-options.html#cfn-ec2-transitgatewaymulticastdomain-options-autoacceptsharedassociations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AutoAcceptSharedAssociations { get; set; }
            /// <summary>
            /// Igmpv2Support
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewaymulticastdomain-options.html#cfn-ec2-transitgatewaymulticastdomain-options-igmpv2support
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Igmpv2Support { get; set; }
        }
    }
}