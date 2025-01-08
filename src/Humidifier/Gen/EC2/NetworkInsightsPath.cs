namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using NetworkInsightsPathTypes;

    public class NetworkInsightsPath : Humidifier.Base.BaseResource, IHaveTags, IHaveProtocol, IHaveSource, IHaveDestination, IHaveSourceIp, IHaveDestinationPort, IHaveDestinationIp
    {
        public class Attributes
        {
            public static string SourceArn =  "SourceArn" ;
            public static string NetworkInsightsPathId =  "NetworkInsightsPathId" ;
            public static string CreatedDate =  "CreatedDate" ;
            public static string NetworkInsightsPathArn =  "NetworkInsightsPathArn" ;
            public static string DestinationArn =  "DestinationArn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.NetworkInsightsPath; }
        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-destination
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Destination { get; set; }
        /// <summary>
        /// DestinationIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-destinationip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationIp { get; set; }
        /// <summary>
        /// SourceIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-sourceip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceIp { get; set; }
        /// <summary>
        /// FilterAtDestination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-filteratdestination
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PathFilter
        /// </summary>
        public Humidifier.EC2.NetworkInsightsPathTypes.PathFilter FilterAtDestination { get; set; }
        /// <summary>
        /// FilterAtSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-filteratsource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PathFilter
        /// </summary>
        public Humidifier.EC2.NetworkInsightsPathTypes.PathFilter FilterAtSource { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-protocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Protocol { get; set; }
        /// <summary>
        /// DestinationPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-destinationport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic DestinationPort { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-source
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkinsightspath.html#cfn-ec2-networkinsightspath-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace NetworkInsightsPathTypes
    {
        public class FilterPortRange : Humidifier.Base.BaseSubResource, IHaveFromPort, IHaveToPort
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightspath-filterportrange.html#cfn-ec2-networkinsightspath-filterportrange-fromport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightspath-filterportrange.html#cfn-ec2-networkinsightspath-filterportrange-toport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ToPort { get; set; }
        }

        public class PathFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightspath-pathfilter.html#cfn-ec2-networkinsightspath-pathfilter-sourceaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceAddress { get; set; }
            /// <summary>
            /// DestinationPortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightspath-pathfilter.html#cfn-ec2-networkinsightspath-pathfilter-destinationportrange
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterPortRange
            /// </summary>
            public Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange DestinationPortRange { get; set; }
            /// <summary>
            /// SourcePortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightspath-pathfilter.html#cfn-ec2-networkinsightspath-pathfilter-sourceportrange
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterPortRange
            /// </summary>
            public Humidifier.EC2.NetworkInsightsPathTypes.FilterPortRange SourcePortRange { get; set; }
            /// <summary>
            /// DestinationAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-networkinsightspath-pathfilter.html#cfn-ec2-networkinsightspath-pathfilter-destinationaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationAddress { get; set; }
        }
    }
}