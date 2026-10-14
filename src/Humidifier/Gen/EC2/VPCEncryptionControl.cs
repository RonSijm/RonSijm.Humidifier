namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCEncryptionControlTypes;

    public class VPCEncryptionControl : Humidifier.Base.BaseResource, IHaveTags, IHaveVpcId, IHaveMode
    {
        public class Attributes
        {
            public static string VpcEncryptionControlId =  "VpcEncryptionControlId" ;
            public static string StateMessage =  "StateMessage" ;
            public static string State =  "State" ;
            public static string ResourceExclusions =  "ResourceExclusions" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCEncryptionControl; }
        /// <summary>
        /// VpcPeeringExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-vpcpeeringexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcPeeringExclusionInput { get; set; }
        /// <summary>
        /// ElasticFileSystemExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-elasticfilesystemexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ElasticFileSystemExclusionInput { get; set; }
        /// <summary>
        /// VpcLatticeExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-vpclatticeexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcLatticeExclusionInput { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-vpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId { get; set; }
        /// <summary>
        /// NatGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-natgatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NatGatewayExclusionInput { get; set; }
        /// <summary>
        /// EgressOnlyInternetGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-egressonlyinternetgatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EgressOnlyInternetGatewayExclusionInput { get; set; }
        /// <summary>
        /// VirtualPrivateGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-virtualprivategatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VirtualPrivateGatewayExclusionInput { get; set; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-mode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Mode { get; set; }
        /// <summary>
        /// InternetGatewayExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-internetgatewayexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InternetGatewayExclusionInput { get; set; }
        /// <summary>
        /// LambdaExclusionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-lambdaexclusioninput
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LambdaExclusionInput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcencryptioncontrol.html#cfn-ec2-vpcencryptioncontrol-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace VPCEncryptionControlTypes
    {
        public class ResourceExclusions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ElasticFileSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-elasticfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion ElasticFileSystem { get; set; }
            /// <summary>
            /// VpcLattice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-vpclattice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion VpcLattice { get; set; }
            /// <summary>
            /// VpcPeering
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-vpcpeering
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion VpcPeering { get; set; }
            /// <summary>
            /// InternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-internetgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion InternetGateway { get; set; }
            /// <summary>
            /// EgressOnlyInternetGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-egressonlyinternetgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion EgressOnlyInternetGateway { get; set; }
            /// <summary>
            /// VirtualPrivateGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-virtualprivategateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion VirtualPrivateGateway { get; set; }
            /// <summary>
            /// NatGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-natgateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion NatGateway { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-resourceexclusions.html#cfn-ec2-vpcencryptioncontrol-resourceexclusions-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcEncryptionControlExclusion
            /// </summary>
            public Humidifier.EC2.VPCEncryptionControlTypes.VpcEncryptionControlExclusion Lambda { get; set; }
        }

        public class VpcEncryptionControlExclusion : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// StateMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion.html#cfn-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion-statemessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StateMessage { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion.html#cfn-ec2-vpcencryptioncontrol-vpcencryptioncontrolexclusion-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
        }
    }
}