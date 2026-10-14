namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCTypes;

    public class VPC : Humidifier.Base.BaseResource, IHaveTags, IHaveCidrBlock, IHaveIpv4NetmaskLength, IHaveIpv4IpamPoolId
    {
        public class Attributes
        {
            public static string CidrBlockAssociations =  "CidrBlockAssociations" ;
            public static string CidrBlock =  "CidrBlock" ;
            public static string DefaultNetworkAcl =  "DefaultNetworkAcl" ;
            public static string VpcId =  "VpcId" ;
            public static string Ipv6CidrBlocks =  "Ipv6CidrBlocks" ;
            public static string DefaultSecurityGroup =  "DefaultSecurityGroup" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPC; }
        /// <summary>
        /// InstanceTenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-instancetenancy
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceTenancy { get; set; }
        /// <summary>
        /// Ipv4NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-ipv4netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Ipv4NetmaskLength { get; set; }
        /// <summary>
        /// CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CidrBlock { get; set; }
        /// <summary>
        /// Ipv4IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-ipv4ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Ipv4IpamPoolId { get; set; }
        /// <summary>
        /// VpcEncryptionControl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-vpcencryptioncontrol
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcEncryptionControl
        /// </summary>
        public Humidifier.EC2.VPCTypes.VpcEncryptionControl VpcEncryptionControl { get; set; }
        /// <summary>
        /// EnableDnsSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-enablednssupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDnsSupport { get; set; }
        /// <summary>
        /// EnableDnsHostnames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-enablednshostnames
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDnsHostnames { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace VPCTypes
    {
        public class VpcEncryptionControl : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveState, IHaveMode
        {
            /// <summary>
            /// ElasticFileSystemExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-elasticfilesystemexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ElasticFileSystemExclusion { get; set; }
            /// <summary>
            /// VirtualPrivateGatewayExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-virtualprivategatewayexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualPrivateGatewayExclusion { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-mode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// VpcEncryptionControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-vpcencryptioncontrolid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcEncryptionControlId { get; set; }
            /// <summary>
            /// VpcLatticeExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-vpclatticeexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcLatticeExclusion { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-vpcid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-state
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// NatGatewayExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-natgatewayexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NatGatewayExclusion { get; set; }
            /// <summary>
            /// EgressOnlyInternetGatewayExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-egressonlyinternetgatewayexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EgressOnlyInternetGatewayExclusion { get; set; }
            /// <summary>
            /// StateMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-statemessage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StateMessage { get; set; }
            /// <summary>
            /// LambdaExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-lambdaexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaExclusion { get; set; }
            /// <summary>
            /// ResourceExclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-resourceexclusions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusions
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions ResourceExclusions { get; set; }
            /// <summary>
            /// InternetGatewayExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-internetgatewayexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InternetGatewayExclusion { get; set; }
            /// <summary>
            /// VpcPeeringExclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrol.html#cfn-ec2-vpc-vpcencryptioncontrol-vpcpeeringexclusion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcPeeringExclusion { get; set; }
        }

        public class VpcEncryptionControlExclusion : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// StateMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusion.html#cfn-ec2-vpc-vpcencryptioncontrolexclusion-statemessage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StateMessage { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusion.html#cfn-ec2-vpc-vpcencryptioncontrolexclusion-state
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }

        public class VpcEncryptionControlExclusions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ElasticFileSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-elasticfilesystem
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion ElasticFileSystem { get; set; }
            /// <summary>
            /// VpcLattice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-vpclattice
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion VpcLattice { get; set; }
            /// <summary>
            /// VpcPeering
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-vpcpeering
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion VpcPeering { get; set; }
            /// <summary>
            /// InternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-internetgateway
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion InternetGateway { get; set; }
            /// <summary>
            /// EgressOnlyInternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-egressonlyinternetgateway
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion EgressOnlyInternetGateway { get; set; }
            /// <summary>
            /// VirtualPrivateGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-virtualprivategateway
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion VirtualPrivateGateway { get; set; }
            /// <summary>
            /// NatGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-natgateway
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion NatGateway { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpc-vpcencryptioncontrolexclusions.html#cfn-ec2-vpc-vpcencryptioncontrolexclusions-lambda
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion Lambda { get; set; }
        }
    }
}