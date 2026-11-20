namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCPeeringConnectionTypes;

    public class VPCPeeringConnection : Humidifier.Base.BaseResource, IHaveTags, IHaveVpcId, IHavePeerRegion, IHavePeerVpcId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string MultipathResilienceStatus =  "MultipathResilienceStatus" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCPeeringConnection; }
        /// <summary>
        /// PeerVpcPeeringConnectionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peervpcpeeringconnectionoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcPeeringConnectionOptions
        /// </summary>
        public Humidifier.EC2.VPCPeeringConnectionTypes.VpcPeeringConnectionOptions PeerVpcPeeringConnectionOptions { get; set; }
        /// <summary>
        /// PeerRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peerrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PeerRoleArn { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcId { get; set; }

        /// <summary>
        /// PeerVpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peervpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PeerVpcId { get; set; }
        /// <summary>
        /// VpcPeeringConnectionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcPeeringConnectionOptions
        /// </summary>
        public Humidifier.EC2.VPCPeeringConnectionTypes.VpcPeeringConnectionOptions VpcPeeringConnectionOptions { get; set; }
        /// <summary>
        /// AssumeRoleRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-assumeroleregion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AssumeRoleRegion { get; set; }
        /// <summary>
        /// PeerRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peerregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PeerRegion { get; set; }
        /// <summary>
        /// PeerOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peerownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PeerOwnerId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace VPCPeeringConnectionTypes
    {
        public class VpcPeeringConnectionOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowDnsResolutionFromRemoteVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions-allowdnsresolutionfromremotevpc
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowDnsResolutionFromRemoteVpc { get; set; }
            /// <summary>
            /// MultipathResilienceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions-multipathresiliencemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MultipathResilienceMode { get; set; }
            /// <summary>
            /// AllowMultipathResilience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions-allowmultipathresilience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowMultipathResilience { get; set; }
        }
    }
}