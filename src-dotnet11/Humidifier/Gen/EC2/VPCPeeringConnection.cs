namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCPeeringConnectionTypes;

    public class VPCPeeringConnection : Humidifier.Base.BaseResource, IHaveTags, IHaveEC2VPCPeeringConnectionTypesVpcPeeringConnectionOptionsPeerVpcPeeringConnectionOptions, IHavePeerRoleArn, IHaveVpcId, IHavePeerVpcId, IHaveEC2VPCPeeringConnectionTypesVpcPeeringConnectionOptionsVpcPeeringConnectionOptions, IHaveAssumeRoleRegion, IHavePeerRegion, IHavePeerOwnerId
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
        public Union<Humidifier.EC2.VPCPeeringConnectionTypes.VpcPeeringConnectionOptions, BaseFunction>? PeerVpcPeeringConnectionOptions { get; set; }
        /// <summary>
        /// PeerRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peerrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PeerRoleArn { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// PeerVpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peervpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeerVpcId { get; set; }
        /// <summary>
        /// VpcPeeringConnectionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcPeeringConnectionOptions
        /// </summary>
        public Union<Humidifier.EC2.VPCPeeringConnectionTypes.VpcPeeringConnectionOptions, BaseFunction>? VpcPeeringConnectionOptions { get; set; }
        /// <summary>
        /// AssumeRoleRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-assumeroleregion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssumeRoleRegion { get; set; }
        /// <summary>
        /// PeerRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peerregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PeerRegion { get; set; }
        /// <summary>
        /// PeerOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-peerownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PeerOwnerId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcpeeringconnection.html#cfn-ec2-vpcpeeringconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VPCPeeringConnectionTypes
    {
        public class VpcPeeringConnectionOptions : Humidifier.Base.BaseSubResource, IHaveAllowDnsResolutionFromRemoteVpc_Boolean, IHaveMultipathResilienceMode, IHaveAllowMultipathResilience_Boolean
        {
            /// <summary>
            /// AllowDnsResolutionFromRemoteVpc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions-allowdnsresolutionfromremotevpc
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowDnsResolutionFromRemoteVpc { get; set; }
            /// <summary>
            /// MultipathResilienceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions-multipathresiliencemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MultipathResilienceMode { get; set; }
            /// <summary>
            /// AllowMultipathResilience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions.html#cfn-ec2-vpcpeeringconnection-vpcpeeringconnectionoptions-allowmultipathresilience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowMultipathResilience { get; set; }
        }
    }
}